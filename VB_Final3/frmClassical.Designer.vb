<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassical
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassical))
        Me.imgRome = New System.Windows.Forms.ImageList(Me.components)
        Me.imgGreece = New System.Windows.Forms.ImageList(Me.components)
        Me.imgAnimals = New System.Windows.Forms.ImageList(Me.components)
        Me.lblAustralia = New System.Windows.Forms.Label()
        Me.lblAfrica = New System.Windows.Forms.Label()
        Me.lblEurope = New System.Windows.Forms.Label()
        Me.lblSouthAmerica = New System.Windows.Forms.Label()
        Me.lblUS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'imgRome
        '
        Me.imgRome.ImageStream = CType(resources.GetObject("imgRome.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgRome.TransparentColor = System.Drawing.Color.Transparent
        Me.imgRome.Images.SetKeyName(0, "rome logo.jpg")
        Me.imgRome.Images.SetKeyName(1, "roman leaders.jpg")
        Me.imgRome.Images.SetKeyName(2, "roman lifestyle.jpg")
        '
        'imgGreece
        '
        Me.imgGreece.ImageStream = CType(resources.GetObject("imgGreece.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgGreece.TransparentColor = System.Drawing.Color.Transparent
        Me.imgGreece.Images.SetKeyName(0, "Greece.jpg")
        Me.imgGreece.Images.SetKeyName(1, "Greek Leaders.jpg")
        Me.imgGreece.Images.SetKeyName(2, "greek lifestyle.jpg")
        '
        'imgAnimals
        '
        Me.imgAnimals.ImageStream = CType(resources.GetObject("imgAnimals.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAnimals.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAnimals.Images.SetKeyName(0, "african bush elephant.png")
        '
        'lblAustralia
        '
        Me.lblAustralia.AutoEllipsis = True
        Me.lblAustralia.BackColor = System.Drawing.Color.Transparent
        Me.lblAustralia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAustralia.Font = New System.Drawing.Font("Orator Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAustralia.ForeColor = System.Drawing.Color.White
        Me.lblAustralia.Image = CType(resources.GetObject("lblAustralia.Image"), System.Drawing.Image)
        Me.lblAustralia.Location = New System.Drawing.Point(500, -24)
        Me.lblAustralia.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAustralia.MaximumSize = New System.Drawing.Size(300, 300)
        Me.lblAustralia.MinimumSize = New System.Drawing.Size(300, 300)
        Me.lblAustralia.Name = "lblAustralia"
        Me.lblAustralia.Size = New System.Drawing.Size(300, 300)
        Me.lblAustralia.TabIndex = 2
        Me.lblAustralia.Text = "AUSTRALIA"
        Me.lblAustralia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAfrica
        '
        Me.lblAfrica.AutoEllipsis = True
        Me.lblAfrica.AutoSize = True
        Me.lblAfrica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAfrica.Font = New System.Drawing.Font("Orator Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfrica.ForeColor = System.Drawing.Color.White
        Me.lblAfrica.Image = CType(resources.GetObject("lblAfrica.Image"), System.Drawing.Image)
        Me.lblAfrica.Location = New System.Drawing.Point(277, -29)
        Me.lblAfrica.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAfrica.MaximumSize = New System.Drawing.Size(300, 300)
        Me.lblAfrica.MinimumSize = New System.Drawing.Size(250, 250)
        Me.lblAfrica.Name = "lblAfrica"
        Me.lblAfrica.Size = New System.Drawing.Size(250, 250)
        Me.lblAfrica.TabIndex = 1
        Me.lblAfrica.Text = "AFRICA"
        Me.lblAfrica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEurope
        '
        Me.lblEurope.AutoEllipsis = True
        Me.lblEurope.AutoSize = True
        Me.lblEurope.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEurope.Font = New System.Drawing.Font("Orator Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEurope.ForeColor = System.Drawing.Color.White
        Me.lblEurope.Image = CType(resources.GetObject("lblEurope.Image"), System.Drawing.Image)
        Me.lblEurope.Location = New System.Drawing.Point(500, 247)
        Me.lblEurope.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEurope.MaximumSize = New System.Drawing.Size(300, 300)
        Me.lblEurope.MinimumSize = New System.Drawing.Size(300, 250)
        Me.lblEurope.Name = "lblEurope"
        Me.lblEurope.Size = New System.Drawing.Size(300, 250)
        Me.lblEurope.TabIndex = 3
        Me.lblEurope.Text = "EUROPE"
        Me.lblEurope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSouthAmerica
        '
        Me.lblSouthAmerica.AutoEllipsis = True
        Me.lblSouthAmerica.AutoSize = True
        Me.lblSouthAmerica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSouthAmerica.Font = New System.Drawing.Font("Orator Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSouthAmerica.ForeColor = System.Drawing.Color.White
        Me.lblSouthAmerica.Image = CType(resources.GetObject("lblSouthAmerica.Image"), System.Drawing.Image)
        Me.lblSouthAmerica.Location = New System.Drawing.Point(-4, -4)
        Me.lblSouthAmerica.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSouthAmerica.MaximumSize = New System.Drawing.Size(300, 300)
        Me.lblSouthAmerica.MinimumSize = New System.Drawing.Size(200, 200)
        Me.lblSouthAmerica.Name = "lblSouthAmerica"
        Me.lblSouthAmerica.Size = New System.Drawing.Size(281, 200)
        Me.lblSouthAmerica.TabIndex = 4
        Me.lblSouthAmerica.Text = "SOUTH AMERICA"
        Me.lblSouthAmerica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUS
        '
        Me.lblUS.AutoEllipsis = True
        Me.lblUS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUS.Font = New System.Drawing.Font("Orator Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUS.ForeColor = System.Drawing.Color.White
        Me.lblUS.Image = CType(resources.GetObject("lblUS.Image"), System.Drawing.Image)
        Me.lblUS.Location = New System.Drawing.Point(-4, 196)
        Me.lblUS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUS.MaximumSize = New System.Drawing.Size(500, 500)
        Me.lblUS.MinimumSize = New System.Drawing.Size(200, 250)
        Me.lblUS.Name = "lblUS"
        Me.lblUS.Size = New System.Drawing.Size(249, 250)
        Me.lblUS.TabIndex = 5
        Me.lblUS.Text = "NORTH AMERICA"
        Me.lblUS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmClassical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 387)
        Me.Controls.Add(Me.lblUS)
        Me.Controls.Add(Me.lblSouthAmerica)
        Me.Controls.Add(Me.lblEurope)
        Me.Controls.Add(Me.lblAustralia)
        Me.Controls.Add(Me.lblAfrica)
        Me.Name = "frmClassical"
        Me.Text = "frmClassical"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgRome As ImageList
    Friend WithEvents imgGreece As ImageList
    Friend WithEvents imgAnimals As ImageList
    Friend WithEvents lblAustralia As Label
    Friend WithEvents lblAfrica As Label
    Friend WithEvents lblEurope As Label
    Friend WithEvents lblSouthAmerica As Label
    Friend WithEvents lblUS As Label
End Class
