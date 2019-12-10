<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSign))
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPromo = New System.Windows.Forms.TextBox()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picNatural = New System.Windows.Forms.PictureBox()
        CType(Me.picNatural, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeople.Location = New System.Drawing.Point(22, 118)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(199, 25)
        Me.lblPeople.TabIndex = 7
        Me.lblPeople.Text = "Number of People:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Promotion Code:"
        '
        'txtPromo
        '
        Me.txtPromo.Location = New System.Drawing.Point(269, 187)
        Me.txtPromo.Name = "txtPromo"
        Me.txtPromo.Size = New System.Drawing.Size(100, 20)
        Me.txtPromo.TabIndex = 9
        '
        'txtPeople
        '
        Me.txtPeople.Location = New System.Drawing.Point(269, 118)
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(100, 20)
        Me.txtPeople.TabIndex = 10
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.Location = New System.Drawing.Point(33, 18)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(78, 25)
        Me.lblSign.TabIndex = 11
        Me.lblSign.Text = "Label2"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(109, 283)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(142, 34)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate:"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'picNatural
        '
        Me.picNatural.Image = CType(resources.GetObject("picNatural.Image"), System.Drawing.Image)
        Me.picNatural.Location = New System.Drawing.Point(450, 104)
        Me.picNatural.Name = "picNatural"
        Me.picNatural.Size = New System.Drawing.Size(271, 240)
        Me.picNatural.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNatural.TabIndex = 16
        Me.picNatural.TabStop = False
        '
        'frmSign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picNatural)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.txtPeople)
        Me.Controls.Add(Me.txtPromo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPeople)
        Me.Name = "frmSign"
        Me.Text = "frmSign"
        CType(Me.picNatural, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPeople As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPromo As TextBox
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents lblSign As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents picNatural As PictureBox
End Class
