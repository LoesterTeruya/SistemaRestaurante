Public Class Historico
    Private objBanco As New Acesso

    Private Sub Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaLista()
    End Sub


    Private Sub BT_atualizar_Click(sender As Object, e As EventArgs) Handles BT_atualizar.Click
        AtualizaLista()
    End Sub


    Private Sub BT_fechar_Click(sender As Object, e As EventArgs) Handles BT_fechar.Click
        Close()
    End Sub



    Public Sub AtualizaLista()
        Dim objCommand As New SqlClient.SqlCommand
        objBanco.Conectar()


        objCommand.CommandText = "SELECT id,mesa,salgado,tubaina,ks,lata,sucocopo,sucojarra,agua,mini,cafe FROM HISTORICO ORDER BY ID DESC"
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)

        Dados.DataSource = ds.Tables(0)

        objBanco.Fechar()

    End Sub

    Private Sub Historico_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 27 Then
            Close()
        End If
    End Sub
End Class