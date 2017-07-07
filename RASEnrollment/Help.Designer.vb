<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logging in")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Creating a School Year")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Setting up the System", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Year")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sections")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Subjects")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fees")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Year Records", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Teachers")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rooms")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Discounts")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Refunds")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Requirements")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maintenance", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registration")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Assessment")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grades")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accounts")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Website Maintenance")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Others", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(1, 28)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node29"
        TreeNode1.Text = "Logging in"
        TreeNode2.Name = "Node30"
        TreeNode2.Text = "Creating a School Year"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "Setting up the System"
        TreeNode4.Name = "Node40"
        TreeNode4.Text = "Year"
        TreeNode5.Name = "Node41"
        TreeNode5.Text = "Sections"
        TreeNode6.Name = "Node43"
        TreeNode6.Text = "Subjects"
        TreeNode7.Name = "Node44"
        TreeNode7.Text = "Fees"
        TreeNode8.Name = "Node36"
        TreeNode8.Text = "Year Records"
        TreeNode9.Name = "Node37"
        TreeNode9.Text = "Teachers"
        TreeNode10.Name = "Node38"
        TreeNode10.Text = "Rooms"
        TreeNode11.Name = "Node39"
        TreeNode11.Text = "Discounts"
        TreeNode12.Name = "Node45"
        TreeNode12.Text = "Refunds"
        TreeNode13.Name = "Node46"
        TreeNode13.Text = "Requirements"
        TreeNode14.Name = "Node1"
        TreeNode14.Text = "Maintenance"
        TreeNode15.Name = "Node47"
        TreeNode15.Text = "Registration"
        TreeNode16.Name = "Node48"
        TreeNode16.Text = "Assessment"
        TreeNode17.Name = "Node49"
        TreeNode17.Text = "Payment"
        TreeNode18.Name = "Node2"
        TreeNode18.Text = "Transaction"
        TreeNode19.Name = "Node33"
        TreeNode19.Text = "Grades"
        TreeNode20.Name = "Node34"
        TreeNode20.Text = "Accounts"
        TreeNode21.Name = "Node35"
        TreeNode21.Text = "Website Maintenance"
        TreeNode22.Name = "Node32"
        TreeNode22.Text = "Others"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode14, TreeNode18, TreeNode22})
        Me.TreeView1.Size = New System.Drawing.Size(166, 401)
        Me.TreeView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(173, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 401)
        Me.Panel1.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(632, 395)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 433)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
