<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGift
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGift))
        Me.radMug = New System.Windows.Forms.RadioButton()
        Me.radMirror = New System.Windows.Forms.RadioButton()
        Me.radDinosaur = New System.Windows.Forms.RadioButton()
        Me.radGlass = New System.Windows.Forms.RadioButton()
        Me.radJournal = New System.Windows.Forms.RadioButton()
        Me.radBookmarks = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.picBookmarks = New System.Windows.Forms.PictureBox()
        Me.picJournal = New System.Windows.Forms.PictureBox()
        Me.picGlass = New System.Windows.Forms.PictureBox()
        Me.picDinosaur = New System.Windows.Forms.PictureBox()
        Me.picMirror = New System.Windows.Forms.PictureBox()
        Me.picMug = New System.Windows.Forms.PictureBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        CType(Me.picBookmarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGlass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDinosaur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMirror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radMug
        '
        Me.radMug.AutoSize = True
        Me.radMug.Location = New System.Drawing.Point(54, 128)
        Me.radMug.Name = "radMug"
        Me.radMug.Size = New System.Drawing.Size(14, 13)
        Me.radMug.TabIndex = 4
        Me.radMug.UseVisualStyleBackColor = True
        '
        'radMirror
        '
        Me.radMirror.AutoSize = True
        Me.radMirror.Location = New System.Drawing.Point(189, 128)
        Me.radMirror.Name = "radMirror"
        Me.radMirror.Size = New System.Drawing.Size(14, 13)
        Me.radMirror.TabIndex = 5
        Me.radMirror.UseVisualStyleBackColor = True
        '
        'radDinosaur
        '
        Me.radDinosaur.AutoSize = True
        Me.radDinosaur.Location = New System.Drawing.Point(54, 279)
        Me.radDinosaur.Name = "radDinosaur"
        Me.radDinosaur.Size = New System.Drawing.Size(14, 13)
        Me.radDinosaur.TabIndex = 6
        Me.radDinosaur.UseVisualStyleBackColor = True
        '
        'radGlass
        '
        Me.radGlass.AutoSize = True
        Me.radGlass.Location = New System.Drawing.Point(189, 283)
        Me.radGlass.Name = "radGlass"
        Me.radGlass.Size = New System.Drawing.Size(14, 13)
        Me.radGlass.TabIndex = 7
        Me.radGlass.UseVisualStyleBackColor = True
        '
        'radJournal
        '
        Me.radJournal.AutoSize = True
        Me.radJournal.Location = New System.Drawing.Point(54, 430)
        Me.radJournal.Name = "radJournal"
        Me.radJournal.Size = New System.Drawing.Size(14, 13)
        Me.radJournal.TabIndex = 10
        Me.radJournal.UseVisualStyleBackColor = True
        '
        'radBookmarks
        '
        Me.radBookmarks.AutoSize = True
        Me.radBookmarks.Location = New System.Drawing.Point(189, 430)
        Me.radBookmarks.Name = "radBookmarks"
        Me.radBookmarks.Size = New System.Drawing.Size(14, 13)
        Me.radBookmarks.TabIndex = 11
        Me.radBookmarks.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Orator Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(412, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 25)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Grace's Shopping Cart"
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.Location = New System.Drawing.Point(397, 46)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(301, 316)
        Me.lstCart.TabIndex = 14
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(641, 420)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(157, 23)
        Me.btnReturn.TabIndex = 15
        Me.btnReturn.Text = "Return to Interactive Page"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lstTotal
        '
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.Location = New System.Drawing.Point(607, 332)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(91, 30)
        Me.lstTotal.TabIndex = 16
        '
        'picBookmarks
        '
        Me.picBookmarks.Image = CType(resources.GetObject("picBookmarks.Image"), System.Drawing.Image)
        Me.picBookmarks.Location = New System.Drawing.Point(134, 302)
        Me.picBookmarks.Name = "picBookmarks"
        Me.picBookmarks.Size = New System.Drawing.Size(137, 122)
        Me.picBookmarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookmarks.TabIndex = 9
        Me.picBookmarks.TabStop = False
        '
        'picJournal
        '
        Me.picJournal.Image = CType(resources.GetObject("picJournal.Image"), System.Drawing.Image)
        Me.picJournal.Location = New System.Drawing.Point(1, 302)
        Me.picJournal.Name = "picJournal"
        Me.picJournal.Size = New System.Drawing.Size(137, 122)
        Me.picJournal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJournal.TabIndex = 8
        Me.picJournal.TabStop = False
        '
        'picGlass
        '
        Me.picGlass.Image = CType(resources.GetObject("picGlass.Image"), System.Drawing.Image)
        Me.picGlass.Location = New System.Drawing.Point(135, 151)
        Me.picGlass.Name = "picGlass"
        Me.picGlass.Size = New System.Drawing.Size(137, 122)
        Me.picGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGlass.TabIndex = 3
        Me.picGlass.TabStop = False
        '
        'picDinosaur
        '
        Me.picDinosaur.Image = CType(resources.GetObject("picDinosaur.Image"), System.Drawing.Image)
        Me.picDinosaur.Location = New System.Drawing.Point(1, 151)
        Me.picDinosaur.Name = "picDinosaur"
        Me.picDinosaur.Size = New System.Drawing.Size(137, 122)
        Me.picDinosaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDinosaur.TabIndex = 2
        Me.picDinosaur.TabStop = False
        '
        'picMirror
        '
        Me.picMirror.Image = CType(resources.GetObject("picMirror.Image"), System.Drawing.Image)
        Me.picMirror.Location = New System.Drawing.Point(135, -1)
        Me.picMirror.Name = "picMirror"
        Me.picMirror.Size = New System.Drawing.Size(136, 122)
        Me.picMirror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMirror.TabIndex = 1
        Me.picMirror.TabStop = False
        '
        'picMug
        '
        Me.picMug.Image = CType(resources.GetObject("picMug.Image"), System.Drawing.Image)
        Me.picMug.Location = New System.Drawing.Point(1, -1)
        Me.picMug.Name = "picMug"
        Me.picMug.Size = New System.Drawing.Size(137, 122)
        Me.picMug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMug.TabIndex = 0
        Me.picMug.TabStop = False
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(573, 368)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(125, 32)
        Me.btnCheck.TabIndex = 17
        Me.btnCheck.Text = "Check Out"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'frmGift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.radBookmarks)
        Me.Controls.Add(Me.radJournal)
        Me.Controls.Add(Me.picBookmarks)
        Me.Controls.Add(Me.picJournal)
        Me.Controls.Add(Me.radGlass)
        Me.Controls.Add(Me.radDinosaur)
        Me.Controls.Add(Me.radMirror)
        Me.Controls.Add(Me.radMug)
        Me.Controls.Add(Me.picGlass)
        Me.Controls.Add(Me.picDinosaur)
        Me.Controls.Add(Me.picMirror)
        Me.Controls.Add(Me.picMug)
        Me.Name = "frmGift"
        Me.Text = "Gift"
        CType(Me.picBookmarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJournal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGlass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDinosaur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMirror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMug, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMug As PictureBox
    Friend WithEvents picMirror As PictureBox
    Friend WithEvents picDinosaur As PictureBox
    Friend WithEvents picGlass As PictureBox
    Friend WithEvents radMug As RadioButton
    Friend WithEvents radMirror As RadioButton
    Friend WithEvents radDinosaur As RadioButton
    Friend WithEvents radGlass As RadioButton
    Friend WithEvents picJournal As PictureBox
    Friend WithEvents picBookmarks As PictureBox
    Friend WithEvents radJournal As RadioButton
    Friend WithEvents radBookmarks As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lstTotal As ListBox
    Friend WithEvents btnCheck As Button
End Class
