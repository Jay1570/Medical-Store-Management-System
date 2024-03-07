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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Product_Name = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Total_Amount = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        cmbProducts = New ComboBox()
        Label2 = New Label()
        lblQuantity = New Label()
        Label3 = New Label()
        txtQuantity = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        Label4 = New Label()
        lblTotalAmount = New Label()
        btnPrint = New Button()
        btnCancel = New Button()
        Label5 = New Label()
        lblPrice = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Red
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.Red
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Product_Name, Quantity, Price, Total_Amount})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.Red
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(455, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(672, 513)
        DataGridView1.TabIndex = 0
        ' 
        ' Product_Name
        ' 
        Product_Name.HeaderText = "Product Name"
        Product_Name.MinimumWidth = 8
        Product_Name.Name = "Product_Name"
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.MinimumWidth = 8
        Quantity.Name = "Quantity"
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.MinimumWidth = 8
        Price.Name = "Price"
        ' 
        ' Total_Amount
        ' 
        Total_Amount.HeaderText = "Total Amount"
        Total_Amount.MinimumWidth = 8
        Total_Amount.Name = "Total_Amount"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 25)
        Label1.TabIndex = 1
        Label1.Text = "Product Name"
        ' 
        ' cmbProducts
        ' 
        cmbProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbProducts.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbProducts.FormattingEnabled = True
        cmbProducts.Location = New Point(237, 32)
        cmbProducts.Name = "cmbProducts"
        cmbProducts.Size = New Size(182, 33)
        cmbProducts.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 25)
        Label2.TabIndex = 3
        Label2.Text = "Quantity Available"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Location = New Point(237, 105)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(182, 31)
        lblQuantity.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 5
        Label3.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(237, 171)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(182, 31)
        txtQuantity.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(89, 416)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 40)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(238, 416)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(112, 40)
        btnRemove.TabIndex = 6
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 25)
        Label4.TabIndex = 10
        Label4.Text = "Total Amount"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.Location = New Point(237, 302)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(182, 31)
        lblTotalAmount.TabIndex = 11
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(89, 485)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(112, 40)
        btnPrint.TabIndex = 7
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(238, 485)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 40)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 25)
        Label5.TabIndex = 14
        Label5.Text = "Price"
        ' 
        ' lblPrice
        ' 
        lblPrice.Location = New Point(237, 234)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(182, 31)
        lblPrice.TabIndex = 15
        ' 
        ' frmInsertSaleItems
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1139, 543)
        Controls.Add(lblPrice)
        Controls.Add(Label5)
        Controls.Add(btnCancel)
        Controls.Add(btnPrint)
        Controls.Add(lblTotalAmount)
        Controls.Add(Label4)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(txtQuantity)
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
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Total_Amount As DataGridViewTextBoxColumn
End Class
