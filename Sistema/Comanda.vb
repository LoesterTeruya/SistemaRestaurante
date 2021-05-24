Public Class Comanda
    Dim numeromesa As Integer
    Private objBanco As New Acesso

    Private Sub Controle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "MESA  " & Mesas.Retornanummesa
        atualizalista()
    End Sub

    Private Sub AdicionaSalgado()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand


        objBanco.Conectar()
        objCommand.CommandText = "
            UPDATE mesas   
                SET salgado = salgado+1,
                ocupado = 1
            WHERE codigo = " & numeromesa


        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)

        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaTubaina()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET tubaina = tubaina + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaKS()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET ks = ks + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaLata()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET lata = lata + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaSucoCOPO()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET sucocopo = sucocopo + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaSucoJARRA()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET sucojarra = sucojarra + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaAgua()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET agua = agua + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaMini()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET mini = mini + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub AdicionaCafe()
        numeromesa = Mesas.Retornanummesa
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "
            UPDATE mesas   
                SET cafe = cafe + 1,
                ocupado = 1
            WHERE codigo = " & numeromesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


        objBanco.Fechar()
        atualizalista()

    End Sub

    Private Sub Controle_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ''Label2.Text = e.KeyValue
        If e.KeyValue = 49 Then
            AdicionaSalgado()
        ElseIf e.KeyValue = 50 Then
            AdicionaTubaina()
        ElseIf e.KeyValue = 51 Then
            AdicionaKS()
        ElseIf e.KeyValue = 52 Then
            AdicionaLata()
        ElseIf e.KeyValue = 53 Then
            AdicionaSucoCOPO()
        ElseIf e.KeyValue = 54 Then
            AdicionaSucoJARRA()
        ElseIf e.KeyValue = 55 Then
            AdicionaAgua()
        ElseIf e.KeyValue = 56 Then
            AdicionaMini()
        ElseIf e.KeyValue = 57 Then
            AdicionaCafe()
        ElseIf e.KeyValue = 27 Then
            Close()
        ElseIf e.KeyValue = 70 Then
            Fechaconta.MdiParent = Principal
            Fechaconta.WindowState = FormWindowState.Maximized
            Fechaconta.Show()
        End If
    End Sub


    Private Sub BT_addSalgado_Click(sender As Object, e As EventArgs) Handles BT_addSalgado.Click
        AdicionaSalgado()
    End Sub
    Private Sub BT_addTubaina_Click(sender As Object, e As EventArgs) Handles BT_addTubaina.Click
        AdicionaTubaina()
    End Sub
    Private Sub BT_addKS_Click(sender As Object, e As EventArgs) Handles BT_addKS.Click
        AdicionaKS()
    End Sub
    Private Sub BT_lata_Click(sender As Object, e As EventArgs) Handles BT_addlata.Click
        AdicionaLata()
    End Sub
    Private Sub BT_addSUCOCOPO_Click(sender As Object, e As EventArgs) Handles BT_addSUCOCOPO.Click
        AdicionaSucoCOPO()
    End Sub
    Private Sub BT_addSUCOJARRA_Click(sender As Object, e As EventArgs) Handles BT_addSUCOJARRA.Click
        AdicionaSucoJARRA()
    End Sub
    Private Sub BT_addAgua_Click(sender As Object, e As EventArgs) Handles BT_addAgua.Click
        AdicionaAgua()
    End Sub
    Private Sub BT_addMINI_Click(sender As Object, e As EventArgs) Handles BT_addMINI.Click
        AdicionaMini()
    End Sub
    Private Sub BT_addCafe_Click(sender As Object, e As EventArgs) Handles BT_addCafe.Click
        AdicionaCafe()
    End Sub

    Private Sub BT_fechaconta_Click(sender As Object, e As EventArgs) Handles BT_fechaconta.Click
        Fechaconta.MdiParent = Principal
        Fechaconta.WindowState = FormWindowState.Maximized
        Fechaconta.Show()
    End Sub




    Public Sub atualizalista()
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        '''''''''''''''''''''''''''''''' salgado 0, tubaina 1, ks 2, lata 3, sucocopo 4, sucojarra 5, agua 6, mini 7, cafe 8
        objCommand.CommandText = "SELECT salgado,tubaina,ks,lata,sucocopo,sucojarra,agua,mini,cafe FROM MESAS WHERE codigo = " & Mesas.Retornanummesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)

        'Dados.DataSource = ds.Tables(0)

        'objCommand.CommandText = "SELECT SALGADO FROM MESAS WHERE codigo = " & Mesas.retornanummesa
        'Dim buscaqnt As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)

        'Dim teste As Integer
        'Dim dt As DataTable = New DataTable
        'dt = ds.Tables(0)
        'teste = ds.Tables(0).Compute("sum(salgado)", "").ToString
        'Label2.Text = teste



        objBanco.Fechar()


        Dim newtable As New DataTable

        newtable.Columns.Add("Item")
        newtable.Columns.Add("Quantidade")
        newtable.Columns.Add("Valor", GetType(Single))

        Dim somaqnt As String

        '' SALGADO
        somaqnt = "SUM(" & ds.Tables(0).Columns(0).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(0), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 4)
        End If

        '' TUBAINA
        somaqnt = "SUM(" & ds.Tables(0).Columns(1).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(1), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 3.5)
        End If

        '' KS
        somaqnt = "SUM(" & ds.Tables(0).Columns(2).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(2), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 3.5)
        End If

        '' LATA
        somaqnt = "SUM(" & ds.Tables(0).Columns(3).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(3), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 4)
        End If

        '' SUCO COPO
        somaqnt = "SUM(" & ds.Tables(0).Columns(4).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(4), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 3)
        End If

        '' SUCO JARRA
        somaqnt = "SUM(" & ds.Tables(0).Columns(5).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(5), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 5)
        End If

        '' AGUA
        somaqnt = "SUM(" & ds.Tables(0).Columns(6).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(6), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 3)
        End If

        '' MINI
        somaqnt = "SUM(" & ds.Tables(0).Columns(7).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(7), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 2.5)
        End If

        '' CAFE
        somaqnt = "SUM(" & ds.Tables(0).Columns(8).ToString & ")"
        If ds.Tables(0).Compute(somaqnt, "") > 0 Then
            newtable.Rows.Add(ds.Tables(0).Columns(8), ds.Tables(0).Compute(somaqnt, ""), ds.Tables(0).Compute(somaqnt, "") * 1)
        End If



        If IsDBNull(newtable.Compute("sum(valor)", "")) = True Then
            labeltotal.Text = "TOTAL = R$0"
        Else
            labeltotal.Text = "TOTAL = " & Format(newtable.Compute("sum(valor)", ""), "C")
        End If



        Dados.DataSource = newtable


    End Sub


    Private Sub BT_voltar_Click(sender As Object, e As EventArgs) Handles BT_voltar.Click
        Close()
    End Sub
End Class