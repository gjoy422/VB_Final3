<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGuest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuest))
        Me.lblNew2 = New System.Windows.Forms.Label()
        Me.lblMission = New System.Windows.Forms.Label()
        Me.btnExplore = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNew2
        '
        Me.lblNew2.AutoSize = True
        Me.lblNew2.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew2.Location = New System.Drawing.Point(656, 63)
        Me.lblNew2.Name = "lblNew2"
        Me.lblNew2.Size = New System.Drawing.Size(42, 15)
        Me.lblNew2.TabIndex = 15
        Me.lblNew2.Text = "gsdfs"
        Me.lblNew2.Visible = False
        '
        'lblMission
        '
        Me.lblMission.AutoSize = True
        Me.lblMission.BackColor = System.Drawing.Color.Transparent
        Me.lblMission.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission.Location = New System.Drawing.Point(0, 0)
        Me.lblMission.Name = "lblMission"
        Me.lblMission.Size = New System.Drawing.Size(303, 450)
        Me.lblMission.TabIndex = 19
        Me.lblMission.Text = resources.GetString("lblMission.Text")
        '
        'btnExplore
        '
        Me.btnExplore.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExplore.Location = New System.Drawing.Point(638, 211)
        Me.btnExplore.Name = "btnExplore"
        Me.btnExplore.Size = New System.Drawing.Size(119, 50)
        Me.btnExplore.TabIndex = 20
        Me.btnExplore.Text = "Explore "
        Me.btnExplore.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Orator Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(638, 301)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(119, 50)
        Me.btnRegister.TabIndex = 21
        Me.btnRegister.Text = "Create an account"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'frmGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.VB_Final3.My.Resources.Resources.natural_history_musuem
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnExplore)
        Me.Controls.Add(Me.lblMission)
        Me.Controls.Add(Me.lblNew2)
        Me.DoubleBuffered = True
        Me.Name = "frmGuest"
        Me.Text = "frmGuest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNew2 As Label
    Friend WithEvents lblMission As Label
    Friend WithEvents btnExplore As Button
    Friend WithEvents btnRegister As Button
End Class
