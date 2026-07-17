' VB.NET twin of Source\Krypton Docking Examples\External Drag To Docking\ContentTreeView.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContentTreeView
    Inherits System.Windows.Forms.UserControl

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Document")
        Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Property Grid")
        Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Input Form")
        Me.treeView1 = New ExternalDragToDocking.DraggableTreeView()
        Me.SuspendLayout()
        Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView1.Form1 = Nothing
        Me.treeView1.Location = New System.Drawing.Point(0, 0)
        Me.treeView1.Name = "treeView1"
        treeNode1.Name = "Document"
        treeNode1.Text = "Document"
        treeNode2.Name = "Property Grid"
        treeNode2.Text = "Property Grid"
        treeNode3.Name = "Input Form"
        treeNode3.Text = "Input Form"
        Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode3})
        Me.treeView1.Size = New System.Drawing.Size(150, 150)
        Me.treeView1.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.treeView1)
        Me.Name = "ContentTreeView"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents treeView1 As DraggableTreeView
End Class
