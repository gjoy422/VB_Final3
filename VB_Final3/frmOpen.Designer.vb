<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpen))
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblNew2 = New System.Windows.Forms.Label()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.chkClassical = New System.Windows.Forms.CheckBox()
        Me.chkAntiquities = New System.Windows.Forms.CheckBox()
        Me.monCal = New System.Windows.Forms.MonthCalendar()
        Me.grpMessage = New System.Windows.Forms.GroupBox()
        Me.radPromotions = New System.Windows.Forms.RadioButton()
        Me.radPersonal = New System.Windows.Forms.RadioButton()
        Me.radNatural = New System.Windows.Forms.RadioButton()
        Me.lblNatural = New System.Windows.Forms.Label()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPersonal = New System.Windows.Forms.Label()
        Me.lblPromotions = New System.Windows.Forms.Label()
        Me.chkUnavailable = New System.Windows.Forms.CheckBox()
        Me.chkNatural = New System.Windows.Forms.CheckBox()
        Me.chkGift = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grpPortal = New System.Windows.Forms.GroupBox()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.grpMessage.SuspendLayout()
        Me.grpPortal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(22, 23)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(0, 15)
        Me.lblNew.TabIndex = 14
        '
        'lblNew2
        '
        Me.lblNew2.AutoSize = True
        Me.lblNew2.Location = New System.Drawing.Point(28, 23)
        Me.lblNew2.Name = "lblNew2"
        Me.lblNew2.Size = New System.Drawing.Size(0, 13)
        Me.lblNew2.TabIndex = 15
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(6, 53)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(195, 21)
        Me.chkAll.TabIndex = 16
        Me.chkAll.Text = "Available: All Floors"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'chkClassical
        '
        Me.chkClassical.AutoSize = True
        Me.chkClassical.Location = New System.Drawing.Point(6, 76)
        Me.chkClassical.Name = "chkClassical"
        Me.chkClassical.Size = New System.Drawing.Size(139, 21)
        Me.chkClassical.TabIndex = 17
        Me.chkClassical.Text = "Classical Wing"
        Me.chkClassical.UseVisualStyleBackColor = True
        '
        'chkAntiquities
        '
        Me.chkAntiquities.AutoSize = True
        Me.chkAntiquities.Location = New System.Drawing.Point(6, 144)
        Me.chkAntiquities.Name = "chkAntiquities"
        Me.chkAntiquities.Size = New System.Drawing.Size(179, 21)
        Me.chkAntiquities.TabIndex = 18
        Me.chkAntiquities.Text = "Antiquities Exhibit"
        Me.chkAntiquities.UseVisualStyleBackColor = True
        '
        'monCal
        '
        Me.monCal.Location = New System.Drawing.Point(574, -6)
        Me.monCal.Name = "monCal"
        Me.monCal.TabIndex = 20
        '
        'grpMessage
        '
        Me.grpMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpMessage.Controls.Add(Me.radPromotions)
        Me.grpMessage.Controls.Add(Me.radPersonal)
        Me.grpMessage.Controls.Add(Me.radNatural)
        Me.grpMessage.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMessage.Location = New System.Drawing.Point(9, 48)
        Me.grpMessage.Name = "grpMessage"
        Me.grpMessage.Size = New System.Drawing.Size(206, 130)
        Me.grpMessage.TabIndex = 25
        Me.grpMessage.TabStop = False
        Me.grpMessage.Text = "Messages"
        '
        'radPromotions
        '
        Me.radPromotions.AutoSize = True
        Me.radPromotions.Location = New System.Drawing.Point(11, 60)
        Me.radPromotions.Name = "radPromotions"
        Me.radPromotions.Size = New System.Drawing.Size(140, 29)
        Me.radPromotions.TabIndex = 2
        Me.radPromotions.TabStop = True
        Me.radPromotions.Text = "Promotions"
        Me.radPromotions.UseVisualStyleBackColor = True
        '
        'radPersonal
        '
        Me.radPersonal.AutoSize = True
        Me.radPersonal.Location = New System.Drawing.Point(11, 95)
        Me.radPersonal.Name = "radPersonal"
        Me.radPersonal.Size = New System.Drawing.Size(118, 29)
        Me.radPersonal.TabIndex = 1
        Me.radPersonal.TabStop = True
        Me.radPersonal.Text = "Personal"
        Me.radPersonal.UseVisualStyleBackColor = True
        '
        'radNatural
        '
        Me.radNatural.AutoSize = True
        Me.radNatural.Location = New System.Drawing.Point(11, 32)
        Me.radNatural.Name = "radNatural"
        Me.radNatural.Size = New System.Drawing.Size(195, 29)
        Me.radNatural.TabIndex = 0
        Me.radNatural.TabStop = True
        Me.radNatural.Text = "Natural History"
        Me.radNatural.UseVisualStyleBackColor = True
        '
        'lblNatural
        '
        Me.lblNatural.AutoSize = True
        Me.lblNatural.BackColor = System.Drawing.Color.Green
        Me.lblNatural.Font = New System.Drawing.Font("Orator Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNatural.Location = New System.Drawing.Point(221, 4)
        Me.lblNatural.Name = "lblNatural"
        Me.lblNatural.Size = New System.Drawing.Size(580, 420)
        Me.lblNatural.TabIndex = 28
        Me.lblNatural.Text = resources.GetString("lblNatural.Text")
        Me.lblNatural.Visible = False
        '
        'RichTextBox
        '
        Me.RichTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RichTextBox.Font = New System.Drawing.Font("Orator Std", 14.1!)
        Me.RichTextBox.Location = New System.Drawing.Point(249, 4)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(223, 201)
        Me.RichTextBox.TabIndex = 26
        Me.RichTextBox.Text = "Memos" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "11/11/19 11:31 a.m" & Global.Microsoft.VisualBasic.ChrW(10) & "Copier on 2nd floor jammed" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "11/11/19 11: 42 a.m." & Global.Microsoft.VisualBasic.ChrW(10) & "Amanda" &
    " wants reports by 3 today" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "11/11/19 12: 36 p.m" & Global.Microsoft.VisualBasic.ChrW(10) & "Cookies in lobby!!" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(9, 184)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 29
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(9, 213)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'lblPersonal
        '
        Me.lblPersonal.AutoSize = True
        Me.lblPersonal.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblPersonal.Font = New System.Drawing.Font("Orator Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonal.Location = New System.Drawing.Point(461, 4)
        Me.lblPersonal.Name = "lblPersonal"
        Me.lblPersonal.Size = New System.Drawing.Size(340, 105)
        Me.lblPersonal.TabIndex = 31
        Me.lblPersonal.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lunch today after the meeting????" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emma"
        Me.lblPersonal.Visible = False
        '
        'lblPromotions
        '
        Me.lblPromotions.AutoSize = True
        Me.lblPromotions.BackColor = System.Drawing.Color.Firebrick
        Me.lblPromotions.Font = New System.Drawing.Font("Orator Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromotions.Location = New System.Drawing.Point(471, 4)
        Me.lblPromotions.Name = "lblPromotions"
        Me.lblPromotions.Size = New System.Drawing.Size(330, 168)
        Me.lblPromotions.TabIndex = 32
        Me.lblPromotions.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OLD NAVY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NEW Markdowns. Ready, GO!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Low prices on hundres of finds!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Ar" &
    "rivals!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Women/Men Shoes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dresses"
        Me.lblPromotions.Visible = False
        '
        'chkUnavailable
        '
        Me.chkUnavailable.AutoSize = True
        Me.chkUnavailable.Location = New System.Drawing.Point(6, 26)
        Me.chkUnavailable.Name = "chkUnavailable"
        Me.chkUnavailable.Size = New System.Drawing.Size(115, 21)
        Me.chkUnavailable.TabIndex = 33
        Me.chkUnavailable.Text = "Unavailable"
        Me.chkUnavailable.UseVisualStyleBackColor = True
        '
        'chkNatural
        '
        Me.chkNatural.AutoSize = True
        Me.chkNatural.Font = New System.Drawing.Font("Orator Std", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNatural.Location = New System.Drawing.Point(6, 123)
        Me.chkNatural.Name = "chkNatural"
        Me.chkNatural.Size = New System.Drawing.Size(147, 21)
        Me.chkNatural.TabIndex = 34
        Me.chkNatural.Text = "Natural History"
        Me.chkNatural.UseVisualStyleBackColor = True
        '
        'chkGift
        '
        Me.chkGift.AutoSize = True
        Me.chkGift.Location = New System.Drawing.Point(6, 103)
        Me.chkGift.Name = "chkGift"
        Me.chkGift.Size = New System.Drawing.Size(99, 21)
        Me.chkGift.TabIndex = 35
        Me.chkGift.Text = "Gift Shop"
        Me.chkGift.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(216, 76)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 34)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'grpPortal
        '
        Me.grpPortal.Controls.Add(Me.btnOut)
        Me.grpPortal.Controls.Add(Me.lblEmployee)
        Me.grpPortal.Controls.Add(Me.chkUnavailable)
        Me.grpPortal.Controls.Add(Me.chkAll)
        Me.grpPortal.Controls.Add(Me.chkClassical)
        Me.grpPortal.Controls.Add(Me.btnUpdate)
        Me.grpPortal.Controls.Add(Me.chkAntiquities)
        Me.grpPortal.Controls.Add(Me.chkGift)
        Me.grpPortal.Controls.Add(Me.chkNatural)
        Me.grpPortal.Font = New System.Drawing.Font("Orator Std", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPortal.Location = New System.Drawing.Point(9, 276)
        Me.grpPortal.Name = "grpPortal"
        Me.grpPortal.Size = New System.Drawing.Size(792, 171)
        Me.grpPortal.TabIndex = 37
        Me.grpPortal.TabStop = False
        Me.grpPortal.Text = "Employee Portal: "
        '
        'btnOut
        '
        Me.btnOut.Location = New System.Drawing.Point(216, 116)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(113, 34)
        Me.btnOut.TabIndex = 37
        Me.btnOut.Tag = ""
        Me.btnOut.Text = "Sign Out"
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Location = New System.Drawing.Point(423, 49)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(8, 85)
        Me.lblEmployee.TabIndex = 0
        Me.lblEmployee.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpPortal)
        Me.Controls.Add(Me.lblNatural)
        Me.Controls.Add(Me.lblPromotions)
        Me.Controls.Add(Me.lblPersonal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.grpMessage)
        Me.Controls.Add(Me.monCal)
        Me.Controls.Add(Me.lblNew2)
        Me.Controls.Add(Me.lblNew)
        Me.DoubleBuffered = True
        Me.Name = "frmOpen"
        Me.Text = "frmOpen"
        Me.grpMessage.ResumeLayout(False)
        Me.grpMessage.PerformLayout()
        Me.grpPortal.ResumeLayout(False)
        Me.grpPortal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNew As Label
    Friend WithEvents lblNew2 As Label
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkClassical As CheckBox
    Friend WithEvents chkAntiquities As CheckBox
    Friend WithEvents monCal As MonthCalendar
    Friend WithEvents grpMessage As GroupBox
    Friend WithEvents radPromotions As RadioButton
    Friend WithEvents radPersonal As RadioButton
    Friend WithEvents radNatural As RadioButton
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents lblNatural As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblPersonal As Label
    Friend WithEvents lblPromotions As Label
    Friend WithEvents chkUnavailable As CheckBox
    Friend WithEvents chkNatural As CheckBox
    Friend WithEvents chkGift As CheckBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents grpPortal As GroupBox
    Friend WithEvents lblEmployee As Label
    Friend WithEvents btnOut As Button
End Class
