<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIntro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntro))
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnShowConfirmation = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfirmation = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowPassword
        '
        Me.btnShowPassword.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnShowPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnShowPassword.Location = New System.Drawing.Point(284, 261)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(68, 35)
        Me.btnShowPassword.TabIndex = 18
        Me.btnShowPassword.Text = "Show"
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(144, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(159, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Email"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtPassword.Location = New System.Drawing.Point(31, 263)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(247, 33)
        Me.txtPassword.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtEmail.Location = New System.Drawing.Point(31, 190)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(321, 33)
        Me.txtEmail.TabIndex = 14
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCreate.Location = New System.Drawing.Point(121, 401)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(140, 35)
        Me.btnCreate.TabIndex = 13
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Book.io.My.Resources.Resources.book_io_logo
        Me.PictureBox2.Location = New System.Drawing.Point(31, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Book.io.My.Resources.Resources.book_io_logotext
        Me.PictureBox1.Location = New System.Drawing.Point(113, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btnShowConfirmation
        '
        Me.btnShowConfirmation.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnShowConfirmation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnShowConfirmation.Location = New System.Drawing.Point(284, 336)
        Me.btnShowConfirmation.Name = "btnShowConfirmation"
        Me.btnShowConfirmation.Size = New System.Drawing.Size(68, 35)
        Me.btnShowConfirmation.TabIndex = 23
        Me.btnShowConfirmation.Text = "Show"
        Me.btnShowConfirmation.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(149, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Confirm"
        '
        'txtConfirmation
        '
        Me.txtConfirmation.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtConfirmation.Location = New System.Drawing.Point(31, 338)
        Me.txtConfirmation.Name = "txtConfirmation"
        Me.txtConfirmation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmation.Size = New System.Drawing.Size(247, 33)
        Me.txtConfirmation.TabIndex = 21
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 463)
        Me.Controls.Add(Me.btnShowConfirmation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtConfirmation)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnCreate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIntro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book.io"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowPassword As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnShowConfirmation As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmation As TextBox
End Class
