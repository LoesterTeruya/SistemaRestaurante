Imports System.Data
Imports Npgsql
Public Class Acesso
    Dim conn As NpgsqlConnection = Nothing

    Public Sub Conectar()
        Try
            Dim ConexaoPG As String = "Server=localhost;Port=5432;UserId=postgres;Password='123456';Database=sistema"

            'Cria uma Instancia de NpgsqlConnection na variavel conn
            conn = New NpgsqlConnection(ConexaoPG)

            'Abre a conexão
            conn.Open()

            'Declara e atribui a instrucao SQL de consulta
            'Dim SQL As String = "SELECT codigo, nome, email, adesao FROM usuarios"

            'Instancia o  NpgsqlDataAdapter responsavel pela comunicação 
            'é feita a leitura dos dados preenchendo o dataset 
            'Dim da As Npgsql.NpgsqlDataAdapter = New NpgsqlDataAdapter(SQL, conn)

            'Instacia um DataSet
            'Dim ds As DataSet = New DataSet()

            'Preenche o DataAdapter 
            'da.Fill(ds, "Usuarios")

            'Atribiu um Datasource a Grid
            'DataGridView1.DataSource = ds.Tables("Usuarios").DefaultView

            'Cria uma Instancia de NpgsqlConnection na variavel conn
            conn = New NpgsqlConnection(ConexaoPG)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Fechar()
        Try
            If Not conn Is Nothing Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ExecuteQuery(ByVal Command As String) As DataSet
        Dim ds As New DataSet
        Try

            Dim da As Npgsql.NpgsqlDataAdapter = New NpgsqlDataAdapter(Command, conn)
            da.Fill(ds)
        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function
End Class




''''' SQL SERVER  ''''''''
'Public Class Acesso
'    Private objConexao As SqlClient.SqlConnection

'    Public Sub Conectar()
'        Try
'            objConexao = New SqlClient.SqlConnection("Data Source = LOESTER-PC\SQLEXPRESS; INITIAL CATALOG = sistema; USER ID = SA; PASSWORD = 123456")

'            objConexao.Open()
'        Catch ex As Exception
'            Throw ex
'        End Try
'    End Sub

'    Public Sub Fechar()
'        Try
'            If Not IsNothing(objConexao) Then
'                If objConexao.State - ConnectionState.Open Then
'                    objConexao.Close()
'                End If
'            End If
'        Catch ex As Exception
'            Throw ex
'        End Try
'    End Sub

'    Public Function ExecuteQuery(ByVal Command As String) As DataSet
'        Dim ds As New DataSet
'        Dim objDataAdapter As New SqlClient.SqlDataAdapter
'        Dim objCommand As New SqlClient.SqlCommand

'        Try
'            objCommand = objConexao.CreateCommand
'            objCommand.CommandText = Command

'            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
'            objDataAdapter.Fill(ds)

'        Catch ex As Exception
'            Throw ex
'        End Try
'        Return ds
'    End Function
'End Class
