<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.grpAccount = New System.Windows.Forms.GroupBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.btnPortal = New System.Windows.Forms.Button()
        Me.grpAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(368, 121)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(308, 23)
        Me.txtUser.TabIndex = 0
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(368, 45)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(308, 23)
        Me.txtLastname.TabIndex = 1
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(368, 83)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(308, 23)
        Me.txtFirst.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(368, 155)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(308, 23)
        Me.txtPassword.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(29, 83)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(133, 25)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "First Name:"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(29, 45)
        Me.lblLastname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(122, 25)
        Me.lblLastname.TabIndex = 5
        Me.lblLastname.Text = "Last Name:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(29, 117)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(111, 25)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Password:"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(29, 193)
        Me.lblConfirm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(199, 25)
        Me.lblConfirm.TabIndex = 8
        Me.lblConfirm.Text = "Confirm Password:"
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(368, 197)
        Me.txtConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(308, 23)
        Me.txtConfirm.TabIndex = 9
        '
        'btnSign
        '
        Me.btnSign.BackColor = System.Drawing.Color.White
        Me.btnSign.Location = New System.Drawing.Point(306, 291)
        Me.btnSign.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(100, 30)
        Me.btnSign.TabIndex = 10
        Me.btnSign.Text = "Sign Up"
        Me.btnSign.UseVisualStyleBackColor = False
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.Location = New System.Drawing.Point(42, 21)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(0, 25)
        Me.lblInstruct.TabIndex = 11
        '
        'grpAccount
        '
        Me.grpAccount.Controls.Add(Me.lblLastname)
        Me.grpAccount.Controls.Add(Me.lblName)
        Me.grpAccount.Controls.Add(Me.btnSign)
        Me.grpAccount.Controls.Add(Me.Label1)
        Me.grpAccount.Controls.Add(Me.txtConfirm)
        Me.grpAccount.Controls.Add(Me.lblUsername)
        Me.grpAccount.Controls.Add(Me.lblConfirm)
        Me.grpAccount.Controls.Add(Me.txtUser)
        Me.grpAccount.Controls.Add(Me.txtLastname)
        Me.grpAccount.Controls.Add(Me.txtPassword)
        Me.grpAccount.Controls.Add(Me.txtFirst)
        Me.grpAccount.Location = New System.Drawing.Point(33, 68)
        Me.grpAccount.Name = "grpAccount"
        Me.grpAccount.Size = New System.Drawing.Size(819, 356)
        Me.grpAccount.TabIndex = 12
        Me.grpAccount.TabStop = False
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Orator Std", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(27, 1)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(841, 64)
        Me.lblFinal.TabIndex = 11
        Me.lblFinal.Text = "Thank you for signing up! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please return to the Portal to sign in to your new ac" &
    "count!"
        Me.lblFinal.Visible = False
        '
        'btnPortal
        '
        Me.btnPortal.BackColor = System.Drawing.Color.White
        Me.btnPortal.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPortal.Location = New System.Drawing.Point(359, 430)
        Me.btnPortal.Name = "btnPortal"
        Me.btnPortal.Size = New System.Drawing.Size(125, 36)
        Me.btnPortal.TabIndex = 13
        Me.btnPortal.Text = "Portal"
        Me.btnPortal.UseVisualStyleBackColor = False
        Me.btnPortal.Visible = False
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 468)
        Me.Controls.Add(Me.btnPortal)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.grpAccount)
        Me.Controls.Add(Me.lblInstruct)
        Me.Font = New System.Drawing.Font("Orator Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAccount"
        Me.Text = "frmAccount"
        Me.grpAccount.ResumeLayout(False)
        Me.grpAccount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConfirm As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents btnSign As Button
    Friend WithEvents lblInstruct As Label
    Friend WithEvents grpAccount As GroupBox
    Friend WithEvents lblFinal As Label
    Friend WithEvents btnPortal As Button
End Class
