' Intro (First Time User) form of Book.io
' Created by Hugo Ferguson 2018
' Software Development 3/4 SAT
' Version 0.3
' Last Modified 15/09/18

Public Class frmIntro

    ' This form appears if there are no staff members defined in the XML,
    ' therefore preventing a login. This allows for the first time
    ' creation of a manager account.

    Private Function VerifyDetailsFields()

        ' Checks if the account details are valid, ie:
        ' the email contains '@' and '.",
        ' the password and confirmation match,
        ' and all 3 fields are filled out.

        If txtEmail.Text = Nothing Or
                txtPassword.Text = Nothing Then
            strMessage = "Please enter an email and password."
            Return False
        Else
            If Not txtEmail.Text.Contains("@") Or
            Not txtEmail.Text.Contains(".") Then
                strMessage = "Please enter a valid email address."
                Return False
            End If
            If Not txtPassword.Text = txtConfirmation.Text Then
                strMessage = "The passwords entered do not match."
                Return False
            End If
            Try
                Convert.FromBase64String(txtPassword.Text)
            Catch ex As Exception
                strMessage = "The staff password can contain only numbers and letters."
                Return False
            End Try
        End If

        Return True

    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        ' Verifies the details fields before adding a manager,
        ' therefore increasing the array size by 1 and making the staff count equal to 1.

        If VerifyDetailsFields() Then

            intStaffCount = 1
            ReDim arrStaffDetails(0 To 1)

            ' The details entered are saved to the staff array, with the remaining
            ' variables left empty for later editing.

            With arrStaffDetails(1)
                .strStaffFirstName = "New Manager"
                .strStaffEmail = txtEmail.Text
                .strStaffPassword = txtPassword.Text
                .strStaffRole = "Management"
                .booStaffStatus = True
            End With

            MessageBox.Show("Manager created successfully." & vbNewLine &
                            "To add the remaining details, please edit the staff member later in the Management Window.",
                            "Book.io System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' The XML is the written with the new array contents
            ' and the Management form opened.

            WriteStaffDetailsXML()
            ReadStaffDetailsXML()
            frmManagement.Show()
            Me.Close()

        Else
            MessageBox.Show(strMessage, "Book.io System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnShowPassword_MouseEnter(sender As Object, e As EventArgs) Handles btnShowPassword.MouseEnter

        ' When hovered over, the passchar of the password textbox is removed,
        ' allowing the password to be viewed.

        txtPassword.PasswordChar = Nothing

    End Sub

    Private Sub btnShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles btnShowPassword.MouseLeave

        ' When hovered over, the passchar of the password textbox is added back,
        ' hiding the password.

        txtPassword.PasswordChar = "•"

    End Sub

    Private Sub btnShowConfirmation_MouseEnter(sender As Object, e As EventArgs) Handles btnShowConfirmation.MouseEnter

        txtConfirmation.PasswordChar = Nothing

    End Sub

    Private Sub btnShowConfirmation_MouseLeave(sender As Object, e As EventArgs) Handles btnShowConfirmation.MouseLeave

        txtConfirmation.PasswordChar = "•"

    End Sub
End Class