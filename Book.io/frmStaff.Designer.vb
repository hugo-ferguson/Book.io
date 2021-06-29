<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.btnStaffSearchId = New System.Windows.Forms.Button()
        Me.btnStaffSearchDate = New System.Windows.Forms.Button()
        Me.txtStaffSearchId = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpStaffDate = New System.Windows.Forms.DateTimePicker()
        Me.calStaffDate = New System.Windows.Forms.MonthCalendar()
        Me.cboStaffSelectHouse = New System.Windows.Forms.ComboBox()
        Me.tbcStaffControl = New System.Windows.Forms.TabControl()
        Me.tabStaffBookingDetails = New System.Windows.Forms.TabPage()
        Me.txtStaffBookingHouse = New System.Windows.Forms.TextBox()
        Me.txtStaffBookingInformation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpStaffBookingStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpStaffBookingStartTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpStaffBookingEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtStaffBookingId = New System.Windows.Forms.TextBox()
        Me.dtpStaffBookingEndTime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStaffBookingCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabStaffGuestDetails = New System.Windows.Forms.TabPage()
        Me.txtStaffGuestFirstName = New System.Windows.Forms.TextBox()
        Me.txtStaffGuestInformation = New System.Windows.Forms.TextBox()
        Me.txtStaffGuestSurname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbcStaffControl.SuspendLayout()
        Me.tabStaffBookingDetails.SuspendLayout()
        Me.tabStaffGuestDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStaffSearchId
        '
        Me.btnStaffSearchId.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnStaffSearchId.Location = New System.Drawing.Point(201, 692)
        Me.btnStaffSearchId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStaffSearchId.Name = "btnStaffSearchId"
        Me.btnStaffSearchId.Size = New System.Drawing.Size(158, 54)
        Me.btnStaffSearchId.TabIndex = 5
        Me.btnStaffSearchId.Text = "Search ID"
        Me.btnStaffSearchId.UseVisualStyleBackColor = True
        '
        'btnStaffSearchDate
        '
        Me.btnStaffSearchDate.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnStaffSearchDate.Location = New System.Drawing.Point(18, 692)
        Me.btnStaffSearchDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStaffSearchDate.Name = "btnStaffSearchDate"
        Me.btnStaffSearchDate.Size = New System.Drawing.Size(158, 54)
        Me.btnStaffSearchDate.TabIndex = 4
        Me.btnStaffSearchDate.Text = "Search Date"
        Me.btnStaffSearchDate.UseVisualStyleBackColor = True
        '
        'txtStaffSearchId
        '
        Me.txtStaffSearchId.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtStaffSearchId.Location = New System.Drawing.Point(180, 412)
        Me.txtStaffSearchId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffSearchId.Name = "txtStaffSearchId"
        Me.txtStaffSearchId.Size = New System.Drawing.Size(176, 45)
        Me.txtStaffSearchId.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label27.Location = New System.Drawing.Point(38, 415)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(135, 38)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Search ID"
        '
        'dtpStaffDate
        '
        Me.dtpStaffDate.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtpStaffDate.Location = New System.Drawing.Point(18, 351)
        Me.dtpStaffDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStaffDate.Name = "dtpStaffDate"
        Me.dtpStaffDate.Size = New System.Drawing.Size(338, 33)
        Me.dtpStaffDate.TabIndex = 2
        '
        'calStaffDate
        '
        Me.calStaffDate.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.calStaffDate.Location = New System.Drawing.Point(18, 83)
        Me.calStaffDate.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.calStaffDate.MaxSelectionCount = 1
        Me.calStaffDate.Name = "calStaffDate"
        Me.calStaffDate.TabIndex = 1
        '
        'cboStaffSelectHouse
        '
        Me.cboStaffSelectHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffSelectHouse.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.cboStaffSelectHouse.FormattingEnabled = True
        Me.cboStaffSelectHouse.Items.AddRange(New Object() {""})
        Me.cboStaffSelectHouse.Location = New System.Drawing.Point(18, 18)
        Me.cboStaffSelectHouse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboStaffSelectHouse.Name = "cboStaffSelectHouse"
        Me.cboStaffSelectHouse.Size = New System.Drawing.Size(338, 46)
        Me.cboStaffSelectHouse.TabIndex = 0
        '
        'tbcStaffControl
        '
        Me.tbcStaffControl.Controls.Add(Me.tabStaffBookingDetails)
        Me.tbcStaffControl.Controls.Add(Me.tabStaffGuestDetails)
        Me.tbcStaffControl.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tbcStaffControl.Location = New System.Drawing.Point(376, 18)
        Me.tbcStaffControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbcStaffControl.Name = "tbcStaffControl"
        Me.tbcStaffControl.SelectedIndex = 0
        Me.tbcStaffControl.Size = New System.Drawing.Size(675, 734)
        Me.tbcStaffControl.TabIndex = 6
        '
        'tabStaffBookingDetails
        '
        Me.tabStaffBookingDetails.Controls.Add(Me.txtStaffBookingHouse)
        Me.tabStaffBookingDetails.Controls.Add(Me.txtStaffBookingInformation)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label1)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label9)
        Me.tabStaffBookingDetails.Controls.Add(Me.dtpStaffBookingStartDate)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label8)
        Me.tabStaffBookingDetails.Controls.Add(Me.dtpStaffBookingStartTime)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label3)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label7)
        Me.tabStaffBookingDetails.Controls.Add(Me.dtpStaffBookingEndDate)
        Me.tabStaffBookingDetails.Controls.Add(Me.txtStaffBookingId)
        Me.tabStaffBookingDetails.Controls.Add(Me.dtpStaffBookingEndTime)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label6)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label5)
        Me.tabStaffBookingDetails.Controls.Add(Me.txtStaffBookingCost)
        Me.tabStaffBookingDetails.Controls.Add(Me.Label4)
        Me.tabStaffBookingDetails.Location = New System.Drawing.Point(4, 47)
        Me.tabStaffBookingDetails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabStaffBookingDetails.Name = "tabStaffBookingDetails"
        Me.tabStaffBookingDetails.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabStaffBookingDetails.Size = New System.Drawing.Size(667, 683)
        Me.tabStaffBookingDetails.TabIndex = 0
        Me.tabStaffBookingDetails.Text = "Booking"
        Me.tabStaffBookingDetails.UseVisualStyleBackColor = True
        '
        'txtStaffBookingHouse
        '
        Me.txtStaffBookingHouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffBookingHouse.Location = New System.Drawing.Point(200, 345)
        Me.txtStaffBookingHouse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffBookingHouse.Name = "txtStaffBookingHouse"
        Me.txtStaffBookingHouse.ReadOnly = True
        Me.txtStaffBookingHouse.Size = New System.Drawing.Size(432, 39)
        Me.txtStaffBookingHouse.TabIndex = 13
        '
        'txtStaffBookingInformation
        '
        Me.txtStaffBookingInformation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffBookingInformation.Location = New System.Drawing.Point(200, 398)
        Me.txtStaffBookingInformation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffBookingInformation.Multiline = True
        Me.txtStaffBookingInformation.Name = "txtStaffBookingInformation"
        Me.txtStaffBookingInformation.ReadOnly = True
        Me.txtStaffBookingInformation.Size = New System.Drawing.Size(432, 259)
        Me.txtStaffBookingInformation.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(54, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Start Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(38, 405)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 31)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpStaffBookingStartDate
        '
        Me.dtpStaffBookingStartDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffBookingStartDate.Enabled = False
        Me.dtpStaffBookingStartDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffBookingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStaffBookingStartDate.Location = New System.Drawing.Point(200, 22)
        Me.dtpStaffBookingStartDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStaffBookingStartDate.Name = "dtpStaffBookingStartDate"
        Me.dtpStaffBookingStartDate.Size = New System.Drawing.Size(216, 39)
        Me.dtpStaffBookingStartDate.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(92, 351)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 31)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "House"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpStaffBookingStartTime
        '
        Me.dtpStaffBookingStartTime.Enabled = False
        Me.dtpStaffBookingStartTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffBookingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStaffBookingStartTime.Location = New System.Drawing.Point(200, 75)
        Me.dtpStaffBookingStartTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStaffBookingStartTime.Name = "dtpStaffBookingStartTime"
        Me.dtpStaffBookingStartTime.Size = New System.Drawing.Size(216, 39)
        Me.dtpStaffBookingStartTime.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(50, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 31)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Start Time"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(44, 297)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 31)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Booking ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpStaffBookingEndDate
        '
        Me.dtpStaffBookingEndDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffBookingEndDate.Enabled = False
        Me.dtpStaffBookingEndDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffBookingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStaffBookingEndDate.Location = New System.Drawing.Point(200, 129)
        Me.dtpStaffBookingEndDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStaffBookingEndDate.Name = "dtpStaffBookingEndDate"
        Me.dtpStaffBookingEndDate.Size = New System.Drawing.Size(216, 39)
        Me.dtpStaffBookingEndDate.TabIndex = 9
        '
        'txtStaffBookingId
        '
        Me.txtStaffBookingId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffBookingId.Location = New System.Drawing.Point(200, 291)
        Me.txtStaffBookingId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffBookingId.Name = "txtStaffBookingId"
        Me.txtStaffBookingId.ReadOnly = True
        Me.txtStaffBookingId.Size = New System.Drawing.Size(216, 39)
        Me.txtStaffBookingId.TabIndex = 12
        '
        'dtpStaffBookingEndTime
        '
        Me.dtpStaffBookingEndTime.Enabled = False
        Me.dtpStaffBookingEndTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStaffBookingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStaffBookingEndTime.Location = New System.Drawing.Point(200, 183)
        Me.dtpStaffBookingEndTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStaffBookingEndTime.Name = "dtpStaffBookingEndTime"
        Me.dtpStaffBookingEndTime.Size = New System.Drawing.Size(216, 39)
        Me.dtpStaffBookingEndTime.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(108, 243)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 31)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Cost"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(62, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 31)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "End Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaffBookingCost
        '
        Me.txtStaffBookingCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffBookingCost.Location = New System.Drawing.Point(200, 237)
        Me.txtStaffBookingCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffBookingCost.Name = "txtStaffBookingCost"
        Me.txtStaffBookingCost.ReadOnly = True
        Me.txtStaffBookingCost.Size = New System.Drawing.Size(216, 39)
        Me.txtStaffBookingCost.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(62, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 31)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "End Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabStaffGuestDetails
        '
        Me.tabStaffGuestDetails.Controls.Add(Me.txtStaffGuestFirstName)
        Me.tabStaffGuestDetails.Controls.Add(Me.txtStaffGuestInformation)
        Me.tabStaffGuestDetails.Controls.Add(Me.txtStaffGuestSurname)
        Me.tabStaffGuestDetails.Controls.Add(Me.Label17)
        Me.tabStaffGuestDetails.Controls.Add(Me.Label11)
        Me.tabStaffGuestDetails.Controls.Add(Me.Label18)
        Me.tabStaffGuestDetails.Location = New System.Drawing.Point(4, 47)
        Me.tabStaffGuestDetails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabStaffGuestDetails.Name = "tabStaffGuestDetails"
        Me.tabStaffGuestDetails.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabStaffGuestDetails.Size = New System.Drawing.Size(667, 683)
        Me.tabStaffGuestDetails.TabIndex = 1
        Me.tabStaffGuestDetails.Text = "Guest"
        Me.tabStaffGuestDetails.UseVisualStyleBackColor = True
        '
        'txtStaffGuestFirstName
        '
        Me.txtStaffGuestFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffGuestFirstName.Location = New System.Drawing.Point(200, 22)
        Me.txtStaffGuestFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffGuestFirstName.Name = "txtStaffGuestFirstName"
        Me.txtStaffGuestFirstName.ReadOnly = True
        Me.txtStaffGuestFirstName.Size = New System.Drawing.Size(216, 39)
        Me.txtStaffGuestFirstName.TabIndex = 7
        '
        'txtStaffGuestInformation
        '
        Me.txtStaffGuestInformation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffGuestInformation.Location = New System.Drawing.Point(200, 132)
        Me.txtStaffGuestInformation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffGuestInformation.Multiline = True
        Me.txtStaffGuestInformation.Name = "txtStaffGuestInformation"
        Me.txtStaffGuestInformation.ReadOnly = True
        Me.txtStaffGuestInformation.Size = New System.Drawing.Size(432, 322)
        Me.txtStaffGuestInformation.TabIndex = 9
        '
        'txtStaffGuestSurname
        '
        Me.txtStaffGuestSurname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffGuestSurname.Location = New System.Drawing.Point(200, 75)
        Me.txtStaffGuestSurname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStaffGuestSurname.Name = "txtStaffGuestSurname"
        Me.txtStaffGuestSurname.ReadOnly = True
        Me.txtStaffGuestSurname.Size = New System.Drawing.Size(216, 39)
        Me.txtStaffGuestSurname.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label17.Location = New System.Drawing.Point(66, 82)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 31)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Surname"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label11.Location = New System.Drawing.Point(36, 138)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 31)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Information"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label18.Location = New System.Drawing.Point(46, 28)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 31)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1065, 771)
        Me.Controls.Add(Me.tbcStaffControl)
        Me.Controls.Add(Me.btnStaffSearchId)
        Me.Controls.Add(Me.btnStaffSearchDate)
        Me.Controls.Add(Me.cboStaffSelectHouse)
        Me.Controls.Add(Me.txtStaffSearchId)
        Me.Controls.Add(Me.calStaffDate)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.dtpStaffDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book.io Staff"
        Me.tbcStaffControl.ResumeLayout(False)
        Me.tabStaffBookingDetails.ResumeLayout(False)
        Me.tabStaffBookingDetails.PerformLayout()
        Me.tabStaffGuestDetails.ResumeLayout(False)
        Me.tabStaffGuestDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStaffSearchId As Button
    Friend WithEvents btnStaffSearchDate As Button
    Friend WithEvents txtStaffSearchId As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents dtpStaffDate As DateTimePicker
    Friend WithEvents calStaffDate As MonthCalendar
    Friend WithEvents cboStaffSelectHouse As ComboBox
    Friend WithEvents tbcStaffControl As TabControl
    Friend WithEvents tabStaffBookingDetails As TabPage
    Friend WithEvents tabStaffGuestDetails As TabPage
    Friend WithEvents txtStaffBookingInformation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpStaffBookingStartDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpStaffBookingStartTime As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpStaffBookingEndDate As DateTimePicker
    Friend WithEvents txtStaffBookingId As TextBox
    Friend WithEvents dtpStaffBookingEndTime As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStaffBookingCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStaffGuestFirstName As TextBox
    Friend WithEvents txtStaffGuestInformation As TextBox
    Friend WithEvents txtStaffGuestSurname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStaffBookingHouse As TextBox
End Class
