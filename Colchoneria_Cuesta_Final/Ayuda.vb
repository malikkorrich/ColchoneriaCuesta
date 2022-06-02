Public Class Ayuda
    Private Sub Ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' AxAcroPDF1.LoadFile("D:\Users\erick\Downloads\Proyecto_REPSOL.pdf")
    End Sub

    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Enabled = True
        PantallaPrincipal.Show()
        Me.Dispose()
    End Sub
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe")
        Catch ex As Exception
            MsgBox("ERROR! " & Err.Number & ": " & Err.Description)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub BlocNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocNotasToolStripMenuItem.Click
        Try
            Process.Start("notepad.exe")
        Catch ex As Exception
            MsgBox("ERROR! " & Err.Number & ": " & Err.Description)
        End Try
    End Sub
End Class