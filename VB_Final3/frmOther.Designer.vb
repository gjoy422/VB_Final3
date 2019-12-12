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
        Me.lblComplaint = New System.Windows.Forms.Label()
        Me.txtComplaint = New System.Windows.Forms.TextBox()
        Me.grpAccount = New System.Windows.Forms.GroupBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.grpCustomer.SuspendLayout()
        Me.grpComplaint.SuspendLayout()
        Me.grpAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboOther
        '
        Me.cboOther.FormattingEnabled = True
        Me.cboOther.Items.AddRange(New Object() {"Customer Service", "File A Complaint", "Create An Account", "Speak To A Manager"})
        Me.cboOther.Location = New System.Drawing.Point(24, 54)
        Me.cboOther.Name = "cboOther"
        Me.cboOther.Size = New System.Drawing.Size(192, 33)
        Me.cboOther.TabIndex = 0
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.grpComplaint)
        Me.grpCustomer.Controls.Add(Me.Label1)
        Me.grpCustomer.Location = New System.Drawing.Point(251, 54)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(611, 324)
        Me.grpCustomer.TabIndex = 1
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Customer Service"
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
        Me.grpComplaint.Controls.Add(Me.grpAccount)
        Me.grpComplaint.Controls.Add(Me.txtComplaint)
        Me.grpComplaint.Controls.Add(Me.lblComplaint)
        Me.grpComplaint.Location = New System.Drawing.Point(0, 0)
        Me.grpComplaint.Name = "grpComplaint"
        Me.grpComplaint.Size = New System.Drawing.Size(611, 324)
        Me.grpComplaint.TabIndex = 2
        Me.grpComplaint.TabStop = False
        Me.grpComplaint.Text = "Complaint"
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
        'txtComplaint
        '
        Me.txtComplaint.Location = New System.Drawing.Point(37, 130)
        Me.txtComplaint.Name = "txtComplaint"
        Me.txtComplaint.Size = New System.Drawing.Size(535, 30)
        Me.txtComplaint.TabIndex = 1
        '
        'grpAccount
        '
        Me.grpAccount.Controls.Add(Me.btnAccount)
        Me.grpAccount.Controls.Add(Me.lblAccount)
        Me.grpAccount.Location = New System.Drawing.Point(0, 0)
        Me.grpAccount.Name = "grpAccount"
        Me.grpAccount.Size = New System.Drawing.Size(611, 324)
        Me.grpAccount.TabIndex = 3
        Me.grpAccount.TabStop = False
        Me.grpAccount.Text = "Complaint"
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
        'btnAccount
        '
        Me.btnAccount.Location = New System.Drawing.Point(37, 158)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(140, 35)
        Me.btnAccount.TabIndex = 1
        Me.btnAccount.Text = "Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'frmOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1467, 865)
        Me.Controls.Add(Me.grpCustomer)
        Me.Controls.Add(Me.cboOther)
        Me.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmOther"
        Me.Text = "frmOther"
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.grpComplaint.ResumeLayout(False)
        Me.grpComplaint.PerformLayout()
        Me.grpAccount.ResumeLayout(False)
        Me.grpAccount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboOther As ComboBox
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpComplaint As GroupBox
    Friend WithEvents grpAccount As GroupBox
    Friend WithEvents btnAccount As Button
    Friend WithEvents lblAccount As Label
    Friend WithEvents txtComplaint As TextBox
    Friend WithEvents lblComplaint As Label
End Class
