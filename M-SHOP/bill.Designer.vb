<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bill))
        Me.stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New M_SHOP.StockDataSet()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tdate = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Ttax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tbillno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tdisc = New System.Windows.Forms.TextBox()
        Me.Tptype = New System.Windows.Forms.TextBox()
        Me.Ttotal = New System.Windows.Forms.TextBox()
        Me.Tpname = New System.Windows.Forms.TextBox()
        Me.Tbname = New System.Windows.Forms.TextBox()
        Me.Tprice = New System.Windows.Forms.TextBox()
        Me.Tqty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.stockTableAdapter = New M_SHOP.StockDataSetTableAdapters.stockTableAdapter()
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stockBindingSource
        '
        Me.stockBindingSource.DataMember = "stock"
        Me.stockBindingSource.DataSource = Me.StockDataSet
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btnprint
        '
        Me.Btnprint.Location = New System.Drawing.Point(333, 455)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(75, 23)
        Me.Btnprint.TabIndex = 13
        Me.Btnprint.Text = "Print"
        Me.Btnprint.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Tdate)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Ttax)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Tbillno)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Tdisc)
        Me.Panel1.Controls.Add(Me.Tptype)
        Me.Panel1.Controls.Add(Me.Ttotal)
        Me.Panel1.Controls.Add(Me.Tpname)
        Me.Panel1.Controls.Add(Me.Tbname)
        Me.Panel1.Controls.Add(Me.Tprice)
        Me.Panel1.Controls.Add(Me.Tqty)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(143, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 420)
        Me.Panel1.TabIndex = 14
        '
        'Tdate
        '
        Me.Tdate.AutoCompleteCustomSource.AddRange(New String() {"Mobile Phones", "Battery", "Charger", "Sim Cards", "Mobile Accessories"})
        Me.Tdate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tdate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Tdate.Location = New System.Drawing.Point(158, 63)
        Me.Tdate.Name = "Tdate"
        Me.Tdate.Size = New System.Drawing.Size(168, 20)
        Me.Tdate.TabIndex = 44
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(158, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 43
        '
        'Ttax
        '
        Me.Ttax.Location = New System.Drawing.Point(158, 306)
        Me.Ttax.Name = "Ttax"
        Me.Ttax.Size = New System.Drawing.Size(168, 20)
        Me.Ttax.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(109, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Tax : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(104, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Date : "
        '
        'Tbillno
        '
        Me.Tbillno.AutoCompleteCustomSource.AddRange(New String() {"Mobile Phones", "Battery", "Charger", "Sim Cards", "Mobile Accessories"})
        Me.Tbillno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tbillno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Tbillno.Location = New System.Drawing.Point(158, 22)
        Me.Tbillno.Name = "Tbillno"
        Me.Tbillno.Size = New System.Drawing.Size(168, 20)
        Me.Tbillno.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Bill No : "
        '
        'Tdisc
        '
        Me.Tdisc.Location = New System.Drawing.Point(158, 336)
        Me.Tdisc.Name = "Tdisc"
        Me.Tdisc.Size = New System.Drawing.Size(168, 20)
        Me.Tdisc.TabIndex = 36
        '
        'Tptype
        '
        Me.Tptype.AutoCompleteCustomSource.AddRange(New String() {"Mobile Phones", "Battery", "Charger", "Sim Cards", "Mobile Accessories"})
        Me.Tptype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tptype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Tptype.Location = New System.Drawing.Point(158, 99)
        Me.Tptype.Name = "Tptype"
        Me.Tptype.Size = New System.Drawing.Size(168, 20)
        Me.Tptype.TabIndex = 30
        '
        'Ttotal
        '
        Me.Ttotal.Location = New System.Drawing.Point(158, 377)
        Me.Ttotal.Name = "Ttotal"
        Me.Ttotal.Size = New System.Drawing.Size(168, 20)
        Me.Ttotal.TabIndex = 33
        '
        'Tpname
        '
        Me.Tpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.Tpname.Location = New System.Drawing.Point(158, 180)
        Me.Tpname.Name = "Tpname"
        Me.Tpname.Size = New System.Drawing.Size(168, 20)
        Me.Tpname.TabIndex = 28
        '
        'Tbname
        '
        Me.Tbname.AutoCompleteCustomSource.AddRange(New String() {"Karbon", "Nokia", "Sony", "Samsung", "Htc", "Apple", "MicroMax"})
        Me.Tbname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tbname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Tbname.Location = New System.Drawing.Point(158, 139)
        Me.Tbname.Name = "Tbname"
        Me.Tbname.Size = New System.Drawing.Size(168, 20)
        Me.Tbname.TabIndex = 29
        '
        'Tprice
        '
        Me.Tprice.Location = New System.Drawing.Point(158, 271)
        Me.Tprice.Name = "Tprice"
        Me.Tprice.Size = New System.Drawing.Size(168, 20)
        Me.Tprice.TabIndex = 32
        '
        'Tqty
        '
        Me.Tqty.Location = New System.Drawing.Point(158, 224)
        Me.Tqty.Name = "Tqty"
        Me.Tqty.Size = New System.Drawing.Size(168, 20)
        Me.Tqty.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Discount : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Product Name: : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Brand Name : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Quantity : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Product Type: : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Price : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Total Amount  : "
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "acer.png")
        Me.ImageList1.Images.SetKeyName(1, "apple.gif")
        Me.ImageList1.Images.SetKeyName(2, "asus.gif")
        Me.ImageList1.Images.SetKeyName(3, "berry.gif")
        Me.ImageList1.Images.SetKeyName(4, "celkon.gif")
        Me.ImageList1.Images.SetKeyName(5, "dell.gif")
        Me.ImageList1.Images.SetKeyName(6, "ericson.gif")
        Me.ImageList1.Images.SetKeyName(7, "gionee.gif")
        Me.ImageList1.Images.SetKeyName(8, "hp.gif")
        Me.ImageList1.Images.SetKeyName(9, "htc.gif")
        Me.ImageList1.Images.SetKeyName(10, "huawei.gif")
        Me.ImageList1.Images.SetKeyName(11, "karbonn.gif")
        Me.ImageList1.Images.SetKeyName(12, "lava.gif")
        Me.ImageList1.Images.SetKeyName(13, "lenovo.gif")
        Me.ImageList1.Images.SetKeyName(14, "lg.gif")
        Me.ImageList1.Images.SetKeyName(15, "micromax.gif")
        Me.ImageList1.Images.SetKeyName(16, "motorola.gif")
        Me.ImageList1.Images.SetKeyName(17, "nokia.gif")
        Me.ImageList1.Images.SetKeyName(18, "orange.gif")
        Me.ImageList1.Images.SetKeyName(19, "panasonic.gif")
        Me.ImageList1.Images.SetKeyName(20, "samsung.gif")
        Me.ImageList1.Images.SetKeyName(21, "sony.gif")
        Me.ImageList1.Images.SetKeyName(22, "sonyerricson.gif")
        Me.ImageList1.Images.SetKeyName(23, "spice.gif")
        Me.ImageList1.Images.SetKeyName(24, "toshiba.gif")
        Me.ImageList1.Images.SetKeyName(25, "xolo.gif")
        Me.ImageList1.Images.SetKeyName(26, "zte.gif")
        '
        'stockTableAdapter
        '
        Me.stockTableAdapter.ClearBeforeFill = True
        '
        'bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 490)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btnprint)
        Me.Name = "bill"
        Me.Text = "Bill"
        CType(Me.stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnprint As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Ttax As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tbillno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tdisc As System.Windows.Forms.TextBox
    Friend WithEvents Tptype As System.Windows.Forms.TextBox
    Friend WithEvents Ttotal As System.Windows.Forms.TextBox
    Friend WithEvents Tpname As System.Windows.Forms.TextBox
    Friend WithEvents Tbname As System.Windows.Forms.TextBox
    Friend WithEvents Tprice As System.Windows.Forms.TextBox
    Friend WithEvents Tqty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Tdate As System.Windows.Forms.TextBox
    Friend WithEvents stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataSet As M_SHOP.StockDataSet
    Friend WithEvents stockTableAdapter As M_SHOP.StockDataSetTableAdapters.stockTableAdapter
End Class
