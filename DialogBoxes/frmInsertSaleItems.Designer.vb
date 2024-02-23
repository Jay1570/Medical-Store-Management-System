<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertSaleItems
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        cmbProducts = New ComboBox()
        Label2 = New Label()
        lblQuantity = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        btnUpdate = New Button()
        Label4 = New Label()
        lblTotalAmount = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(455, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(561, 495)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 25)
        Label1.TabIndex = 1
        Label1.Text = "Product Name"
        ' 
        ' cmbProducts
        ' 
        cmbProducts.FormattingEnabled = True
        cmbProducts.Location = New Point(238, 61)
        cmbProducts.Name = "cmbProducts"
        cmbProducts.Size = New Size(182, 33)
        cmbProducts.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 25)
        Label2.TabIndex = 3
        Label2.Text = "Quantity Available"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(238, 148)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(0, 25)
        lblQuantity.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 5
        Label3.Text = "Quantity"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(238, 231)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 31)
        TextBox1.TabIndex = 6
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(27, 416)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 40)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(167, 416)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(112, 40)
        btnRemove.TabIndex = 8
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(307, 416)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 40)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 325)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 25)
        Label4.TabIndex = 10
        Label4.Text = "Total Amount"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(238, 325)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(0, 25)
        lblTotalAmount.TabIndex = 11
        ' 
        ' frmInsertSaleItems
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1028, 552)
        Controls.Add(lblTotalAmount)
        Controls.Add(Label4)
        Controls.Add(btnUpdate)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(lblQuantity)
        Controls.Add(Label2)
        Controls.Add(cmbProducts)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "frmInsertSaleItems"
        Text = "Insert Bill Details"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProducts As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalAmount As Label
End Class
