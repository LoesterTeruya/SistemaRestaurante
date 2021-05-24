Public Class Fechaconta
    Private objBanco As New Acesso

    Private Sub Fechaconta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textomesa.Text = "MESA  " & Mesas.Retornanummesa
        atualizalista()
    End Sub


    Private Sub FechaConta()
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()
        
        '''' INCLUI NO HISTORICO
        objCommand.CommandText = "
            INSERT INTO historico (mesa,salgado,tubaina,ks,lata,sucocopo,sucojarra,agua,mini,cafe)
            SELECT codigo,salgado,tubaina,ks,lata,sucocopo,sucojarra,agua,mini,cafe
                FROM mesas
            WHERE codigo = " & Mesas.Retornanummesa
        objBanco.ExecuteQuery(objCommand.CommandText)


        '''' ZERA CONTA
        objCommand.CommandText = "
            UPDATE mesas   
                SET salgado =0, tubaina=0, ks=0, lata=0, sucocopo=0, sucojarra=0, agua=0, mini=0, cafe =0, ocupado=0
            WHERE codigo = " & Mesas.Retornanummesa
        objBanco.ExecuteQuery(objCommand.CommandText)

        atualizalista()

        textomesa.Text = textomesa.Text + "     CONTA FECHADA"

        objBanco.Fechar()

        Comanda.Close()
    End Sub


    Private Sub Fechaconta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 70 Then
            Fechaconta()
        ElseIf e.KeyValue = 27 Then
            Close()
        End If
    End Sub

    Private Sub BT_fechar_Click(sender As Object, e As EventArgs) Handles BT_fechar.Click
        FechaConta()
    End Sub
    Private Sub BT_voltar_Click(sender As Object, e As EventArgs) Handles BT_voltar.Click
        Close()
    End Sub




    Public Sub atualizalista()

        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        '''''''''''''''''''''''''''''''' salgado 0, tubaina 1, ks 2, lata 3, sucocopo 4, sucojarra 5, agua 6, mini 7, cafe 8
        objCommand.CommandText = "SELECT salgado,tubaina,ks,lata,sucocopo,sucojarra,agua,mini,cafe FROM MESAS WHERE codigo = " & Mesas.Retornanummesa
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)


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


End Class