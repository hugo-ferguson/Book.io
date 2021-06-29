Public Class frmStaff

    ' Much of this Form accomplishes the same task as frmManagement, however without
    ' writing functionality. Therefore much of the code for displaying the dates
    ' and the details are identical to that found in frmManagement.

    Dim intCurrentHouseIndex As Integer                 ' Stores the array index of the selected house.
    Dim intCurrentBookingIndex As Integer               ' Stores the array index of the selected booking.
    Dim intCalBookingCount = 0                          ' Stores the number of bookings displayed in the calendar.
    Dim arrHouseBookingEndDates(0) As DateTime          ' Stores a list of the end dates of the bookings in the calendar.
    Dim arrHouseBookingStartDates(0) As DateTime        ' Stores a list of the start dates of the bookings in the calendar.
    Dim arrCalBookingIds(0) As Integer                  ' Stores the Ids of the bookings displayed in the calendar.

    Private Sub SearchHouseBookings(ByVal Id As Integer)

        ' Id variable is the index of the house choice box.
        ' Index of the house choice box begins at 0, whereas the XML Details arrays begin at 1.

        intCurrentHouseIndex = Id + 1
        intCalBookingCount = 0

        ' Clear the Booking start and end date arrays by changing the upper bound to 0,
        ' Clear the list of booking Ids.

        ReDim arrHouseBookingStartDates(0)
        ReDim arrHouseBookingEndDates(0)
        ReDim arrCalBookingIds(0)

        ' Loop through the bookings in the array but searching indexes from 1 to the number of bookings.

        If intBookingCount <> 0 Then

            For i = 1 To intBookingCount

                ' Check if the bookings house Id is the same as the house Id selected in the choice box.

                If arrBookingDetails(i).intBookingHouseId = intCurrentHouseIndex Then

                    ' Increase the count of bookings in the calendar by 1,
                    ' the number of bookings that are associated with the selected house.

                    intCalBookingCount += 1

                    ' Increase each of the arry bounds to the amount of bookings in the calendar.

                    ReDim Preserve arrCalBookingIds(0 To intCalBookingCount)                    ' Stores the Ids of the bookings
                    arrCalBookingIds(intCalBookingCount) = arrBookingDetails(i).intBookingId    ' to be displayed in the calendar.

                    ReDim Preserve arrHouseBookingStartDates(0 To intCalBookingCount)           ' Stores the start dates of the bookings,
                    ReDim Preserve arrHouseBookingEndDates(0 To intCalBookingCount)             ' Stores the end dates of the bookings.

                    arrHouseBookingStartDates(intCalBookingCount) =             ' Stores the start date and end date of the booking
                        Date.Parse(arrBookingDetails(i).datBookingStartDate)    ' at index intCalBookingCount into a new array,
                    arrHouseBookingEndDates(intCalBookingCount) =               ' this new array stores the upper and lower dates to
                        Date.Parse(arrBookingDetails(i).datBookingEndDate)      ' be displayed in the calendar.

                End If

            Next

        End If

    End Sub

    Private Sub DisplayCalendarBookingDates(ByVal tmpCalendar)

        ' Displays the booking dates of a selected house in the calendar by bolding the dates
        ' including and between the start and end dates of all the bookings in the selected house.
        ' arrCalBookingDates stores all the dates that must be bolded in the calendar.
        ' Resets the bolded dates in the calendar.

        Dim arrCalBookingDates(0) As DateTime
        tmpCalendar.BoldedDates = Nothing

        ' Only attempts to display dates if there are dates in the XML.

        If intCalBookingCount <> 0 Then

            For i = 1 To intCalBookingCount

                ' Goes through all bookings that must be added to the calendar.
                ' Creates a temporary date to store the start date and booking date.

                Dim tmpStartDate As Date = arrHouseBookingStartDates(i).ToShortDateString   ' Converts the start and end date to short
                Dim tmpEndDate As Date = arrHouseBookingEndDates(i).ToShortDateString       ' date, so time doesn't affect comparison.

                ' Increase the bounds of the Calendar Booking array by 1.
                ' Adds the start date of the booking to the list of calender bookings, as this
                ' value will remain valid.

                ReDim Preserve arrCalBookingDates(0 To UBound(arrCalBookingDates) + 1)
                arrCalBookingDates(UBound(arrCalBookingDates)) = tmpStartDate

                ' Until the temporary start date is the same as the end date,
                ' Add a day to the start date. Each time a day is added to the start date,
                ' the array is resized by 1, and the new start date is added.
                ' Once the start date is the end date, all dates within the range have been
                ' added to the array.

                Do Until tmpStartDate = tmpEndDate

                    tmpStartDate = tmpStartDate.AddDays(1)
                    ReDim Preserve arrCalBookingDates(0 To UBound(arrCalBookingDates) + 1)
                    arrCalBookingDates(UBound(arrCalBookingDates)) = tmpStartDate

                Loop
            Next

            ' For every entry in the array of calendar dates, 
            ' bold the date on the calendar. 
            ' Then update the bolded dates of the calendar.

            For i = 1 To UBound(arrCalBookingDates)

                tmpCalendar.AddBoldedDate(arrCalBookingDates(i))

            Next

            tmpCalendar.UpdateBoldedDates()

        End If

    End Sub

    Private Function SearchId(Id)

        ' Uses a binary search to find the index of a given booking Id.
        ' This is the same procedure as found in frmManagement.

        Dim tmpLow As Integer = 1
        Dim tmpHigh As Integer = intBookingCount
        Dim tmpMiddle As Integer

        While tmpLow <= tmpHigh
            tmpMiddle = (tmpLow + tmpHigh) / 2

            If arrBookingDetails(tmpMiddle).intBookingId = Id Then
                Exit While
            End If

            If arrBookingDetails(tmpMiddle).intBookingId > Id Then
                tmpHigh = tmpMiddle - 1
            Else
                tmpLow = tmpMiddle + 1
            End If

        End While

        If arrBookingDetails(tmpMiddle).intBookingId <> Id Then
            strMessage = "Booking Id not found"
            Return False
        Else
            intCurrentBookingIndex = tmpMiddle
            Return True
        End If

    End Function

    Private Sub DisplayDetailsFromDate(ByVal tmpDate)

        ' Displays the details of a booking from a selected date.
        ' First calculates which booking the selected date falls within,
        ' Then displays the details of that booking.
        ' Converts the selected date tmpDate to a short format, so time value is ingored.

        tmpDate = tmpDate.ToShortDateString

        For i = 1 To intBookingCount

            ' For every booking in the booking details array,
            ' if the selected date is greater than or equal to the start date and
            ' less than or equal to the end date,
            ' display the details of that booking.

            If tmpDate >= arrBookingDetails(i).datBookingStartDate.ToShortDateString And
               tmpDate <= arrBookingDetails(i).datBookingEndDate.ToShortDateString And
                arrBookingDetails(i).intBookingHouseId = intCurrentHouseIndex Then

                intCurrentBookingIndex = i
                DisplayBookingDetails(intCurrentBookingIndex)

                Exit For

            Else

                ' If the date was not within the start and end date range of any booking,
                ' clear the details fields.

                ClearDetails(tabStaffBookingDetails)
                ClearDetails(tabStaffGuestDetails)

            End If

        Next

        For i = 1 To intGuestCount

            ' Finds the guest details for the previously found booking index.
            ' Then displays these details.

            If arrGuestDetails(i).intGuestBookingId =
                    arrBookingDetails(intCurrentBookingIndex).intBookingId Then

                DisplayGuestDetails(i)

                Exit For

            Else

                ClearDetails(tabStaffGuestDetails)

            End If

        Next

    End Sub

    Private Sub DisplayBookingDetails(Index)

        With arrBookingDetails(Index)

            ' Set all the controls to display details of the booking selected.

            txtStaffBookingId.Text = .intBookingId
            txtStaffBookingCost.Text = FormatCurrency(.flpBookingCost)
            txtStaffBookingInformation.Text = .strBookingInformation

            dtpStaffBookingStartDate.Value = .datBookingStartDate
            dtpStaffBookingStartTime.Value = .datBookingStartDate
            dtpStaffBookingEndDate.Value = .datBookingEndDate
            dtpStaffBookingEndTime.Value = .datBookingEndDate

            For i = 1 To intHouseCount

                If arrBookingDetails(Index).intBookingHouseId =
                        arrHouseDetails(i).intHouseId Then

                    txtStaffBookingHouse.Text = arrHouseDetails(i).strHouseName

                End If

            Next

        End With

    End Sub

    Private Sub DisplayGuestDetails(Index)

        With arrGuestDetails(Index)

            ' Set all the controls to display details of the booking selected.

            txtStaffGuestFirstName.Text = .strGuestFirstName
            txtStaffGuestSurname.Text = .strGuestSurname
            txtStaffGuestInformation.Text = .strGuestInformation

        End With

    End Sub

    Private Sub ClearDetails(tab)

        ' Clears the controls in a certain tab (tab variable).
        ' Lops through the controls in the tab, and clears textboxes and datetimepickers.

        For Each ctrl As Control In tab.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = Nothing
            ElseIf TypeOf ctrl Is DateTimePicker Then
                ctrl.Text = Date.Today
            End If
        Next

    End Sub

    Private Sub cboStaffSelectHouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStaffSelectHouse.SelectedIndexChanged

        ' When a house is selected in the choicebox, search for the bookings
        ' associated with that house and display them in the calendar.

        SearchHouseBookings(cboStaffSelectHouse.SelectedIndex)
        DisplayCalendarBookingDates(calStaffDate)

    End Sub

    Private Sub calBookingDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calStaffDate.DateChanged

        ' Sync the date selected on the calendar to the date time picker.

        dtpStaffDate.Value = calStaffDate.SelectionEnd

    End Sub

    Private Sub dtpBookingDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStaffDate.ValueChanged

        ' Sync the date selected in the date time picker to the calendar.

        calStaffDate.SelectionEnd = dtpStaffDate.Value

    End Sub

    Private Sub btnStaffSearchDate_Click(sender As Object, e As EventArgs) Handles btnStaffSearchDate.Click

        ' Search for the booking that has been selected and display the details.

        DisplayDetailsFromDate(dtpStaffDate.Value)

    End Sub

    Private Sub btnStaffSearchId_Click(sender As Object, e As EventArgs) Handles btnStaffSearchId.Click

        ' Validates the Id field text then searches the Id.
        ' When the Id number is found, the index of the array it corrosponds to is returned
        ' by the search function.

        If IsNumeric(txtStaffSearchId.Text) Then
            If SearchId(txtStaffSearchId.Text) Then
                DisplayBookingDetails(intCurrentBookingIndex)
                Dim tmpGuestFound As Boolean = False
                For i = 1 To intGuestCount

                    If arrGuestDetails(i).intGuestBookingId =
                    arrBookingDetails(intCurrentBookingIndex).intBookingId Then
                        DisplayGuestDetails(i)
                        tmpGuestFound = True
                    End If

                Next

                If tmpGuestFound = False Then
                    ClearDetails(tabStaffGuestDetails)
                End If

            Else
                MessageBox.Show("Search Failed." & vbNewLine & strMessage,
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearDetails(tabStaffBookingDetails)
            End If
        Else
            strMessage = "The Booking Id must be a number."
            MessageBox.Show("Search Failed." & vbNewLine & strMessage,
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDetails(tabStaffBookingDetails)
        End If

        txtStaffSearchId.Text = Nothing

    End Sub

    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Upon the loading of the form, add all the houses names in the XML to the
        ' house choiceboxes in all tabs.

        cboStaffSelectHouse.Items.Clear()

        ' Update all choiceboxes with the names of all houses.

        For i = 1 To intHouseCount
            cboStaffSelectHouse.Items.Add(arrHouseDetails(i).strHouseName)
        Next
    End Sub

    Private Sub frmStaff_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        frmLogin.Show()

    End Sub
End Class