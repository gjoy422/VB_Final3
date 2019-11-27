<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPortal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPortal))
        Me.btnSign = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        Me.lblForgot = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblNew2 = New System.Windows.Forms.Label()
        Me.picNatural = New System.Windows.Forms.PictureBox()
        CType(Me.picNatural, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(608, 306)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(75, 23)
        Me.btnSign.TabIndex = 4
        Me.btnSign.Text = "Sign In"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(603, 132)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(100, 25)
        Me.lblWelcome.TabIndex = 7
        Me.lblWelcome.Text = "Welcome!"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(559, 199)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(216, 20)
        Me.txtLogin.TabIndex = 8
        '
        'txtGuest
        '
        Me.txtGuest.Location = New System.Drawing.Point(559, 257)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Size = New System.Drawing.Size(216, 20)
        Me.txtGuest.TabIndex = 9
        '
        'lblForgot
        '
        Me.lblForgot.AutoSize = True
        Me.lblForgot.Location = New System.Drawing.Point(556, 222)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(92, 13)
        Me.lblForgot.TabIndex = 10
        Me.lblForgot.Text = "Forgot Password?"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(455, 199)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(78, 25)
        Me.lblLogin.TabIndex = 11
        Me.lblLogin.Text = "Login:"
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.Location = New System.Drawing.Point(354, 251)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(199, 25)
        Me.lblSign.TabIndex = 12
        Me.lblSign.Text = "Sign in as guest:"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(553, 380)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(0, 13)
        Me.lblNew.TabIndex = 13
        Me.lblNew.Visible = False
        '
        'lblNew2
        '
        Me.lblNew2.AutoSize = True
        Me.lblNew2.Location = New System.Drawing.Point(553, 380)
        Me.lblNew2.Name = "lblNew2"
        Me.lblNew2.Size = New System.Drawing.Size(32, 13)
        Me.lblNew2.TabIndex = 14
        Me.lblNew2.Text = "gsdfs"
        Me.lblNew2.Visible = False
        '
        'picNatural
        '
        Me.picNatural.Image = CType(resources.GetObject("picNatural.Image"), System.Drawing.Image)
        Me.picNatural.Location = New System.Drawing.Point(38, 118)
        Me.picNatural.Name = "picNatural"
        Me.picNatural.Size = New System.Drawing.Size(271, 240)
        Me.picNatural.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNatural.TabIndex = 15
        Me.picNatural.TabStop = False
        '
        'frmPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picNatural)
        Me.Controls.Add(Me.lblNew2)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblForgot)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnSign)
        Me.Name = "frmPortal"
        Me.Text = "Form1"
        CType(Me.picNatural, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSign As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtGuest As TextBox
    Friend WithEvents lblForgot As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblSign As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lblNew2 As Label
    Friend WithEvents picNatural As PictureBox
End Class
