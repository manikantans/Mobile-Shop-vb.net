<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Tabother = New System.Windows.Forms.TabPage()
        Me.Tabstock = New System.Windows.Forms.TabPage()
        Me.Combostockbrname = New System.Windows.Forms.ComboBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Btnstocksearch = New System.Windows.Forms.Button()
        Me.Btnstockupdate = New System.Windows.Forms.Button()
        Me.dtg1 = New System.Windows.Forms.DataGridView()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New M_SHOP.StockDataSet()
        Me.Btnnewstock = New System.Windows.Forms.Button()
        Me.Txtsptype = New System.Windows.Forms.TextBox()
        Me.Txtspname = New System.Windows.Forms.TextBox()
        Me.TXtsbrname = New System.Windows.Forms.TextBox()
        Me.Txtsprice = New System.Windows.Forms.TextBox()
        Me.Txtsqty = New System.Windows.Forms.TextBox()
        Me.Lblspname = New System.Windows.Forms.Label()
        Me.Lsbrname = New System.Windows.Forms.Label()
        Me.Lsqty = New System.Windows.Forms.Label()
        Me.Lsptype = New System.Windows.Forms.Label()
        Me.Lsprice = New System.Windows.Forms.Label()
        Me.Tabservice = New System.Windows.Forms.TabPage()
        Me.Btnservprint = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Txtservcharge = New System.Windows.Forms.TextBox()
        Me.LTamt = New System.Windows.Forms.Label()
        Me.LRepcharge = New System.Windows.Forms.Label()
        Me.Dduedate = New System.Windows.Forms.DateTimePicker()
        Me.Dcdate = New System.Windows.Forms.DateTimePicker()
        Me.LSerCharge = New System.Windows.Forms.Label()
        Me.LCdate = New System.Windows.Forms.Label()
        Me.Comboitemret = New System.Windows.Forms.ComboBox()
        Me.Combowarr = New System.Windows.Forms.ComboBox()
        Me.LProName = New System.Windows.Forms.Label()
        Me.LWarranty = New System.Windows.Forms.Label()
        Me.LReturned = New System.Windows.Forms.Label()
        Me.LRepairs = New System.Windows.Forms.Label()
        Me.LDue = New System.Windows.Forms.Label()
        Me.Lservicecode = New System.Windows.Forms.Label()
        Me.Txtrepairs = New System.Windows.Forms.TextBox()
        Me.Txtrepcharge = New System.Windows.Forms.TextBox()
        Me.Txtserpname = New System.Windows.Forms.TextBox()
        Me.Txtservcode = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tabsales = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Btnbill = New System.Windows.Forms.Button()
        Me.Ltotalamt = New System.Windows.Forms.Label()
        Me.Lprice = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.TXtbrname = New System.Windows.Forms.TextBox()
        Me.Lptype = New System.Windows.Forms.Label()
        Me.Combopname = New System.Windows.Forms.ComboBox()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Texttax = New System.Windows.Forms.TextBox()
        Me.Lqty = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lblptype = New System.Windows.Forms.Label()
        Me.Labeltax = New System.Windows.Forms.Label()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.ldate = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Labeldate = New System.Windows.Forms.Label()
        Me.Lbrname = New System.Windows.Forms.Label()
        Me.dtpsale = New System.Windows.Forms.DateTimePicker()
        Me.Lblpname = New System.Windows.Forms.Label()
        Me.Txtbillno = New System.Windows.Forms.TextBox()
        Me.lblbrname = New System.Windows.Forms.Label()
        Me.Lbillno = New System.Windows.Forms.Label()
        Me.Lpname = New System.Windows.Forms.Label()
        Me.Labelbillno = New System.Windows.Forms.Label()
        Me.Labeldisc = New System.Windows.Forms.Label()
        Me.Textdisc = New System.Windows.Forms.TextBox()
        Me.Lbldisc = New System.Windows.Forms.Label()
        Me.Textprotype = New System.Windows.Forms.TextBox()
        Me.Textqty = New System.Windows.Forms.TextBox()
        Me.Texttotal = New System.Windows.Forms.TextBox()
        Me.Textprice = New System.Windows.Forms.TextBox()
        Me.Txtpname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.popup = New System.Windows.Forms.Label()
        Me.Comstock = New System.Windows.Forms.ComboBox()
        Me.Textstockinfo = New System.Windows.Forms.TextBox()
        Me.Labelstatus = New System.Windows.Forms.Label()
        Me.Labelstockstatus = New System.Windows.Forms.Label()
        Me.MobileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet1 = New M_SHOP.StockDataSet1()
        Me.Tabfile = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabFORFORM = New System.Windows.Forms.TabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StockTableAdapter = New M_SHOP.StockDataSetTableAdapters.stockTableAdapter()
        Me.MobileTableAdapter = New M_SHOP.StockDataSet1TableAdapters.mobileTableAdapter()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txttotalamt = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txpalte = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtfad = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtono = New System.Windows.Forms.TextBox()
        Me.txtitype = New System.Windows.Forms.TextBox()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.txtad = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Tabstock.SuspendLayout()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabservice.SuspendLayout()
        Me.Tabsales.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MobileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabfile.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFORFORM.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabother
        '
        Me.Tabother.Location = New System.Drawing.Point(4, 25)
        Me.Tabother.Name = "Tabother"
        Me.Tabother.Size = New System.Drawing.Size(877, 519)
        Me.Tabother.TabIndex = 5
        Me.Tabother.Text = "  Other Services  "
        Me.Tabother.UseVisualStyleBackColor = True
        '
        'Tabstock
        '
        Me.Tabstock.Controls.Add(Me.Combostockbrname)
        Me.Tabstock.Controls.Add(Me.btnadd)
        Me.Tabstock.Controls.Add(Me.Btnstocksearch)
        Me.Tabstock.Controls.Add(Me.Btnstockupdate)
        Me.Tabstock.Controls.Add(Me.dtg1)
        Me.Tabstock.Controls.Add(Me.Btnnewstock)
        Me.Tabstock.Controls.Add(Me.Txtsptype)
        Me.Tabstock.Controls.Add(Me.Txtspname)
        Me.Tabstock.Controls.Add(Me.TXtsbrname)
        Me.Tabstock.Controls.Add(Me.Txtsprice)
        Me.Tabstock.Controls.Add(Me.Txtsqty)
        Me.Tabstock.Controls.Add(Me.Lblspname)
        Me.Tabstock.Controls.Add(Me.Lsbrname)
        Me.Tabstock.Controls.Add(Me.Lsqty)
        Me.Tabstock.Controls.Add(Me.Lsptype)
        Me.Tabstock.Controls.Add(Me.Lsprice)
        Me.Tabstock.Location = New System.Drawing.Point(4, 25)
        Me.Tabstock.Name = "Tabstock"
        Me.Tabstock.Size = New System.Drawing.Size(877, 519)
        Me.Tabstock.TabIndex = 3
        Me.Tabstock.Text = "     Stock    "
        Me.Tabstock.UseVisualStyleBackColor = True
        '
        'Combostockbrname
        '
        Me.Combostockbrname.FormattingEnabled = True
        Me.Combostockbrname.Location = New System.Drawing.Point(294, 11)
        Me.Combostockbrname.Name = "Combostockbrname"
        Me.Combostockbrname.Size = New System.Drawing.Size(168, 21)
        Me.Combostockbrname.TabIndex = 38
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(109, 313)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(184, 23)
        Me.btnadd.TabIndex = 37
        Me.btnadd.Text = "Add Stock"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Btnstocksearch
        '
        Me.Btnstocksearch.Location = New System.Drawing.Point(325, 294)
        Me.Btnstocksearch.Name = "Btnstocksearch"
        Me.Btnstocksearch.Size = New System.Drawing.Size(75, 23)
        Me.Btnstocksearch.TabIndex = 36
        Me.Btnstocksearch.Text = "Search"
        Me.Btnstocksearch.UseVisualStyleBackColor = True
        '
        'Btnstockupdate
        '
        Me.Btnstockupdate.Location = New System.Drawing.Point(198, 270)
        Me.Btnstockupdate.Name = "Btnstockupdate"
        Me.Btnstockupdate.Size = New System.Drawing.Size(95, 23)
        Me.Btnstockupdate.TabIndex = 35
        Me.Btnstockupdate.Text = "Update Stock"
        Me.Btnstockupdate.UseVisualStyleBackColor = True
        '
        'dtg1
        '
        Me.dtg1.AllowUserToOrderColumns = True
        Me.dtg1.AutoGenerateColumns = False
        Me.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductDataGridViewTextBoxColumn, Me.PnameDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.dtg1.DataSource = Me.StockBindingSource
        Me.dtg1.Location = New System.Drawing.Point(325, 38)
        Me.dtg1.Name = "dtg1"
        Me.dtg1.Size = New System.Drawing.Size(543, 236)
        Me.dtg1.TabIndex = 34
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "product"
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "product"
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        '
        'PnameDataGridViewTextBoxColumn
        '
        Me.PnameDataGridViewTextBoxColumn.DataPropertyName = "pname"
        Me.PnameDataGridViewTextBoxColumn.HeaderText = "pname"
        Me.PnameDataGridViewTextBoxColumn.Name = "PnameDataGridViewTextBoxColumn"
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "brand"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.StockDataSet
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btnnewstock
        '
        Me.Btnnewstock.Location = New System.Drawing.Point(109, 269)
        Me.Btnnewstock.Name = "Btnnewstock"
        Me.Btnnewstock.Size = New System.Drawing.Size(75, 23)
        Me.Btnnewstock.TabIndex = 33
        Me.Btnnewstock.Text = "New Stock"
        Me.Btnnewstock.UseVisualStyleBackColor = True
        '
        'Txtsptype
        '
        Me.Txtsptype.AutoCompleteCustomSource.AddRange(New String() {"Mobile Phones", "Battery", "Charger", "Sim Cards", "Mobile Accessories"})
        Me.Txtsptype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtsptype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txtsptype.Location = New System.Drawing.Point(109, 45)
        Me.Txtsptype.Name = "Txtsptype"
        Me.Txtsptype.Size = New System.Drawing.Size(168, 20)
        Me.Txtsptype.TabIndex = 28
        '
        'Txtspname
        '
        Me.Txtspname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtspname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.Txtspname.Location = New System.Drawing.Point(109, 120)
        Me.Txtspname.Name = "Txtspname"
        Me.Txtspname.Size = New System.Drawing.Size(168, 20)
        Me.Txtspname.TabIndex = 26
        '
        'TXtsbrname
        '
        Me.TXtsbrname.AutoCompleteCustomSource.AddRange(New String() {"Karbon", "Nokia", "Sony", "Samsung", "Htc", "Apple", "MicroMax"})
        Me.TXtsbrname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXtsbrname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXtsbrname.Location = New System.Drawing.Point(109, 83)
        Me.TXtsbrname.Name = "TXtsbrname"
        Me.TXtsbrname.Size = New System.Drawing.Size(168, 20)
        Me.TXtsbrname.TabIndex = 27
        '
        'Txtsprice
        '
        Me.Txtsprice.Location = New System.Drawing.Point(109, 161)
        Me.Txtsprice.Name = "Txtsprice"
        Me.Txtsprice.Size = New System.Drawing.Size(168, 20)
        Me.Txtsprice.TabIndex = 30
        '
        'Txtsqty
        '
        Me.Txtsqty.Location = New System.Drawing.Point(109, 207)
        Me.Txtsqty.Name = "Txtsqty"
        Me.Txtsqty.Size = New System.Drawing.Size(168, 20)
        Me.Txtsqty.TabIndex = 29
        '
        'Lblspname
        '
        Me.Lblspname.AutoSize = True
        Me.Lblspname.Location = New System.Drawing.Point(19, 123)
        Me.Lblspname.Name = "Lblspname"
        Me.Lblspname.Size = New System.Drawing.Size(84, 13)
        Me.Lblspname.TabIndex = 21
        Me.Lblspname.Text = "Product Name : "
        '
        'Lsbrname
        '
        Me.Lsbrname.AutoSize = True
        Me.Lsbrname.Location = New System.Drawing.Point(31, 86)
        Me.Lsbrname.Name = "Lsbrname"
        Me.Lsbrname.Size = New System.Drawing.Size(75, 13)
        Me.Lsbrname.TabIndex = 22
        Me.Lsbrname.Text = "Brand Name : "
        '
        'Lsqty
        '
        Me.Lsqty.AutoSize = True
        Me.Lsqty.Location = New System.Drawing.Point(48, 210)
        Me.Lsqty.Name = "Lsqty"
        Me.Lsqty.Size = New System.Drawing.Size(55, 13)
        Me.Lsqty.TabIndex = 23
        Me.Lsqty.Text = "Quantity : "
        '
        'Lsptype
        '
        Me.Lsptype.AutoSize = True
        Me.Lsptype.Location = New System.Drawing.Point(26, 45)
        Me.Lsptype.Name = "Lsptype"
        Me.Lsptype.Size = New System.Drawing.Size(77, 13)
        Me.Lsptype.TabIndex = 25
        Me.Lsptype.Text = "Product Type: "
        '
        'Lsprice
        '
        Me.Lsprice.AutoSize = True
        Me.Lsprice.Location = New System.Drawing.Point(63, 168)
        Me.Lsprice.Name = "Lsprice"
        Me.Lsprice.Size = New System.Drawing.Size(40, 13)
        Me.Lsprice.TabIndex = 24
        Me.Lsprice.Text = "Price : "
        '
        'Tabservice
        '
        Me.Tabservice.Controls.Add(Me.Btnservprint)
        Me.Tabservice.Controls.Add(Me.TextBox6)
        Me.Tabservice.Controls.Add(Me.Txtservcharge)
        Me.Tabservice.Controls.Add(Me.LTamt)
        Me.Tabservice.Controls.Add(Me.LRepcharge)
        Me.Tabservice.Controls.Add(Me.Dduedate)
        Me.Tabservice.Controls.Add(Me.Dcdate)
        Me.Tabservice.Controls.Add(Me.LSerCharge)
        Me.Tabservice.Controls.Add(Me.LCdate)
        Me.Tabservice.Controls.Add(Me.Comboitemret)
        Me.Tabservice.Controls.Add(Me.Combowarr)
        Me.Tabservice.Controls.Add(Me.LProName)
        Me.Tabservice.Controls.Add(Me.LWarranty)
        Me.Tabservice.Controls.Add(Me.LReturned)
        Me.Tabservice.Controls.Add(Me.LRepairs)
        Me.Tabservice.Controls.Add(Me.LDue)
        Me.Tabservice.Controls.Add(Me.Lservicecode)
        Me.Tabservice.Controls.Add(Me.Txtrepairs)
        Me.Tabservice.Controls.Add(Me.Txtrepcharge)
        Me.Tabservice.Controls.Add(Me.Txtserpname)
        Me.Tabservice.Controls.Add(Me.Txtservcode)
        Me.Tabservice.Controls.Add(Me.Panel3)
        Me.Tabservice.Location = New System.Drawing.Point(4, 25)
        Me.Tabservice.Name = "Tabservice"
        Me.Tabservice.Size = New System.Drawing.Size(877, 519)
        Me.Tabservice.TabIndex = 2
        Me.Tabservice.Text = "    Service    "
        Me.Tabservice.UseVisualStyleBackColor = True
        '
        'Btnservprint
        '
        Me.Btnservprint.Location = New System.Drawing.Point(193, 474)
        Me.Btnservprint.Name = "Btnservprint"
        Me.Btnservprint.Size = New System.Drawing.Size(75, 23)
        Me.Btnservprint.TabIndex = 24
        Me.Btnservprint.Text = "Print"
        Me.Btnservprint.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(174, 425)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(149, 20)
        Me.TextBox6.TabIndex = 23
        '
        'Txtservcharge
        '
        Me.Txtservcharge.Location = New System.Drawing.Point(174, 382)
        Me.Txtservcharge.Name = "Txtservcharge"
        Me.Txtservcharge.Size = New System.Drawing.Size(149, 20)
        Me.Txtservcharge.TabIndex = 22
        '
        'LTamt
        '
        Me.LTamt.AutoSize = True
        Me.LTamt.Location = New System.Drawing.Point(82, 425)
        Me.LTamt.Name = "LTamt"
        Me.LTamt.Size = New System.Drawing.Size(79, 13)
        Me.LTamt.TabIndex = 21
        Me.LTamt.Text = "Total Amount : "
        '
        'LRepcharge
        '
        Me.LRepcharge.AutoSize = True
        Me.LRepcharge.Location = New System.Drawing.Point(77, 344)
        Me.LRepcharge.Name = "LRepcharge"
        Me.LRepcharge.Size = New System.Drawing.Size(84, 13)
        Me.LRepcharge.TabIndex = 20
        Me.LRepcharge.Text = "Repair Charge : "
        '
        'Dduedate
        '
        Me.Dduedate.Location = New System.Drawing.Point(174, 299)
        Me.Dduedate.Name = "Dduedate"
        Me.Dduedate.Size = New System.Drawing.Size(148, 20)
        Me.Dduedate.TabIndex = 19
        '
        'Dcdate
        '
        Me.Dcdate.Location = New System.Drawing.Point(174, 70)
        Me.Dcdate.Name = "Dcdate"
        Me.Dcdate.Size = New System.Drawing.Size(148, 20)
        Me.Dcdate.TabIndex = 18
        '
        'LSerCharge
        '
        Me.LSerCharge.AutoSize = True
        Me.LSerCharge.Location = New System.Drawing.Point(72, 385)
        Me.LSerCharge.Name = "LSerCharge"
        Me.LSerCharge.Size = New System.Drawing.Size(89, 13)
        Me.LSerCharge.TabIndex = 17
        Me.LSerCharge.Text = "Service Charge : "
        '
        'LCdate
        '
        Me.LCdate.AutoSize = True
        Me.LCdate.Location = New System.Drawing.Point(122, 76)
        Me.LCdate.Name = "LCdate"
        Me.LCdate.Size = New System.Drawing.Size(39, 13)
        Me.LCdate.TabIndex = 16
        Me.LCdate.Text = "Date : "
        '
        'Comboitemret
        '
        Me.Comboitemret.FormattingEnabled = True
        Me.Comboitemret.Items.AddRange(New Object() {"Battery", "Memory Card", "Sim Card"})
        Me.Comboitemret.Location = New System.Drawing.Point(173, 185)
        Me.Comboitemret.Name = "Comboitemret"
        Me.Comboitemret.Size = New System.Drawing.Size(149, 21)
        Me.Comboitemret.TabIndex = 15
        '
        'Combowarr
        '
        Me.Combowarr.FormattingEnabled = True
        Me.Combowarr.Items.AddRange(New Object() {"YES", "NO"})
        Me.Combowarr.Location = New System.Drawing.Point(173, 144)
        Me.Combowarr.Name = "Combowarr"
        Me.Combowarr.Size = New System.Drawing.Size(149, 21)
        Me.Combowarr.TabIndex = 14
        '
        'LProName
        '
        Me.LProName.AutoSize = True
        Me.LProName.Location = New System.Drawing.Point(77, 112)
        Me.LProName.Name = "LProName"
        Me.LProName.Size = New System.Drawing.Size(84, 13)
        Me.LProName.TabIndex = 13
        Me.LProName.Text = "Product Name : "
        '
        'LWarranty
        '
        Me.LWarranty.AutoSize = True
        Me.LWarranty.Location = New System.Drawing.Point(102, 147)
        Me.LWarranty.Name = "LWarranty"
        Me.LWarranty.Size = New System.Drawing.Size(59, 13)
        Me.LWarranty.TabIndex = 12
        Me.LWarranty.Text = "Warranty : "
        '
        'LReturned
        '
        Me.LReturned.AutoSize = True
        Me.LReturned.Location = New System.Drawing.Point(73, 188)
        Me.LReturned.Name = "LReturned"
        Me.LReturned.Size = New System.Drawing.Size(88, 13)
        Me.LReturned.TabIndex = 11
        Me.LReturned.Text = "Items Returned : "
        '
        'LRepairs
        '
        Me.LRepairs.AutoSize = True
        Me.LRepairs.Location = New System.Drawing.Point(109, 233)
        Me.LRepairs.Name = "LRepairs"
        Me.LRepairs.Size = New System.Drawing.Size(52, 13)
        Me.LRepairs.TabIndex = 10
        Me.LRepairs.Text = "Repairs : "
        '
        'LDue
        '
        Me.LDue.AutoSize = True
        Me.LDue.Location = New System.Drawing.Point(99, 299)
        Me.LDue.Name = "LDue"
        Me.LDue.Size = New System.Drawing.Size(62, 13)
        Me.LDue.TabIndex = 9
        Me.LDue.Text = "Due Date : "
        '
        'Lservicecode
        '
        Me.Lservicecode.AutoSize = True
        Me.Lservicecode.Location = New System.Drawing.Point(81, 37)
        Me.Lservicecode.Name = "Lservicecode"
        Me.Lservicecode.Size = New System.Drawing.Size(80, 13)
        Me.Lservicecode.TabIndex = 8
        Me.Lservicecode.Text = "Service Code : "
        '
        'Txtrepairs
        '
        Me.Txtrepairs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtrepairs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.Txtrepairs.Location = New System.Drawing.Point(174, 230)
        Me.Txtrepairs.Multiline = True
        Me.Txtrepairs.Name = "Txtrepairs"
        Me.Txtrepairs.Size = New System.Drawing.Size(149, 52)
        Me.Txtrepairs.TabIndex = 5
        '
        'Txtrepcharge
        '
        Me.Txtrepcharge.Location = New System.Drawing.Point(173, 337)
        Me.Txtrepcharge.Name = "Txtrepcharge"
        Me.Txtrepcharge.Size = New System.Drawing.Size(150, 20)
        Me.Txtrepcharge.TabIndex = 3
        '
        'Txtserpname
        '
        Me.Txtserpname.Location = New System.Drawing.Point(174, 109)
        Me.Txtserpname.Name = "Txtserpname"
        Me.Txtserpname.Size = New System.Drawing.Size(149, 20)
        Me.Txtserpname.TabIndex = 2
        '
        'Txtservcode
        '
        Me.Txtservcode.Location = New System.Drawing.Point(174, 34)
        Me.Txtservcode.Name = "Txtservcode"
        Me.Txtservcode.Size = New System.Drawing.Size(149, 20)
        Me.Txtservcode.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(550, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 375)
        Me.Panel3.TabIndex = 0
        '
        'Tabsales
        '
        Me.Tabsales.BackColor = System.Drawing.Color.CadetBlue
        Me.Tabsales.Controls.Add(Me.Panel4)
        Me.Tabsales.Controls.Add(Me.Panel1)
        Me.Tabsales.Location = New System.Drawing.Point(4, 25)
        Me.Tabsales.Name = "Tabsales"
        Me.Tabsales.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabsales.Size = New System.Drawing.Size(877, 519)
        Me.Tabsales.TabIndex = 1
        Me.Tabsales.Text = "        Sales      "
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.Btnbill)
        Me.Panel4.Controls.Add(Me.Ltotalamt)
        Me.Panel4.Controls.Add(Me.Lprice)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.Lbltotal)
        Me.Panel4.Controls.Add(Me.TXtbrname)
        Me.Panel4.Controls.Add(Me.Lptype)
        Me.Panel4.Controls.Add(Me.Combopname)
        Me.Panel4.Controls.Add(Me.lblprice)
        Me.Panel4.Controls.Add(Me.Texttax)
        Me.Panel4.Controls.Add(Me.Lqty)
        Me.Panel4.Controls.Add(Me.lbltax)
        Me.Panel4.Controls.Add(Me.lblptype)
        Me.Panel4.Controls.Add(Me.Labeltax)
        Me.Panel4.Controls.Add(Me.Btnprint)
        Me.Panel4.Controls.Add(Me.ldate)
        Me.Panel4.Controls.Add(Me.lblqty)
        Me.Panel4.Controls.Add(Me.Labeldate)
        Me.Panel4.Controls.Add(Me.Lbrname)
        Me.Panel4.Controls.Add(Me.dtpsale)
        Me.Panel4.Controls.Add(Me.Lblpname)
        Me.Panel4.Controls.Add(Me.Txtbillno)
        Me.Panel4.Controls.Add(Me.lblbrname)
        Me.Panel4.Controls.Add(Me.Lbillno)
        Me.Panel4.Controls.Add(Me.Lpname)
        Me.Panel4.Controls.Add(Me.Labelbillno)
        Me.Panel4.Controls.Add(Me.Labeldisc)
        Me.Panel4.Controls.Add(Me.Textdisc)
        Me.Panel4.Controls.Add(Me.Lbldisc)
        Me.Panel4.Controls.Add(Me.Textprotype)
        Me.Panel4.Controls.Add(Me.Textqty)
        Me.Panel4.Controls.Add(Me.Texttotal)
        Me.Panel4.Controls.Add(Me.Textprice)
        Me.Panel4.Controls.Add(Me.Txtpname)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(393, 513)
        Me.Panel4.TabIndex = 26
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StockBindingSource, "pname", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(111, 254)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 24
        '
        'Btnbill
        '
        Me.Btnbill.Location = New System.Drawing.Point(111, 416)
        Me.Btnbill.Name = "Btnbill"
        Me.Btnbill.Size = New System.Drawing.Size(75, 23)
        Me.Btnbill.TabIndex = 25
        Me.Btnbill.Text = "BILL"
        Me.Btnbill.UseVisualStyleBackColor = True
        '
        'Ltotalamt
        '
        Me.Ltotalamt.AutoSize = True
        Me.Ltotalamt.Location = New System.Drawing.Point(25, 364)
        Me.Ltotalamt.Name = "Ltotalamt"
        Me.Ltotalamt.Size = New System.Drawing.Size(79, 13)
        Me.Ltotalamt.TabIndex = 4
        Me.Ltotalamt.Text = "Total Amount : "
        '
        'Lprice
        '
        Me.Lprice.AutoSize = True
        Me.Lprice.Location = New System.Drawing.Point(65, 258)
        Me.Lprice.Name = "Lprice"
        Me.Lprice.Size = New System.Drawing.Size(40, 13)
        Me.Lprice.TabIndex = 3
        Me.Lprice.Text = "Price : "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(111, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Location = New System.Drawing.Point(25, 364)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(79, 13)
        Me.Lbltotal.TabIndex = 4
        Me.Lbltotal.Text = "Total Amount : "
        '
        'TXtbrname
        '
        Me.TXtbrname.AutoCompleteCustomSource.AddRange(New String() {"Karbon", "Nokia", "Sony", "Samsung", "Htc", "Apple", "MicroMax"})
        Me.TXtbrname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXtbrname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXtbrname.Location = New System.Drawing.Point(111, 123)
        Me.TXtbrname.Name = "TXtbrname"
        Me.TXtbrname.Size = New System.Drawing.Size(168, 20)
        Me.TXtbrname.TabIndex = 7
        '
        'Lptype
        '
        Me.Lptype.AutoSize = True
        Me.Lptype.Location = New System.Drawing.Point(28, 90)
        Me.Lptype.Name = "Lptype"
        Me.Lptype.Size = New System.Drawing.Size(77, 13)
        Me.Lptype.TabIndex = 5
        Me.Lptype.Text = "Product Type: "
        '
        'Combopname
        '
        Me.Combopname.FormattingEnabled = True
        Me.Combopname.Location = New System.Drawing.Point(111, 164)
        Me.Combopname.Name = "Combopname"
        Me.Combopname.Size = New System.Drawing.Size(168, 21)
        Me.Combopname.TabIndex = 23
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(65, 258)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(40, 13)
        Me.lblprice.TabIndex = 3
        Me.lblprice.Text = "Price : "
        '
        'Texttax
        '
        Me.Texttax.Location = New System.Drawing.Point(111, 290)
        Me.Texttax.Name = "Texttax"
        Me.Texttax.Size = New System.Drawing.Size(168, 20)
        Me.Texttax.TabIndex = 21
        '
        'Lqty
        '
        Me.Lqty.AutoSize = True
        Me.Lqty.Location = New System.Drawing.Point(50, 211)
        Me.Lqty.Name = "Lqty"
        Me.Lqty.Size = New System.Drawing.Size(55, 13)
        Me.Lqty.TabIndex = 2
        Me.Lqty.Text = "Quantity : "
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Location = New System.Drawing.Point(65, 293)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(34, 13)
        Me.lbltax.TabIndex = 20
        Me.lbltax.Text = "Tax : "
        '
        'lblptype
        '
        Me.lblptype.AutoSize = True
        Me.lblptype.Location = New System.Drawing.Point(28, 90)
        Me.lblptype.Name = "lblptype"
        Me.lblptype.Size = New System.Drawing.Size(77, 13)
        Me.lblptype.TabIndex = 5
        Me.lblptype.Text = "Product Type: "
        '
        'Labeltax
        '
        Me.Labeltax.AutoSize = True
        Me.Labeltax.Location = New System.Drawing.Point(65, 293)
        Me.Labeltax.Name = "Labeltax"
        Me.Labeltax.Size = New System.Drawing.Size(34, 13)
        Me.Labeltax.TabIndex = 20
        Me.Labeltax.Text = "Tax : "
        '
        'Btnprint
        '
        Me.Btnprint.Location = New System.Drawing.Point(203, 416)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(75, 23)
        Me.Btnprint.TabIndex = 12
        Me.Btnprint.Text = "Print"
        Me.Btnprint.UseVisualStyleBackColor = True
        '
        'ldate
        '
        Me.ldate.AutoSize = True
        Me.ldate.Location = New System.Drawing.Point(65, 54)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(39, 13)
        Me.ldate.TabIndex = 19
        Me.ldate.Text = "Date : "
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(50, 211)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(55, 13)
        Me.lblqty.TabIndex = 2
        Me.lblqty.Text = "Quantity : "
        '
        'Labeldate
        '
        Me.Labeldate.AutoSize = True
        Me.Labeldate.Location = New System.Drawing.Point(65, 54)
        Me.Labeldate.Name = "Labeldate"
        Me.Labeldate.Size = New System.Drawing.Size(39, 13)
        Me.Labeldate.TabIndex = 19
        Me.Labeldate.Text = "Date : "
        '
        'Lbrname
        '
        Me.Lbrname.AutoSize = True
        Me.Lbrname.Location = New System.Drawing.Point(33, 126)
        Me.Lbrname.Name = "Lbrname"
        Me.Lbrname.Size = New System.Drawing.Size(75, 13)
        Me.Lbrname.TabIndex = 1
        Me.Lbrname.Text = "Brand Name : "
        '
        'dtpsale
        '
        Me.dtpsale.Location = New System.Drawing.Point(111, 48)
        Me.dtpsale.Name = "dtpsale"
        Me.dtpsale.Size = New System.Drawing.Size(168, 20)
        Me.dtpsale.TabIndex = 18
        '
        'Lblpname
        '
        Me.Lblpname.AutoSize = True
        Me.Lblpname.Location = New System.Drawing.Point(21, 167)
        Me.Lblpname.Name = "Lblpname"
        Me.Lblpname.Size = New System.Drawing.Size(84, 13)
        Me.Lblpname.TabIndex = 0
        Me.Lblpname.Text = "Product Name : "
        '
        'Txtbillno
        '
        Me.Txtbillno.AutoCompleteCustomSource.AddRange(New String() {"Mobile Phones", "Battery", "Charger", "Sim Cards", "Mobile Accessories"})
        Me.Txtbillno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtbillno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txtbillno.Location = New System.Drawing.Point(111, 6)
        Me.Txtbillno.Name = "Txtbillno"
        Me.Txtbillno.Size = New System.Drawing.Size(168, 20)
        Me.Txtbillno.TabIndex = 17
        '
        'lblbrname
        '
        Me.lblbrname.AutoSize = True
        Me.lblbrname.Location = New System.Drawing.Point(31, 126)
        Me.lblbrname.Name = "lblbrname"
        Me.lblbrname.Size = New System.Drawing.Size(75, 13)
        Me.lblbrname.TabIndex = 1
        Me.lblbrname.Text = "Brand Name : "
        '
        'Lbillno
        '
        Me.Lbillno.AutoSize = True
        Me.Lbillno.Location = New System.Drawing.Point(40, 9)
        Me.Lbillno.Name = "Lbillno"
        Me.Lbillno.Size = New System.Drawing.Size(64, 13)
        Me.Lbillno.TabIndex = 16
        Me.Lbillno.Text = "Item Code : "
        '
        'Lpname
        '
        Me.Lpname.AutoSize = True
        Me.Lpname.Location = New System.Drawing.Point(21, 167)
        Me.Lpname.Name = "Lpname"
        Me.Lpname.Size = New System.Drawing.Size(84, 13)
        Me.Lpname.TabIndex = 0
        Me.Lpname.Text = "Product Name : "
        '
        'Labelbillno
        '
        Me.Labelbillno.AutoSize = True
        Me.Labelbillno.Location = New System.Drawing.Point(50, 9)
        Me.Labelbillno.Name = "Labelbillno"
        Me.Labelbillno.Size = New System.Drawing.Size(46, 13)
        Me.Labelbillno.TabIndex = 16
        Me.Labelbillno.Text = "Bill No : "
        '
        'Labeldisc
        '
        Me.Labeldisc.AutoSize = True
        Me.Labeldisc.Location = New System.Drawing.Point(47, 327)
        Me.Labeldisc.Name = "Labeldisc"
        Me.Labeldisc.Size = New System.Drawing.Size(58, 13)
        Me.Labeldisc.TabIndex = 14
        Me.Labeldisc.Text = "Discount : "
        '
        'Textdisc
        '
        Me.Textdisc.Location = New System.Drawing.Point(111, 324)
        Me.Textdisc.Name = "Textdisc"
        Me.Textdisc.Size = New System.Drawing.Size(168, 20)
        Me.Textdisc.TabIndex = 15
        '
        'Lbldisc
        '
        Me.Lbldisc.AutoSize = True
        Me.Lbldisc.Location = New System.Drawing.Point(47, 327)
        Me.Lbldisc.Name = "Lbldisc"
        Me.Lbldisc.Size = New System.Drawing.Size(58, 13)
        Me.Lbldisc.TabIndex = 14
        Me.Lbldisc.Text = "Discount : "
        '
        'Textprotype
        '
        Me.Textprotype.AutoCompleteCustomSource.AddRange(New String() {"Mobile Phones", "Battery", "Charger", "Sim Cards", "Mobile Accessories"})
        Me.Textprotype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Textprotype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Textprotype.Location = New System.Drawing.Point(111, 87)
        Me.Textprotype.Name = "Textprotype"
        Me.Textprotype.Size = New System.Drawing.Size(168, 20)
        Me.Textprotype.TabIndex = 8
        '
        'Textqty
        '
        Me.Textqty.Location = New System.Drawing.Point(111, 208)
        Me.Textqty.Name = "Textqty"
        Me.Textqty.Size = New System.Drawing.Size(168, 20)
        Me.Textqty.TabIndex = 9
        '
        'Texttotal
        '
        Me.Texttotal.Location = New System.Drawing.Point(110, 361)
        Me.Texttotal.Name = "Texttotal"
        Me.Texttotal.ReadOnly = True
        Me.Texttotal.Size = New System.Drawing.Size(169, 20)
        Me.Texttotal.TabIndex = 11
        '
        'Textprice
        '
        Me.Textprice.Location = New System.Drawing.Point(111, 255)
        Me.Textprice.Name = "Textprice"
        Me.Textprice.Size = New System.Drawing.Size(168, 20)
        Me.Textprice.TabIndex = 10
        '
        'Txtpname
        '
        Me.Txtpname.AutoCompleteCustomSource.AddRange(New String() {"225", "225 Dual SIM", "Lumia 930", "Lumia 635", "Lumia 630 Dual SIM", "Lumia 630", "XL", "X+", "X", "Asha 230", "220", "Lumia Icon", "Lumia 525", "Lumia 1520 ", "Lumia 1320", "Lumia 2520", "Asha 503 Dual SIM", "Asha 503", "Asha 502 Dual SIM", "Asha 500 Dual SIM", "Asha 500", "108 Dual SIM", "515", "107 Dual SIM", "106", "Lumia 625", "Lumia 1020", "208", "207", "Lumia 925", "Lumia 928", "Asha 501", "Asha 210", "Lumia 720", "Lumia 520", "301", "105", "Asha 310", "Lumia 505", "Lumia 620", "114", "206", "Asha 205", "109", "Lumia 822", "Lumia 510", "Lumia 810", "Asha 309", "Asha 308", "Lumia 920", "Lumia 820", "Asha 311", "Asha 306", "Asha 305", "113", "112", "111", "110", "Lumia 610 NFC", "103", "808 PureView", "800c", "Lumia 610", "Asha 302", "Asha 203", "Asha 202", "Lumia 900", "Lumia 900 AT&T", "801T", "X2-02", "Lumia 800", "Lumia 710 T-Mobile", "Lumia 710", "Asha 303", "Asha 300", "Asha 201", "Asha 200", "603", "C2-05", "X2-05", "C5-06", "C5-05", "C5-04", "101", "100", "701", "700", "600", "C3-01 Gold Edition", "500", "N9", "C5 5MP", "C2-06", "C2-03", "C2-02", "702T", "T7", "N950", "Oro", "X1-01", "X7-00", "E6", "C7 Astound", "X1-00", "X2-01", "C2-01", "C5-03", "E7", "C6-01", "C7", "C3-01 Touch and Type", "5250", "X3 Touch and Type S", "X3-02 Touch and Type", "X6 8GB", "X5-01", "5233", "E73 Mode", "C2-00", "C1-02", "C1-01", "C1-00", "N8", "X2-00", "C6", "E5", "C3", "C5", "C5 TD-SCDMA", "X5 TD-SCDMA", "6303i classic", "5132 XpressMusic", "X6 16GB", "2710 Navigation Edition", "X6", "6700 slide", "7230", "5330 Mobile TV Edition", "2690", "2220 slide", "1800", "1616", "1280", "5235 Comes With Music", "6788", "N97 mini", "X3", "N900", "5230", "3208c", "5800 Navigation Edition", "6350", "Mural", "6760 slide", "6790 Surge", "3720 classic", "5530 XpressMusic", "E72", "3710 fold", "6730 classic", "6600i slide", "7020", "2720 fold", "2730 classic", "E52", "6216 classic", "5730 XpressMusic", "5330 XpressMusic", "5030 XpressRadio", "N86 8MP", "E75", "E55", "6720 classic", "6710 Navigator", "5630 XpressMusic", "6700 classic", "6303 classic", "2700 classic", "6208c", "8800 Gold Arte", "N97", "6260 slide", "E63", "7100 Supernova", "5130 XpressMusic", "2330 classic", "2323 classic", "1662", "1661", "1202", "5800 XpressMusic", "N85", "N79", "8800 Carbon Arte", "3610 fold", "7610 Supernova", "7510 Supernova", "7310 Supernova", "7210 Supernova", "E71", "E66", "6600 fold", "703", "6600 slide", "3600 slide", "5320 XpressMusic", "5220 XpressMusic", "6212 classic", "5000", "7070 Prism", "2680 slide", "1680 classic", "6300i", "N96", "N78", "6220 classic", "6210 Navigator", "6124 classic", "6650 fold", "3555", "3120 classic", "7900 Crystal Prism", "2600 classic", "1209", "3110 Evolve", "N82", "8800 Sapphire Arte", "8800 Arte", "6301", "E51", "E51 camera-free", "6263", "N81 8GB", "N81", "N95 8GB", "5610 XpressMusic", "5310 XpressMusic", "6555", "7900 Prism", "7500 Prism", "8600 Luna", "6500 slide", "6500 classic", "N810", "3500 classic", "2630", "N87", "6267", "2760", "2660", "1650", "1208", "1200", "6120 classic", "6121 classic", "5700", "5070", "E90", "E65", "E61i", "N77", "6110 Navigator", "N800", "3109 classic", "3110 classic", "N76", "N93i", "6290", "6086", "6300", "2626", "N95", "N75", "5300", "5200", "6288", "6085", "8800 Sirocco", "7390", "7373", "6151", "6080", "1110i", "E50", "5500 Sport", "N93", "N73", "N72", "2610", "2310", "1112", "6136", "6133", "6131", "6126", "6070", "6125", "6103", "6233", "6234", "6282", "9300i", "N92", "N80", "N71", "7380", "7370", "7360", "E70", "E62", "E61", "E60", "3250", "6708", "6280", "6270", "6111", "6060", "N91", "N90"})
        Me.Txtpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txtpname.Location = New System.Drawing.Point(111, 164)
        Me.Txtpname.Name = "Txtpname"
        Me.Txtpname.Size = New System.Drawing.Size(168, 20)
        Me.Txtpname.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Comstock)
        Me.Panel1.Controls.Add(Me.Textstockinfo)
        Me.Panel1.Controls.Add(Me.Labelstatus)
        Me.Panel1.Controls.Add(Me.Labelstockstatus)
        Me.Panel1.Location = New System.Drawing.Point(395, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 513)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.popup)
        Me.Panel2.Location = New System.Drawing.Point(73, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 312)
        Me.Panel2.TabIndex = 6
        '
        'popup
        '
        Me.popup.AutoSize = True
        Me.popup.ForeColor = System.Drawing.Color.Maroon
        Me.popup.Location = New System.Drawing.Point(104, 0)
        Me.popup.Name = "popup"
        Me.popup.Size = New System.Drawing.Size(0, 13)
        Me.popup.TabIndex = 5
        '
        'Comstock
        '
        Me.Comstock.FormattingEnabled = True
        Me.Comstock.Location = New System.Drawing.Point(295, 18)
        Me.Comstock.Name = "Comstock"
        Me.Comstock.Size = New System.Drawing.Size(73, 21)
        Me.Comstock.TabIndex = 4
        '
        'Textstockinfo
        '
        Me.Textstockinfo.Location = New System.Drawing.Point(295, 18)
        Me.Textstockinfo.Name = "Textstockinfo"
        Me.Textstockinfo.Size = New System.Drawing.Size(58, 20)
        Me.Textstockinfo.TabIndex = 3
        '
        'Labelstatus
        '
        Me.Labelstatus.AutoSize = True
        Me.Labelstatus.Location = New System.Drawing.Point(173, 25)
        Me.Labelstatus.Name = "Labelstatus"
        Me.Labelstatus.Size = New System.Drawing.Size(13, 13)
        Me.Labelstatus.TabIndex = 2
        Me.Labelstatus.Text = ".."
        '
        'Labelstockstatus
        '
        Me.Labelstockstatus.AutoSize = True
        Me.Labelstockstatus.Location = New System.Drawing.Point(90, 25)
        Me.Labelstockstatus.Name = "Labelstockstatus"
        Me.Labelstockstatus.Size = New System.Drawing.Size(77, 13)
        Me.Labelstockstatus.TabIndex = 1
        Me.Labelstockstatus.Text = "Stock Status : "
        '
        'MobileBindingSource
        '
        Me.MobileBindingSource.DataMember = "mobile"
        Me.MobileBindingSource.DataSource = Me.StockDataSet1
        '
        'StockDataSet1
        '
        Me.StockDataSet1.DataSetName = "StockDataSet1"
        Me.StockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabfile
        '
        Me.Tabfile.BackColor = System.Drawing.Color.CadetBlue
        Me.Tabfile.Controls.Add(Me.SplitContainer1)
        Me.Tabfile.Location = New System.Drawing.Point(4, 25)
        Me.Tabfile.Name = "Tabfile"
        Me.Tabfile.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabfile.Size = New System.Drawing.Size(877, 519)
        Me.Tabfile.TabIndex = 0
        Me.Tabfile.Text = "  File  "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txttotalamt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txpalte)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtfad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtono)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtitype)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtcname)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Size = New System.Drawing.Size(871, 513)
        Me.SplitContainer1.SplitterDistance = 290
        Me.SplitContainer1.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(5, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(111, 407)
        Me.Panel5.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(3, 304)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(102, 96)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 210)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(105, 87)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'TabFORFORM
        '
        Me.TabFORFORM.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabFORFORM.Controls.Add(Me.Tabfile)
        Me.TabFORFORM.Controls.Add(Me.Tabsales)
        Me.TabFORFORM.Controls.Add(Me.Tabservice)
        Me.TabFORFORM.Controls.Add(Me.Tabstock)
        Me.TabFORFORM.Controls.Add(Me.Tabother)
        Me.TabFORFORM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFORFORM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabFORFORM.Location = New System.Drawing.Point(0, 0)
        Me.TabFORFORM.Multiline = True
        Me.TabFORFORM.Name = "TabFORFORM"
        Me.TabFORFORM.SelectedIndex = 0
        Me.TabFORFORM.Size = New System.Drawing.Size(885, 548)
        Me.TabFORFORM.TabIndex = 1
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
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'MobileTableAdapter
        '
        Me.MobileTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("MadScience", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 1
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(57, 428)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 29)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "NEW"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(-18, 366)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(113, 17)
        Me.label8.TabIndex = 66
        Me.label8.Text = "total amoumt"
        '
        'txttotalamt
        '
        Me.txttotalamt.Enabled = False
        Me.txttotalamt.Location = New System.Drawing.Point(131, 359)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.Size = New System.Drawing.Size(183, 20)
        Me.txttotalamt.TabIndex = 65
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(131, 234)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(183, 20)
        Me.dtp.TabIndex = 64
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("MadScience", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.ImageIndex = 0
        Me.button1.ImageList = Me.ImageList1
        Me.button1.Location = New System.Drawing.Point(138, 428)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(74, 29)
        Me.button1.TabIndex = 63
        Me.button1.Text = "order"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = True
        '
        'txpalte
        '
        Me.txpalte.Location = New System.Drawing.Point(131, 317)
        Me.txpalte.Name = "txpalte"
        Me.txpalte.Size = New System.Drawing.Size(183, 20)
        Me.txpalte.TabIndex = 62
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(-18, 320)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(100, 17)
        Me.label7.TabIndex = 61
        Me.label7.Text = "No of plates"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(-19, 234)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(47, 17)
        Me.label6.TabIndex = 60
        Me.label6.Text = "Date"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label5.Location = New System.Drawing.Point(-21, 102)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(86, 17)
        Me.label5.TabIndex = 59
        Me.label5.Text = "Item Type"
        '
        'txtfad
        '
        Me.txtfad.Location = New System.Drawing.Point(131, 275)
        Me.txtfad.Name = "txtfad"
        Me.txtfad.Size = New System.Drawing.Size(183, 20)
        Me.txtfad.TabIndex = 58
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(-21, 55)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 17)
        Me.label1.TabIndex = 54
        Me.label1.Text = "Order no"
        '
        'txtono
        '
        Me.txtono.Location = New System.Drawing.Point(131, 55)
        Me.txtono.Name = "txtono"
        Me.txtono.Size = New System.Drawing.Size(183, 20)
        Me.txtono.TabIndex = 50
        '
        'txtitype
        '
        Me.txtitype.Location = New System.Drawing.Point(131, 99)
        Me.txtitype.Name = "txtitype"
        Me.txtitype.Size = New System.Drawing.Size(183, 20)
        Me.txtitype.TabIndex = 51
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(131, 144)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(183, 20)
        Me.txtcname.TabIndex = 52
        '
        'txtad
        '
        Me.txtad.Location = New System.Drawing.Point(131, 194)
        Me.txtad.Name = "txtad"
        Me.txtad.Size = New System.Drawing.Size(183, 20)
        Me.txtad.TabIndex = 53
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(-24, 147)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(136, 17)
        Me.label2.TabIndex = 55
        Me.label2.Text = "Customer Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(-18, 194)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 17)
        Me.label3.TabIndex = 56
        Me.label3.Text = "Address"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Michroma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(-18, 278)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(144, 17)
        Me.label4.TabIndex = 57
        Me.label4.Text = "Function Address"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 548)
        Me.Controls.Add(Me.TabFORFORM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "MOBILE SHOP"
        Me.Tabstock.ResumeLayout(False)
        Me.Tabstock.PerformLayout()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabservice.ResumeLayout(False)
        Me.Tabservice.PerformLayout()
        Me.Tabsales.ResumeLayout(False)
        Me.Tabsales.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MobileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabfile.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFORFORM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabother As System.Windows.Forms.TabPage
    Friend WithEvents Tabstock As System.Windows.Forms.TabPage
    Friend WithEvents Tabservice As System.Windows.Forms.TabPage
    Friend WithEvents Tabsales As System.Windows.Forms.TabPage
    Friend WithEvents Tabfile As System.Windows.Forms.TabPage
    Friend WithEvents TabFORFORM As System.Windows.Forms.TabControl
    Friend WithEvents Txtsptype As System.Windows.Forms.TextBox
    Friend WithEvents Txtspname As System.Windows.Forms.TextBox
    Friend WithEvents TXtsbrname As System.Windows.Forms.TextBox
    Friend WithEvents Txtsprice As System.Windows.Forms.TextBox
    Friend WithEvents Txtsqty As System.Windows.Forms.TextBox
    Friend WithEvents Lblspname As System.Windows.Forms.Label
    Friend WithEvents Lsbrname As System.Windows.Forms.Label
    Friend WithEvents Lsqty As System.Windows.Forms.Label
    Friend WithEvents Lsptype As System.Windows.Forms.Label
    Friend WithEvents Lsprice As System.Windows.Forms.Label
    Friend WithEvents Btnnewstock As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StockDataSet As M_SHOP.StockDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As M_SHOP.StockDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockDataSet1 As M_SHOP.StockDataSet1
    Friend WithEvents MobileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobileTableAdapter As M_SHOP.StockDataSet1TableAdapters.mobileTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtg1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Labelstockstatus As System.Windows.Forms.Label
    Friend WithEvents Labelstatus As System.Windows.Forms.Label
    Friend WithEvents Textstockinfo As System.Windows.Forms.TextBox
    Friend WithEvents Comstock As System.Windows.Forms.ComboBox
    Friend WithEvents popup As System.Windows.Forms.Label
    Friend WithEvents Combowarr As System.Windows.Forms.ComboBox
    Friend WithEvents LProName As System.Windows.Forms.Label
    Friend WithEvents LWarranty As System.Windows.Forms.Label
    Friend WithEvents LReturned As System.Windows.Forms.Label
    Friend WithEvents LRepairs As System.Windows.Forms.Label
    Friend WithEvents LDue As System.Windows.Forms.Label
    Friend WithEvents Lservicecode As System.Windows.Forms.Label
    Friend WithEvents Txtrepairs As System.Windows.Forms.TextBox
    Friend WithEvents Txtrepcharge As System.Windows.Forms.TextBox
    Friend WithEvents Txtserpname As System.Windows.Forms.TextBox
    Friend WithEvents Txtservcode As System.Windows.Forms.TextBox
    Friend WithEvents Comboitemret As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Txtservcharge As System.Windows.Forms.TextBox
    Friend WithEvents LTamt As System.Windows.Forms.Label
    Friend WithEvents LRepcharge As System.Windows.Forms.Label
    Friend WithEvents Dduedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dcdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LSerCharge As System.Windows.Forms.Label
    Friend WithEvents LCdate As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnservprint As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Btnbill As System.Windows.Forms.Button
    Friend WithEvents Ltotalamt As System.Windows.Forms.Label
    Friend WithEvents Lprice As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Lbltotal As System.Windows.Forms.Label
    Friend WithEvents TXtbrname As System.Windows.Forms.TextBox
    Friend WithEvents Lptype As System.Windows.Forms.Label
    Friend WithEvents Combopname As System.Windows.Forms.ComboBox
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents Texttax As System.Windows.Forms.TextBox
    Friend WithEvents Lqty As System.Windows.Forms.Label
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents lblptype As System.Windows.Forms.Label
    Friend WithEvents Labeltax As System.Windows.Forms.Label
    Friend WithEvents Btnprint As System.Windows.Forms.Button
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents Labeldate As System.Windows.Forms.Label
    Friend WithEvents Lbrname As System.Windows.Forms.Label
    Friend WithEvents dtpsale As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lblpname As System.Windows.Forms.Label
    Friend WithEvents Txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents lblbrname As System.Windows.Forms.Label
    Friend WithEvents Lbillno As System.Windows.Forms.Label
    Friend WithEvents Lpname As System.Windows.Forms.Label
    Friend WithEvents Labelbillno As System.Windows.Forms.Label
    Friend WithEvents Labeldisc As System.Windows.Forms.Label
    Friend WithEvents Textdisc As System.Windows.Forms.TextBox
    Friend WithEvents Lbldisc As System.Windows.Forms.Label
    Friend WithEvents Textprotype As System.Windows.Forms.TextBox
    Friend WithEvents Textqty As System.Windows.Forms.TextBox
    Friend WithEvents Texttotal As System.Windows.Forms.TextBox
    Friend WithEvents Textprice As System.Windows.Forms.TextBox
    Friend WithEvents Txtpname As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Btnstockupdate As System.Windows.Forms.Button
    Friend WithEvents Btnstocksearch As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Combostockbrname As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents txttotalamt As System.Windows.Forms.TextBox
    Private WithEvents dtp As System.Windows.Forms.DateTimePicker
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txpalte As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtfad As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtono As System.Windows.Forms.TextBox
    Private WithEvents txtitype As System.Windows.Forms.TextBox
    Private WithEvents txtcname As System.Windows.Forms.TextBox
    Private WithEvents txtad As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label

End Class
