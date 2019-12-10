<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAntiquities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAntiquities))
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.picEgyptian = New System.Windows.Forms.PictureBox()
        Me.lblEgyptian = New System.Windows.Forms.Label()
        Me.lblRoman = New System.Windows.Forms.Label()
        Me.lblGreek = New System.Windows.Forms.Label()
        Me.picRoman = New System.Windows.Forms.PictureBox()
        Me.picGreek = New System.Windows.Forms.PictureBox()
        Me.lblGreeks = New System.Windows.Forms.Label()
        Me.lblAntiquities = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picEgyptian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSelect
        '
        Me.cboSelect.BackColor = System.Drawing.Color.White
        Me.cboSelect.Font = New System.Drawing.Font("Orator Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"Egyptian", "Roman", "Greek"})
        Me.cboSelect.Location = New System.Drawing.Point(12, 153)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(163, 25)
        Me.cboSelect.TabIndex = 0
        Me.cboSelect.Text = "Select an exhibit:"
        '
        'picEgyptian
        '
        Me.picEgyptian.Image = CType(resources.GetObject("picEgyptian.Image"), System.Drawing.Image)
        Me.picEgyptian.Location = New System.Drawing.Point(332, 12)
        Me.picEgyptian.Name = "picEgyptian"
        Me.picEgyptian.Size = New System.Drawing.Size(193, 211)
        Me.picEgyptian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEgyptian.TabIndex = 1
        Me.picEgyptian.TabStop = False
        Me.picEgyptian.Visible = False
        '
        'lblEgyptian
        '
        Me.lblEgyptian.AutoSize = True
        Me.lblEgyptian.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEgyptian.Location = New System.Drawing.Point(259, 251)
        Me.lblEgyptian.Name = "lblEgyptian"
        Me.lblEgyptian.Size = New System.Drawing.Size(392, 60)
        Me.lblEgyptian.TabIndex = 2
        Me.lblEgyptian.Text = "A large panel fragment from a painted wood sarcophagus:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The decoration depicts t" &
    "he goddess Hathor in the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "form of a white cow below a figure of Horus" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " as a ha" &
    "wk with out-stretched protective wings."
        Me.lblEgyptian.Visible = False
        '
        'lblRoman
        '
        Me.lblRoman.AutoSize = True
        Me.lblRoman.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoman.Location = New System.Drawing.Point(196, 236)
        Me.lblRoman.Name = "lblRoman"
        Me.lblRoman.Size = New System.Drawing.Size(546, 75)
        Me.lblRoman.TabIndex = 4
        Me.lblRoman.Text = resources.GetString("lblRoman.Text")
        Me.lblRoman.Visible = False
        '
        'lblGreek
        '
        Me.lblGreek.AutoSize = True
        Me.lblGreek.Location = New System.Drawing.Point(507, 267)
        Me.lblGreek.Name = "lblGreek"
        Me.lblGreek.Size = New System.Drawing.Size(0, 13)
        Me.lblGreek.TabIndex = 5
        '
        'picRoman
        '
        Me.picRoman.Image = CType(resources.GetObject("picRoman.Image"), System.Drawing.Image)
        Me.picRoman.Location = New System.Drawing.Point(332, 12)
        Me.picRoman.Name = "picRoman"
        Me.picRoman.Size = New System.Drawing.Size(193, 211)
        Me.picRoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRoman.TabIndex = 3
        Me.picRoman.TabStop = False
        Me.picRoman.Visible = False
        '
        'picGreek
        '
        Me.picGreek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGreek.Image = CType(resources.GetObject("picGreek.Image"), System.Drawing.Image)
        Me.picGreek.Location = New System.Drawing.Point(332, 12)
        Me.picGreek.Name = "picGreek"
        Me.picGreek.Size = New System.Drawing.Size(193, 211)
        Me.picGreek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGreek.TabIndex = 6
        Me.picGreek.TabStop = False
        Me.picGreek.Visible = False
        '
        'lblGreeks
        '
        Me.lblGreeks.AutoSize = True
        Me.lblGreeks.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeks.ForeColor = System.Drawing.Color.Black
        Me.lblGreeks.Location = New System.Drawing.Point(205, 226)
        Me.lblGreeks.Name = "lblGreeks"
        Me.lblGreeks.Size = New System.Drawing.Size(469, 135)
        Me.lblGreeks.TabIndex = 7
        Me.lblGreeks.Tag = ""
        Me.lblGreeks.Text = resources.GetString("lblGreeks.Text")
        Me.lblGreeks.Visible = False
        '
        'lblAntiquities
        '
        Me.lblAntiquities.AutoSize = True
        Me.lblAntiquities.BackColor = System.Drawing.Color.White
        Me.lblAntiquities.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntiquities.Location = New System.Drawing.Point(12, 38)
        Me.lblAntiquities.Name = "lblAntiquities"
        Me.lblAntiquities.Size = New System.Drawing.Size(78, 100)
        Me.lblAntiquities.TabIndex = 8
        Me.lblAntiquities.Text = "Label1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 415)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmAntiquities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblAntiquities)
        Me.Controls.Add(Me.lblGreeks)
        Me.Controls.Add(Me.picGreek)
        Me.Controls.Add(Me.lblGreek)
        Me.Controls.Add(Me.lblRoman)
        Me.Controls.Add(Me.picRoman)
        Me.Controls.Add(Me.lblEgyptian)
        Me.Controls.Add(Me.picEgyptian)
        Me.Controls.Add(Me.cboSelect)
        Me.DoubleBuffered = True
        Me.Name = "frmAntiquities"
        Me.Text = "frmAntiquities"
        CType(Me.picEgyptian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSelect As ComboBox
    Friend WithEvents picEgyptian As PictureBox
    Friend WithEvents lblEgyptian As Label
    Friend WithEvents lblRoman As Label
    Friend WithEvents lblGreek As Label
    Friend WithEvents picRoman As PictureBox
    Friend WithEvents picGreek As PictureBox
    Friend WithEvents lblGreeks As Label
    Friend WithEvents lblAntiquities As Label
    Friend WithEvents btnBack As Button
End Class
