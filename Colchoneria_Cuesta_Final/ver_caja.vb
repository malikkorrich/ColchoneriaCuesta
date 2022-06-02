Public Class ver_caja
    Dim venta As New EstructureCaja
    Private Sub ver_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelImporteCaja.Text = 0


    End Sub

    Private Sub cargarTodosDatos()

        FileOpen(1, "ventas.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, venta.fecha)
            Input(1, venta.hora)
            Input(1, venta.importe)

            ListBoxFecha.Items.Add(venta.fecha)
            ListBoxHora.Items.Add(venta.hora)
            ListBoxImporte.Items.Add(venta.importe & " €")

        End While
        FileClose(1)
    End Sub

    'Metodo pa
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

    'Para los list box que Scrolleen al mismo tiempo 


    Public Scrolling As Boolean


    '************************
    'PARA EL ListBoxFecha
    '*************************
    Private Sub ListBoxFecha_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFecha.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBoxFecha_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFecha.MouseMove
        If Scrolling Then
            Me.ListBoxHora.TopIndex = Me.ListBoxFecha.TopIndex
            Me.ListBoxImporte.TopIndex = Me.ListBoxFecha.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxFecha_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFecha.MouseUp
        Scrolling = False
    End Sub



    '*******************************
    'PARA EL ListBoxHora
    '*******************************
    Private Sub ListBoxHora_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxHora.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBoxHora_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxHora.MouseMove
        If Scrolling Then
            Me.ListBoxFecha.TopIndex = Me.ListBoxHora.TopIndex
            Me.ListBoxImporte.TopIndex = Me.ListBoxHora.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxHora_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxHora.MouseUp
        Scrolling = False
    End Sub




    '*******************************
    'PARA EL LISTBOX   PRECIO TOTAL
    '********************************
    Private Sub ListBoxImporte_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxImporte.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBoxImporte_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxImporte.MouseMove
        If Scrolling Then
            Me.ListBoxFecha.TopIndex = Me.ListBoxImporte.TopIndex
            Me.ListBoxHora.TopIndex = Me.ListBoxImporte.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxImporte_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxImporte.MouseUp
        Scrolling = False
    End Sub


    'ListBoxNumeroCaja
    'ListBoxFecha
    'ListBoxHora
    'ListBoxImporte
    '*****************
    'Para controlar que se seleccione la misma línea

    Private Sub ListBoxFecha_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxFecha.DoubleClick
        If ListBoxFecha.SelectedIndex <> ListBoxHora.SelectedIndex And
            ListBoxFecha.SelectedIndex <> ListBoxImporte.SelectedIndex Then


            ListBoxHora.SetSelected(ListBoxFecha.SelectedIndex, True)
            ListBoxImporte.SetSelected(ListBoxFecha.SelectedIndex, True)
        End If
    End Sub
    Private Sub ListBoxHora_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxHora.DoubleClick
        If ListBoxHora.SelectedIndex <> ListBoxFecha.SelectedIndex And
            ListBoxHora.SelectedIndex <> ListBoxImporte.SelectedIndex Then

            ListBoxFecha.SetSelected(ListBoxHora.SelectedIndex, True)
            ListBoxImporte.SetSelected(ListBoxHora.SelectedIndex, True)
        End If
    End Sub
    Private Sub ListBoxPrecioUnidad_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxImporte.DoubleClick
        If ListBoxImporte.SelectedIndex <> ListBoxFecha.SelectedIndex And
            ListBoxImporte.SelectedIndex <> ListBoxHora.SelectedIndex Then

            ListBoxFecha.SetSelected(ListBoxImporte.SelectedIndex, True)
            ListBoxHora.SetSelected(ListBoxImporte.SelectedIndex, True)
        End If
    End Sub

    'Para cambiar el valor de las listas egun la fecha elegida.
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'Hacemos una busqueda para leer el fichero completo y jugar con el 
        Dim sumador As Single = 0
        limpiarPantalla()

        FileOpen(1, "ventas.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, venta.fecha)
            Input(1, venta.hora)
            Input(1, venta.importe)

            If (DateTimePicker1.Value.ToLongDateString = venta.fecha.ToLongDateString) Then
                ListBoxFecha.Items.Add(venta.fecha)
                ListBoxHora.Items.Add(venta.hora)
                ListBoxImporte.Items.Add(venta.importe & " €")
            End If

        End While
        FileClose(1)


        'Hacemos un For para leer la listBox donde salen los importes. Para calcular el hacer caja
        For a As Integer = 0 To ListBoxImporte.Items.Count - 1
            sumador = sumador + ListBoxImporte.Items(a)
        Next

        LabelImporteCaja.Text = sumador

    End Sub

    Private Sub limpiarPantalla()
        ListBoxFecha.Items.Clear()
        ListBoxHora.Items.Clear()
        ListBoxImporte.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(venta.fecha.ToLongDateString)
        'MsgBox(DateTimePicker1.Value.ToLongDateString)
    End Sub

    Private Sub ButtonMostrarTodo_Click(sender As Object, e As EventArgs) Handles ButtonMostrarTodo.Click
        cargarTodosDatos()
    End Sub
End Class