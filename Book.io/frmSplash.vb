' Splash screen of Book.io
' Created by Hugo Ferguson 2018
' Software Development 3/4 SAT
' Last Modified 15/09/18

Public Class frmSplash

    ' Uses a timer to fade the form in and out.
    ' When the form loads, the timer begins and with every tick of the timer,
    ' the window opacity increases until it is at its maximum.

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick

        Do Until Me.Opacity = 1
            Me.Opacity += 0.01
            Threading.Thread.Sleep(2)
        Loop

        tmrSplash.Stop()

        ' The timer is then stopped and the XML files are verified
        ' for existence and then read.


        If VerifyXMLFiles(strMessage) Then
            ReadBookingDetailsXML()
            ReadGuestDetailsXML()
            ReadHouseDetailsXML()
            ReadStaffDetailsXML()
        Else
            MessageBox.Show("Program Error." & vbNewLine & strMessage,
                            "Book.io System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Once the files are read, the timer resumes
        ' and the window fades out.

        Threading.Thread.Sleep(1000)
        tmrSplash.Start()

        Do Until Me.Opacity = 0
            Me.Opacity -= 0.01
            Threading.Thread.Sleep(2)
        Loop

        tmrSplash.Stop()

        ' If the number of staff members is 0, then a window
        ' is shown allowing the user to create the first manager role.

        If UBound(arrStaffDetails) < 1 Then
            MessageBox.Show("Please fill in the following window to create your first manager role.",
                            "Book.io System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmIntro.Show()
        Else
            frmLogin.Show()
        End If

        Me.Close()

    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set opacity to 0 and begin the timer to run the fading.

        Me.Opacity = 0
        Me.Cursor = Cursors.Default
        tmrSplash.Start()

    End Sub

End Class
