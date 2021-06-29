Imports System.Xml
Imports System.IO

' XML System of Book.io
' Created by Hugo Ferguson 2018
' Software Development 3/4 SAT
' Version 0.3
' Last Modified 12/09/18

Module XML_System

    Dim wrapper As New TripleDES(strPassword)

    ' When the financedetails and staffdetails XML elements are read, 
    ' they are decrypted before being written to the array.

    Public arrXMLFiles() As String = {(Application.StartupPath & "\Resources\XML\StaffDetails.xml"),
        (Application.StartupPath & "\Resources\XML\BookingDetails.xml"),
        (Application.StartupPath & "\Resources\XML\GuestDetails.xml"),
        (Application.StartupPath & "\Resources\XML\FinanceDetails.xml"),
        (Application.StartupPath & "\Resources\XML\HouseDetails.xml")}

    Public Function VerifyXMLFiles(ByRef strTempMessage As String)

        For i = 0 To UBound(arrXMLFiles)
            If Not File.Exists(arrXMLFiles(i)) Then
                strTempMessage += (Path.GetFileName(arrXMLFiles(i)) & " is missing." & vbNewLine)
            End If
        Next

        If strTempMessage = Nothing Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub ReadStaffDetailsXML()

        intStaffCount = 0

        Using reader As XmlReader = XmlReader.Create(arrXMLFiles(0))
            While reader.Read()
                If reader.IsStartElement() Then
                    If reader.Name = "StaffDetails" Then
                    ElseIf reader.Name = "Staff" Then
                        intStaffCount += 1
                        ReDim Preserve arrStaffDetails(0 To intStaffCount)
                    ElseIf reader.Name = "FirstName" Then
                        arrStaffDetails(intStaffCount).strStaffFirstName = reader.ReadInnerXml
                    ElseIf reader.Name = "Surname" Then
                        arrStaffDetails(intStaffCount).strStaffSurname = reader.ReadInnerXml
                    ElseIf reader.Name = "Email" Then
                        arrStaffDetails(intStaffCount).strStaffEmail = reader.ReadInnerXml
                    ElseIf reader.Name = "Password" Then
                        arrStaffDetails(intStaffCount).strStaffPassword = wrapper.DecryptText(reader.ReadInnerXml)
                    ElseIf reader.Name = "Wage" Then
                        arrStaffDetails(intStaffCount).flpStaffWage = reader.ReadInnerXml
                    ElseIf reader.Name = "Role" Then
                        arrStaffDetails(intStaffCount).strStaffRole = reader.ReadInnerXml
                    ElseIf reader.Name = "Status" Then
                        arrStaffDetails(intStaffCount).booStaffStatus = reader.ReadInnerXml
                    ElseIf reader.Name = "Mobile" Then
                        arrStaffDetails(intStaffCount).strStaffMobile = reader.ReadInnerXml
                    ElseIf reader.Name = "Address" Then
                        arrStaffDetails(intStaffCount).strStaffAddress = reader.ReadInnerXml
                    ElseIf reader.Name = "City" Then
                        arrStaffDetails(intStaffCount).strStaffCity = reader.ReadInnerXml
                    ElseIf reader.Name = "PostCode" Then
                        arrStaffDetails(intStaffCount).strStaffPostCode = reader.ReadInnerXml
                    ElseIf reader.Name = "StaffImage" Then
                        arrStaffDetails(intStaffCount).strStaffImage = reader.ReadInnerXml
                    End If
                End If
            End While
        End Using

    End Sub

    Public Sub ReadBookingDetailsXML()

        intBookingCount = 0

        Using reader As XmlReader = XmlReader.Create(arrXMLFiles(1))
            While reader.Read()
                If reader.IsStartElement() Then
                    If reader.Name = "BookingDetails" Then
                    ElseIf reader.Name = "Booking" Then
                        intBookingCount += 1
                        ReDim Preserve arrBookingDetails(0 To intBookingCount)
                        arrBookingDetails(intBookingCount).intBookingId = reader("Id")
                    ElseIf reader.Name = "HouseId" Then
                        arrBookingDetails(intBookingCount).intBookingHouseId = reader.ReadInnerXml
                    ElseIf reader.Name = "StartDate" Then
                        arrBookingDetails(intBookingCount).datBookingStartDate = reader.ReadInnerXml
                    ElseIf reader.Name = "EndDate" Then
                        arrBookingDetails(intBookingCount).datBookingEndDate = reader.ReadInnerXml
                    ElseIf reader.Name = "Cost" Then
                        arrBookingDetails(intBookingCount).flpBookingCost = reader.ReadInnerXml
                    ElseIf reader.Name = "Information" Then
                        arrBookingDetails(intBookingCount).strBookingInformation = reader.ReadInnerXml
                    End If
                End If
            End While
        End Using

    End Sub

    Public Sub ReadGuestDetailsXML()

        intGuestCount = 0

        Using reader As XmlReader = XmlReader.Create(arrXMLFiles(2))
            While reader.Read()
                If reader.IsStartElement() Then
                    If reader.Name = "GuestDetails" Then
                    ElseIf reader.Name = "Guest" Then
                        intGuestCount += 1
                        ReDim Preserve arrGuestDetails(0 To intGuestCount)
                    ElseIf reader.Name = "BookingId" Then
                        arrGuestDetails(intGuestCount).intGuestBookingId = reader.ReadInnerXml
                    ElseIf reader.Name = "Firstname" Then
                        arrGuestDetails(intGuestCount).strGuestFirstName = reader.ReadInnerXml
                    ElseIf reader.Name = "Surname" Then
                        arrGuestDetails(intGuestCount).strGuestSurname = reader.ReadInnerXml
                    ElseIf reader.Name = "Mobile" Then
                        arrGuestDetails(intGuestCount).strGuestMobile = reader.ReadInnerXml
                    ElseIf reader.Name = "Information" Then
                        arrGuestDetails(intGuestCount).strGuestInformation = reader.ReadInnerXml
                    End If
                End If
            End While
        End Using

    End Sub

    Public Sub ReadFinanceDetailsXML()

        Using reader As XmlReader = XmlReader.Create(arrXMLFiles(3))
            While reader.Read()
                If reader.IsStartElement() Then
                    If reader.Name = "FinanceDetails" Then
                    ElseIf reader.Name = "Card" Then
                        intFinanceCount += 1
                        ReDim Preserve arrFinanceDetails(0 To intFinanceCount)
                    ElseIf reader.Name = "CardName" Then
                        arrFinanceDetails(intFinanceCount).strCardName = wrapper.DecryptText(reader.ReadInnerXml)
                    ElseIf reader.Name = "CardNumber" Then
                        arrFinanceDetails(intFinanceCount).strCardNumber = wrapper.DecryptText(reader.ReadInnerXml)
                    ElseIf reader.Name = "Expiry" Then
                        arrFinanceDetails(intFinanceCount).strCardExpiry = wrapper.DecryptText(reader.ReadInnerXml)
                    ElseIf reader.Name = "CVV" Then
                        arrFinanceDetails(intFinanceCount).strCardCVV = wrapper.DecryptText(reader.ReadInnerXml)
                    ElseIf reader.Name = "BookingId" Then
                        arrFinanceDetails(intFinanceCount).intFinanceBookingId = reader.ReadInnerXml
                    End If
                End If
            End While
        End Using

    End Sub

    Public Sub ReadHouseDetailsXML()

        Using reader As XmlReader = XmlReader.Create(arrXMLFiles(4))
            While reader.Read()
                If reader.IsStartElement() Then
                    If reader.Name = "HouseDetails" Then
                    ElseIf reader.Name = "House" Then
                        intHouseCount += 1
                        ReDim Preserve arrHouseDetails(0 To intHouseCount)
                        arrHouseDetails(intHouseCount).intHouseId = reader("Id")
                    ElseIf reader.Name = "Name" Then
                        arrHouseDetails(intHouseCount).strHouseName = reader.ReadInnerXml
                    ElseIf reader.Name = "Address" Then
                        arrHouseDetails(intHouseCount).strHouseAddress = reader.ReadInnerXml
                    ElseIf reader.Name = "City" Then
                        arrHouseDetails(intHouseCount).strHouseCity = reader.ReadInnerXml
                    ElseIf reader.Name = "PostCode" Then
                        arrHouseDetails(intHouseCount).strHousePostCode = reader.ReadInnerXml
                    ElseIf reader.Name = "WeekdayRate" Then
                        arrHouseDetails(intHouseCount).flpHouseWeekdayRate = reader.ReadInnerXml
                    ElseIf reader.Name = "WeekendRate" Then
                        arrHouseDetails(intHouseCount).flpHouseWeekendRate = reader.ReadInnerXml
                    ElseIf reader.Name = "PIN" Then
                        arrHouseDetails(intHouseCount).strHousePIN = reader.ReadInnerXml
                    ElseIf reader.Name = "Information" Then
                        arrHouseDetails(intHouseCount).strHouseInformation = reader.ReadInnerXml
                    End If
                End If
            End While
        End Using

    End Sub

    Public Sub WriteBookingDetailsXML()

        ' Writes the values in the Array StaffDetail to the xml file to update it.
        ' All positions in the array are copied to the xml file.

        Dim settings As XmlWriterSettings = New XmlWriterSettings
        settings.Indent = True
        settings.ConformanceLevel = ConformanceLevel.Document

        ' Start writing to the XML file BookingDetails.xml

        Using writer As XmlWriter = XmlWriter.Create(arrXMLFiles(1), settings)

            writer.WriteStartDocument()                         ' Begin with the first element, BookingDetails.
            writer.WriteStartElement("BookingDetails")

            ' Loops through all the bookings in the array (intBookingCount) and fill in the xml file
            ' with details in array arrBookingDetails.

            For i = 1 To intBookingCount

                writer.WriteStartElement("Booking")                                                     ' Start the first element.
                writer.WriteAttributeString("Id", arrBookingDetails(i).intBookingId)                    ' Id is an attribute of Booking in xml.
                writer.WriteElementString("HouseId", arrBookingDetails(i).intBookingHouseId)            ' Add the values in the record to the
                writer.WriteElementString("StartDate", arrBookingDetails(i).datBookingStartDate)        ' Corrosponding element in xml.
                writer.WriteElementString("EndDate", arrBookingDetails(i).datBookingEndDate)
                writer.WriteElementString("Cost", arrBookingDetails(i).flpBookingCost)
                writer.WriteElementString("Information", arrBookingDetails(i).strBookingInformation)
                writer.WriteEndElement()

            Next

            writer.WriteEndElement()        ' Close element BookingDetails.
            writer.WriteEndDocument()       ' End the document.

        End Using

    End Sub

    Public Sub WriteStaffDetailsXML()

        Dim settings As XmlWriterSettings = New XmlWriterSettings
        settings.Indent = True
        settings.ConformanceLevel = ConformanceLevel.Document

        Using writer As XmlWriter = XmlWriter.Create(arrXMLFiles(0), settings)

            writer.WriteStartDocument()
            writer.WriteStartElement("StaffDetails")

            For i = 1 To intStaffCount

                writer.WriteStartElement("Staff")
                writer.WriteElementString("FirstName", arrStaffDetails(i).strStaffFirstName)
                writer.WriteElementString("Surname", arrStaffDetails(i).strStaffSurname)
                writer.WriteElementString("Email", arrStaffDetails(i).strStaffEmail)
                writer.WriteElementString("Password", wrapper.EncryptText(arrStaffDetails(i).strStaffPassword))
                writer.WriteElementString("Mobile", arrStaffDetails(i).strStaffMobile)
                writer.WriteElementString("Address", arrStaffDetails(i).strStaffAddress)
                writer.WriteElementString("City", arrStaffDetails(i).strStaffCity)
                writer.WriteElementString("PostCode", arrStaffDetails(i).strStaffPostCode)
                writer.WriteElementString("Wage", arrStaffDetails(i).flpStaffWage)
                writer.WriteElementString("Role", arrStaffDetails(i).strStaffRole)
                writer.WriteElementString("StaffImage", arrStaffDetails(i).strStaffImage)
                writer.WriteElementString("Status", arrStaffDetails(i).booStaffStatus)
                writer.WriteEndElement()

            Next

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using

    End Sub

    Public Sub WriteHouseDetailsXML()

        Dim settings As XmlWriterSettings = New XmlWriterSettings
        settings.Indent = True
        settings.ConformanceLevel = ConformanceLevel.Document

        Using writer As XmlWriter = XmlWriter.Create(arrXMLFiles(4), settings)

            writer.WriteStartDocument()
            writer.WriteStartElement("HouseDetails")

            For i = 1 To intHouseCount

                writer.WriteStartElement("House")
                writer.WriteAttributeString("Id", arrHouseDetails(i).intHouseId)
                writer.WriteElementString("Name", arrHouseDetails(i).strHouseName)
                writer.WriteElementString("Address", arrHouseDetails(i).strHouseAddress)
                writer.WriteElementString("City", arrHouseDetails(i).strHouseCity)
                writer.WriteElementString("PostCode", arrHouseDetails(i).strHousePostCode)
                writer.WriteElementString("WeekdayRate", arrHouseDetails(i).flpHouseWeekdayRate)
                writer.WriteElementString("WeekendRate", arrHouseDetails(i).flpHouseWeekendRate)
                writer.WriteElementString("PIN", arrHouseDetails(i).strHousePIN)
                writer.WriteElementString("Information", arrHouseDetails(i).strHouseInformation)
                writer.WriteEndElement()

            Next

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using

    End Sub

    Public Sub WriteGuestDetailsXML()

        Dim settings As XmlWriterSettings = New XmlWriterSettings
        settings.Indent = True
        settings.ConformanceLevel = ConformanceLevel.Document

        Using writer As XmlWriter = XmlWriter.Create(arrXMLFiles(2), settings)

            writer.WriteStartDocument()
            writer.WriteStartElement("GuestDetails")

            For i = 1 To intGuestCount

                writer.WriteStartElement("Guest")
                writer.WriteElementString("BookingId", arrGuestDetails(i).intGuestBookingId)
                writer.WriteElementString("Firstname", arrGuestDetails(i).strGuestFirstName)
                writer.WriteElementString("Surname", arrGuestDetails(i).strGuestSurname)
                writer.WriteElementString("Mobile", arrGuestDetails(i).strGuestMobile)
                writer.WriteElementString("Information", arrGuestDetails(i).strGuestInformation)
                writer.WriteEndElement()

            Next

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using

    End Sub

    Public Sub WriteFinanceDetailsXML()

        Dim settings As XmlWriterSettings = New XmlWriterSettings
        settings.Indent = True
        settings.ConformanceLevel = ConformanceLevel.Document

        Using writer As XmlWriter = XmlWriter.Create(arrXMLFiles(3), settings)

            writer.WriteStartDocument()
            writer.WriteStartElement("FinanceDetails")

            For i = 1 To intFinanceCount

                writer.WriteStartElement("Card")
                writer.WriteElementString("CardName", wrapper.EncryptText(arrFinanceDetails(i).strCardName))
                writer.WriteElementString("CardNumber", wrapper.EncryptText(arrFinanceDetails(i).strCardNumber))
                writer.WriteElementString("Expiry", wrapper.EncryptText(arrFinanceDetails(i).strCardExpiry))
                writer.WriteElementString("CVV", wrapper.EncryptText(arrFinanceDetails(i).strCardCVV))
                writer.WriteElementString("BookingId", arrFinanceDetails(i).intFinanceBookingId)
                writer.WriteEndElement()

            Next

            writer.WriteEndElement()
            writer.WriteEndDocument()

        End Using

    End Sub

End Module