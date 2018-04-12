Imports System.Data.OleDb
Imports System.IO
Public Class main
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim n As Integer
    Dim i As Integer
    
   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet1.mobile' table. You can move, or remove it, as needed.
        Me.MobileTableAdapter.Fill(Me.StockDataSet1.mobile)
        'TODO: This line of code loads data into the 'StockDataSet.stock' table. You can move, or remove it, as needed.
        disable()
        dpdown()
        dpdownstock()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\FILES\M-SHOP\stock.mdb"
        con.Open()
        cmd.Connection = con
        'cmd.CommandText = "select * from stock"
        'da.SelectCommand = cmd
        'ds.Clear()
        'da.Fill(ds, "stock")
        'n = ds.Tables("stock").Rows.Count
        'stockshow()
    End Sub
    'stockupdate disable
    Sub disable()
        Txtsptype.Enabled = False
        TXtsbrname.Enabled = False
        Txtspname.Enabled = False
        Txtsprice.Enabled = False
        Txtsqty.Enabled = False
    End Sub
    'stock textbox validation
    Sub val1()
        If Txtsptype.Text = "" Or TXtsbrname.Text = "" Or Txtspname.Text = "" Then
            Dialog1.Label1.Text = "Fields are empty  Please enter neccassary data"
        ElseIf Txtsprice.Text = "" Or Txtsprice.Text = 0 Or Txtsqty.Text = "" Or Txtsqty.Text = 0 Then
            Dialog1.Label1.Text = "Fields are empty  Please enter neccassary data"
        End If

        Dialog1.Show()

    End Sub
    'new stock
    Sub newstock()
        Try
            cmd.CommandText = "insert into stock values ('" & Txtsptype.Text & "','" & Txtspname.Text & "','" & TXtsbrname.Text & "','" & Txtsprice.Text & "','" & Txtsqty.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("RECORD UPDATED SUCCESSFULLY", MsgBoxStyle.OkOnly, "STOCK")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnewstock.Click
        Txtsptype.Enabled = True
        TXtsbrname.Enabled = True
        Txtspname.Enabled = True
        Txtsprice.Enabled = True
        Txtsqty.Enabled = True
       

    End Sub


    Sub dpdown()
        Dim items(Me.ImageList1.Images.Count - 1) As String
        For i As Int32 = 0 To Me.ImageList1.Images.Count - 1
            items(i) = "Item " & i.ToString
        Next
        Me.ComboBox1.Items.AddRange(items)
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.DrawMode = DrawMode.OwnerDrawVariable
        Me.ComboBox1.ItemHeight = Me.ImageList1.ImageSize.Height
        Me.ComboBox1.Width = Me.ImageList1.ImageSize.Width + 25
        Me.ComboBox1.MaxDropDownItems = Me.ImageList1.Images.Count
    End Sub

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
        If Texttotal.Text = 0 Then
            Dialog1.Label1.Text = "Please enter quantity"
            Dialog1.Show()
        Else
            bill.Show()
        End If

    End Sub

    Private Sub ComboBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem
        If e.Index <> -1 Then
            e.Graphics.DrawImage(Me.ImageList1.Images(e.Index), _
                                 e.Bounds.Left, e.Bounds.Top)
        End If
    End Sub


    Private Sub ComboBox1_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles ComboBox1.MeasureItem
        e.ItemHeight = Me.ImageList1.ImageSize.Height
        e.ItemWidth = Me.ImageList1.ImageSize.Width
    End Sub


    Sub brand()
        TXtbrname.Text = ComboBox1.SelectedItem.ToString
        Select Case TXtbrname.Text
            Case "Item 0"
                TXtbrname.Text = "Acer"
            Case "Item 1"
                TXtbrname.Text = "Apple"
            Case "Item 2"
                TXtbrname.Text = "Asus"
            Case "Item 3"
                TXtbrname.Text = "Black Berry"
            Case "Item 4"
                TXtbrname.Text = "Celkon"
            Case "Item 5"
                TXtbrname.Text = "Intex"
            Case "Item 6"
                TXtbrname.Text = "IBall"
            Case "Item 7"
                TXtbrname.Text = "Gionee"
            Case "Item 8"
                TXtbrname.Text = "HP"
            Case "Item 9"
                TXtbrname.Text = "HTC"
            Case "Item 10"
                TXtbrname.Text = "Huawei"
            Case "Item 11"
                TXtbrname.Text = "Karbonn"
            Case "Item 12"
                TXtbrname.Text = "Lava"
            Case "Item 13"
                TXtbrname.Text = "Lenovo"
            Case "Item 14"
                TXtbrname.Text = "LG"
            Case "Item 15"
                TXtbrname.Text = "Micromax"
            Case "Item 16"
                TXtbrname.Text = "Motorola"
            Case "Item 17"
                TXtbrname.Text = "Nokia"
            Case "Item 18"
                TXtbrname.Text = "Videocon"
            Case "Item 19"
                TXtbrname.Text = "Panasonic"
            Case "Item 20"
                TXtbrname.Text = "Samsung"
            Case "Item 21"
                TXtbrname.Text = "Sony"
            Case "Item 22"
                TXtbrname.Text = "Sony Ericsson"
            Case "Item 23"
                TXtbrname.Text = "Spice"
            Case "Item 24"
                TXtbrname.Text = "Thoshiba"
            Case "Item 25"
                TXtbrname.Text = "Xolo"
            Case "Item 26"
                TXtbrname.Text = "ZTE"
        End Select
    End Sub

    Sub comb()
        Try
            Dim qry As String
            brand()
            qry = "SELECT * FROM stock where brand='" & TXtbrname.Text & "'"
            Dim da As New OleDbDataAdapter(qry, con)
            Dim ds As New DataSet
            da.Fill(ds)
            Combopname.ValueMember = "pname"
            Combopname.DataSource = ds.Tables(0)
            Combopname.SelectedIndex = 0
        Catch ex As Exception
            Dialog1.Label1.Text = "No stock for " & TXtbrname.Text & " Please select another model"
            Dialog1.Show()
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        comb()

    End Sub


    Private Sub Combopname_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combopname.DropDownClosed

    End Sub


    Private Sub Combopname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combopname.SelectedIndexChanged
        Txtpname.Text = Combopname.SelectedValue
        stockcheck()

    End Sub

    Private Sub Txtpname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpname.TextChanged
        Dim qry1 As String
        qry1 = "SELECT * FROM stock where pname='" & Txtpname.Text & "'"
        Dim da1 As New OleDbDataAdapter(qry1, con)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        ComboBox2.ValueMember = "price"
        ComboBox2.DataSource = ds1.Tables(0)
        ComboBox2.SelectedIndex = 0
        ComboBox2.Refresh()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Textprice.Text = ComboBox2.SelectedValue
    End Sub

    Private Sub Btnbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbill.Click

        Dim qty As Integer
        Dim dis, tax, price, total As Double
        qty = Val(Textqty.Text)
        dis = Val(Textdisc.Text)
        price = Val(Textprice.Text)
        total = qty * price
        tax = 0.05 * total
        Texttax.Text = tax
        dis = (dis * total) / 100
        Texttotal.Text = (tax + total) - dis
        stockdec()
    End Sub
    'shows stock details in datagrid
    Sub stockshow()
        Dim qry As String
        qry = "SELECT * FROM stock"
        Dim da As New OleDbDataAdapter(qry, con)
        Dim ds As New DataSet
        da.Fill(ds)
        dtg1.DataSource = ds.Tables(0)
        dtg1.Refresh()
    End Sub
    'stock checking function
    Sub stockcheck()
        Dim qry1 As String
        qry1 = "SELECT * FROM stock where pname='" & Txtpname.Text & "'"
        Dim da1 As New OleDbDataAdapter(qry1, con)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        Comstock.ValueMember = "qty"
        Comstock.DataSource = ds1.Tables(0)
        Comstock.SelectedIndex = 0
        Comstock.Refresh()
        If Comstock.SelectedValue = 0 Then
            Labelstatus.Text = "OUT OF STOCK"
            Labelstatus.ForeColor = Color.Red
            Texttax.Visible = False
            Textdisc.Visible = False
            Texttotal.Visible = False
            Textqty.Visible = False
            Btnbill.Visible = False
        ElseIf Comstock.SelectedValue < 5 Then
            Labelstatus.Text = "AVAILABLE"
            Labelstatus.ForeColor = Color.Yellow
            Texttax.Visible = True
            Textdisc.Visible = True
            Texttotal.Visible = True
            Textqty.Visible = True
            Btnbill.Visible = True
        Else
            Labelstatus.Text = "AVAILABLE"
            Labelstatus.ForeColor = Color.Green
            Texttax.Visible = True
            Textdisc.Visible = True
            Texttotal.Visible = True
            Textqty.Visible = True
            Btnbill.Visible = True
        End If
    End Sub
    'decrease stock
    Sub stockdec()
        Try
            Textstockinfo.Text = Comstock.Text - Textqty.Text
            cmd.CommandText = "update stock set qty='" & Textstockinfo.Text & "' where pname='" & Txtpname.Text & "'"
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            Dialog1.Label1.Text = "Please Ensure that you have enterd neccassary data"
            Dialog1.Show()

        End Try




    End Sub


    Private Sub Labelstockstatus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelstockstatus.MouseHover
        popup.Text = "STOCK DETAIL : AVAILABILITY OF THE SELECTED PRODUCT"
    End Sub

    Private Sub Labelstockstatus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelstockstatus.MouseLeave
        popup.Text = ""
    End Sub



    Private Sub Labelstatus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelstatus.MouseHover
        popup.Text = "STOCK DETAIL : AVAILABILITY OF THE SELECTED PRODUCT"
    End Sub

    Private Sub Labelstatus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Labelstatus.MouseLeave
        popup.Text = ""
    End Sub

    Private Sub Comstock_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Comstock.MouseHover
        popup.Text = "STOCK DETAIL : AVAILABILITY OF THE SELECTED PRODUCT"
    End Sub

    Private Sub Comstock_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Comstock.MouseLeave
        popup.Text = ""
    End Sub

    'total amount for the service

    Private Sub Btnservprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnservprint.Click
        ServBill.Show()
    End Sub




    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OpenFileDialog1.InitialDirectory = "D:\"
        Me.OpenFileDialog1.Filter = "ALL FILES|*.*|mp3|*.mp3"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OpenFileDialog1.InitialDirectory = "D:\"
        Me.OpenFileDialog1.Filter = "Video|*.mp4;*.3gp;*.flv;*avi;*.3gpp2;*.mpeg;*.dat;*.mkv;*.wmv|All Files|*.*"
        Me.OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OpenFileDialog1.InitialDirectory = "D:\"
        Me.OpenFileDialog1.Filter = "Music Files|*.mp3;*.m4a;*.wav|ALL FILES|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OpenFileDialog1.InitialDirectory = "D:\"
        Me.OpenFileDialog1.Filter = "ALL FILES|*.*|jpg|*.jpg"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            cmd.CommandText = "insert into order values ('" & txtono.Text & "','" & txtitype.Text & "','" & txtcname.Text & "','" & txtad.Text & "','" & dtp.Text & "','" & txtfad.Text & "','" & txpalte.Text & "','" & txttotalamt.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("ORDER SUCCESS", MsgBoxStyle.OkOnly, "ORDER")
        Catch ex As Exception
            MsgBox(",,,,,,")
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        val1()
        newstock()
    End Sub

    Private Sub Btnstockupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstockupdate.Click
        Txtsptype.Enabled = True
        TXtsbrname.Enabled = True
        Txtspname.Enabled = True
        Txtsprice.Enabled = True
        Txtsqty.Enabled = True
    End Sub
    Sub dpdownstock()
        Dim items(Me.ImageList1.Images.Count - 1) As String
        For i As Int32 = 0 To Me.ImageList1.Images.Count - 1
            items(i) = "Item " & i.ToString
        Next
        Me.Combostockbrname.Items.AddRange(items)
        Me.Combostockbrname.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Combostockbrname.DrawMode = DrawMode.OwnerDrawVariable
        Me.Combostockbrname.ItemHeight = Me.ImageList1.ImageSize.Height
        Me.Combostockbrname.Width = Me.ImageList1.ImageSize.Width + 25
        Me.Combostockbrname.MaxDropDownItems = Me.ImageList1.Images.Count
    End Sub

    Private Sub Combostockbrname_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Combostockbrname.DrawItem
        If e.Index <> -1 Then
            e.Graphics.DrawImage(Me.ImageList1.Images(e.Index), _
                                 e.Bounds.Left, e.Bounds.Top)
        End If
    End Sub


    Private Sub Combostockbrname_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles Combostockbrname.MeasureItem
        e.ItemHeight = Me.ImageList1.ImageSize.Height
        e.ItemWidth = Me.ImageList1.ImageSize.Width
    End Sub
    Private Sub Combostockbrname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combostockbrname.SelectedIndexChanged

        TXtsbrname.Text = Combostockbrname.SelectedValue
        brand()
    End Sub

    Private Sub Tabstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabstock.Click

    End Sub
End Class

