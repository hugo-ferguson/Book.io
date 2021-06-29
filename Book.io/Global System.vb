Imports System.Security.Cryptography
Imports System.IO
Imports Microsoft.Win32

' Global System of Book.io
' Created by Hugo Ferguson 2018
' Software Development 3/4 SAT
' Version 0.3
' Last Modified 16/09/18

Module Global_System

    ' Declare array counters and other global variables.
    ' strPassword is used as the encryption key in the TripleDES function.

    Public strMessage As String
    Public intStaffCount As Integer
    Public intBookingCount As Integer
    Public intHouseCount As Integer
    Public intGuestCount As Integer
    Public intFinanceCount As Integer
    Public strPassword As String = "u4aUt0Bzkvjp%^dofeOnzlP3dv98K7GdRGFvi*Rq%X3OJ$fYT6KOH$g1BXfwEq5W"
    Public wrapper As New TripleDES(strPassword)

    Public arrStaffDetails(0) As StaffDetails           ' Staff array.
    Public arrBookingDetails(0) As BookingDetails       ' Booking array.
    Public arrGuestDetails(0) As GuestDetails           ' Guest array.
    Public arrFinanceDetails(0) As FinanceDetails       ' Finance array.
    Public arrHouseDetails(0) As HouseDetails           ' House array.

    Public Structure StaffDetails

        Dim strStaffFirstName As String
        Dim strStaffSurname As String
        Dim strStaffEmail As String
        Dim strStaffPassword As String
        Dim strStaffRole As String
        Dim strStaffMobile As String
        Dim strStaffAddress As String
        Dim strStaffCity As String
        Dim strStaffPostCode As String
        Dim strStaffImage As String
        Dim flpStaffWage As Double
        Dim booStaffStatus As Boolean

    End Structure

    Public Structure BookingDetails

        Dim strBookingInformation As String
        Dim intBookingId As Integer
        Dim intBookingHouseId As Integer
        Dim flpBookingCost As Double
        Dim datBookingStartDate As DateTime
        Dim datBookingEndDate As DateTime

    End Structure

    Public Structure GuestDetails

        Dim strGuestFirstName As String
        Dim strGuestSurname As String
        Dim strGuestMobile As String
        Dim strGuestInformation As String
        Dim intGuestBookingId As Integer

    End Structure

    Public Structure FinanceDetails

        Dim strCardName As String
        Dim strCardNumber As String
        Dim strCardCVV As String
        Dim strCardExpiry As String
        Dim intFinanceBookingId As Integer

    End Structure

    Public Structure HouseDetails

        Dim strHouseName As String
        Dim strHouseAddress As String
        Dim strHouseCity As String
        Dim strHousePostCode As String
        Dim strHousePIN As String
        Dim strHouseInformation As String
        Dim intHouseId As Integer
        Dim flpHouseWeekdayRate As Double
        Dim flpHouseWeekendRate As Double

    End Structure

    Public NotInheritable Class TripleDES

        ' Used to encrypt/decrypt strings.
        ' When saving to or reading the finance and staff details XML,
        ' individual strings are encrypted and saved to their elements.

        ' The encryption system used is TripleDES, the password
        ' is constant and stored in strPassword. This provides enough security
        ' to prevent reading of the XML file.

        Private TripleDES As New TripleDESCryptoServiceProvider

        Private Function TruncateHash(ByVal Key As String, ByVal Length As Integer) As Byte()
            Dim SHA1 As New SHA1CryptoServiceProvider
            Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(Key)
            Dim hash() As Byte = SHA1.ComputeHash(keyBytes)

            ReDim Preserve hash(Length - 1)
            Return hash
        End Function

        Sub New(ByVal Key As String)
            TripleDES.Key = TruncateHash(Key, TripleDES.KeySize \ 8)
            TripleDES.IV = TruncateHash("", TripleDES.BlockSize \ 8)
        End Sub

        Public Function EncryptText(ByVal decText As String) As String

            ' Takes a string passed in (decText) and encrypts it using
            ' TripleDES and the password. It then returns the encrypted value.

            If (String.IsNullOrEmpty(decText)) Then Return Nothing

            Dim textBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(decText)
            Dim memStream As New System.IO.MemoryStream
            Dim encStream As New CryptoStream(memStream, TripleDES.CreateEncryptor(),
                                                      System.Security.Cryptography.CryptoStreamMode.Write)

            encStream.Write(textBytes, 0, textBytes.Length)
            encStream.FlushFinalBlock()

            Return Convert.ToBase64String(memStream.ToArray)

        End Function

        Public Function DecryptText(ByVal encText As String) As String

            ' Takes a string passed in (encText) and decrypts it using
            ' TripleDES and the password. It then returns the decrypted value.

            If (String.IsNullOrEmpty(encText)) Then Return Nothing

            Dim encBytes() As Byte = Convert.FromBase64String(encText)
            Dim memStream As New System.IO.MemoryStream
            Dim decStream As New CryptoStream(memStream, TripleDES.CreateDecryptor(),
                                                      System.Security.Cryptography.CryptoStreamMode.Write)

            decStream.Write(encBytes, 0, encBytes.Length)
            decStream.FlushFinalBlock()

            Return System.Text.Encoding.Unicode.GetString(memStream.ToArray)

        End Function

    End Class

End Module
