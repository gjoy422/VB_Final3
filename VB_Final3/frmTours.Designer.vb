<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTours
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
        Me.grpTour = New System.Windows.Forms.GroupBox()
        Me.cldTour = New System.Windows.Forms.MonthCalendar()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.chkTour3 = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkTour2 = New System.Windows.Forms.CheckBox()
        Me.chkTour = New System.Windows.Forms.CheckBox()
        Me.lblNatural = New System.Windows.Forms.Label()
        Me.lblAntiquities = New System.Windows.Forms.Label()
        Me.lblClassical = New System.Windows.Forms.Label()
        Me.grpTour.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTour
        '
        Me.grpTour.Controls.Add(Me.lblClassical)
        Me.grpTour.Controls.Add(Me.lblAntiquities)
        Me.grpTour.Controls.Add(Me.lblNatural)
        Me.grpTour.Controls.Add(Me.cldTour)
        Me.grpTour.Controls.Add(Me.lblDate)
        Me.grpTour.Location = New System.Drawing.Point(12, 63)
        Me.grpTour.Name = "grpTour"
        Me.grpTour.Size = New System.Drawing.Size(456, 352)
        Me.grpTour.TabIndex = 0
        Me.grpTour.TabStop = False
        '
        'cldTour
        '
        Me.cldTour.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
        Me.cldTour.Location = New System.Drawing.Point(200, 35)
        Me.cldTour.Name = "cldTour"
        Me.cldTour.TabIndex = 8
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(22, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(166, 25)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Select a date:"
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(21, 9)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(78, 25)
        Me.lblIntro.TabIndex = 1
        Me.lblIntro.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.chkTour3)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.chkTour2)
        Me.Panel1.Controls.Add(Me.chkTour)
        Me.Panel1.Location = New System.Drawing.Point(489, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 352)
        Me.Panel1.TabIndex = 2
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(277, 326)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'chkTour3
        '
        Me.chkTour3.AutoSize = True
        Me.chkTour3.Location = New System.Drawing.Point(37, 217)
        Me.chkTour3.Name = "chkTour3"
        Me.chkTour3.Size = New System.Drawing.Size(81, 17)
        Me.chkTour3.TabIndex = 3
        Me.chkTour3.Text = "CheckBox1"
        Me.chkTour3.UseVisualStyleBackColor = True
        Me.chkTour3.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Orator Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(19, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(8, 34)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'chkTour2
        '
        Me.chkTour2.AutoSize = True
        Me.chkTour2.Location = New System.Drawing.Point(37, 180)
        Me.chkTour2.Name = "chkTour2"
        Me.chkTour2.Size = New System.Drawing.Size(81, 17)
        Me.chkTour2.TabIndex = 1
        Me.chkTour2.Text = "CheckBox1"
        Me.chkTour2.UseVisualStyleBackColor = True
        Me.chkTour2.Visible = False
        '
        'chkTour
        '
        Me.chkTour.AutoSize = True
        Me.chkTour.Location = New System.Drawing.Point(37, 139)
        Me.chkTour.Name = "chkTour"
        Me.chkTour.Size = New System.Drawing.Size(81, 17)
        Me.chkTour.TabIndex = 0
        Me.chkTour.Text = "CheckBox1"
        Me.chkTour.UseVisualStyleBackColor = True
        Me.chkTour.Visible = False
        '
        'lblNatural
        '
        Me.lblNatural.AutoSize = True
        Me.lblNatural.Location = New System.Drawing.Point(37, 264)
        Me.lblNatural.Name = "lblNatural"
        Me.lblNatural.Size = New System.Drawing.Size(39, 13)
        Me.lblNatural.TabIndex = 9
        Me.lblNatural.Text = "Label1"
        Me.lblNatural.Visible = False
        '
        'lblAntiquities
        '
        Me.lblAntiquities.AutoSize = True
        Me.lblAntiquities.Location = New System.Drawing.Point(197, 264)
        Me.lblAntiquities.Name = "lblAntiquities"
        Me.lblAntiquities.Size = New System.Drawing.Size(39, 13)
        Me.lblAntiquities.TabIndex = 10
        Me.lblAntiquities.Text = "Label1"
        Me.lblAntiquities.Visible = False
        '
        'lblClassical
        '
        Me.lblClassical.AutoSize = True
        Me.lblClassical.Location = New System.Drawing.Point(303, 287)
        Me.lblClassical.Name = "lblClassical"
        Me.lblClassical.Size = New System.Drawing.Size(39, 13)
        Me.lblClassical.TabIndex = 11
        Me.lblClassical.Text = "Label1"
        Me.lblClassical.Visible = False
        '
        'frmTours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.grpTour)
        Me.Name = "frmTours"
        Me.Text = "frmTour"
        Me.grpTour.ResumeLayout(False)
        Me.grpTour.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpTour As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblIntro As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkTour2 As CheckBox
    Friend WithEvents chkTour As CheckBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents chkTour3 As CheckBox
    Friend WithEvents cldTour As MonthCalendar
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblClassical As Label
    Friend WithEvents lblAntiquities As Label
    Friend WithEvents lblNatural As Label
End Class
