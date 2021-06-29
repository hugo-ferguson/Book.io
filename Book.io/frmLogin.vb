' Login form of Book.io
' Created by Hugo Ferguson 2018
' Software Development 3/4 SAT
' Version 0.3
' Last Modified 14/09/18

Public Class frmLogin

    Dim intCurrentIndex As Integer
    Dim strMessage As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BringToFront()
        ShowLoggedOutElements()

    End Sub

    Private Sub ShowLoggedOutElements()

        ' Relocate buttons to appropriate locations, 
        ' hide all currently open windows,
        ' enable buttons for new login,
        ' clear fields for new login.

        frmManagement.Close()
        frmStaff.Close()

        btnLogin.Location = New Point(225, 283)

        btnLogout.Hide()
        btnLogout.Enabled = False
        btnLogin.Show()
        btnLogin.Enabled = True
        btnManagement.Hide()
        btnManagement.Enabled = False
        btnStaff.Hide()
        btnStaff.Enabled = False
        btnShowPassword.Enabled = True
        txtUserName.Enabled = True
        txtPassword.Enabled = True

        txtUserName.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub ShowLoggedInElements()

        ' Move the buttons on the form,
        ' Hide the form,
        ' When a user exits the management/staff window, 
        ' the login form is reopened.
        ' Therefore buttons must be in new locations for logout button
        ' and the button to open the new form.

        Me.Hide()

        btnLogout.Location = New Point(143, 283)        ' Move the buttons to their places.
        btnStaff.Location = New Point(304, 283)
        btnManagement.Location = New Point(304, 283)

        btnLogout.Show()                    ' Show and hide the required buttons.
        btnLogout.Enabled = True
        btnLogin.Hide()
        btnLogin.Enabled = False
        btnShowPassword.Enabled = False
        txtUserName.Enabled = False
        txtPassword.Enabled = False

    End Sub

    Private Function VerifyLoginFormat()

        ' Verify if inputted details are in correct format:
        ' If the username and password textboxes are filled.

        If txtUserName.Text <> "" And
            txtPassword.Text <> "" Then
            Return True
        Else
            strMessage = "Please enter a valid username and password."
            Return False
        End If

    End Function

    Private Function VerifyLoginDetails()

        ' Compare the login details entered with those stored in the XML.
        ' Then checks if the user is employed.
        ' If none of these checks can be performed the XML file is assumed to be
        ' missing or there are no users in the XML.

        If VerifyLoginFormat() Then
            If intStaffCount <> 0 Then
                For i = 1 To intStaffCount
                    If txtUserName.Text.ToLower = arrStaffDetails(i).strStaffEmail And
                            txtPassword.Text = arrStaffDetails(i).strStaffPassword Then
                        If arrStaffDetails(i).booStaffStatus = True Then
                            intCurrentIndex = i
                            Return True
                        Else
                            strMessage = "User not currently employed."
                            Return False
                        End If
                    Else
                        strMessage = "Incorrect username or password."
                    End If
                Next
            Else
                strMessage = "No staff members have been created or the StaffDetails file is missing."
            End If
        End If

        Return False

    End Function

    Private Sub PerformLogin()

        ' Verify the login format and check credentials.
        ' If successful, the login is performed by showing the
        ' users form and by enabling its corrosponding button on the 
        ' login form.
        ' If unsuccessful, an error is created with the message
        ' depending on what went wrong when performing the verification.

        strMessage = Nothing

        If VerifyLoginFormat() And
            VerifyLoginDetails() Then

            If arrStaffDetails(intCurrentIndex).strStaffRole = "Management" Then
                frmManagement.Show()
                btnManagement.Show()
                btnManagement.Enabled = True
            Else
                frmStaff.Show()
                btnStaff.Show()
                btnStaff.Enabled = True
            End If

            ShowLoggedInElements()

        Else

            MessageBox.Show("Login Failed." & vbNewLine & strMessage,
                            "Book.io Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()

        End If

    End Sub

    Private Sub btnShowPassword_MouseEnter(sender As Object, e As EventArgs) Handles btnShowPassword.MouseEnter

        txtPassword.PasswordChar = Nothing

    End Sub

    Private Sub btnShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles btnShowPassword.MouseLeave

        txtPassword.PasswordChar = "•"

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        PerformLogin()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        ShowLoggedOutElements()

    End Sub

    Private Sub btnManagement_Click(sender As Object, e As EventArgs) Handles btnManagement.Click

        frmManagement.Show()
        ShowLoggedInElements()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        frmManagement.Show()
        frmStaff.Show()

    End Sub

End Class