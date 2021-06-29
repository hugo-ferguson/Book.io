Imports Microsoft.Win32
Imports System.Xml
Imports System.IO
Imports System.Drawing.Printing
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

' Management form of Book.io
' Created by Hugo Ferguson 2018
' Software Development 3/4 SAT
' Version 0.3
' Last Modified 16/09/18

Public Class frmManagement

    Dim booArrayEdit As Boolean
    Dim intCurrentHouseIndex As Integer                 ' Stores the array index of the selected house.
    Dim intCurrentBookingIndex As Integer               ' Stores the array index of the selected booking.
    Dim intCurrentGuestIndex As Integer                 ' Stores the array index of the selected guest, usually equal to the booking.
    Dim intCurrentStaffIndex As Integer                 ' Stores the array index of the selected finance, usually equal to the guest.
    Dim intCalBookingCount = 0                          ' Stores the number of bookings displayed in the calendar.
    Dim arrHouseBookingEndDates(0) As DateTime          ' Stores a list of the end dates of the bookings in the calendar.
    Dim arrHouseBookingStartDates(0) As DateTime        ' Stores a list of the start dates of the bookings in the calendar.
    Dim arrCalBookingIds(0) As Integer                  ' Stores the Ids of the bookings displayed in the calendar.
    Dim strStaffImagesDirectory As String =             ' Contains the path of StaffImages.
        Application.StartupPath & "\Resources\StaffImages"
    Dim booSaved As Boolean = False                     ' Stores whether a save was successful.

    Private Sub SortDetailsArrays(LowIndex As Integer, HighIndex As Integer)

        ' Uses a recursive quicksort algorithm to sort the booking, staff and finance arrays.
        ' These arrays all use the same Id and are synchronised with each other,
        ' therefore they are sorted together using the BookingId as the comparator.

        Dim tmpLow As Integer = LowIndex
        Dim tmpHigh As Integer = HighIndex
        Dim tmpPivot As String = arrBookingDetails((tmpLow + tmpHigh) / 2).intBookingId
        Dim tmpBookingSwap As BookingDetails
        Dim tmpGuestSwap As GuestDetails
        Dim tmpFinanceSwap As FinanceDetails

        Do Until tmpLow > tmpHigh

            Do While arrBookingDetails(tmpLow).intBookingId < tmpPivot
                tmpLow += 1
            Loop

            Do While tmpPivot < arrBookingDetails(tmpHigh).intBookingId
                tmpHigh -= 1
            Loop

            If tmpLow <= tmpHigh Then
                tmpBookingSwap = arrBookingDetails(tmpLow)
                tmpGuestSwap = arrGuestDetails(tmpLow)
                tmpFinanceSwap = arrFinanceDetails(tmpLow)

                arrBookingDetails(tmpLow) = arrBookingDetails(tmpHigh)
                arrGuestDetails(tmpLow) = arrGuestDetails(tmpHigh)
                arrFinanceDetails(tmpLow) = arrFinanceDetails(tmpHigh)

                arrBookingDetails(tmpHigh) = tmpBookingSwap
                arrGuestDetails(tmpHigh) = tmpGuestSwap
                arrFinanceDetails(tmpHigh) = tmpFinanceSwap

                tmpLow += 1
                tmpHigh -= 1
            End If

        Loop

        ' The function is recursive, and therefore calls itself again until
        ' the sort is complete.

        If LowIndex < tmpHigh Then SortDetailsArrays(LowIndex, tmpHigh)
        If tmpLow < HighIndex Then SortDetailsArrays(tmpLow, HighIndex)

    End Sub

    Private Function VerifyDetailsFields(type)

        ' Verifies the details fields of the given field (type).
        ' Depending on the value of this different controls are checked for
        ' existance, type and range.
        ' The function returns true if the data is valid.
        ' If at any point the function encounters an empty text box etc.
        ' it returns False.

        Select Case type
            Case "Booking"      ' Verify the booking details fields.
                If txtBookingCost.Text = "" Or
                   cboBookingHouse.Text = "" Then

                    strMessage = "Please enter all required booking details."
                    Return False
                End If
                If Not IsNumeric(txtBookingCost.Text) Then
                    strMessage = "The booking cost must be a number."
                    Return False
                End If
            Case "Guest"
                If txtGuestBookingId.Text = "" Or
                    txtGuestFirstName.Text = "" Or
                    txtGuestSurname.Text = "" Or
                    txtGuestMobile.Text = "" Then

                    strMessage = "Please enter all required guest details."
                    Return False
                End If
                If Not Regex.IsMatch(txtGuestMobile.Text, "^[0-9 ]+$") Then
                    strMessage = "The guest mobile must be a number."
                    Return False
                End If
                If Not Regex.IsMatch(txtCardNumber.Text, "^[0-9 ]+$") Then
                    strMessage = "The card number must be a number."
                    Return False
                End If
                If Not IsNumeric(txtCardCVV.Text) Then
                    strMessage = "The card CVV must be a number."
                    Return False
                End If
            Case "House"    ' Verify the house details fields.
                If txtHouseName.Text = "" Or
                   txtHouseAddress.Text = "" Or
                   txtHouseCity.Text = "" Or
                   txtHousePostCode.Text = "" Or
                   txtHouseWeekdayRate.Text = "" Or
                   txtHouseWeekendRate.Text = "" Then

                    strMessage = "Please enter all required house details."
                    Return False

                End If
                If Not IsNumeric(txtHousePostCode.Text) Then
                    strMessage = "The house postcode must be a number."
                    Return False
                End If
                If Not IsNumeric(txtHouseWeekdayRate.Text) Or
                    Not IsNumeric(txtHouseWeekendRate.Text) Then
                    strMessage = "The house rates must be numbers."
                    Return False
                End If
            Case "Staff"    ' Verify the house details fields.
                If txtStaffFirstName.Text = "" Or
                   txtStaffSurname.Text = "" Or
                   txtStaffEmail.Text = "" Or
                   txtStaffPassword.Text = "" Or
                   cboStaffRole.Text = "" Then

                    strMessage = "Please enter all required staff details."
                    Return False
                End If
                If Not rbtStaffStatusTrue.Checked And Not rbtStaffStatusFalse.Checked Then
                    strMessage = "Please enter all required staff details."
                    Return False
                End If
                If Not txtStaffEmail.Text.Contains("@") Or
                Not txtStaffEmail.Text.Contains(".") Then
                    strMessage = "Please enter a valid email address."
                    Return False
                End If
                If Not IsNumeric(txtStaffWage.Text) Then
                    strMessage = "The staff wage must be a number."
                    Return False
                End If
                If Not IsNumeric(txtStaffPostcode.Text) Then
                    strMessage = "The staff postcode must be a number."
                    Return False
                End If
                If Not Regex.IsMatch(txtStaffMobile.Text, "^[0-9 ]+$") Then
                    strMessage = "The staff mobile must be a number."
                    Return False
                End If
                Try
                    Convert.FromBase64String(txtStaffPassword.Text)
                Catch ex As Exception
                    strMessage = "The staff password can contain only numbers and letters."
                    Return False
                End Try
        End Select

        Return True

    End Function

    Private Sub ClearDetails(tab)

        ' Clears the controls in a certain tab (tab variable).
        ' Lops through the controls in the tab, and clears textboxes and datetimepickers etc.

        For Each ctrl As Control In tab.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = Nothing
            ElseIf TypeOf ctrl Is DateTimePicker Then
                ctrl.Text = Date.Today
            ElseIf TypeOf ctrl Is ComboBox Then
                ctrl.Text = Nothing
            End If
        Next

    End Sub

    Private Sub FormatCurrencyTextBox(TextBox)

        ' Called by the various currency format buttons,
        ' takes the text in the textbox and formats it if there is a number in it.
        ' If the textbox is empty, it simply displays $0.00

        If IsNumeric(TextBox.Text) Then
            TextBox.Text = FormatCurrency(TextBox.Text)
        ElseIf TextBox.Text = Nothing Then
            TextBox.Text = FormatCurrency(0)
        End If

    End Sub

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
                ' add a day to the start date. Each time a day is added to the start date,
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

                ClearDetails(gboBookingDetails)
                ClearDetails(gboStaffDetails)
            End If

        Next

        For i = 1 To intGuestCount

            If arrGuestDetails(i).intGuestBookingId =
                    arrBookingDetails(intCurrentBookingIndex).intBookingId Then
                DisplayGuestDetails(i)
                Exit For
            Else
                ClearDetails(gboStaffDetails)
            End If
        Next

    End Sub

    Private Function SearchBookingId(Id)

        ' Uses a binary search for the index of a given booking Id within the sorted booking array.
        ' The search boudaries are from 1 to the count, as the first position of all
        ' _Details arrays contain nothing.'
        ' This array could potentially be very large, therefore a binary search is most efficient.

        Dim tmpLow As Integer = 1
        Dim tmpHigh As Integer = UBound(arrBookingDetails)
        Dim tmpMiddle As Integer

        ' Define the middle as the average of the low and high values,
        ' these values are then iterated and changed depending on whether
        ' or not the Key (the booking Id) is greater than or less than the high and low.

        While tmpLow <= tmpHigh
            tmpMiddle = (tmpLow + tmpHigh) / 2

            If arrBookingDetails(tmpMiddle).intBookingId = Id Then
                Exit While
            End If

            ' Redefine the midpoint as either one above the low or one below the high.

            If arrBookingDetails(tmpMiddle).intBookingId > Id Then
                tmpHigh = tmpMiddle - 1
            Else
                tmpLow = tmpMiddle + 1
            End If

        End While

        ' If the midpoint at the end of the search doesn't equal the Id,
        ' it doesn't exist.
        ' Otherwise, the booking index is set the midpoint.

        If arrBookingDetails(tmpMiddle).intBookingId <> Id Then
            strMessage = "There is no booking with this Id."
            Return False
        Else
            intCurrentBookingIndex = tmpMiddle
            Return True
        End If

    End Function

    Private Sub DisplayBookingDetails(Index)

        With arrBookingDetails(Index)

            ' Set all the controls to display details of the booking selected.

            txtBookingId.Text = .intBookingId
            txtBookingCost.Text = FormatCurrency(.flpBookingCost)
            txtBookingInformation.Text = .strBookingInformation

            dtpBookingStartDate.Value = .datBookingStartDate
            dtpBookingStartTime.Value = .datBookingStartDate
            dtpBookingEndDate.Value = .datBookingEndDate
            dtpBookingEndTime.Value = .datBookingEndDate

            ' The index of the choicebox is equal to one less than the house selected,
            ' as that is how it is defined when reading the houses.

            cboBookingHouse.SelectedIndex = (arrBookingDetails(Index).intBookingHouseId - 1)

        End With

    End Sub

    Private Function CalculateBookingCost(StartDate As DateTime, EndDate As DateTime, HouseId As Integer)

        ' Function to calculate the total cost of the booking given the
        ' start data and the end date and the house Id. Using these,
        ' the number of dates the booking falls on is calculated and mutliplied
        ' by the rate of the house it is in.

        Dim tmpWeekdayCount As Integer = 0
        Dim tmpWeekendCount As Integer = 0
        Dim tmpBookingCost As Double = 0

        ' Add the first day to the count of weekdays and weekends. 
        ' Since these can have different rates, the number is stored seperately.
        ' To check if this first date is a weekday or weekend, the day of the week
        ' is calculated and checked to see if it is a weekend. 

        If Weekday(StartDate, vbMonday) > 5 Then
            tmpWeekendCount += 1
        Else
            tmpWeekdayCount += 1
        End If

        ' Calculate the range of dates within StartDate and EndDate,
        ' then check if the date is a weekend or weekday, increasing
        ' the relevant count by 1.

        Do Until StartDate = EndDate.AddDays(-1)
            StartDate = StartDate.AddDays(1)
            If Weekday(StartDate, vbMonday) <= 5 Then
                tmpWeekdayCount += 1
            Else
                tmpWeekendCount += 1
            End If
        Loop

        ' Then multiply the number of weekdays by the weekday rate of the house
        ' and then the weekend days by the weekend rate.
        ' Then return the final result.

        tmpBookingCost += arrHouseDetails(HouseId).flpHouseWeekdayRate * tmpWeekdayCount
        tmpBookingCost += arrHouseDetails(HouseId).flpHouseWeekendRate * tmpWeekendCount

        Return tmpBookingCost

    End Function

    Private Function CheckExistingDate(ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal HouseId As Integer, ByVal BookingId As Integer)

        ' Checks if the date range within the start date and end date (StartDate and EndDate) do not intersect
        ' with any other bookings at the same house.
        ' An array is defined as all of the dates within the ranges of all bookings in the selected house,
        ' and another is defined as the bookings within the range of the new booking.

        Dim tmpAllBookingDays(0) As DateTime
        Dim tmpBookingDays(0) As DateTime
        Dim tmpStartDate As DateTime
        Dim tmpEndDate As DateTime

        ' Loops through all bookings and finds those that are in the same house as the new booking,
        ' the loop then adds all of the dates within the booking start and finish dates to the total array,
        ' before increasing the array's size automatically.

        For i = 1 To intBookingCount
            If arrBookingDetails(i).intBookingId <> BookingId Then
                If arrBookingDetails(i).intBookingHouseId = HouseId Then
                    tmpStartDate = Date.Parse(arrBookingDetails(i).datBookingStartDate.ToShortDateString)
                    tmpEndDate = Date.Parse(arrBookingDetails(i).datBookingEndDate.ToShortDateString)
                    Do Until tmpStartDate = tmpEndDate.AddDays(1)
                        tmpAllBookingDays(UBound(tmpAllBookingDays)) = tmpStartDate
                        tmpStartDate = Date.Parse(tmpStartDate.ToShortDateString).AddDays(1)
                        ReDim Preserve tmpAllBookingDays(0 To UBound(tmpAllBookingDays) + 1)
                    Loop
                End If
            End If
        Next

        ' Starts with the StartDate of the new booking and increases its value by 1
        ' until it equals the EndDate. Before the StartDate value is increased, it is
        ' added to the array containing the dates of the new booking. 
        ' When the startdate equals the enddate, all dates have been added.

        Do Until Date.Parse(StartDate.ToShortDateString) = Date.Parse(EndDate.ToShortDateString).AddDays(1)
            tmpBookingDays(UBound(tmpBookingDays)) = Date.Parse(StartDate.ToShortDateString)
            StartDate = Date.Parse(StartDate.ToShortDateString).AddDays(1)
            ReDim Preserve tmpBookingDays(0 To UBound(tmpBookingDays) + 1)
        Loop

        ' The last position of the array is then removed, as due to the loop it
        ' contains an empty position. If the intersection was computed with this
        ' position left, it would always return true as they would be identical.

        ReDim Preserve tmpAllBookingDays(0 To UBound(tmpAllBookingDays) - 1)
        ReDim Preserve tmpBookingDays(0 To UBound(tmpBookingDays) - 1)

        If tmpAllBookingDays.Intersect(tmpBookingDays).Any Then
            Return True
        End If
        Return False

    End Function

    Private Sub SaveBooking(Editing As Boolean, StartDate As DateTime, EndDate As DateTime, HouseId As Integer)

        ' Saves a booking by saving the array then writing to the XML.
        ' The details entered are verified, then if they are valid
        ' they are written to the Array. The editing boolean
        ' specifies if the array is being edited or if a new entry must be created.

        booSaved = False

        If VerifyDetailsFields("Booking") Then
            If Date.Parse(dtpBookingStartDate.Value.ToShortDateString) <= Date.Parse(dtpBookingEndDate.Value.ToShortDateString) Then

                ' If the save button is clicked with the Id field blank, then the booking
                ' will not be saved as it has no destination.
                ' To create a new booking, the add button must be used.

                If Editing Then
                    If txtBookingId.Text <> Nothing Then
                        intCurrentBookingIndex = Convert.ToInt32(txtBookingId.Text)
                    Else
                        strMessage = "This booking doesn't exist. To create a new booking, use the Add Booking button."
                        MessageBox.Show(strMessage, "Save",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    intCurrentBookingIndex = intBookingCount + 1
                End If

                ' If the booking dates selected are already present in another booking
                ' in the same house, the save will not proceed.

                If Not CheckExistingDate(StartDate, EndDate, HouseId, intCurrentBookingIndex) Then
                    WriteBookingDetailsArray(Editing)
                    WriteBookingDetailsXML()
                    WriteGuestDetailsXML()
                    WriteFinanceDetailsXML()

                    ' If a new booking is being created (editing = false) then a new staff and finance
                    ' position is created along side it. These are copies of the 0th position
                    ' of the array, which is a blank array position with the correct variables.
                    ' This ensures that the number of guests and bookings are equal.

                    strMessage = "Booking saved succesfully."
                    MessageBox.Show(strMessage, "Save",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                    booSaved = True

                Else

                    strMessage = "A booking in this house already exits on this date."
                    MessageBox.Show(strMessage, "Save",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                strMessage = "The booking start date must be before the end date."
                MessageBox.Show(strMessage, "Save",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show(strMessage, "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub WriteBookingDetailsArray(Editing As Boolean)

        ' Writes the fields to the booking array.
        ' If the array is not being edited (editing = false) then a new position
        ' is created, with index equal to the count.
        ' Placing it at the end of the array.
        ' If the array is being edited, the Id to write to is the Id field.

        If Editing = False Then
            intBookingCount += 1
            intCurrentBookingIndex = UBound(arrBookingDetails) + 1
            Dim tmpId As Integer = arrBookingDetails(UBound(arrBookingDetails)).intBookingId + 1
            ReDim Preserve arrBookingDetails(0 To UBound(arrBookingDetails) + 1)
            arrBookingDetails(intCurrentBookingIndex).intBookingId = tmpId

            intGuestCount += 1
            ReDim Preserve arrGuestDetails(0 To UBound(arrGuestDetails) + 1)
            arrGuestDetails(UBound(arrGuestDetails)).intGuestBookingId = tmpId

            intFinanceCount += 1
            ReDim Preserve arrFinanceDetails(0 To UBound(arrFinanceDetails) + 1)
            arrFinanceDetails(UBound(arrFinanceDetails)).intFinanceBookingId = tmpId
        Else
            arrBookingDetails(intCurrentBookingIndex).intBookingId = Convert.ToInt32(txtBookingId.Text)
        End If

        ' Creates the booking start and finish dates to be written by concatonating
        ' the start date with the start time, as these are in seperate datetimepickers.

        Dim tmpBookingStartDate As DateTime = Date.Parse(dtpBookingStartDate.Value)
        Dim tmpBookingStartTime As DateTime = Date.Parse(dtpBookingStartTime.Value)
        Dim tmpBookingEndDate As DateTime = Date.Parse(dtpBookingEndDate.Value)
        Dim tmpBookingEndTime As DateTime = Date.Parse(dtpBookingEndTime.Value)

        With arrBookingDetails(intCurrentBookingIndex)
            .datBookingStartDate = DateTime.Parse(String.Concat(tmpBookingStartDate.ToShortDateString & " " &
                                                  tmpBookingStartTime.ToShortTimeString))
            .datBookingEndDate = DateTime.Parse(String.Concat(tmpBookingEndDate.ToShortDateString & " " &
                                                  tmpBookingEndTime.ToShortTimeString))
            .flpBookingCost = Double.Parse(txtBookingCost.Text, Globalization.NumberStyles.Currency)
            .intBookingHouseId = cboBookingHouse.SelectedIndex + 1
            .strBookingInformation = txtBookingInformation.Text
        End With

    End Sub

    Private Sub DeleteBookingArrayPosition(Id)

        ' Deletes the booking array position given the Id of the booking.
        ' Uses the FindIndex method to find the index of the Id without using a for loop.

        intCurrentBookingIndex = Array.FindIndex(arrBookingDetails, Function(f) f.intBookingId = Id)

        ' When a booking is deleted, the accompanying guest and therefore finance details are cleared.
        ' Both of these arrays are synchronised with the same Id number, therefore the same
        ' index can be used when deleting data from all arrays.

        If UBound(arrBookingDetails) > 1 Then
            Array.Clear(arrBookingDetails, intCurrentBookingIndex, 1)
            Array.Clear(arrGuestDetails, intCurrentBookingIndex, 1)
            Array.Clear(arrFinanceDetails, intCurrentBookingIndex, 1)

            For i = intCurrentBookingIndex To intBookingCount - 1
                arrBookingDetails(i) = arrBookingDetails(i + 1)
                arrGuestDetails(i) = arrGuestDetails(i + 1)
                arrFinanceDetails(i) = arrFinanceDetails(i + 1)
            Next

            ' The count of the bookings, guests and finances are reduced by 1.
            ' The array size is also lowered by 1, as the final position of the array
            ' contains an empty index after the previous clearing process.
            ' The array length is also used to determine the number of bookings and therefore must
            ' remain accurate.

            intBookingCount -= 1
            ReDim Preserve arrBookingDetails(0 To intBookingCount)
            intGuestCount -= 1
            ReDim Preserve arrGuestDetails(0 To intGuestCount)
            intFinanceCount -= 1
            ReDim Preserve arrFinanceDetails(0 To intFinanceCount)
        Else

            ' If the array size is 1, then the previous process need not be applied, and the
            ' array is simply redefined with a size of 0.

            ReDim arrBookingDetails(0 To 0)
            intBookingCount -= 1
            ReDim arrGuestDetails(0 To 0)
            intGuestCount -= 1
            ReDim arrFinanceDetails(0 To 0)
            intFinanceCount -= 1
        End If

        strMessage = "Booking deleted succesfully."
        MessageBox.Show(strMessage, "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Function SearchGuestId(Id)

        ' Uses a binary search to find the index of the GuestDetails array given the
        ' staff Id to search for. The array is sorted in the SortGuestDetailsArray sub,
        ' required for a binary search.

        Dim tmpLow As Integer = 1
        Dim tmpHigh As Integer = UBound(arrGuestDetails)
        Dim tmpMiddle As Integer

        While tmpLow <= tmpHigh
            tmpMiddle = (tmpLow + tmpHigh) / 2

            If arrGuestDetails(tmpMiddle).intGuestBookingId = Id Then
                Exit While
            End If

            If arrGuestDetails(tmpMiddle).intGuestBookingId > Id Then
                tmpHigh = tmpMiddle - 1
            Else
                tmpLow = tmpMiddle + 1
            End If

        End While

        ' If the search is successful, then the function returns true and the intCurrentGuestIndex
        ' variable is updated to the index of the guest with the correct Id.

        If arrGuestDetails(tmpMiddle).intGuestBookingId <> Id Then
            strMessage = "There is no booking with this Id."
            Return False
        Else
            intCurrentGuestIndex = tmpMiddle
            Return True
        End If

    End Function

    Private Sub DisplayGuestDetails(Index)

        With arrGuestDetails(Index)

            ' Set all the controls to display details of the guest selected.
            ' Guest data is contained in both the GuestDetails array and the FinanceDetails array.

            txtGuestFirstName.Text = .strGuestFirstName
            txtGuestSurname.Text = .strGuestSurname
            txtGuestInformation.Text = .strGuestInformation
            txtGuestMobile.Text = .strGuestMobile
            txtGuestBookingId.Text = .intGuestBookingId

        End With

        With arrFinanceDetails(Index)

            txtCardName.Text = .strCardName
            txtCardNumber.Text = .strCardNumber
            txtCardCVV.Text = .strCardCVV
            'dtpCardExpiry.Value = Date.Parse(.datCardExpiry)

        End With

    End Sub

    Private Sub WriteGuestDetailsArray(Id)

        ' Writes the data in the fields to the guest array and the finance array.

        With arrGuestDetails(Id)
            .strGuestFirstName = txtGuestFirstName.Text
            .strGuestSurname = txtGuestSurname.Text
            .strGuestMobile = txtGuestMobile.Text
            .strGuestInformation = txtGuestInformation.Text
        End With

        ' The data being saved to finance details is encrypted using TripleDES
        ' and the password.

        With arrFinanceDetails(Id)
            .strCardName = txtCardName.Text
            .strCardNumber = txtCardNumber.Text
            .strCardExpiry = dtpCardExpiry.Value
            .strCardCVV = txtCardCVV.Text
        End With

    End Sub

    Private Sub SaveGuest(Id)

        ' Saves a guest to the array at an Id.
        ' It is impossible to add a guest, as when a booking
        ' is created it is done automatically. Therefore editing
        ' is not present.

        If VerifyDetailsFields("Guest") Then
            WriteGuestDetailsArray(Id)
            WriteGuestDetailsXML()
            WriteFinanceDetailsXML()
            strMessage = "Guest saved succesfully."
            MessageBox.Show(strMessage, "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(strMessage, "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DisplayHouseDetails(Index)

        With arrHouseDetails(Index)

            ' Set all the controls to display details of the house selected.
            ' Also formats the currency values (weekday and weekend rates) as currencies.

            txtHouseName.Text = .strHouseName
            txtHouseAddress.Text = .strHouseAddress
            txtHouseCity.Text = .strHouseCity
            txtHousePostCode.Text = .strHousePostCode
            txtHouseWeekdayRate.Text = FormatCurrency(.flpHouseWeekdayRate)
            txtHouseWeekendRate.Text = FormatCurrency(.flpHouseWeekendRate)
            txtHousePIN.Text = .strHousePIN
            txtHouseInformation.Text = .strHouseInformation

        End With

    End Sub

    Private Sub WriteHouseDetailsArray(Editing)

        ' Sets the values in the HouseDetails array to the information
        ' in the associated textboxes etc.
        ' Creates a new index in the array if the editing value is false,
        ' otherwise writing to the appropriate index if it is false.

        If Editing = False Then
            ReDim Preserve arrHouseDetails(0 To intHouseCount + 1)
            intHouseCount += 1
            intCurrentHouseIndex = intHouseCount
            arrHouseDetails(intCurrentHouseIndex).intHouseId = intHouseCount
        End If

        With arrHouseDetails(intCurrentHouseIndex)
            .strHouseName = txtHouseName.Text
            .strHouseAddress = txtHouseAddress.Text
            .strHouseCity = txtHouseCity.Text
            .strHousePostCode = txtHousePostCode.Text
            .flpHouseWeekdayRate = txtHouseWeekdayRate.Text
            .flpHouseWeekendRate = txtHouseWeekendRate.Text
            .strHousePIN = txtHousePIN.Text
            .strHouseInformation = txtHouseInformation.Text
        End With

    End Sub

    Private Sub SaveHouse(Editing As Boolean)

        ' Writes the array values and the XML file after verifying that the details required
        ' are entered and valid.
        ' Uses the WriteHouseDetailsArray sub and the WriteHouseXML sub to write the information.

        booSaved = False

        If VerifyDetailsFields("House") Then
            If Editing Then
                intCurrentHouseIndex = cboSelectHouseHouse.SelectedIndex + 1
            End If

            WriteHouseDetailsArray(Editing)
            WriteHouseDetailsXML()

            strMessage = "House saved succesfully."
            MessageBox.Show(strMessage, "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            booSaved = True

        Else

            MessageBox.Show(strMessage, "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub DeleteHouseArrayPosition(Index)

        ' Clears the house details at a given array position.
        ' This position is cleared, leaving an empty index in the array.
        ' The procedure loops through all array positions from this index to the endm
        ' changing the index at i to the next index, therefore shifting the list down.
        ' If there is only 1 position in the array, it can be deleted by skipping this process.

        Array.Clear(arrHouseDetails, Index, 1)

        For i = Index To intHouseCount - 1
            arrHouseDetails(i) = arrHouseDetails(i + 1)
        Next

        ' The house count is then changed reduced by 1,
        ' And the array size is shrunk by 1, removing the empty index at the end.

        intHouseCount -= 1
        ReDim Preserve arrHouseDetails(0 To intHouseCount)
        strMessage = "Entry deleted succesfully."
        MessageBox.Show(strMessage, "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub DisplayStaffDetails(Index)

        With arrStaffDetails(Index)

            ' Set all the controls to display details of the staff selected.

            txtStaffFirstName.Text = .strStaffFirstName
            txtStaffSurname.Text = .strStaffSurname
            txtStaffAddress.Text = .strStaffAddress
            txtStaffCity.Text = .strStaffCity
            txtStaffPostcode.Text = .strStaffPostCode
            txtStaffEmail.Text = .strStaffEmail
            txtStaffMobile.Text = .strStaffMobile
            txtStaffPassword.Text = .strStaffPassword
            cboStaffRole.Text = .strStaffRole
            txtStaffWage.Text = FormatCurrency(.flpStaffWage)
            txtStaffImage.Text = Path.Combine(strStaffImagesDirectory, .strStaffImage)

            If .booStaffStatus = True Then
                rbtStaffStatusTrue.Select()
            Else
                rbtStaffStatusFalse.Select()
            End If

            ' Clear the contents of the previously loaded staff image.

            txtStaffImage.Clear()

            ' Check if the file that the staff image string refers to exists, and if so display
            ' the image. A filestream is then used so as to allow the image to be used by other
            ' programs if necessary.

            If File.Exists(Path.Combine(strStaffImagesDirectory, .strStaffImage)) Then

                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(Path.Combine(strStaffImagesDirectory, .strStaffImage),
                                              System.IO.FileMode.Open, System.IO.FileAccess.Read)

                pboStaffImage.Image = System.Drawing.Image.FromStream(fs)
                txtStaffImage.Text = .strStaffImage
                fs.Close()
                fs.Dispose()

            Else
                pboStaffImage.Image = Nothing
            End If
        End With

    End Sub

    Private Sub WriteStaffDetailsArray(Editing As Boolean)

        ' Writes the StaffDetails array given the values of the various textboxes etc/
        ' If the editing boolean is set true, then the array must be edited at the selected
        ' position. If editing is false, then a new position must be created and hence the staff
        ' count increased.

        If Editing = False Then
            ReDim Preserve arrStaffDetails(0 To intStaffCount + 1)  ' Increase the array bounds by 1.
            intStaffCount += 1                                      ' Add 1 to the Staff Count.
            intCurrentStaffIndex = intStaffCount                    ' Set the index of current staff to the newly created position.
        End If

        ' Set the array values to that of the textboxes etc.

        With arrStaffDetails(intCurrentStaffIndex)
            .strStaffFirstName = txtStaffFirstName.Text
            .strStaffSurname = txtStaffSurname.Text
            .strStaffAddress = txtStaffAddress.Text
            .strStaffCity = txtStaffCity.Text
            .strStaffPostCode = txtStaffPostcode.Text
            .strStaffEmail = txtStaffEmail.Text
            .strStaffMobile = txtStaffMobile.Text
            .strStaffPassword = txtStaffPassword.Text
            .strStaffRole = cboStaffRole.Text
            .flpStaffWage = Double.Parse(txtStaffWage.Text, Globalization.NumberStyles.Currency)
            .strStaffImage = Path.GetFileName(txtStaffImage.Text)
            If rbtStaffStatusTrue.Checked Then
                .booStaffStatus = True
            Else
                .booStaffStatus = False
            End If
        End With

    End Sub

    Private Sub ShowStaffImageDialog()

        ' Opens a file browser window and sets filter (files that are acceptable) and then allows the file
        ' selected to be added to txtEmpId and displayed in pbID.

        Dim dlgIdPic As New OpenFileDialog

        dlgIdPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff"   ' Acceptable file types.
        dlgIdPic.ShowDialog()

        ' Checks if a file was selected in the browser, if not the file is not displayed (otherwise an error occurs)
        ' The file selected is then set to the picturebox and the path is put in the path textbox.

        If dlgIdPic.FileName <> "" Then

            txtStaffImage.Text = dlgIdPic.FileName                              ' Set textbox to the image file selected.
            Dim fs As System.IO.FileStream                                      ' Create a filestream

            ' The filestream ensures that the picturebox doesn't use the file directly, so that the image save
            ' sub can overwrite the file if the image wasn't changed when saving.
            ' txtStaffImage can be used as the directory as the user cannot change its contents, so the information
            ' will remain the same and in the correct format.

            fs = New System.IO.FileStream(txtStaffImage.Text,
            System.IO.FileMode.Open, System.IO.FileAccess.Read)
            pboStaffImage.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            fs.Dispose()

        End If

    End Sub

    Private Sub SaveStaffImage()

        ' Performs the saving of the image file, by checking if the file already exists,
        ' Then copying and renaming the image selected in ShowIdPicDialog to the IdPictures folder in the application directory.
        ' Then updates the employee image in StaffDetail.

        ' Try statement attempts to copy the image file that is in strImgFile and perform change the textbox and array.
        ' If the image file cannot be copied (such as if the image wasn't changed before pressing save),
        ' The image is not updated.

        Try
            If File.Exists(Path.Combine(strStaffImagesDirectory, Path.GetFileName(txtStaffImage.Text))) Then
                arrStaffDetails(intCurrentStaffIndex).strStaffImage = Path.GetFileName(txtStaffImage.Text)
                Exit Try
            End If

            My.Computer.FileSystem.CopyFile(txtStaffImage.Text,
            Path.Combine(strStaffImagesDirectory, Path.GetFileName(txtStaffImage.Text)), True)    ' Attempt to copy the image.
            txtStaffImage.Text = Path.Combine(strStaffImagesDirectory, Path.GetFileName(txtStaffImage.Text))
        Catch ex As Exception                                                   ' If an exception was produced by the try,
            Exit Try                                                            ' do not copy the image or update array with an image file.
        End Try

    End Sub

    Private Sub SaveStaff(Editing As Boolean)

        ' Saves a staff member by saving the array then writing to the XML.
        ' The details entered are verified, then if they are valid
        ' they are written to the Array. The editing boolean
        ' specifies if the array is being edited or if a new entry must be created.

        booSaved = False

        If VerifyDetailsFields("Staff") Then
            If Editing Then
                intCurrentStaffIndex = cboSelectStaff.SelectedIndex + 1
            End If

            ' Saves the staff array with the details entered and the image file
            ' as chosen via the dialog box and the image file textbox.

            SaveStaffImage()
            WriteStaffDetailsArray(Editing)
            WriteStaffDetailsXML()

            strMessage = "Staff saved succesfully."
            MessageBox.Show(strMessage, "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            booSaved = True

        Else

            MessageBox.Show(strMessage, "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Function CanDeleteStaff(Id)

        ' Function to check if the staff member with a given Id can be deleted.
        ' A staff member cannot be deleted if they are the last manager.
        ' Therefore, the number of managers is calculated.

        Dim tmpManagementCount As Integer = 0

        For i = 1 To intStaffCount
            If arrStaffDetails(i).strStaffRole = "Management" Then
                tmpManagementCount += 1
            End If
        Next

        ' If staff member being deleted is a manager, and the number of managers is 1,
        ' the staff member cannot be deleted.

        If arrStaffDetails(Id).strStaffRole = "Management" Then
            If tmpManagementCount = 1 Then
                Return False
            End If
        End If

        Return True

    End Function

    Private Sub DeleteStaffArrayPosition(Index)

        ' Deletes a staff member located at a given index number.
        ' This procedure is similar to the booking and house deletion procedures.

        Array.Clear(arrStaffDetails, Index, 1)

        For i = Index To intStaffCount - 1
            arrStaffDetails(i) = arrStaffDetails(i + 1)
        Next

        intStaffCount -= 1
        ReDim Preserve arrStaffDetails(0 To intStaffCount)
        strMessage = "Entry deleted succesfully."
        MessageBox.Show(strMessage, "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument.PrintPage

        ' Prints the booking details via the PrintDocument event.

        Dim x = intCurrentBookingIndex
        Dim tmpFont1 As New Font(New FontFamily("Yu Gothic Light"), 26)                                         ' Title font.
        Dim tmpFont2 As New Font(New FontFamily("Yu Gothic Light"), 20, FontStyle.Italic)                       ' Subheading font.
        Dim tmpFont3 As New Font(New FontFamily("Yu Gothic Light"), 14)                                         ' Body font.
        Dim tmpLogo As New Bitmap(Application.StartupPath & "\Resources\Images\book.io_logo.png")               ' Logo image path.
        Dim tmpRectangle As New Rectangle(90, 90, 60, 60)                                                       ' Logo image size.
        Dim tmpStartDate As String = arrBookingDetails(x).datBookingStartDate.ToString("g")                     ' Start date with no seconds.
        Dim tmpEndDate As String = arrBookingDetails(x).datBookingEndDate.ToString("g")                         ' End date with no seconds.
        Dim tmpHouseName As String = arrHouseDetails(arrBookingDetails(x).intBookingHouseId).strHouseName       ' House name.
        'Dim tmpCardExpiry As String = arrFinanceDetails(x).datCardExpiry.ToString("MM/yy")                      ' Card expiry with only month and year

        With e.Graphics

            ' The headings, subheadings and body text are printed with a definate location
            ' as their sizes don't change. The fields are limited in length and therefore
            ' can't go beyond the page size.

            ' Print the booking details section.

            .DrawImage(tmpLogo, tmpRectangle)
            .DrawString("Booking Details", tmpFont1, Brushes.Black, 160, 100)
            .DrawString("Booking", tmpFont2, Brushes.Black, 85, 170)
            .DrawString(String.Concat("Booking Id: ", (arrBookingDetails(x).intBookingId)), tmpFont3, Brushes.Black, 85, 225)
            .DrawString(String.Concat("Check In: ", tmpStartDate), tmpFont3, Brushes.Black, 85, 260)
            .DrawString(String.Concat("Check Out: ", tmpEndDate), tmpFont3, Brushes.Black, 85, 295)
            .DrawString(String.Concat("House: ", tmpHouseName), tmpFont3, Brushes.Black, 85, 330)
            .DrawString(String.Concat("Cost: ", FormatCurrency(arrBookingDetails(x).flpBookingCost)), tmpFont3, Brushes.Black, 85, 365)
            .DrawString(String.Concat("Information: ", arrBookingDetails(x).strBookingInformation), tmpFont3, Brushes.Black, 85, 400)

            ' Print the guest details section.

            .DrawString("Guest", tmpFont2, Brushes.Black, 85, 480)
            .DrawString(String.Concat("Name: ", arrGuestDetails(x).strGuestFirstName, " ", arrGuestDetails(x).strGuestSurname), tmpFont3, Brushes.Black, 85, 535)
            .DrawString(String.Concat("Mobile: ", arrGuestDetails(x).strGuestMobile), tmpFont3, Brushes.Black, 85, 570)
            .DrawString(String.Concat("Card Name: ", arrFinanceDetails(x).strCardName), tmpFont3, Brushes.Black, 85, 605)
            .DrawString(String.Concat("Card Number: ", arrFinanceDetails(x).strCardNumber), tmpFont3, Brushes.Black, 85, 640)
            .DrawString(String.Concat("CVV: ", arrFinanceDetails(x).strCardCVV), tmpFont3, Brushes.Black, 85, 675)
            '.DrawString(String.Concat("Card Expiry: ", tmpCardExpiry), tmpFont3, Brushes.Black, 85, 710)
            .DrawString(String.Concat("Information: ", arrGuestDetails(x).strGuestInformation), tmpFont3, Brushes.Black, 85, 745)
        End With

    End Sub

    Private Sub frmManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReadFinanceDetailsXML()
        SortDetailsArrays(1, intBookingCount)

        ' Upon the loading of the form, add all the houses names in the XML to the
        ' house choiceboxes in all tabs.

        cboSelectBookingHouse.Items.Clear()
        cboSelectStaff.Items.Clear()

        ' Makes the datetimepickers for the booking times show only
        ' hours and minutes, as seconds don't matter.

        dtpBookingStartTime.CustomFormat = "hh:mm tt"
        dtpBookingStartTime.Format = DateTimePickerFormat.Custom
        dtpBookingStartTime.ShowUpDown = True
        dtpBookingEndTime.CustomFormat = "hh:mm tt"
        dtpBookingEndTime.Format = DateTimePickerFormat.Custom
        dtpBookingEndTime.ShowUpDown = True
        dtpCardExpiry.CustomFormat = "MM/yyyy"
        dtpCardExpiry.Format = DateTimePickerFormat.Custom

        ' Update all choiceboxes with the names of all houses.

        For i = 1 To intHouseCount
            With arrHouseDetails(i)
                cboSelectBookingHouse.Items.Add(.strHouseName)
                cboBookingHouse.Items.Add(.strHouseName)
                cboSelectGuestHouse.Items.Add(.strHouseName)
                cboSelectHouseHouse.Items.Add(.strHouseName)
            End With
        Next

        For i = 1 To intStaffCount
            cboSelectStaff.Items.Add(arrStaffDetails(i).strStaffFirstName &
                                    " " & arrStaffDetails(i).strStaffSurname)
        Next

    End Sub

    Private Sub frmManagement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        ' When the management form is closed, show the login window
        ' so management can be reopened or the user logged out.

        frmLogin.Show()

    End Sub

    Private Sub cboSelectBookingHouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectBookingHouse.SelectedIndexChanged

        ' When a house is selected in the choicebox, search for the bookings
        ' associated with that house and display them in the calendar.

        cboSelectGuestHouse.SelectedIndex = cboSelectBookingHouse.SelectedIndex
        SearchHouseBookings(cboSelectBookingHouse.SelectedIndex)
        DisplayCalendarBookingDates(calBookingDate)

    End Sub

    Private Sub calBookingDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calBookingDate.DateChanged

        ' Sync the date selected on the calendar to the date time picker.

        dtpGuestDate.Value = calBookingDate.SelectionEnd
        dtpBookingDate.Value = calBookingDate.SelectionEnd

    End Sub

    Private Sub dtpBookingDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBookingDate.ValueChanged

        ' Sync the date selected in the date time picker to the calendar.

        calGuestDate.SelectionStart = dtpGuestDate.Value
        calGuestDate.SelectionEnd = dtpGuestDate.Value
        calBookingDate.SelectionStart = dtpBookingDate.Value
        calBookingDate.SelectionEnd = dtpBookingDate.Value

    End Sub

    Private Sub btnSearchBookingDate_Click(sender As Object, e As EventArgs) Handles btnSearchBookingDate.Click

        ' Search for the booking that has been selected and display the details.

        DisplayDetailsFromDate(dtpBookingDate.Value)

    End Sub

    Private Sub btnSearchBookingId_Click(sender As Object, e As EventArgs) Handles btnSearchBookingId.Click

        ' Validates the Id field text then searches the Id.
        ' When the Id number is found, the index of the array it corrosponds to is returned
        ' by the search function.

        If IsNumeric(txtBookingSearchId.Text) Then
            If SearchBookingId(txtBookingSearchId.Text) Then
                DisplayBookingDetails(intCurrentBookingIndex)
            Else
                MessageBox.Show("Search Failed." & vbNewLine & strMessage,
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearDetails(gboBookingDetails)
            End If
        Else
            strMessage = "The Booking Id must be a number."
            MessageBox.Show("Search Failed." & vbNewLine & strMessage,
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDetails(gboBookingDetails)
        End If

        txtBookingSearchId.Clear()

    End Sub

    Private Sub btnSaveBooking_Click(sender As Object, e As EventArgs) Handles btnSaveBooking.Click

        ' Saves a booking, then reloads the calendar bolded dates.

        SaveBooking(True, dtpBookingStartDate.Value, dtpBookingEndDate.Value, cboBookingHouse.SelectedIndex + 1)

        If booSaved Then
            SearchHouseBookings(cboSelectBookingHouse.SelectedIndex)
            DisplayCalendarBookingDates(calBookingDate)
            DisplayCalendarBookingDates(calGuestDate)
        End If

    End Sub

    Private Sub btnDeleteBooking_Click(sender As Object, e As EventArgs) Handles btnDeleteBooking.Click

        ' Deletes a booking along with the associated guest and finance details.
        ' Then updates the XMLs and updates the calendars.

        If txtBookingId.Text <> Nothing Then
            If vbYes = MsgBox("Are you sure you wish to delete this booking?", vbYesNo, "Save") Then

                DeleteBookingArrayPosition(Convert.ToInt32(txtBookingId.Text))

                WriteBookingDetailsXML()
                WriteGuestDetailsXML()
                WriteFinanceDetailsXML()

                SearchHouseBookings(cboSelectBookingHouse.SelectedIndex)
                SearchHouseBookings(cboSelectGuestHouse.SelectedIndex)

                DisplayCalendarBookingDates(calBookingDate)
                DisplayCalendarBookingDates(calGuestDate)

                ClearDetails(gboBookingDetails)
                ClearDetails(gboGuestDetails)

            End If
        End If

    End Sub

    Private Sub btnAddBooking_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click

        ' Adds a booking, therefore saving it and creating a new array position.

        SaveBooking(False, dtpBookingStartDate.Value, dtpBookingEndDate.Value, cboBookingHouse.SelectedIndex + 1)

        ' If the save succeeded, the calendar is refreshed and the new Id is displayed.

        If booSaved Then
            SearchHouseBookings(cboSelectBookingHouse.SelectedIndex)
            DisplayCalendarBookingDates(calBookingDate)
            DisplayCalendarBookingDates(calGuestDate)
            txtBookingId.Text = arrBookingDetails(intBookingCount).intBookingId
        End If

    End Sub

    Private Sub btnPrintBooking_Click(sender As Object, e As EventArgs) Handles btnPrintBooking.Click

        ' Prints the booking. Requires a booking Id to be selected.
        ' Opens the print dialogue and sets the printer settings.

        If txtBookingId.Text <> Nothing Then
            intCurrentBookingIndex = Array.FindIndex(arrBookingDetails, Function(f) f.intBookingId = txtBookingId.Text)
            PrintDialog.Document = PrintDocument
            PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
            PrintDialog.AllowSomePages = True

            If PrintDialog.ShowDialog = DialogResult.OK Then
                PrintDocument.PrinterSettings = PrintDialog.PrinterSettings
                PrintDocument.Print()
            End If
        Else
            MessageBox.Show("No booking has been selected.", "Print",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cboSelectGuestHouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectGuestHouse.SelectedIndexChanged

        ' When a house for the guest calendar is selected, update the guest calender
        ' with booking dates for that house.

        cboSelectBookingHouse.SelectedIndex = cboSelectGuestHouse.SelectedIndex
        SearchHouseBookings(cboSelectGuestHouse.SelectedIndex)
        DisplayCalendarBookingDates(calGuestDate)

    End Sub

    Private Sub calGuestDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calGuestDate.DateChanged

        ' Sync the dates in the date time picker with the calendar.

        dtpGuestDate.Value = calGuestDate.SelectionEnd

    End Sub

    Private Sub dtpGuestDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpGuestDate.ValueChanged

        ' Sync the dates in the calendar with the date time picker.

        calBookingDate.SelectionEnd = dtpGuestDate.Value

    End Sub

    Private Sub btnSearchGuestDate_Click(sender As Object, e As EventArgs) Handles btnSearchGuestDate.Click

        ' Displays guest details from a selected date in the calendar.

        DisplayDetailsFromDate(dtpGuestDate.Value)

    End Sub

    Private Sub btnSearchGuestId_Click(sender As Object, e As EventArgs) Handles btnSearchGuestId.Click

        ' Searches for a guest Id if the Id entered is a number.

        If IsNumeric(txtGuestId.Text) Then
            If SearchGuestId(txtGuestId.Text) Then
                DisplayGuestDetails(intCurrentGuestIndex)
            Else
                MessageBox.Show("Search Failed." & vbNewLine & strMessage,
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearDetails(gboGuestDetails)
            End If
        Else
            strMessage = "The Guest Id must be a number."
            MessageBox.Show("Search Failed." & vbNewLine & strMessage,
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDetails(gboGuestDetails)
        End If

        txtGuestId.Clear()

    End Sub

    Private Sub btnSaveGuest_Click(sender As Object, e As EventArgs) Handles btnSaveGuest.Click

        ' Saves the guest with the Id in the guest details section.

        SaveGuest(txtGuestBookingId.Text)

    End Sub

    Private Sub cboSelectHouseHouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectHouseHouse.SelectedIndexChanged

        ' Displays the house information for the selected house.

        DisplayHouseDetails(cboSelectHouseHouse.SelectedIndex + 1)

    End Sub

    Private Sub btnSaveHouse_Click(sender As Object, e As EventArgs) Handles btnSaveHouse.Click

        ' Saves a house, therefore editing an array position.
        ' If the save succeeded, the selected house is updated to the
        ' new house and the house comboboxes are updated

        SaveHouse(True)

        If booSaved Then
            cboSelectHouseHouse.Items.Clear()
            cboSelectBookingHouse.Items.Clear()
            cboBookingHouse.Items.Clear()
            cboSelectGuestHouse.Items.Clear()

            For i = 1 To intHouseCount
                cboSelectHouseHouse.Items.Add(arrHouseDetails(i).strHouseName)
                cboSelectBookingHouse.Items.Add(arrHouseDetails(i).strHouseName)
                cboBookingHouse.Items.Add(arrHouseDetails(i).strHouseName)
                cboSelectGuestHouse.Items.Add(arrHouseDetails(i).strHouseName)
            Next
            cboSelectHouseHouse.SelectedIndex = intCurrentHouseIndex - 1
        End If

    End Sub

    Private Sub btnAddHouse_Click(sender As Object, e As EventArgs) Handles btnAddHouse.Click

        ' Adds a house to the array, then updates all house comboboxes.
        ' The selected house is also set to the newly created house.

        SaveHouse(False)

        If booSaved Then
            cboSelectHouseHouse.Items.Clear()
            cboSelectBookingHouse.Items.Clear()
            cboBookingHouse.Items.Clear()
            cboSelectGuestHouse.Items.Clear()

            For i = 1 To intHouseCount
                With arrHouseDetails(i)
                    cboSelectBookingHouse.Items.Add(.strHouseName)
                    cboBookingHouse.Items.Add(.strHouseName)
                    cboSelectGuestHouse.Items.Add(.strHouseName)
                    cboSelectHouseHouse.Items.Add(.strHouseName)
                End With
            Next

            cboSelectHouseHouse.SelectedIndex = intCurrentHouseIndex - 1
        End If

    End Sub

    Private Sub btnDeleteHouse_Click(sender As Object, e As EventArgs) Handles btnDeleteHouse.Click

        ' A house is deleted only if a house is selected.
        ' The XML is rewritten to remove the house.
        ' Then updates the house comboboxes and clears the fields on the house tab.

        If cboSelectHouseHouse.Text <> Nothing Then
            If vbYes = MsgBox("Are you sure you wish to delete this house?", vbYesNo, "Save") Then
                DeleteHouseArrayPosition(cboSelectHouseHouse.SelectedIndex + 1)
                WriteHouseDetailsXML()

                calBookingDate.BoldedDates = Nothing
                calGuestDate.BoldedDates = Nothing

                cboSelectHouseHouse.Items.Clear()
                cboSelectBookingHouse.Items.Clear()
                cboBookingHouse.Items.Clear()
                cboSelectGuestHouse.Items.Clear()

                For i = 1 To intHouseCount
                    With arrHouseDetails(i)
                        cboSelectBookingHouse.Items.Add(.strHouseName)
                        cboBookingHouse.Items.Add(.strHouseName)
                        cboSelectGuestHouse.Items.Add(.strHouseName)
                        cboSelectHouseHouse.Items.Add(.strHouseName)
                    End With
                Next

                ClearDetails(gboHouseDetails)
            End If
        Else
            MessageBox.Show("There is no house selected.",
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cboSelectStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectStaff.SelectedIndexChanged

        ' Displays the staff details of a selected staff.

        DisplayStaffDetails(cboSelectStaff.SelectedIndex + 1)

    End Sub

    Private Sub btnSaveStaff_Click(sender As Object, e As EventArgs) Handles btnSaveStaff.Click

        ' Saves the staff member, editing the array.

        SaveStaff(True)

        If booSaved Then
            cboSelectStaff.Items.Clear()

            For i = 1 To intStaffCount
                cboSelectStaff.Items.Add(arrStaffDetails(i).strStaffFirstName &
                                        " " & arrStaffDetails(i).strStaffSurname)
            Next
            cboSelectStaff.SelectedIndex = intCurrentStaffIndex - 1
        End If

    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click

        ' Adds the staff memeber, creating a new array position.

        Dim tmpEmailUsed As Boolean = False
        booSaved = False

        For i = 1 To intStaffCount
            If arrStaffDetails(i).strStaffEmail.ToLower = txtStaffEmail.Text.ToLower Then
                tmpEmailUsed = True
            End If
        Next

        ' Checks if the new staff member's email is in use within the array.

        If Not tmpEmailUsed Then
            SaveStaff(False)
        Else
            MessageBox.Show("This email address is already in use.",
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If booSaved Then
            cboSelectStaff.Items.Clear()

            For i = 1 To intStaffCount
                cboSelectStaff.Items.Add(arrStaffDetails(i).strStaffFirstName &
                                        " " & arrStaffDetails(i).strStaffSurname)
            Next
            cboSelectStaff.SelectedIndex = intCurrentStaffIndex - 1
        End If

    End Sub

    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click

        ' Deletes the selected staff member.
        ' However if this staff member is the last manager, it cannot
        ' be deleted to prevent the inability to edit other staff members
        ' in the future.

        If cboSelectStaff.Text <> Nothing Then

            ' Checks if the staff member being deleted is the last manager.

            If CanDeleteStaff(cboSelectStaff.SelectedIndex + 1) Then
                If vbYes = MsgBox("Are you sure you wish to delete this staff?", vbYesNo, "Save") Then
                    If arrStaffDetails(cboSelectStaff.SelectedIndex + 1).strStaffImage <> Nothing Then
                        File.Delete(Path.Combine(strStaffImagesDirectory,
                                 arrStaffDetails(cboSelectStaff.SelectedIndex + 1).strStaffImage))
                    End If
                    DeleteStaffArrayPosition(cboSelectStaff.SelectedIndex + 1)
                    WriteStaffDetailsXML()

                    cboSelectStaff.Items.Clear()

                    For i = 1 To intStaffCount
                        cboSelectStaff.Items.Add(arrStaffDetails(i).strStaffFirstName &
                                       " " & arrStaffDetails(i).strStaffSurname)
                    Next

                    ClearDetails(gboStaffDetails)
                    txtStaffImage.Text = Nothing
                    pboStaffImage.Image = Nothing
                End If
            Else
                MessageBox.Show("Cannot delete the only manager.",
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("There is no staff selected.",
                            "Book.io", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnImageUpload_Click(sender As Object, e As EventArgs) Handles btnImageUpload.Click

        ' Opens a file dialogue to select the staff image file.

        ShowStaffImageDialog()

    End Sub

    Private Sub btnBookingCostFormat_Click(sender As Object, e As EventArgs) Handles btnBookingCostFormat.Click

        ' Calculates the booking cost using a function and displays it.
        ' It requires a start date, end date and house to be selected.

        If cboBookingHouse.Text <> Nothing Then
            Dim tmpStartDate As Date = Date.Parse(dtpBookingStartDate.Value.ToShortDateString)
            Dim tmpEndDate As Date = Date.Parse(dtpBookingEndDate.Value.ToShortDateString)

            If DateDiff(DateInterval.Day, tmpStartDate, tmpEndDate) > 0 Then
                txtBookingCost.Text = FormatCurrency(CalculateBookingCost(tmpStartDate, tmpEndDate, cboBookingHouse.SelectedIndex + 1))
            End If
        End If

    End Sub

    Private Sub btnWeekdayRateFormat_Click(sender As Object, e As EventArgs) Handles btnWeekdayRateFormat.Click

        ' Formats the weekday rate textbox as currency.

        FormatCurrencyTextBox(txtHouseWeekdayRate)

    End Sub

    Private Sub btnWeekendRateFormat_Click(sender As Object, e As EventArgs) Handles btnWeekendRateFormat.Click

        ' Formats the weekend rate textbox as currency.

        FormatCurrencyTextBox(txtHouseWeekendRate)

    End Sub

    Private Sub btnStaffWageFormat_Click(sender As Object, e As EventArgs) Handles btnStaffWageFormat.Click

        ' Formats the staff wage textbox as currency.

        FormatCurrencyTextBox(txtStaffWage)

    End Sub

End Class