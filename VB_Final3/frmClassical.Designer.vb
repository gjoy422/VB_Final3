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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LIFESTYLE", 2, 2)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LEADERS", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ROME", New System.Windows.Forms.TreeNode() {TreeNode2})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassical))
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LIFESTYLE")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LEADERS", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GREECE", New System.Windows.Forms.TreeNode() {TreeNode5})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.imgRome = New System.Windows.Forms.ImageList(Me.components)
        Me.treeGreece = New System.Windows.Forms.TreeView()
        Me.imgGreece = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.imgRome
        Me.TreeView1.Location = New System.Drawing.Point(1, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "nodLife"
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Text = "LIFESTYLE"
        TreeNode2.ImageIndex = 1
        TreeNode2.Name = "nodLead"
        TreeNode2.Text = "LEADERS"
        TreeNode3.Name = "Node0"
        TreeNode3.SelectedImageIndex = 0
        TreeNode3.Text = "ROME"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.TreeView1.SelectedImageIndex = 2
        Me.TreeView1.Size = New System.Drawing.Size(807, 452)
        Me.TreeView1.TabIndex = 0
        '
        'imgRome
        '
        Me.imgRome.ImageStream = CType(resources.GetObject("imgRome.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgRome.TransparentColor = System.Drawing.Color.Transparent
        Me.imgRome.Images.SetKeyName(0, "rome logo.jpg")
        Me.imgRome.Images.SetKeyName(1, "roman leaders.jpg")
        Me.imgRome.Images.SetKeyName(2, "roman lifestyle.jpg")
        '
        'treeGreece
        '
        Me.treeGreece.ImageIndex = 0
        Me.treeGreece.ImageList = Me.imgGreece
        Me.treeGreece.Location = New System.Drawing.Point(1, 164)
        Me.treeGreece.Name = "treeGreece"
        TreeNode4.ImageIndex = 2
        TreeNode4.Name = "Node3"
        TreeNode4.Text = "LIFESTYLE"
        TreeNode5.ImageIndex = 1
        TreeNode5.Name = "nodLife"
        TreeNode5.SelectedImageIndex = 1
        TreeNode5.Text = "LEADERS"
        TreeNode6.Name = "Node1"
        TreeNode6.Text = "GREECE"
        Me.treeGreece.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6})
        Me.treeGreece.SelectedImageIndex = 0
        Me.treeGreece.Size = New System.Drawing.Size(818, 206)
        Me.treeGreece.TabIndex = 1
        '
        'imgGreece
        '
        Me.imgGreece.ImageStream = CType(resources.GetObject("imgGreece.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgGreece.TransparentColor = System.Drawing.Color.Transparent
        Me.imgGreece.Images.SetKeyName(0, "Greece.jpg")
        Me.imgGreece.Images.SetKeyName(1, "Greek Leaders.jpg")
        Me.imgGreece.Images.SetKeyName(2, "greek lifestyle.jpg")
        '
        'frmClassical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.treeGreece)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frmClassical"
        Me.Text = "frmClassical"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents imgRome As ImageList
    Friend WithEvents treeGreece As TreeView
    Friend WithEvents imgGreece As ImageList
End Class
