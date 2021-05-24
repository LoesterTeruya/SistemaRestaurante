Public Class Mesas
    Private objBanco As New Acesso
    Dim mesaclique As Integer

    Public Function Retornanummesa()
        Return mesaclique
    End Function

    Private Sub Mesas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim objCommand As New SqlClient.SqlCommand

        objBanco.Conectar()

        objCommand.CommandText = "SELECT ocupado FROM MESAS ORDER BY codigo"
        Dim ds As DataSet = objBanco.ExecuteQuery(objCommand.CommandText)

        objBanco.Fechar()


        Button1.BackColor = IIf(ds.Tables(0).Rows(0)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button2.BackColor = IIf(ds.Tables(0).Rows(1)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button3.BackColor = IIf(ds.Tables(0).Rows(2)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button4.BackColor = IIf(ds.Tables(0).Rows(3)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button5.BackColor = IIf(ds.Tables(0).Rows(4)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button6.BackColor = IIf(ds.Tables(0).Rows(5)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button7.BackColor = IIf(ds.Tables(0).Rows(6)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button8.BackColor = IIf(ds.Tables(0).Rows(7)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button9.BackColor = IIf(ds.Tables(0).Rows(8)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button10.BackColor = IIf(ds.Tables(0).Rows(9)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button11.BackColor = IIf(ds.Tables(0).Rows(10)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button12.BackColor = IIf(ds.Tables(0).Rows(11)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button13.BackColor = IIf(ds.Tables(0).Rows(12)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button14.BackColor = IIf(ds.Tables(0).Rows(13)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button15.BackColor = IIf(ds.Tables(0).Rows(14)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button16.BackColor = IIf(ds.Tables(0).Rows(15)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button17.BackColor = IIf(ds.Tables(0).Rows(16)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button18.BackColor = IIf(ds.Tables(0).Rows(17)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button19.BackColor = IIf(ds.Tables(0).Rows(18)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button20.BackColor = IIf(ds.Tables(0).Rows(19)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button21.BackColor = IIf(ds.Tables(0).Rows(20)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button22.BackColor = IIf(ds.Tables(0).Rows(21)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button23.BackColor = IIf(ds.Tables(0).Rows(22)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button24.BackColor = IIf(ds.Tables(0).Rows(23)("ocupado"), Color.Salmon, Color.PaleGreen)
        Button25.BackColor = IIf(ds.Tables(0).Rows(24)("ocupado"), Color.Salmon, Color.PaleGreen)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mesaclique = 1
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mesaclique = 2
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mesaclique = 3
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mesaclique = 4
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mesaclique = 5
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mesaclique = 6
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mesaclique = 7
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mesaclique = 8
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        mesaclique = 9
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        mesaclique = 10
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        mesaclique = 11
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        mesaclique = 12
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        mesaclique = 13
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        mesaclique = 14
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        mesaclique = 15
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        mesaclique = 16
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        mesaclique = 17
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        mesaclique = 18
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        mesaclique = 19
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        mesaclique = 20
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        mesaclique = 21
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        mesaclique = 22
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        mesaclique = 23
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        mesaclique = 24
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        mesaclique = 25
        Comanda.MdiParent = Principal
        Comanda.WindowState = FormWindowState.Maximized
        Comanda.Show()
    End Sub
End Class