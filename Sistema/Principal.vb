Imports System.Data.SqlClient
Public Class Principal
    Private Sub Janela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mesas.MdiParent = Me
        Mesas.WindowState = FormWindowState.Maximized
        Mesas.Show()
    End Sub



    Private Sub MesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesasToolStripMenuItem.Click
        Mesas.MdiParent = Me
        Mesas.WindowState = FormWindowState.Maximized
        Mesas.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub HistoricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoToolStripMenuItem.Click
        Historico.MdiParent = Me
        Historico.WindowState = FormWindowState.Maximized
        Historico.Show()
    End Sub
End Class
