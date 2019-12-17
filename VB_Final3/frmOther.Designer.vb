<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOther
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
        Me.cboOther = New System.Windows.Forms.ComboBox()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpComplaint = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Complaints = New System.Windows.Forms.ListBox()
        Me.txtComplaint = New System.Windows.Forms.TextBox()
        Me.lblComplaint = New System.Windows.Forms.Label()
        Me.grpAccounts = New System.Windows.Forms.GroupBox()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.grpManager = New System.Windows.Forms.GroupBox()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.lblManager = New System.Windows.Forms.Label()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grpCustomer.SuspendLayout()
        Me.grpComplaint.SuspendLayout()
        Me.grpAccounts.SuspendLayout()
        Me.grpManager.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboOther
        '
        Me.cboOther.FormattingEnabled = True
        Me.cboOther.Items.AddRange(New Object() {"Customer Service", "File A Complaint", "Create An Account", "Speak To A Manager"})
        Me.cboOther.Location = New System.Drawing.Point(12, 54)
        Me.cboOther.Name = "cboOther"
        Me.cboOther.Size = New System.Drawing.Size(192, 33)
        Me.cboOther.TabIndex = 0
        Me.cboOther.Text = "Select"
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.Label1)
        Me.grpCustomer.Location = New System.Drawing.Point(237, 41)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(611, 324)
        Me.grpCustomer.TabIndex = 1
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Customer Service"
        Me.grpCustomer.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To speak to a customer service representative, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "call this number: 1-800-755-HIST" &
    ""
        '
        'grpComplaint
        '
        Me.grpComplaint.Controls.Add(Me.btnSend)
        Me.grpComplaint.Controls.Add(Me.Complaints)
        Me.grpComplaint.Controls.Add(Me.txtComplaint)
        Me.grpComplaint.Controls.Add(Me.lblComplaint)
        Me.grpComplaint.Location = New System.Drawing.Point(237, 41)
        Me.grpComplaint.Name = "grpComplaint"
        Me.grpComplaint.Size = New System.Drawing.Size(652, 336)
        Me.grpComplaint.TabIndex = 2
        Me.grpComplaint.TabStop = False
        Me.grpComplaint.Text = "Complaint"
        Me.grpComplaint.Visible = False
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(109, 297)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(103, 37)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Complaints
        '
        Me.Complaints.Font = New System.Drawing.Font("Orator Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Complaints.FormattingEnabled = True
        Me.Complaints.ItemHeight = 17
        Me.Complaints.Items.AddRange(New Object() {"The sushi was terrible!", "Seriously, what was up ", "with food??!!"})
        Me.Complaints.Location = New System.Drawing.Point(350, 112)
        Me.Complaints.Name = "Complaints"
        Me.Complaints.Size = New System.Drawing.Size(222, 174)
        Me.Complaints.TabIndex = 2
        '
        'txtComplaint
        '
        Me.txtComplaint.Font = New System.Drawing.Font("Orator Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplaint.Location = New System.Drawing.Point(25, 112)
        Me.txtComplaint.Multiline = True
        Me.txtComplaint.Name = "txtComplaint"
        Me.txtComplaint.Size = New System.Drawing.Size(278, 179)
        Me.txtComplaint.TabIndex = 1
        '
        'lblComplaint
        '
        Me.lblComplaint.AutoSize = True
        Me.lblComplaint.Location = New System.Drawing.Point(32, 59)
        Me.lblComplaint.Name = "lblComplaint"
        Me.lblComplaint.Size = New System.Drawing.Size(243, 25)
        Me.lblComplaint.TabIndex = 0
        Me.lblComplaint.Text = "Enter your complaint:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'grpAccounts
        '
        Me.grpAccounts.Controls.Add(Me.btnAccount)
        Me.grpAccounts.Controls.Add(Me.lblAccount)
        Me.grpAccounts.Location = New System.Drawing.Point(237, 41)
        Me.grpAccounts.Name = "grpAccounts"
        Me.grpAccounts.Size = New System.Drawing.Size(652, 324)
        Me.grpAccounts.TabIndex = 3
        Me.grpAccounts.TabStop = False
        Me.grpAccounts.Text = "Account"
        Me.grpAccounts.Visible = False
        '
        'btnAccount
        '
        Me.btnAccount.Location = New System.Drawing.Point(37, 158)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(140, 35)
        Me.btnAccount.TabIndex = 1
        Me.btnAccount.Text = "Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(32, 59)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(408, 50)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "Click the ""Account"" button to begin " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "setting up your account:"
        '
        'grpManager
        '
        Me.grpManager.Controls.Add(Me.btnCall)
        Me.grpManager.Controls.Add(Me.lblManager)
        Me.grpManager.Location = New System.Drawing.Point(231, 41)
        Me.grpManager.Name = "grpManager"
        Me.grpManager.Size = New System.Drawing.Size(701, 402)
        Me.grpManager.TabIndex = 4
        Me.grpManager.TabStop = False
        Me.grpManager.Text = "Speak to a Manager"
        Me.grpManager.Visible = False
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(37, 125)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(140, 35)
        Me.btnCall.TabIndex = 1
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'lblManager
        '
        Me.lblManager.AutoSize = True
        Me.lblManager.Location = New System.Drawing.Point(32, 59)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(419, 50)
        Me.lblManager.TabIndex = 0
        Me.lblManager.Text = "Please select the ""Call"" button and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wait as your line is being connected." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Location = New System.Drawing.Point(13, 13)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(78, 25)
        Me.lblInstruct.TabIndex = 5
        Me.lblInstruct.Text = "Label2"
        '
        'picLogo
        '
        Me.picLogo.Image = Global.VB_Final3.My.Resources.Resources.natural_history_musuem
        Me.picLogo.Location = New System.Drawing.Point(32, 170)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(134, 153)
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'frmOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1467, 865)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.grpManager)
        Me.Controls.Add(Me.grpComplaint)
        Me.Controls.Add(Me.grpAccounts)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.grpCustomer)
        Me.Controls.Add(Me.cboOther)
        Me.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmOther"
        Me.Text = "frmOther"
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.grpComplaint.ResumeLayout(False)
        Me.grpComplaint.PerformLayout()
        Me.grpAccounts.ResumeLayout(False)
        Me.grpAccounts.PerformLayout()
        Me.grpManager.ResumeLayout(False)
        Me.grpManager.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOther As ComboBox
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpComplaint As GroupBox
    Friend WithEvents grpAccounts As GroupBox
    Friend WithEvents btnAccount As Button
    Friend WithEvents lblAccount As Label
    Friend WithEvents txtComplaint As TextBox
    Friend WithEvents lblComplaint As Label
    Friend WithEvents grpManager As GroupBox
    Friend WithEvents btnCall As Button
    Friend WithEvents lblManager As Label
    Friend WithEvents Complaints As ListBox
    Friend WithEvents btnSend As Button
    Friend WithEvents lblInstruct As Label
    Friend WithEvents picLogo As PictureBox
End Class
