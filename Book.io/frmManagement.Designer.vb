<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManagement))
        Me.tbcManagementControls = New System.Windows.Forms.TabControl()
        Me.tabBookingDetails = New System.Windows.Forms.TabPage()
        Me.btnPrintBooking = New System.Windows.Forms.Button()
        Me.btnAddBooking = New System.Windows.Forms.Button()
        Me.gboBookingDetails = New System.Windows.Forms.GroupBox()
        Me.btnBookingCostFormat = New System.Windows.Forms.Button()
        Me.txtBookingInformation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBookingHouse = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBookingId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBookingCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpBookingEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpBookingEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpBookingStartTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpBookingStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchBookingId = New System.Windows.Forms.Button()
        Me.btnSearchBookingDate = New System.Windows.Forms.Button()
        Me.btnDeleteBooking = New System.Windows.Forms.Button()
        Me.btnSaveBooking = New System.Windows.Forms.Button()
        Me.txtBookingSearchId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.calBookingDate = New System.Windows.Forms.MonthCalendar()
        Me.cboSelectBookingHouse = New System.Windows.Forms.ComboBox()
        Me.tabGuestDetails = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gboGuestDetails = New System.Windows.Forms.GroupBox()
        Me.txtGuestMobile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGuestBookingId = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtGuestInformation = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpCardExpiry = New System.Windows.Forms.DateTimePicker()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.txtGuestSurname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtGuestFirstName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCardCVV = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSearchGuestId = New System.Windows.Forms.Button()
        Me.btnSearchGuestDate = New System.Windows.Forms.Button()
        Me.btnSaveGuest = New System.Windows.Forms.Button()
        Me.txtGuestId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpGuestDate = New System.Windows.Forms.DateTimePicker()
        Me.calGuestDate = New System.Windows.Forms.MonthCalendar()
        Me.cboSelectGuestHouse = New System.Windows.Forms.ComboBox()
        Me.tabHouseDetails = New System.Windows.Forms.TabPage()
        Me.btnAddHouse = New System.Windows.Forms.Button()
        Me.gboHouseDetails = New System.Windows.Forms.GroupBox()
        Me.txtHouseCity = New System.Windows.Forms.TextBox()
        Me.txtHouseAddress = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btnWeekendRateFormat = New System.Windows.Forms.Button()
        Me.btnWeekdayRateFormat = New System.Windows.Forms.Button()
        Me.txtHouseInformation = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtHousePIN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHouseWeekendRate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHousePostCode = New System.Windows.Forms.TextBox()
        Me.txtHouseName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtHouseWeekdayRate = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnDeleteHouse = New System.Windows.Forms.Button()
        Me.btnSaveHouse = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboSelectHouseHouse = New System.Windows.Forms.ComboBox()
        Me.tabStaffDetails = New System.Windows.Forms.TabPage()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.gboStaffDetails = New System.Windows.Forms.GroupBox()
        Me.txtStaffCity = New System.Windows.Forms.TextBox()
        Me.txtStaffAddress = New System.Windows.Forms.TextBox()
        Me.btnStaffWageFormat = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.rbtStaffStatusFalse = New System.Windows.Forms.RadioButton()
        Me.rbtStaffStatusTrue = New System.Windows.Forms.RadioButton()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cboStaffRole = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtStaffPassword = New System.Windows.Forms.TextBox()
        Me.txtStaffFirstName = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtStaffSurname = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtStaffWage = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtStaffMobile = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtStaffPostcode = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnDeleteStaff = New System.Windows.Forms.Button()
        Me.btnSaveStaff = New System.Windows.Forms.Button()
        Me.cboSelectStaff = New System.Windows.Forms.ComboBox()
        Me.txtStaffImage = New System.Windows.Forms.TextBox()
        Me.btnImageUpload = New System.Windows.Forms.Button()
        Me.pboStaffImage = New System.Windows.Forms.PictureBox()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.tbcManagementControls.SuspendLayout()
        Me.tabBookingDetails.SuspendLayout()
        Me.gboBookingDetails.SuspendLayout()
        Me.tabGuestDetails.SuspendLayout()
        Me.gboGuestDetails.SuspendLayout()
        Me.tabHouseDetails.SuspendLayout()
        Me.gboHouseDetails.SuspendLayout()
        Me.tabStaffDetails.SuspendLayout()
        Me.gboStaffDetails.SuspendLayout()
        CType(Me.pboStaffImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcManagementControls
        '
        Me.tbcManagementControls.Controls.Add(Me.tabBookingDetails)
        Me.tbcManagementControls.Controls.Add(Me.tabGuestDetails)
        Me.tbcManagementControls.Controls.Add(Me.tabHouseDetails)
        Me.tbcManagementControls.Controls.Add(Me.tabStaffDetails)
        Me.tbcManagementControls.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcManagementControls.Location = New System.Drawing.Point(11, 11)
        Me.tbcManagementControls.Margin = New System.Windows.Forms.Padding(2)
        Me.tbcManagementControls.Name = "tbcManagementControls"
        Me.tbcManagementControls.SelectedIndex = 0
        Me.tbcManagementControls.Size = New System.Drawing.Size(712, 539)
        Me.tbcManagementControls.TabIndex = 0
        '
        'tabBookingDetails
        '
        Me.tabBookingDetails.AccessibleName = "tabBookingDetails"
        Me.tabBookingDetails.Controls.Add(Me.btnPrintBooking)
        Me.tabBookingDetails.Controls.Add(Me.btnAddBooking)
        Me.tabBookingDetails.Controls.Add(Me.gboBookingDetails)
        Me.tabBookingDetails.Controls.Add(Me.btnSearchBookingId)
        Me.tabBookingDetails.Controls.Add(Me.btnSearchBookingDate)
        Me.tabBookingDetails.Controls.Add(Me.btnDeleteBooking)
        Me.tabBookingDetails.Controls.Add(Me.btnSaveBooking)
        Me.tabBookingDetails.Controls.Add(Me.txtBookingSearchId)
        Me.tabBookingDetails.Controls.Add(Me.Label2)
        Me.tabBookingDetails.Controls.Add(Me.dtpBookingDate)
        Me.tabBookingDetails.Controls.Add(Me.calBookingDate)
        Me.tabBookingDetails.Controls.Add(Me.cboSelectBookingHouse)
        Me.tabBookingDetails.Location = New System.Drawing.Point(4, 34)
        Me.tabBookingDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.tabBookingDetails.Name = "tabBookingDetails"
        Me.tabBookingDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.tabBookingDetails.Size = New System.Drawing.Size(704, 501)
        Me.tabBookingDetails.TabIndex = 0
        Me.tabBookingDetails.Text = "Bookings"
        Me.tabBookingDetails.UseVisualStyleBackColor = True
        '
        'btnPrintBooking
        '
        Me.btnPrintBooking.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBooking.Location = New System.Drawing.Point(140, 444)
        Me.btnPrintBooking.Name = "btnPrintBooking"
        Me.btnPrintBooking.Size = New System.Drawing.Size(105, 35)
        Me.btnPrintBooking.TabIndex = 10
        Me.btnPrintBooking.Text = "Print Booking"
        Me.btnPrintBooking.UseVisualStyleBackColor = True
        '
        'btnAddBooking
        '
        Me.btnAddBooking.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBooking.Location = New System.Drawing.Point(18, 444)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(105, 35)
        Me.btnAddBooking.TabIndex = 9
        Me.btnAddBooking.Text = "Save New Booking"
        Me.btnAddBooking.UseVisualStyleBackColor = True
        '
        'gboBookingDetails
        '
        Me.gboBookingDetails.Controls.Add(Me.btnBookingCostFormat)
        Me.gboBookingDetails.Controls.Add(Me.txtBookingInformation)
        Me.gboBookingDetails.Controls.Add(Me.Label9)
        Me.gboBookingDetails.Controls.Add(Me.Label8)
        Me.gboBookingDetails.Controls.Add(Me.cboBookingHouse)
        Me.gboBookingDetails.Controls.Add(Me.Label7)
        Me.gboBookingDetails.Controls.Add(Me.txtBookingId)
        Me.gboBookingDetails.Controls.Add(Me.Label6)
        Me.gboBookingDetails.Controls.Add(Me.txtBookingCost)
        Me.gboBookingDetails.Controls.Add(Me.Label5)
        Me.gboBookingDetails.Controls.Add(Me.dtpBookingEndTime)
        Me.gboBookingDetails.Controls.Add(Me.dtpBookingEndDate)
        Me.gboBookingDetails.Controls.Add(Me.Label1)
        Me.gboBookingDetails.Controls.Add(Me.dtpBookingStartTime)
        Me.gboBookingDetails.Controls.Add(Me.dtpBookingStartDate)
        Me.gboBookingDetails.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboBookingDetails.Location = New System.Drawing.Point(271, 21)
        Me.gboBookingDetails.Name = "gboBookingDetails"
        Me.gboBookingDetails.Size = New System.Drawing.Size(430, 458)
        Me.gboBookingDetails.TabIndex = 8
        Me.gboBookingDetails.TabStop = False
        Me.gboBookingDetails.Text = "Booking Details"
        '
        'btnBookingCostFormat
        '
        Me.btnBookingCostFormat.Location = New System.Drawing.Point(277, 169)
        Me.btnBookingCostFormat.Name = "btnBookingCostFormat"
        Me.btnBookingCostFormat.Size = New System.Drawing.Size(79, 29)
        Me.btnBookingCostFormat.TabIndex = 14
        Me.btnBookingCostFormat.Text = "Calculate"
        Me.btnBookingCostFormat.UseVisualStyleBackColor = True
        '
        'txtBookingInformation
        '
        Me.txtBookingInformation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingInformation.Location = New System.Drawing.Point(126, 274)
        Me.txtBookingInformation.MaxLength = 240
        Me.txtBookingInformation.Multiline = True
        Me.txtBookingInformation.Name = "txtBookingInformation"
        Me.txtBookingInformation.Size = New System.Drawing.Size(289, 159)
        Me.txtBookingInformation.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "House"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboBookingHouse
        '
        Me.cboBookingHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBookingHouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBookingHouse.FormattingEnabled = True
        Me.cboBookingHouse.ItemHeight = 21
        Me.cboBookingHouse.Location = New System.Drawing.Point(126, 239)
        Me.cboBookingHouse.Name = "cboBookingHouse"
        Me.cboBookingHouse.Size = New System.Drawing.Size(289, 29)
        Me.cboBookingHouse.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Booking ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBookingId
        '
        Me.txtBookingId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingId.Location = New System.Drawing.Point(126, 204)
        Me.txtBookingId.Name = "txtBookingId"
        Me.txtBookingId.ReadOnly = True
        Me.txtBookingId.Size = New System.Drawing.Size(145, 29)
        Me.txtBookingId.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cost"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBookingCost
        '
        Me.txtBookingCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookingCost.Location = New System.Drawing.Point(126, 169)
        Me.txtBookingCost.Name = "txtBookingCost"
        Me.txtBookingCost.Size = New System.Drawing.Size(145, 29)
        Me.txtBookingCost.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Check Out:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpBookingEndTime
        '
        Me.dtpBookingEndTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpBookingEndTime.Location = New System.Drawing.Point(126, 134)
        Me.dtpBookingEndTime.Name = "dtpBookingEndTime"
        Me.dtpBookingEndTime.ShowUpDown = True
        Me.dtpBookingEndTime.Size = New System.Drawing.Size(145, 29)
        Me.dtpBookingEndTime.TabIndex = 12
        '
        'dtpBookingEndDate
        '
        Me.dtpBookingEndDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingEndDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookingEndDate.Location = New System.Drawing.Point(126, 99)
        Me.dtpBookingEndDate.Name = "dtpBookingEndDate"
        Me.dtpBookingEndDate.Size = New System.Drawing.Size(145, 29)
        Me.dtpBookingEndDate.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Check In:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpBookingStartTime
        '
        Me.dtpBookingStartTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpBookingStartTime.Location = New System.Drawing.Point(126, 64)
        Me.dtpBookingStartTime.Name = "dtpBookingStartTime"
        Me.dtpBookingStartTime.ShowUpDown = True
        Me.dtpBookingStartTime.Size = New System.Drawing.Size(145, 29)
        Me.dtpBookingStartTime.TabIndex = 10
        '
        'dtpBookingStartDate
        '
        Me.dtpBookingStartDate.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingStartDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookingStartDate.Location = New System.Drawing.Point(126, 29)
        Me.dtpBookingStartDate.Name = "dtpBookingStartDate"
        Me.dtpBookingStartDate.Size = New System.Drawing.Size(145, 29)
        Me.dtpBookingStartDate.TabIndex = 9
        '
        'btnSearchBookingId
        '
        Me.btnSearchBookingId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBookingId.Location = New System.Drawing.Point(140, 347)
        Me.btnSearchBookingId.Name = "btnSearchBookingId"
        Me.btnSearchBookingId.Size = New System.Drawing.Size(105, 35)
        Me.btnSearchBookingId.TabIndex = 5
        Me.btnSearchBookingId.Text = "Search ID"
        Me.btnSearchBookingId.UseVisualStyleBackColor = True
        '
        'btnSearchBookingDate
        '
        Me.btnSearchBookingDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBookingDate.Location = New System.Drawing.Point(18, 347)
        Me.btnSearchBookingDate.Name = "btnSearchBookingDate"
        Me.btnSearchBookingDate.Size = New System.Drawing.Size(105, 35)
        Me.btnSearchBookingDate.TabIndex = 4
        Me.btnSearchBookingDate.Text = "Search Date"
        Me.btnSearchBookingDate.UseVisualStyleBackColor = True
        '
        'btnDeleteBooking
        '
        Me.btnDeleteBooking.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBooking.Location = New System.Drawing.Point(140, 395)
        Me.btnDeleteBooking.Name = "btnDeleteBooking"
        Me.btnDeleteBooking.Size = New System.Drawing.Size(105, 35)
        Me.btnDeleteBooking.TabIndex = 7
        Me.btnDeleteBooking.Text = "Delete Booking"
        Me.btnDeleteBooking.UseVisualStyleBackColor = True
        '
        'btnSaveBooking
        '
        Me.btnSaveBooking.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBooking.Location = New System.Drawing.Point(18, 395)
        Me.btnSaveBooking.Name = "btnSaveBooking"
        Me.btnSaveBooking.Size = New System.Drawing.Size(105, 35)
        Me.btnSaveBooking.TabIndex = 6
        Me.btnSaveBooking.Text = "Save Changes"
        Me.btnSaveBooking.UseVisualStyleBackColor = True
        '
        'txtBookingSearchId
        '
        Me.txtBookingSearchId.Location = New System.Drawing.Point(126, 277)
        Me.txtBookingSearchId.Name = "txtBookingSearchId"
        Me.txtBookingSearchId.Size = New System.Drawing.Size(119, 32)
        Me.txtBookingSearchId.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search ID"
        '
        'dtpBookingDate
        '
        Me.dtpBookingDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBookingDate.Location = New System.Drawing.Point(18, 240)
        Me.dtpBookingDate.Name = "dtpBookingDate"
        Me.dtpBookingDate.Size = New System.Drawing.Size(227, 25)
        Me.dtpBookingDate.TabIndex = 2
        '
        'calBookingDate
        '
        Me.calBookingDate.Location = New System.Drawing.Point(18, 63)
        Me.calBookingDate.MaxSelectionCount = 1
        Me.calBookingDate.Name = "calBookingDate"
        Me.calBookingDate.TabIndex = 1
        '
        'cboSelectBookingHouse
        '
        Me.cboSelectBookingHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectBookingHouse.FormattingEnabled = True
        Me.cboSelectBookingHouse.Items.AddRange(New Object() {""})
        Me.cboSelectBookingHouse.Location = New System.Drawing.Point(18, 21)
        Me.cboSelectBookingHouse.Name = "cboSelectBookingHouse"
        Me.cboSelectBookingHouse.Size = New System.Drawing.Size(227, 33)
        Me.cboSelectBookingHouse.TabIndex = 0
        '
        'tabGuestDetails
        '
        Me.tabGuestDetails.Controls.Add(Me.Label26)
        Me.tabGuestDetails.Controls.Add(Me.gboGuestDetails)
        Me.tabGuestDetails.Controls.Add(Me.btnSearchGuestId)
        Me.tabGuestDetails.Controls.Add(Me.btnSearchGuestDate)
        Me.tabGuestDetails.Controls.Add(Me.btnSaveGuest)
        Me.tabGuestDetails.Controls.Add(Me.txtGuestId)
        Me.tabGuestDetails.Controls.Add(Me.Label10)
        Me.tabGuestDetails.Controls.Add(Me.dtpGuestDate)
        Me.tabGuestDetails.Controls.Add(Me.calGuestDate)
        Me.tabGuestDetails.Controls.Add(Me.cboSelectGuestHouse)
        Me.tabGuestDetails.Location = New System.Drawing.Point(4, 34)
        Me.tabGuestDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.tabGuestDetails.Name = "tabGuestDetails"
        Me.tabGuestDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.tabGuestDetails.Size = New System.Drawing.Size(704, 501)
        Me.tabGuestDetails.TabIndex = 1
        Me.tabGuestDetails.Text = "Guests"
        Me.tabGuestDetails.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(31, 279)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 25)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "Search ID"
        '
        'gboGuestDetails
        '
        Me.gboGuestDetails.Controls.Add(Me.txtGuestMobile)
        Me.gboGuestDetails.Controls.Add(Me.Label3)
        Me.gboGuestDetails.Controls.Add(Me.txtGuestBookingId)
        Me.gboGuestDetails.Controls.Add(Me.Label38)
        Me.gboGuestDetails.Controls.Add(Me.txtGuestInformation)
        Me.gboGuestDetails.Controls.Add(Me.Label19)
        Me.gboGuestDetails.Controls.Add(Me.dtpCardExpiry)
        Me.gboGuestDetails.Controls.Add(Me.txtCardNumber)
        Me.gboGuestDetails.Controls.Add(Me.txtCardName)
        Me.gboGuestDetails.Controls.Add(Me.txtGuestSurname)
        Me.gboGuestDetails.Controls.Add(Me.Label17)
        Me.gboGuestDetails.Controls.Add(Me.txtGuestFirstName)
        Me.gboGuestDetails.Controls.Add(Me.Label11)
        Me.gboGuestDetails.Controls.Add(Me.Label14)
        Me.gboGuestDetails.Controls.Add(Me.txtCardCVV)
        Me.gboGuestDetails.Controls.Add(Me.Label15)
        Me.gboGuestDetails.Controls.Add(Me.Label16)
        Me.gboGuestDetails.Controls.Add(Me.Label18)
        Me.gboGuestDetails.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboGuestDetails.Location = New System.Drawing.Point(271, 21)
        Me.gboGuestDetails.Name = "gboGuestDetails"
        Me.gboGuestDetails.Size = New System.Drawing.Size(430, 458)
        Me.gboGuestDetails.TabIndex = 8
        Me.gboGuestDetails.TabStop = False
        Me.gboGuestDetails.Text = "Guest Details"
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestMobile.Location = New System.Drawing.Point(126, 134)
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.Size = New System.Drawing.Size(289, 29)
        Me.txtGuestMobile.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mobile"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGuestBookingId
        '
        Me.txtGuestBookingId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestBookingId.Location = New System.Drawing.Point(126, 29)
        Me.txtGuestBookingId.Name = "txtGuestBookingId"
        Me.txtGuestBookingId.ReadOnly = True
        Me.txtGuestBookingId.Size = New System.Drawing.Size(145, 29)
        Me.txtGuestBookingId.TabIndex = 9
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(39, 33)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(81, 20)
        Me.Label38.TabIndex = 23
        Me.Label38.Text = "Booking Id"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGuestInformation
        '
        Me.txtGuestInformation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInformation.Location = New System.Drawing.Point(126, 309)
        Me.txtGuestInformation.Multiline = True
        Me.txtGuestInformation.Name = "txtGuestInformation"
        Me.txtGuestInformation.Size = New System.Drawing.Size(289, 143)
        Me.txtGuestInformation.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 278)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Card Expiry"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpCardExpiry
        '
        Me.dtpCardExpiry.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCardExpiry.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCardExpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCardExpiry.Location = New System.Drawing.Point(126, 274)
        Me.dtpCardExpiry.Name = "dtpCardExpiry"
        Me.dtpCardExpiry.Size = New System.Drawing.Size(145, 29)
        Me.dtpCardExpiry.TabIndex = 16
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.Location = New System.Drawing.Point(126, 204)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(289, 29)
        Me.txtCardNumber.TabIndex = 14
        '
        'txtCardName
        '
        Me.txtCardName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardName.Location = New System.Drawing.Point(126, 169)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(289, 29)
        Me.txtCardName.TabIndex = 13
        '
        'txtGuestSurname
        '
        Me.txtGuestSurname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestSurname.Location = New System.Drawing.Point(126, 99)
        Me.txtGuestSurname.Name = "txtGuestSurname"
        Me.txtGuestSurname.Size = New System.Drawing.Size(145, 29)
        Me.txtGuestSurname.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(53, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 20)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Surname"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGuestFirstName
        '
        Me.txtGuestFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestFirstName.Location = New System.Drawing.Point(126, 64)
        Me.txtGuestFirstName.Name = "txtGuestFirstName"
        Me.txtGuestFirstName.Size = New System.Drawing.Size(145, 29)
        Me.txtGuestFirstName.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Information"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(84, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 20)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "CVV"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCardCVV
        '
        Me.txtCardCVV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardCVV.Location = New System.Drawing.Point(126, 239)
        Me.txtCardCVV.Name = "txtCardCVV"
        Me.txtCardCVV.Size = New System.Drawing.Size(145, 29)
        Me.txtCardCVV.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Name on Card"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Card Number"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(40, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearchGuestId
        '
        Me.btnSearchGuestId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchGuestId.Location = New System.Drawing.Point(140, 395)
        Me.btnSearchGuestId.Name = "btnSearchGuestId"
        Me.btnSearchGuestId.Size = New System.Drawing.Size(105, 35)
        Me.btnSearchGuestId.TabIndex = 5
        Me.btnSearchGuestId.Text = "Search ID"
        Me.btnSearchGuestId.UseVisualStyleBackColor = True
        '
        'btnSearchGuestDate
        '
        Me.btnSearchGuestDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchGuestDate.Location = New System.Drawing.Point(18, 395)
        Me.btnSearchGuestDate.Name = "btnSearchGuestDate"
        Me.btnSearchGuestDate.Size = New System.Drawing.Size(105, 35)
        Me.btnSearchGuestDate.TabIndex = 4
        Me.btnSearchGuestDate.Text = "Search Date"
        Me.btnSearchGuestDate.UseVisualStyleBackColor = True
        '
        'btnSaveGuest
        '
        Me.btnSaveGuest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGuest.Location = New System.Drawing.Point(18, 444)
        Me.btnSaveGuest.Name = "btnSaveGuest"
        Me.btnSaveGuest.Size = New System.Drawing.Size(105, 35)
        Me.btnSaveGuest.TabIndex = 6
        Me.btnSaveGuest.Text = "Save Changes"
        Me.btnSaveGuest.UseVisualStyleBackColor = True
        '
        'txtGuestId
        '
        Me.txtGuestId.Location = New System.Drawing.Point(126, 277)
        Me.txtGuestId.Name = "txtGuestId"
        Me.txtGuestId.Size = New System.Drawing.Size(119, 32)
        Me.txtGuestId.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(90, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 25)
        Me.Label10.TabIndex = 12
        '
        'dtpGuestDate
        '
        Me.dtpGuestDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGuestDate.Location = New System.Drawing.Point(18, 240)
        Me.dtpGuestDate.Name = "dtpGuestDate"
        Me.dtpGuestDate.Size = New System.Drawing.Size(227, 25)
        Me.dtpGuestDate.TabIndex = 2
        '
        'calGuestDate
        '
        Me.calGuestDate.Location = New System.Drawing.Point(18, 63)
        Me.calGuestDate.Name = "calGuestDate"
        Me.calGuestDate.TabIndex = 1
        '
        'cboSelectGuestHouse
        '
        Me.cboSelectGuestHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectGuestHouse.FormattingEnabled = True
        Me.cboSelectGuestHouse.Location = New System.Drawing.Point(18, 21)
        Me.cboSelectGuestHouse.Name = "cboSelectGuestHouse"
        Me.cboSelectGuestHouse.Size = New System.Drawing.Size(227, 33)
        Me.cboSelectGuestHouse.TabIndex = 0
        '
        'tabHouseDetails
        '
        Me.tabHouseDetails.AccessibleName = "tabHouseDetails"
        Me.tabHouseDetails.Controls.Add(Me.btnAddHouse)
        Me.tabHouseDetails.Controls.Add(Me.gboHouseDetails)
        Me.tabHouseDetails.Controls.Add(Me.btnDeleteHouse)
        Me.tabHouseDetails.Controls.Add(Me.btnSaveHouse)
        Me.tabHouseDetails.Controls.Add(Me.Label25)
        Me.tabHouseDetails.Controls.Add(Me.cboSelectHouseHouse)
        Me.tabHouseDetails.Location = New System.Drawing.Point(4, 34)
        Me.tabHouseDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.tabHouseDetails.Name = "tabHouseDetails"
        Me.tabHouseDetails.Size = New System.Drawing.Size(704, 501)
        Me.tabHouseDetails.TabIndex = 2
        Me.tabHouseDetails.Text = "Houses"
        Me.tabHouseDetails.UseVisualStyleBackColor = True
        '
        'btnAddHouse
        '
        Me.btnAddHouse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHouse.Location = New System.Drawing.Point(18, 444)
        Me.btnAddHouse.Name = "btnAddHouse"
        Me.btnAddHouse.Size = New System.Drawing.Size(105, 35)
        Me.btnAddHouse.TabIndex = 1
        Me.btnAddHouse.Text = "Save New House"
        Me.btnAddHouse.UseVisualStyleBackColor = True
        '
        'gboHouseDetails
        '
        Me.gboHouseDetails.Controls.Add(Me.txtHouseCity)
        Me.gboHouseDetails.Controls.Add(Me.txtHouseAddress)
        Me.gboHouseDetails.Controls.Add(Me.Label39)
        Me.gboHouseDetails.Controls.Add(Me.btnWeekendRateFormat)
        Me.gboHouseDetails.Controls.Add(Me.btnWeekdayRateFormat)
        Me.gboHouseDetails.Controls.Add(Me.txtHouseInformation)
        Me.gboHouseDetails.Controls.Add(Me.Label23)
        Me.gboHouseDetails.Controls.Add(Me.txtHousePIN)
        Me.gboHouseDetails.Controls.Add(Me.Label12)
        Me.gboHouseDetails.Controls.Add(Me.txtHouseWeekendRate)
        Me.gboHouseDetails.Controls.Add(Me.Label13)
        Me.gboHouseDetails.Controls.Add(Me.txtHousePostCode)
        Me.gboHouseDetails.Controls.Add(Me.txtHouseName)
        Me.gboHouseDetails.Controls.Add(Me.Label20)
        Me.gboHouseDetails.Controls.Add(Me.Label21)
        Me.gboHouseDetails.Controls.Add(Me.txtHouseWeekdayRate)
        Me.gboHouseDetails.Controls.Add(Me.Label22)
        Me.gboHouseDetails.Controls.Add(Me.Label24)
        Me.gboHouseDetails.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboHouseDetails.Location = New System.Drawing.Point(271, 21)
        Me.gboHouseDetails.Name = "gboHouseDetails"
        Me.gboHouseDetails.Size = New System.Drawing.Size(430, 458)
        Me.gboHouseDetails.TabIndex = 4
        Me.gboHouseDetails.TabStop = False
        Me.gboHouseDetails.Text = "House Details"
        '
        'txtHouseCity
        '
        Me.txtHouseCity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseCity.Location = New System.Drawing.Point(126, 99)
        Me.txtHouseCity.Name = "txtHouseCity"
        Me.txtHouseCity.Size = New System.Drawing.Size(145, 29)
        Me.txtHouseCity.TabIndex = 7
        '
        'txtHouseAddress
        '
        Me.txtHouseAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseAddress.Location = New System.Drawing.Point(126, 64)
        Me.txtHouseAddress.Name = "txtHouseAddress"
        Me.txtHouseAddress.Size = New System.Drawing.Size(289, 29)
        Me.txtHouseAddress.TabIndex = 6
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(86, 103)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(34, 20)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "City"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnWeekendRateFormat
        '
        Me.btnWeekendRateFormat.Location = New System.Drawing.Point(277, 204)
        Me.btnWeekendRateFormat.Name = "btnWeekendRateFormat"
        Me.btnWeekendRateFormat.Size = New System.Drawing.Size(29, 29)
        Me.btnWeekendRateFormat.TabIndex = 12
        Me.btnWeekendRateFormat.Text = "$"
        Me.btnWeekendRateFormat.UseVisualStyleBackColor = True
        '
        'btnWeekdayRateFormat
        '
        Me.btnWeekdayRateFormat.Location = New System.Drawing.Point(277, 169)
        Me.btnWeekdayRateFormat.Name = "btnWeekdayRateFormat"
        Me.btnWeekdayRateFormat.Size = New System.Drawing.Size(29, 29)
        Me.btnWeekdayRateFormat.TabIndex = 10
        Me.btnWeekdayRateFormat.Text = "$"
        Me.btnWeekdayRateFormat.UseVisualStyleBackColor = True
        '
        'txtHouseInformation
        '
        Me.txtHouseInformation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseInformation.Location = New System.Drawing.Point(126, 274)
        Me.txtHouseInformation.Multiline = True
        Me.txtHouseInformation.Name = "txtHouseInformation"
        Me.txtHouseInformation.Size = New System.Drawing.Size(289, 146)
        Me.txtHouseInformation.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(33, 278)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 20)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Information"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHousePIN
        '
        Me.txtHousePIN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousePIN.Location = New System.Drawing.Point(126, 239)
        Me.txtHousePIN.Name = "txtHousePIN"
        Me.txtHousePIN.Size = New System.Drawing.Size(145, 29)
        Me.txtHousePIN.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Weekend Rate"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHouseWeekendRate
        '
        Me.txtHouseWeekendRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseWeekendRate.Location = New System.Drawing.Point(126, 204)
        Me.txtHouseWeekendRate.Name = "txtHouseWeekendRate"
        Me.txtHouseWeekendRate.Size = New System.Drawing.Size(145, 29)
        Me.txtHouseWeekendRate.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(58, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Address"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHousePostCode
        '
        Me.txtHousePostCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHousePostCode.Location = New System.Drawing.Point(126, 134)
        Me.txtHousePostCode.Name = "txtHousePostCode"
        Me.txtHousePostCode.Size = New System.Drawing.Size(145, 29)
        Me.txtHousePostCode.TabIndex = 8
        '
        'txtHouseName
        '
        Me.txtHouseName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseName.Location = New System.Drawing.Point(126, 29)
        Me.txtHouseName.Name = "txtHouseName"
        Me.txtHouseName.Size = New System.Drawing.Size(289, 29)
        Me.txtHouseName.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(60, 243)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 20)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Key PIN"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 20)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Weekday Rate"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHouseWeekdayRate
        '
        Me.txtHouseWeekdayRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseWeekdayRate.Location = New System.Drawing.Point(126, 169)
        Me.txtHouseWeekdayRate.Name = "txtHouseWeekdayRate"
        Me.txtHouseWeekdayRate.Size = New System.Drawing.Size(145, 29)
        Me.txtHouseWeekdayRate.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(45, 137)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 20)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Post Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(71, 33)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 20)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Name"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeleteHouse
        '
        Me.btnDeleteHouse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteHouse.Location = New System.Drawing.Point(140, 395)
        Me.btnDeleteHouse.Name = "btnDeleteHouse"
        Me.btnDeleteHouse.Size = New System.Drawing.Size(105, 35)
        Me.btnDeleteHouse.TabIndex = 3
        Me.btnDeleteHouse.Text = "Delete House"
        Me.btnDeleteHouse.UseVisualStyleBackColor = True
        '
        'btnSaveHouse
        '
        Me.btnSaveHouse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveHouse.Location = New System.Drawing.Point(18, 395)
        Me.btnSaveHouse.Name = "btnSaveHouse"
        Me.btnSaveHouse.Size = New System.Drawing.Size(105, 35)
        Me.btnSaveHouse.TabIndex = 2
        Me.btnSaveHouse.Text = "Save Changes"
        Me.btnSaveHouse.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(90, 280)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(0, 25)
        Me.Label25.TabIndex = 23
        '
        'cboSelectHouseHouse
        '
        Me.cboSelectHouseHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectHouseHouse.FormattingEnabled = True
        Me.cboSelectHouseHouse.Location = New System.Drawing.Point(18, 21)
        Me.cboSelectHouseHouse.Name = "cboSelectHouseHouse"
        Me.cboSelectHouseHouse.Size = New System.Drawing.Size(227, 33)
        Me.cboSelectHouseHouse.TabIndex = 0
        '
        'tabStaffDetails
        '
        Me.tabStaffDetails.AccessibleName = "tabStaffDetails"
        Me.tabStaffDetails.Controls.Add(Me.btnAddStaff)
        Me.tabStaffDetails.Controls.Add(Me.gboStaffDetails)
        Me.tabStaffDetails.Controls.Add(Me.btnDeleteStaff)
        Me.tabStaffDetails.Controls.Add(Me.btnSaveStaff)
        Me.tabStaffDetails.Controls.Add(Me.cboSelectStaff)
        Me.tabStaffDetails.Controls.Add(Me.txtStaffImage)
        Me.tabStaffDetails.Controls.Add(Me.btnImageUpload)
        Me.tabStaffDetails.Controls.Add(Me.pboStaffImage)
        Me.tabStaffDetails.Location = New System.Drawing.Point(4, 34)
        Me.tabStaffDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.tabStaffDetails.Name = "tabStaffDetails"
        Me.tabStaffDetails.Size = New System.Drawing.Size(704, 501)
        Me.tabStaffDetails.TabIndex = 3
        Me.tabStaffDetails.Text = "Staff"
        Me.tabStaffDetails.UseVisualStyleBackColor = True
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.Location = New System.Drawing.Point(18, 444)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(105, 35)
        Me.btnAddStaff.TabIndex = 3
        Me.btnAddStaff.Text = "Save New Staff"
        Me.btnAddStaff.UseVisualStyleBackColor = True
        '
        'gboStaffDetails
        '
        Me.gboStaffDetails.Controls.Add(Me.txtStaffCity)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffAddress)
        Me.gboStaffDetails.Controls.Add(Me.btnStaffWageFormat)
        Me.gboStaffDetails.Controls.Add(Me.Label37)
        Me.gboStaffDetails.Controls.Add(Me.rbtStaffStatusFalse)
        Me.gboStaffDetails.Controls.Add(Me.rbtStaffStatusTrue)
        Me.gboStaffDetails.Controls.Add(Me.Label36)
        Me.gboStaffDetails.Controls.Add(Me.Label33)
        Me.gboStaffDetails.Controls.Add(Me.cboStaffRole)
        Me.gboStaffDetails.Controls.Add(Me.Label27)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffPassword)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffFirstName)
        Me.gboStaffDetails.Controls.Add(Me.Label34)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffSurname)
        Me.gboStaffDetails.Controls.Add(Me.Label35)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffWage)
        Me.gboStaffDetails.Controls.Add(Me.Label28)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffMobile)
        Me.gboStaffDetails.Controls.Add(Me.Label29)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffPostcode)
        Me.gboStaffDetails.Controls.Add(Me.Label30)
        Me.gboStaffDetails.Controls.Add(Me.Label31)
        Me.gboStaffDetails.Controls.Add(Me.txtStaffEmail)
        Me.gboStaffDetails.Controls.Add(Me.Label32)
        Me.gboStaffDetails.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboStaffDetails.Location = New System.Drawing.Point(271, 21)
        Me.gboStaffDetails.Name = "gboStaffDetails"
        Me.gboStaffDetails.Size = New System.Drawing.Size(430, 458)
        Me.gboStaffDetails.TabIndex = 6
        Me.gboStaffDetails.TabStop = False
        Me.gboStaffDetails.Text = "Staff Details"
        '
        'txtStaffCity
        '
        Me.txtStaffCity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffCity.Location = New System.Drawing.Point(126, 133)
        Me.txtStaffCity.Name = "txtStaffCity"
        Me.txtStaffCity.Size = New System.Drawing.Size(145, 29)
        Me.txtStaffCity.TabIndex = 10
        '
        'txtStaffAddress
        '
        Me.txtStaffAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffAddress.Location = New System.Drawing.Point(126, 98)
        Me.txtStaffAddress.Name = "txtStaffAddress"
        Me.txtStaffAddress.Size = New System.Drawing.Size(289, 29)
        Me.txtStaffAddress.TabIndex = 9
        '
        'btnStaffWageFormat
        '
        Me.btnStaffWageFormat.Location = New System.Drawing.Point(277, 346)
        Me.btnStaffWageFormat.Name = "btnStaffWageFormat"
        Me.btnStaffWageFormat.Size = New System.Drawing.Size(29, 29)
        Me.btnStaffWageFormat.TabIndex = 17
        Me.btnStaffWageFormat.Text = "$"
        Me.btnStaffWageFormat.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(86, 137)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(34, 20)
        Me.Label37.TabIndex = 42
        Me.Label37.Text = "City"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbtStaffStatusFalse
        '
        Me.rbtStaffStatusFalse.AutoSize = True
        Me.rbtStaffStatusFalse.Location = New System.Drawing.Point(216, 384)
        Me.rbtStaffStatusFalse.Name = "rbtStaffStatusFalse"
        Me.rbtStaffStatusFalse.Size = New System.Drawing.Size(59, 24)
        Me.rbtStaffStatusFalse.TabIndex = 19
        Me.rbtStaffStatusFalse.Text = "False"
        Me.rbtStaffStatusFalse.UseVisualStyleBackColor = True
        '
        'rbtStaffStatusTrue
        '
        Me.rbtStaffStatusTrue.AutoSize = True
        Me.rbtStaffStatusTrue.Checked = True
        Me.rbtStaffStatusTrue.Location = New System.Drawing.Point(126, 384)
        Me.rbtStaffStatusTrue.Name = "rbtStaffStatusTrue"
        Me.rbtStaffStatusTrue.Size = New System.Drawing.Size(55, 24)
        Me.rbtStaffStatusTrue.TabIndex = 18
        Me.rbtStaffStatusTrue.TabStop = True
        Me.rbtStaffStatusTrue.Text = "True"
        Me.rbtStaffStatusTrue.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(71, 384)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(49, 20)
        Me.Label36.TabIndex = 38
        Me.Label36.Text = "Status"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(81, 314)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 20)
        Me.Label33.TabIndex = 37
        Me.Label33.Text = "Role"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboStaffRole
        '
        Me.cboStaffRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffRole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffRole.FormattingEnabled = True
        Me.cboStaffRole.Items.AddRange(New Object() {"Staff", "Management"})
        Me.cboStaffRole.Location = New System.Drawing.Point(126, 310)
        Me.cboStaffRole.Name = "cboStaffRole"
        Me.cboStaffRole.Size = New System.Drawing.Size(289, 29)
        Me.cboStaffRole.TabIndex = 15
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(50, 278)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 20)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "Password"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaffPassword
        '
        Me.txtStaffPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPassword.Location = New System.Drawing.Point(126, 274)
        Me.txtStaffPassword.Name = "txtStaffPassword"
        Me.txtStaffPassword.Size = New System.Drawing.Size(289, 29)
        Me.txtStaffPassword.TabIndex = 14
        '
        'txtStaffFirstName
        '
        Me.txtStaffFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffFirstName.Location = New System.Drawing.Point(126, 29)
        Me.txtStaffFirstName.Name = "txtStaffFirstName"
        Me.txtStaffFirstName.Size = New System.Drawing.Size(145, 29)
        Me.txtStaffFirstName.TabIndex = 7
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(53, 68)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 20)
        Me.Label34.TabIndex = 32
        Me.Label34.Text = "Surname"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaffSurname
        '
        Me.txtStaffSurname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffSurname.Location = New System.Drawing.Point(126, 64)
        Me.txtStaffSurname.Name = "txtStaffSurname"
        Me.txtStaffSurname.Size = New System.Drawing.Size(145, 29)
        Me.txtStaffSurname.TabIndex = 8
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(40, 33)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 20)
        Me.Label35.TabIndex = 30
        Me.Label35.Text = "First Name"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaffWage
        '
        Me.txtStaffWage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffWage.Location = New System.Drawing.Point(126, 346)
        Me.txtStaffWage.Name = "txtStaffWage"
        Me.txtStaffWage.Size = New System.Drawing.Size(145, 29)
        Me.txtStaffWage.TabIndex = 16
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(64, 242)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 20)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Mobile"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaffMobile
        '
        Me.txtStaffMobile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffMobile.Location = New System.Drawing.Point(126, 238)
        Me.txtStaffMobile.Name = "txtStaffMobile"
        Me.txtStaffMobile.Size = New System.Drawing.Size(289, 29)
        Me.txtStaffMobile.TabIndex = 13
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(58, 102)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(62, 20)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Address"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaffPostcode
        '
        Me.txtStaffPostcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPostcode.Location = New System.Drawing.Point(126, 168)
        Me.txtStaffPostcode.Name = "txtStaffPostcode"
        Me.txtStaffPostcode.Size = New System.Drawing.Size(145, 29)
        Me.txtStaffPostcode.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(73, 350)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 20)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "Wage"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(74, 207)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(46, 20)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffEmail.Location = New System.Drawing.Point(126, 203)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(289, 29)
        Me.txtStaffEmail.TabIndex = 12
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(51, 172)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 20)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Postcode"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStaff.Location = New System.Drawing.Point(140, 395)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(105, 35)
        Me.btnDeleteStaff.TabIndex = 5
        Me.btnDeleteStaff.Text = "Delete Staff"
        Me.btnDeleteStaff.UseVisualStyleBackColor = True
        '
        'btnSaveStaff
        '
        Me.btnSaveStaff.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveStaff.Location = New System.Drawing.Point(18, 395)
        Me.btnSaveStaff.Name = "btnSaveStaff"
        Me.btnSaveStaff.Size = New System.Drawing.Size(105, 35)
        Me.btnSaveStaff.TabIndex = 4
        Me.btnSaveStaff.Text = "Save Changes"
        Me.btnSaveStaff.UseVisualStyleBackColor = True
        '
        'cboSelectStaff
        '
        Me.cboSelectStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectStaff.FormattingEnabled = True
        Me.cboSelectStaff.Location = New System.Drawing.Point(18, 21)
        Me.cboSelectStaff.Name = "cboSelectStaff"
        Me.cboSelectStaff.Size = New System.Drawing.Size(227, 33)
        Me.cboSelectStaff.TabIndex = 0
        '
        'txtStaffImage
        '
        Me.txtStaffImage.Location = New System.Drawing.Point(18, 300)
        Me.txtStaffImage.Name = "txtStaffImage"
        Me.txtStaffImage.ReadOnly = True
        Me.txtStaffImage.Size = New System.Drawing.Size(138, 32)
        Me.txtStaffImage.TabIndex = 1
        '
        'btnImageUpload
        '
        Me.btnImageUpload.Location = New System.Drawing.Point(162, 298)
        Me.btnImageUpload.Name = "btnImageUpload"
        Me.btnImageUpload.Size = New System.Drawing.Size(83, 36)
        Me.btnImageUpload.TabIndex = 2
        Me.btnImageUpload.Text = "Upload"
        Me.btnImageUpload.UseVisualStyleBackColor = True
        '
        'pboStaffImage
        '
        Me.pboStaffImage.Location = New System.Drawing.Point(18, 63)
        Me.pboStaffImage.Name = "pboStaffImage"
        Me.pboStaffImage.Size = New System.Drawing.Size(227, 227)
        Me.pboStaffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboStaffImage.TabIndex = 12
        Me.pboStaffImage.TabStop = False
        '
        'PrintDocument
        '
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'frmManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(735, 561)
        Me.Controls.Add(Me.tbcManagementControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmManagement"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book.io Management"
        Me.tbcManagementControls.ResumeLayout(False)
        Me.tabBookingDetails.ResumeLayout(False)
        Me.tabBookingDetails.PerformLayout()
        Me.gboBookingDetails.ResumeLayout(False)
        Me.gboBookingDetails.PerformLayout()
        Me.tabGuestDetails.ResumeLayout(False)
        Me.tabGuestDetails.PerformLayout()
        Me.gboGuestDetails.ResumeLayout(False)
        Me.gboGuestDetails.PerformLayout()
        Me.tabHouseDetails.ResumeLayout(False)
        Me.tabHouseDetails.PerformLayout()
        Me.gboHouseDetails.ResumeLayout(False)
        Me.gboHouseDetails.PerformLayout()
        Me.tabStaffDetails.ResumeLayout(False)
        Me.tabStaffDetails.PerformLayout()
        Me.gboStaffDetails.ResumeLayout(False)
        Me.gboStaffDetails.PerformLayout()
        CType(Me.pboStaffImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcManagementControls As TabControl
    Friend WithEvents tabBookingDetails As TabPage
    Friend WithEvents tabGuestDetails As TabPage
    Friend WithEvents tabHouseDetails As TabPage
    Friend WithEvents tabStaffDetails As TabPage
    Friend WithEvents cboSelectBookingHouse As ComboBox
    Friend WithEvents calBookingDate As MonthCalendar
    Friend WithEvents txtBookingSearchId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents btnSearchBookingId As Button
    Friend WithEvents btnSearchBookingDate As Button
    Friend WithEvents btnDeleteBooking As Button
    Friend WithEvents btnSaveBooking As Button
    Friend WithEvents gboBookingDetails As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpBookingStartTime As DateTimePicker
    Friend WithEvents dtpBookingStartDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpBookingEndTime As DateTimePicker
    Friend WithEvents dtpBookingEndDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cboBookingHouse As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBookingId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBookingCost As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSearchGuestId As Button
    Friend WithEvents btnSearchGuestDate As Button
    Friend WithEvents btnSaveGuest As Button
    Friend WithEvents txtGuestId As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpGuestDate As DateTimePicker
    Friend WithEvents calGuestDate As MonthCalendar
    Friend WithEvents cboSelectGuestHouse As ComboBox
    Friend WithEvents gboGuestDetails As GroupBox
    Friend WithEvents txtGuestFirstName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCardCVV As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtGuestSurname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dtpCardExpiry As DateTimePicker
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents gboHouseDetails As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtHousePIN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHouseWeekendRate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHousePostCode As TextBox
    Friend WithEvents txtHouseName As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtHouseWeekdayRate As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnDeleteHouse As Button
    Friend WithEvents btnSaveHouse As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents txtStaffImage As TextBox
    Friend WithEvents btnImageUpload As Button
    Friend WithEvents pboStaffImage As PictureBox
    Friend WithEvents txtBookingInformation As TextBox
    Friend WithEvents txtGuestInformation As TextBox
    Friend WithEvents txtHouseInformation As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents cboSelectHouseHouse As ComboBox
    Friend WithEvents gboStaffDetails As GroupBox
    Friend WithEvents txtStaffFirstName As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtStaffSurname As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtStaffWage As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtStaffMobile As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtStaffPostcode As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtStaffEmail As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents btnDeleteStaff As Button
    Friend WithEvents btnSaveStaff As Button
    Friend WithEvents cboSelectStaff As ComboBox
    Friend WithEvents rbtStaffStatusFalse As RadioButton
    Friend WithEvents rbtStaffStatusTrue As RadioButton
    Friend WithEvents Label36 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents cboStaffRole As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtStaffPassword As TextBox
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents btnAddHouse As Button
    Friend WithEvents btnBookingCostFormat As Button
    Friend WithEvents btnWeekendRateFormat As Button
    Friend WithEvents btnWeekdayRateFormat As Button
    Friend WithEvents btnStaffWageFormat As Button
    Friend WithEvents btnAddBooking As Button
    Friend WithEvents txtGuestBookingId As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents btnPrintBooking As Button
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents txtHouseAddress As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtStaffAddress As TextBox
    Friend WithEvents txtHouseCity As TextBox
    Friend WithEvents txtStaffCity As TextBox
    Friend WithEvents txtGuestMobile As TextBox
    Friend WithEvents Label3 As Label
End Class
