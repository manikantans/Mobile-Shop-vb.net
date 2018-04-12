Imports System.Drawing.Printing
Imports System.Data.OleDb

Public Class bill

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
        Panel1.VerticalScroll.Value = 0
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 879, 1100)
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static page As Integer = 1
        Dim startPosition As Integer = (page - 1) * PrintDocument1.DefaultPageSettings.Bounds.Height + 5
        Static maxPages As Integer = 0

        If page = 1 Then
            For Each ctrl As Control In Panel1.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is PictureBox Then
                    ctrl.Tag = Int((ctrl.Top + ctrl.Height) / PrintDocument1.DefaultPageSettings.Bounds.Height) + 1
                    If CInt(ctrl.Tag) > maxPages Then maxPages = CInt(ctrl.Tag)
                End If
            Next
        End If

        For Each ctrl As Control In Panel1.Controls
            If CInt(ctrl.Tag) = page Then
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Then
                    Dim sf As New System.Drawing.StringFormat
                    If TypeOf ctrl Is TextBox Then
                        If DirectCast(ctrl, TextBox).TextAlign = HorizontalAlignment.Right Then
                            sf.Alignment = StringAlignment.Far
                        Else
                            sf.Alignment = StringAlignment.Near
                        End If
                    ElseIf TypeOf ctrl Is Label Then
                        If DirectCast(ctrl, Label).TextAlign = ContentAlignment.TopLeft Then
                            sf.Alignment = StringAlignment.Far
                        ElseIf DirectCast(ctrl, Label).TextAlign = ContentAlignment.TopRight Then
                            sf.Alignment = StringAlignment.Far
                        End If
                    End If

                    sf.FormatFlags = StringFormatFlags.NoClip
                    e.Graphics.DrawString(ctrl.Text, ctrl.Font, New SolidBrush(ctrl.ForeColor), New RectangleF(ctrl.Left + 5, ctrl.Top - startPosition, ctrl.Width, ctrl.Height), sf)
                ElseIf TypeOf ctrl Is PictureBox Then
                    e.Graphics.DrawImage(DirectCast(ctrl, PictureBox).Image, New PointF(ctrl.Left, ctrl.Top - startPosition))
                End If
            End If
        Next

        page += 1
        If page > maxPages Then

            e.HasMorePages = False
            page = 1
            maxPages = 0
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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



        Tbillno.Text = main.Txtbillno.Text
        Tbname.Text = main.TXtbrname.Text
        Tpname.Text = main.Combopname.Text
        Tptype.Text = main.Textprotype.Text
        Tdate.Text = main.dtpsale.Text
        Tprice.Text = main.Textprice.Text
        Tdisc.Text = main.Textdisc.Text
        Ttax.Text = main.Texttax.Text
        Ttotal.Text = main.Texttotal.Text
        Tqty.Text = main.Textqty.Text
        ComboBox1.SelectedItem = main.ComboBox1.SelectedItem
        brandselect()

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
    Sub brandselect()
        Try
            Tbname.Text = main.ComboBox1.SelectedItem.ToString
            Select Case Tbname.Text
                Case "Item 0"
                    Tbname.Text = "Acer"
                Case "Item 1"
                    Tbname.Text = "Apple"
                Case "Item 2"
                    Tbname.Text = "Asus"
                Case "Item 3"
                    Tbname.Text = "Black Berry"
                Case "Item 4"
                    Tbname.Text = "Celkon"
                Case "Item 5"
                    Tbname.Text = "Intex"
                Case "Item 6"
                    Tbname.Text = "I Ball"
                Case "Item 7"
                    Tbname.Text = "Gionee"
                Case "Item 8"
                    Tbname.Text = "HP"
                Case "Item 9"
                    Tbname.Text = "HTC"
                Case "Item 10"
                    Tbname.Text = "Huawei"
                Case "Item 11"
                    Tbname.Text = "Karbonn"
                Case "Item 12"
                    Tbname.Text = "Lava"
                Case "Item 13"
                    Tbname.Text = "Lenovo"
                Case "Item 14"
                    Tbname.Text = "LG"
                Case "Item 15"
                    Tbname.Text = "Micromax"
                Case "Item 16"
                    Tbname.Text = "Motorola"
                Case "Item 17"
                    Tbname.Text = "Nokia"
                Case "Item 18"
                    Tbname.Text = "Videocon"
                Case "Item 19"
                    Tbname.Text = "Panasonic"
                Case "Item 20"
                    Tbname.Text = "Samsung"
                Case "Item 21"
                    Tbname.Text = "Sony"
                Case "Item 22"
                    Tbname.Text = "Sony Ericsson"
                Case "Item 23"
                    Tbname.Text = "Spice"
                Case "Item 24"
                    Tbname.Text = "Thoshiba"
                Case "Item 25"
                    Tbname.Text = "Xolo"
                Case "Item 26"
                    Tbname.Text = "ZTE"
            End Select
        Catch ex As Exception
            Dialog1.Label1.Text = "There is no data is enterd to print"
            Dialog1.Show()

            Me.Dispose()
        End Try
        
    End Sub

    Private Function ReportViewer1() As Object
        Throw New NotImplementedException
    End Function

    Private Sub ReportViewer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class