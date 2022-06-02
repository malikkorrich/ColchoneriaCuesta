'Para poder mostrar el Word de ayuda
'Imports Microsoft.Office.Interop.Word

Imports BibliotecaClasesColchuneriaCuesta
Imports System.Drawing.Printing
Imports System.IO


Public Class PantallaPrincipal
    Dim venta As New EstructureCaja
    Dim validacion As New Validaciones
    Dim errores As New Errores

    Dim gestionError As New GestionErrores
    Dim ga As New Articulos

    Private Sub PantallaPrinciapl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Try
        'Me.ControlBox = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Timer1.Enabled = True
        FileClose(1)
        CargarButtonsDinamicos()

        IniciarPantalla()



        '  Catch ex As Exception
        '  MsgBox("ERROR! " & Err.Number & ": " & Err.Description)
        '  End Try
    End Sub

    Private Sub IniciarPantalla()
        'Inicializamos los botones que no se van a usar de momento 
        ButtonQuitarLista.Enabled = False
        ButtonCobrar.Enabled = False
        LabelEntrega.Enabled = False

        TextBoxEntregaNumerico.Enabled = False
        LabelADevolver.Enabled = False
        LabelADevolverNumerico.Enabled = False

        LabelTotalAPagarNumerico.Text = 0
        TextBoxEntregaNumerico.Text = ""
        LabelADevolverNumerico.Text = ""

        RadioButtonEfectivo.Checked = False
        RadioButtonTarjeta.Checked = False

        ListBoxID.Items.Clear()
        ListBoxUnidades.Items.Clear()
        ListBoxDescripcion.Items.Clear()
        ListBoxPrecioUnidad.Items.Clear()
        ListBoxPrecioTotal.Items.Clear()

    End Sub



    Public Sub CargarButtonsDinamicos()
        Dim counter As Integer = 1
        'LA X es un count del fichero de productos para saber cuantos tenemos Nos lo pensamos x
        Dim x As Integer = 50
        Dim y As Integer = 0
        Dim j As Integer = 0

        PanelBotonesPagPrin.Controls.Clear()
        'Cuando le de la los BOTONES la comprobacion seria 

        Dim flag As Boolean = False

        'ListBoxID.Items.Add(ga.articulo.id)
        'ListBoxNombre.Items.Add(ga.articulo.nombre)
        'ListBoxCategoria.Items.Add(ga.articulo.Categoria)
        'ListBoxAncho.Items.Add(ga.articulo.ancho)
        'ListBoxLargo.Items.Add(ga.articulo.largo)
        'ListBoxColor.Items.Add(ga.articulo.color)
        'ListBoxPrecio.Items.Add(ga.articulo.precio)
        'ListBoxStock.Items.Add(ga.articulo.stock)
        'ListBoxProveedor.Items.Add(ga.articulo.proveedor)

        Dim contador As Integer = 1
        FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Read, , Len(ga.articulo))
        Seek(1, 1)
        While Not EOF(1)
            FileGet(1, ga.articulo, )
            Dim btn As Button = New Button
            'En ves de la g se poner el ID del producto 
            btn.Name = ga.articulo.nombre   'Le damos un identificador 
            btn.Text = ga.articulo.nombre 'Le introducimos la descripcion del producto
            btn.TextAlign = ContentAlignment.BottomCenter
            btn.Size = New Size(150, 150)
            btn.Location = New Point(160 * j, 160 * y)
            btn.Cursor = Cursors.Hand 'Para que el cursor se vea como un mano
            'Para visualizar una imagen encima del texto usando el método Resize en este caso para redimensionar la imagen que se meta.
            Dim img As Image = ResizeImage(Image.FromFile(ga.rutaImgen & ga.articulo.id & ".jpg"))
            btn.Image = img
            btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter

            'Añadimos el Botón 
            PanelBotonesPagPrin.Controls.Add(btn)

            AddHandler btn.Click, AddressOf Btn_Producto_Click
            counter = counter + 1
            'Para cambiar los que se van a ver en pantalla.
            If contador Mod 8 = 0 Then
                y += 1
                j = 0
            Else
                j += 1
            End If
            contador = contador + 1
        End While
        FileClose(1)

    End Sub

    'Blibloteca de clases 
    'MsgBox(My.Application.Info.DirectoryPath)
    Private Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(120, 120)
                          )
    End Function

    'Método para el evento click del boton dinámico.
    Private Sub Btn_Producto_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim btn As Button = DirectCast(sender, Button)

            FormItems.Show()
            Me.Enabled = False
            FormItems.Label1.Text = btn.Name

            'Aqui en esta linea lo que tenemos que poner es un FOR para cuando lea ese
            '
            '    For i As Integer = 1 To  Step 1

            '   Next

            'ESTO ESTABA YA HECHO DE LA PAGINA WEB
            'If btn.Name = "btn1" Then
            '    MessageBox.Show("Btn1 clicked")
            'ElseIf btn.Name = "btn2" Then
            '    MessageBox.Show("Btn2 Clicked")
            'End If
        Catch ex As Exception
            MsgBox("ERROR! " & Err.Number & ": " & Err.Description)
        End Try

    End Sub

    'Para mostrar Fecha y Hora en Labels
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelHora.Text = Now.ToShortTimeString.ToString()
        LabelFecha.Text = DateTime.Now.ToLongDateString()
    End Sub


    'Programación de los botones del menu strip que llevan a sus formularios correspondientes 

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe")
        Catch ex As Exception
            MsgBox("ERROR! " & Err.Number & ": " & Err.Description)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Application.Exit()

    End Sub
    Private Sub BlocNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocNotasToolStripMenuItem.Click
        Try
            Process.Start("notepad.exe")
        Catch ex As Exception
            MsgBox("ERROR! " & Err.Number & ": " & Err.Description)
        End Try
    End Sub
    Private Sub VerCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerCajaToolStripMenuItem.Click
        ' ver_caja.MenuStripVerCaja.Items
        ver_caja.Show()
        Me.Enabled = False
    End Sub
    Private Sub GestiónDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeProductosToolStripMenuItem.Click
        GestionArticulos.Show()
        Me.Enabled = False
    End Sub
    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        GestionEmpleados.Show()
        Me.Enabled = False
    End Sub
    Private Sub GestiónDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeClientesToolStripMenuItem.Click
        GestionClientes.Show()
        Me.Enabled = False
    End Sub
    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        Ayuda.Show()
        Me.Enabled = False
    End Sub


    '**Codigo usado para la actualizacion de datos del listbox**

    'Declarramos la variable que cambiara si se ha hecho Scroll o no.
    Public Scrolling As Boolean


    'Para el ListBoxDescripcion

    Private Sub ListBoxDescripcion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDescripcion.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDescripcion.MouseMove
        If Scrolling Then
            Me.ListBoxUnidades.TopIndex = Me.ListBoxDescripcion.TopIndex
            Me.ListBoxPrecioUnidad.TopIndex = Me.ListBoxDescripcion.TopIndex
            Me.ListBoxPrecioTotal.TopIndex = Me.ListBoxDescripcion.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxDescripcion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDescripcion.MouseUp
        Scrolling = False
    End Sub

    'Para controlar que se seleccione la misma línea
    Private Sub ListBoxDescripcion_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxDescripcion.DoubleClick
        If ListBoxDescripcion.SelectedIndex <> ListBoxUnidades.SelectedIndex And
            ListBoxDescripcion.SelectedIndex <> ListBoxPrecioUnidad.SelectedIndex And
            ListBoxDescripcion.SelectedIndex <> ListBoxPrecioTotal.SelectedIndex Then

            ListBoxUnidades.SetSelected(ListBoxDescripcion.SelectedIndex, True)
            ListBoxPrecioUnidad.SetSelected(ListBoxDescripcion.SelectedIndex, True)
            ListBoxPrecioTotal.SetSelected(ListBoxDescripcion.SelectedIndex, True)
        End If
    End Sub



    'Para el ListBoxUnidades

    Private Sub ListBoxUnidades_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxUnidades.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBoxUnidades_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxUnidades.MouseMove
        If Scrolling Then
            Me.ListBoxDescripcion.TopIndex = Me.ListBoxUnidades.TopIndex
            Me.ListBoxPrecioUnidad.TopIndex = Me.ListBoxUnidades.TopIndex
            Me.ListBoxPrecioTotal.TopIndex = Me.ListBoxUnidades.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxUnidades_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxUnidades.MouseUp
        Scrolling = False
    End Sub

    Private Sub ListBoxUnidades_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxUnidades.DoubleClick
        If ListBoxUnidades.SelectedIndex <> ListBoxDescripcion.SelectedIndex And
             ListBoxUnidades.SelectedIndex <> ListBoxPrecioUnidad.SelectedIndex And
            ListBoxUnidades.SelectedIndex <> ListBoxPrecioTotal.SelectedIndex Then

            ListBoxDescripcion.SetSelected(ListBoxUnidades.SelectedIndex, True)
            ListBoxPrecioUnidad.SetSelected(ListBoxUnidades.SelectedIndex, True)
            ListBoxPrecioTotal.SetSelected(ListBoxUnidades.SelectedIndex, True)
        End If
    End Sub

    '****************************
    'Para el ListBoxPrecioUnidades
    '****************************

    Private Sub ListBoxPrecioUnidad_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecioUnidad.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBoxPrecioUnidad_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecioUnidad.MouseMove
        If Scrolling Then
            Me.ListBoxDescripcion.TopIndex = Me.ListBoxPrecioUnidad.TopIndex
            Me.ListBoxUnidades.TopIndex = Me.ListBoxPrecioUnidad.TopIndex
            Me.ListBoxPrecioTotal.TopIndex = Me.ListBoxPrecioUnidad.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxPrecioUnidad_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecioUnidad.MouseUp
        Scrolling = False
    End Sub

    Private Sub ListBoxPrecioUnidad_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxPrecioUnidad.DoubleClick
        If ListBoxPrecioUnidad.SelectedIndex <> ListBoxUnidades.SelectedIndex And
            ListBoxPrecioUnidad.SelectedIndex <> ListBoxDescripcion.SelectedIndex And
            ListBoxPrecioUnidad.SelectedIndex <> ListBoxPrecioTotal.SelectedIndex Then

            ListBoxUnidades.SetSelected(ListBoxPrecioUnidad.SelectedIndex, True)
            ListBoxDescripcion.SetSelected(ListBoxPrecioUnidad.SelectedIndex, True)
            ListBoxPrecioTotal.SetSelected(ListBoxPrecioUnidad.SelectedIndex, True)
        End If
    End Sub

    '****************************
    'Para el ListBoxPrecioTotal
    '****************************
    Private Sub ListBoxPrecioTotal_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecioTotal.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBoxPrecioTotal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecioTotal.MouseMove
        If Scrolling Then
            Me.ListBoxDescripcion.TopIndex = Me.ListBoxPrecioTotal.TopIndex
            Me.ListBoxUnidades.TopIndex = Me.ListBoxPrecioTotal.TopIndex
            Me.ListBoxPrecioUnidad.TopIndex = Me.ListBoxPrecioTotal.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxPrecioTotal_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecioTotal.MouseUp
        Scrolling = False
    End Sub

    Private Sub ListBoxPrecioTotal_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxPrecioTotal.DoubleClick
        If ListBoxPrecioTotal.SelectedIndex <> ListBoxUnidades.SelectedIndex And
            ListBoxPrecioTotal.SelectedIndex <> ListBoxPrecioUnidad.SelectedIndex And
            ListBoxPrecioTotal.SelectedIndex <> ListBoxDescripcion.SelectedIndex Then

            ListBoxUnidades.SetSelected(ListBoxPrecioTotal.SelectedIndex, True)
            ListBoxPrecioUnidad.SetSelected(ListBoxPrecioTotal.SelectedIndex, True)
            ListBoxDescripcion.SetSelected(ListBoxPrecioTotal.SelectedIndex, True)
        End If
    End Sub



    'Lo que hace es quitar una liena seleccionada entera, y tambien actualiza el stock
    'Es decir cuando quito un producto, se le sumaria al stock un numero 
    'En caso de querer cancelar la operacón entera seria quitar uno a uno los productos, o en todo caso 
    'Crear un boton de quitar. IDK Luego lo pienso jejejej 
    Private Sub ButtonQuitarLista_Click(sender As Object, e As EventArgs) Handles ButtonQuitarLista.Click



        'Para quitar el item, o en toco caso destarñe una unidad
        ListBoxUnidades.Items.Remove(ListBoxUnidades.SelectedItem)
        ListBoxDescripcion.Items.Remove(ListBoxDescripcion.SelectedItem)
        ListBoxPrecioUnidad.Items.Remove(ListBoxPrecioUnidad.SelectedItem)
        ListBoxPrecioTotal.Items.Remove(ListBoxPrecioTotal.SelectedItem)


    End Sub

    'Esto va junto, que el metodo impirmir junto al boton cobrar.
    Private Sub ButtonCobrar_Click(sender As Object, e As EventArgs) Handles ButtonCobrar.Click

        'Para imprimir
        AddHandler PrintDocument1.PrintPage, AddressOf Me.TicketEntero
        PrintDocument1.Print()

        actualizarCaja()

        IniciarPantalla()
        LabelEntrega.Enabled = False
        TextBoxEntregaNumerico.Enabled = False
        LabelADevolver.Enabled = False
        LabelADevolverNumerico.Enabled = False

    End Sub

    Private Sub actualizarCaja()
        'Abre Fichiero si no esta lo crea sino 
        'Converte single al string CStr(single)

        Try
            'precio csng(textbprecio.txt)
            FileOpen(1, "ventas.txt", OpenMode.Append)
            Write(1, DateTime.Now.ToLongDateString(), (DateTime.Now.TimeOfDay.Hours & ":" & DateTime.Now.TimeOfDay.Minutes), CSng(LabelTotalAPagarNumerico.Text))
            FileClose(1)
        Catch ex As Exception
            MsgBox("Error ", "Erro Guardar Fichiero")
        End Try
    End Sub

    Private Sub RadioButtonEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEfectivo.CheckedChanged
        ButtonCobrar.Enabled = False
        LabelADevolver.Enabled = True
        LabelADevolverNumerico.Enabled = True
        LabelEntrega.Enabled = True
        TextBoxEntregaNumerico.Enabled = True
    End Sub

    Private Sub RadioButtonTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTarjeta.CheckedChanged
        ButtonCobrar.Enabled = True
        LabelEntrega.Enabled = False
        TextBoxEntregaNumerico.Enabled = False
        LabelADevolver.Enabled = False
        LabelADevolverNumerico.Enabled = False
    End Sub

    Private Sub TicketEntero(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim a As Integer
        Dim y As Integer = 520

        ev.Graphics.DrawImage(Image.FromFile("D:\Users\erick\Documents\Desarrollo_practica_di\Practica1EVA\Desarrollo_practica_1eva\ImageList\logotipo-negro200x105_.png"), 160, 120, 190, 150)
        ev.Graphics.DrawString("C/ VALLEHERMOSO, 42", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 190, 280)
        ev.Graphics.DrawString("28015 MADRID ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 210, 300)
        ev.Graphics.DrawString("Colchonería Cuesta SL ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 200, 320)
        ev.Graphics.DrawString("TEL.915-932-215 / 605-689-166", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 170, 340)
        ev.Graphics.DrawString(Format(Now, "dd-MM-yyyy - "), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 130, 380)
        ev.Graphics.DrawString("----------------------------------------------------------------- ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 400)
        ev.Graphics.DrawString(Format(Now, "dd-MM-yyyy - "), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 135, 420)
        ev.Graphics.DrawString("----------------------------------------------------------------- ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 440)
        ev.Graphics.DrawString("Uds " + "   Descripcion " + "              Precio " + "     Suma", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 480)
        ev.Graphics.DrawString("----------------------------------------------------------------- ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 500)
        'Articulos que figuran en la Cesta de la Pantalla Principal
        For a = 0 To ListBoxUnidades.Items.Count - 1
            ev.Graphics.DrawString((ListBoxPrecioUnidad.Items.Item(a)), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 125, y) ' Cortar texto si es posible 
            ev.Graphics.DrawString((ListBoxDescripcion.Items.Item(a)), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 155, y)
            ev.Graphics.DrawString((ListBoxPrecioUnidad.Items.Item(a)), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 355, y)
            ev.Graphics.DrawString((ListBoxPrecioTotal.Items.Item(a)), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 415, y)
            y = y + 20
        Next
        'ListBoxUnidades.Items.Item(a) + ListBoxDescripcion.Items.Item(a) + ListBoxPrecioUnidad.Items.Item(a) + ListBoxPrecioTotal.Items.Item(a)

        ev.Graphics.DrawString("----------------------------------------------------------------- ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 540 + y)
        'Total falta por programar
        ev.Graphics.DrawString("----------------------------------------------------------------- ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 580 + y)
        'iva y formas de pago
        ev.Graphics.DrawString("Le atendió: " & "Pepe", New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 140, 660 + y)
        ev.Graphics.DrawString("----------------------------------------------------------------- ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 720 + y)
        ev.Graphics.DrawString("----------------------------------------------------------------- ", New Font("GaArialdugi", 8, FontStyle.Regular), Brushes.Black, 120, 760)
        ev.Graphics.DrawString("IVA INCLUIDO  ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 780)
        ev.Graphics.DrawString("GRACIAS POR SU VISITA ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, 120, 8000)
    End Sub





    'Codicion que activa o no el método de pago 
    'Este label tiene un limite de numeros de 99999'99 (7digitos la coma no consume mucho espacio)
    Private Sub LabelTotalAPagarNumerico_TextChanged(sender As Object, e As EventArgs) Handles LabelTotalAPagarNumerico.TextChanged
        If LabelTotalAPagarNumerico.Text = 0 Or LabelTotalAPagarNumerico.Text = "€" Then

            GroupBoxMetodoPago.Enabled = False
        Else
            GroupBoxMetodoPago.Enabled = True
        End If
    End Sub


    'Programamos la activacion del boton Cobrar
    'Y tambien le programamos el mostar por pantalla al label A devolver Numérico
    Private Sub TextBoxEntregaNumerico_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEntregaNumerico.TextChanged
        If (TextBoxEntregaNumerico.Text <> "") Then
            If (Convert.ToInt32(TextBoxEntregaNumerico.Text) >= Convert.ToInt32(LabelTotalAPagarNumerico.Text)) Then
                ButtonCobrar.Enabled = True
            Else
                ButtonCobrar.Enabled = False
            End If
            LabelADevolverNumerico.Text = (TextBoxEntregaNumerico.Text - LabelTotalAPagarNumerico.Text)
        Else
            LabelADevolverNumerico.Text = 0
        End If

    End Sub

    Private Sub FormularioPruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormularioPruebaToolStripMenuItem.Click
        FormularioProbarFile.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (MessageBox.Show("¿Está seguro que desea salir?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        End If
        InicioSesion.Close() 'Para cerrar el formulario de inicio de sesion, el cual es el principal.
    End Sub
End Class

