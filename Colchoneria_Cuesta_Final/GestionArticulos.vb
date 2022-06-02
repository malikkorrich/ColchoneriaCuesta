Imports BibliotecaClasesColchuneriaCuesta
Imports System.IO
    Public Class GestionArticulos

        'instanciamos un Objeto de clase Validaciones
        Dim validacion As New Validaciones
        Dim errores As New Errores

        Dim gestionError As New GestionErrores
        Dim ga As New Articulos


    Private Sub GestionArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'colcando contenido del fichiero
        'volcal contenido del fihciero sequencial en los listbox
        limpiarPantalla()
        'cargar datos rellenar fichiero antes de cargar
        cargarDatos()
    End Sub


        'metodo para cargar datos
        Public Sub cargarDatos()

            FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Read, , Len(ga.articulo))
            Seek(1, 1)
            While Not EOF(1)
                FileGet(1, ga.articulo, )
                ListBoxID.Items.Add(ga.articulo.id)
                ListBoxNombre.Items.Add(ga.articulo.nombre)
                ListBoxCategoria.Items.Add(ga.articulo.Categoria)
                ListBoxAncho.Items.Add(ga.articulo.ancho)
                ListBoxLargo.Items.Add(ga.articulo.largo)
                ListBoxColor.Items.Add(ga.articulo.color)
                ListBoxPrecio.Items.Add(ga.articulo.precio)
                ListBoxStock.Items.Add(ga.articulo.stock)
                ListBoxProveedor.Items.Add(ga.articulo.proveedor)
            End While
            FileClose(1)
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

        Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
            GestionEmpleados.Show()
            Me.Enabled = False
        End Sub

        Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
            Ayuda.Show()
            Me.Enabled = False
        End Sub



        '********** Validacion Registros de Busqueda *********************

        Private Sub TextBoxbusID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxbusID.TextChanged

            'usamos el metodo isNUmeroValid(String arg)
            If Not validacion.IsNumeroValid(TextBoxbusID.Text) Then


                'TextBoxID.Clear()
                ' TextBoxID.Focus()

            Else

            End If
        End Sub


        Private Sub TextBoxbusNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxbusNombre.TextChanged
            If Not validacion.IsTextValid(TextBoxbusNombre.Text) Then


                '   TextBoxbusNombre.Clear()
                'TextBoxbusNombre.Focus()

            Else
            End If
        End Sub


        '********** Validacion Registros de Gestion *********************

        Private Sub TextBoxbusID_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged
            If Not validacion.IsNumeroValid(TextBoxID.Text) Then




            Else
                ' TextBoxID.Clear()
                ' TextBoxID.Focus()

            End If
        End Sub

        Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged
            If Not validacion.IsTextValid(TextBoxNombre.Text) Then


                '  TextBoxNombre.Clear()
                ' TextBoxNombre.Refresh()


            Else

            End If
        End Sub

        Private Sub TextBoxAncho_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAncho.TextChanged
            If Not validacion.anchoLargoValid(TextBoxAncho.Text) Then


                'TextBoxAncho.Clear()
                'TextBoxAncho.Focus()

            Else

            End If
        End Sub

        Private Sub TextBoxLargo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLargo.TextChanged
            If Not validacion.anchoLargoValid(TextBoxLargo.Text) Then


                '  TextBoxLargo.Clear()
                '  TextBoxLargo.Focus()

            Else

            End If
        End Sub

        Private Sub TextBoxPrecio_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecio.TextChanged
            If Not validacion.precioValid(TextBoxPrecio.Text) Then


                ' TextBoxPrecio.Clear()
                ' TextBoxPrecio.Focus()

            Else

            End If
        End Sub

        Private Sub TextBoxStock_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStock.TextChanged
            If Not validacion.IsNumeroValid(TextBoxStock.Text) Then


                'TextBoxStock.Clear()
                ' TextBoxStock.Focus()

            Else

            End If
        End Sub

        Private Sub TextBoxProveedor_TextChanged(sender As Object, e As EventArgs) Handles TextBoxProveedor.TextChanged
            If Not validacion.IsTextValid(TextBoxProveedor.Text) Then


                'TextBoxProveedor.Clear()
                ' TextBoxProveedor.Focus()

            Else

            End If
        End Sub

        Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

        End Sub








        'Para los list box que Scrolleen al mismo tiempo 
        'ListBoxID
        'ListBoxNombre
        'ListBoxCategoria
        'ListBoxAncho
        'ListBoxLargo
        'ListBoxColor
        'ListBoxPrecio
        'ListBoxStock
        'ListBoxProveedor
        'ListBoxRutaImagen


        Public Scrolling As Boolean
        '*************************
        'Para el ListBoxID
        '**************************
        Private Sub ListBoxID_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxID.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxID_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxID.MouseMove
            If Scrolling Then
                Me.ListBoxNombre.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxID.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxID_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxID.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxID.DoubleClick
            If ListBoxID.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxProveedor.SelectedIndex Then

                ListBoxNombre.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxID.SelectedIndex, True)

            End If
        End Sub



        '*************************
        'Para el ListBoxNombre
        '**************************
        Private Sub ListBoxNombre_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxNombre.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxNombre_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxNombre.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxNombre.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxNombre_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxNombre.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNombre.DoubleClick
            If ListBoxNombre.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxProveedor.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxNombre.SelectedIndex, True)

            End If
        End Sub



        '*************************
        'Para el ListBoxCategoria
        '**************************
        Private Sub ListBoxCategoria_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxCategoria.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxCategoria_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxCategoria.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxCategoria.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxCategoria.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxCategoria.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxCategoria.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxCategoria.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxCategoria.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxCategoria.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxCategoria.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxCategoria_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxCategoria.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCategoria.DoubleClick
            If ListBoxCategoria.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxCategoria.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxCategoria.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxCategoria.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxCategoria.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxCategoria.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxCategoria.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxCategoria.SelectedIndex <> ListBoxProveedor.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxCategoria.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxCategoria.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxCategoria.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxCategoria.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxCategoria.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxCategoria.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxCategoria.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxCategoria.SelectedIndex, True)

            End If
        End Sub



        '*************************
        'Para el ListBoxAncho
        '**************************
        Private Sub ListBoxAncho_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxAncho.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxAncho_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxAncho.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxAncho.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxAncho.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxAncho.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxAncho.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxAncho.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxAncho.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxAncho.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxAncho.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxAncho_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxAncho.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxAncho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAncho.DoubleClick
            If ListBoxAncho.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxAncho.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxAncho.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxAncho.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxAncho.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxAncho.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxAncho.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxAncho.SelectedIndex <> ListBoxProveedor.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxAncho.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxAncho.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxAncho.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxAncho.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxAncho.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxAncho.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxAncho.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxAncho.SelectedIndex, True)

            End If
        End Sub



        '*************************
        'Para el ListBoxLargo
        '**************************
        Private Sub ListBoxLargo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxLargo.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxLargo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxLargo.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxLargo.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxLargo.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxLargo.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxLargo.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxLargo.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxLargo.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxLargo.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxLargo.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxLargo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxLargo.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxLargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLargo.DoubleClick
            If ListBoxLargo.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxLargo.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxLargo.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxLargo.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxLargo.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxLargo.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxLargo.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxLargo.SelectedIndex <> ListBoxProveedor.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxLargo.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxLargo.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxLargo.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxLargo.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxLargo.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxLargo.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxLargo.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxLargo.SelectedIndex, True)

            End If
        End Sub


        '*************************
        'Para el ListBoxColor
        '**************************
        Private Sub ListBoxColor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxColor.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxColor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxColor.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxColor.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxColor.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxColor.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxColor.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxColor.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxColor.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxColor.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxColor.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxColor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxColor.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxColor.DoubleClick
            If ListBoxColor.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxColor.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxColor.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxColor.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxColor.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxColor.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxColor.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxColor.SelectedIndex <> ListBoxProveedor.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxColor.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxColor.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxColor.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxColor.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxColor.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxColor.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxColor.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxColor.SelectedIndex, True)

            End If
        End Sub



        '*************************
        'Para el ListBoxPrecio
        '**************************
        Private Sub ListBoxPrecio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecio.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxPrecio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecio.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxPrecio.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxPrecio.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxPrecio.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxPrecio.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxPrecio.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxPrecio.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxPrecio.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxPrecio.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxPrecio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxID.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxPrecio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrecio.DoubleClick
            If ListBoxPrecio.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxProveedor.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxPrecio.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxPrecio.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxPrecio.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxPrecio.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxPrecio.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxPrecio.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxPrecio.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxPrecio.SelectedIndex, True)

            End If
        End Sub



        '*************************
        'Para el ListBoxStock
        '**************************
        Private Sub ListBoxStock_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxStock.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxStock_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxStock.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxStock.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxStock.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxStock.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxStock.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxStock.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxStock.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxStock.TopIndex
                Me.ListBoxProveedor.TopIndex = Me.ListBoxStock.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxStock_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxStock.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxStock.DoubleClick
            If ListBoxStock.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxProveedor.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxStock.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxStock.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxStock.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxStock.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxStock.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxStock.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxStock.SelectedIndex, True)
                ListBoxProveedor.SetSelected(ListBoxStock.SelectedIndex, True)

            End If
        End Sub



        '*************************
        'Para el ListBoxProveedor
        '**************************
        Private Sub ListBoxProveedor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxProveedor.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxProveedor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxProveedor.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxProveedor.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxProveedor.TopIndex
                Me.ListBoxCategoria.TopIndex = Me.ListBoxProveedor.TopIndex
                Me.ListBoxAncho.TopIndex = Me.ListBoxProveedor.TopIndex
                Me.ListBoxLargo.TopIndex = Me.ListBoxProveedor.TopIndex
                Me.ListBoxColor.TopIndex = Me.ListBoxProveedor.TopIndex
                Me.ListBoxPrecio.TopIndex = Me.ListBoxProveedor.TopIndex
                Me.ListBoxStock.TopIndex = Me.ListBoxProveedor.TopIndex

            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxProveedor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxProveedor.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProveedor.DoubleClick
            If ListBoxProveedor.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxProveedor.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxProveedor.SelectedIndex <> ListBoxCategoria.SelectedIndex And
            ListBoxProveedor.SelectedIndex <> ListBoxAncho.SelectedIndex And
            ListBoxProveedor.SelectedIndex <> ListBoxLargo.SelectedIndex And
            ListBoxProveedor.SelectedIndex <> ListBoxColor.SelectedIndex And
            ListBoxProveedor.SelectedIndex <> ListBoxPrecio.SelectedIndex And
            ListBoxProveedor.SelectedIndex <> ListBoxStock.SelectedIndex Then


                ListBoxID.SetSelected(ListBoxProveedor.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxProveedor.SelectedIndex, True)
                ListBoxCategoria.SetSelected(ListBoxProveedor.SelectedIndex, True)
                ListBoxAncho.SetSelected(ListBoxProveedor.SelectedIndex, True)
                ListBoxLargo.SetSelected(ListBoxProveedor.SelectedIndex, True)
                ListBoxColor.SetSelected(ListBoxProveedor.SelectedIndex, True)
                ListBoxPrecio.SetSelected(ListBoxProveedor.SelectedIndex, True)
                ListBoxStock.SetSelected(ListBoxProveedor.SelectedIndex, True)

            End If
        End Sub

    'limpiar pantalla
    Public Sub limpiarPantalla()
            TextBoxID.Clear()
            TextBoxbusID.Clear()
            TextBoxNombre.Clear()
            TextBoxbusNombre.Clear()
            ComboBoxbusCategoria.ResetText()
            ComboBoxCategoria.ResetText()
            ComboBoxColor.ResetText()
            TextBoxAncho.Clear()
            TextBoxLargo.Clear()
            TextBoxPrecio.Clear()
            TextBoxStock.Clear()
            TextBoxProveedor.Clear()

            'limpiar listbox
            ListBoxID.Items.Clear()
            ListBoxNombre.Items.Clear()
            ListBoxCategoria.Items.Clear()
            ListBoxAncho.Items.Clear()
            ListBoxLargo.Items.Clear()
            ListBoxColor.Items.Clear()
            ListBoxPrecio.Items.Clear()
            ListBoxStock.Items.Clear()
        ListBoxProveedor.Items.Clear()

        'PictureBoxProducto.Dispose()
        PictureBoxProducto.Image = New PictureBox().Image



    End Sub



    'andir un articulo
    Private Sub ButtonAlta_Click(sender As Object, e As EventArgs) Handles ButtonAlta.Click
            'comprobar si los compos estan llenos 
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or ComboBoxCategoria.Text = "" Or TextBoxAncho.Text = "" Or TextBoxLargo.Text = "" Or ComboBoxColor.Text = "" Or TextBoxPrecio.Text = "" Or TextBoxStock.Text = "" Or TextBoxProveedor.Text = "" Then
                MsgBox("Porfavor rellene los campos . ", 64, "Gestion Articulos")
            Else



                Try

                    Dim pos As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Write, , Len(ga.articulo))

                    ga.articulo.id = Trim(TextBoxID.Text)
                    ga.articulo.nombre = Trim(TextBoxNombre.Text)
                ga.articulo.Categoria = RTrim(ComboBoxCategoria.SelectedItem)
                ga.articulo.ancho = Trim(CSng(TextBoxAncho.Text))
                    ga.articulo.largo = Trim(CSng(TextBoxLargo.Text))
                    ga.articulo.color = Trim(ComboBoxColor.SelectedItem)
                    ga.articulo.precio = Trim(CSng(TextBoxPrecio.Text))
                    ga.articulo.stock = Trim(CSng(TextBoxStock.Text))
                    ga.articulo.proveedor = Trim(TextBoxProveedor.Text)
                    FilePut(1, ga.articulo, pos)



                    PictureBoxProducto.Image.Save(ga.rutaImgen & TextBoxID.Text & ".jpg")
                    MsgBox("Empleado guardado con éxito", 64, "Gestion Clientes")
                    'limpiar pictureBox
                    PictureBoxProducto.Image = New PictureBox().Image
                    TextBoxID.Focus()
                    limpiarPantalla()
                ' cargarDatos()


            Catch ex As Exception
                    'aqui buscamos el Error en GestionErrores
                    Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

                    'guardamos el Exception
                    errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

                    'si no ecuentramos el error mostrar mensaje del exepcion capturada
                    If buscarError = False Then
                        MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
                    End If


                End Try

                FileClose(1)

            End If



        End Sub

        Private Sub ListBoxNombre_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxNombre.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub

        Private Sub ListBoxStock_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxStock.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub

        Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

        End Sub
        'buscar un articulo
        Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
            If TextBoxbusID.Text = "" And TextBoxbusNombre.Text = "" And ComboBoxbusCategoria.Text = "" Then
                MsgBox("Porfavor rellene un campo de Busqueda. ", 64, "Gestion Articulos")
            Else
                Try


                    Dim pos As Integer
                    'aqui la posicion que busacamos
                    pos = Val(TextBoxbusID.Text)

                    'abremos flujos
                    FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Read, , Len(ga.articulo))
                    'nos posicionamos
                    Seek(1, pos)
                    'leemeos
                    FileGet(1, ga.articulo, )
                    'si exsiste leyemos añdimos los datos listbox
                    If ga.articulo.id > 0 Then

                        If (ListBoxID.Items.Contains(ga.articulo.id)) Then

                            MsgBox("Articulo ya existe . ", 64, "Gestion Articulos")
                        Else
                            ListBoxID.Items.Add(ga.articulo.id)
                            ListBoxNombre.Items.Add(ga.articulo.nombre)
                            ListBoxCategoria.Items.Add(ga.articulo.Categoria)
                            ListBoxAncho.Items.Add(ga.articulo.ancho)
                            ListBoxLargo.Items.Add(ga.articulo.largo)
                            ListBoxColor.Items.Add(ga.articulo.color)
                            ListBoxPrecio.Items.Add(ga.articulo.precio)
                            ListBoxStock.Items.Add(ga.articulo.stock)
                            ListBoxProveedor.Items.Add(ga.articulo.proveedor)

                        End If



                    Else

                        MsgBox("Articulo no exsite . Busqueda fallida ", 64, "Gestion Articulos")
                    End If






                Catch ex As Exception
                    'aqui buscamos el Error en GestionErrores
                    Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

                    'guardamos el Exception
                    errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

                    'si no ecuentramos el error mostrar mensaje del exepcion capturada
                    If buscarError = False Then
                        MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
                    End If

                End Try
                FileClose(1)

            End If






        End Sub

        Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
            limpiarPantalla()
        End Sub

        Private Sub ListBoxID_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxID.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem


        End Sub

        Private Sub ListBoxCategoria_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxCategoria.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub

        Private Sub ListBoxAncho_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxAncho.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub

        Private Sub ListBoxLargo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxLargo.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub

        Private Sub ListBoxColor_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxColor.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub

        Private Sub ListBoxPrecio_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxPrecio.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub

        Private Sub ListBoxProveedor_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxProveedor.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxID.SelectedItem

            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            ComboBoxCategoria.Text = ListBoxCategoria.SelectedItem


            ComboBoxColor.Text = ListBoxColor.SelectedItem
            TextBoxAncho.Text = ListBoxAncho.SelectedItem
            TextBoxLargo.Text = ListBoxLargo.SelectedItem
            TextBoxPrecio.Text = ListBoxPrecio.SelectedItem
            TextBoxStock.Text = ListBoxStock.SelectedItem
            TextBoxProveedor.Text = ListBoxProveedor.SelectedItem
        End Sub
        'modificar  articulo
        Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or ComboBoxCategoria.Text = "" Or TextBoxAncho.Text = "" Or TextBoxLargo.Text = "" Or ComboBoxColor.Text = "" Or TextBoxPrecio.Text = "" Or TextBoxStock.Text = "" Or TextBoxProveedor.Text = "" Then
                MsgBox("Porfavor rellene los campos . ", 64, "Gestion Articulos")
            Else
                Try

                    Dim pos As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Write, , Len(ga.articulo))
                    Seek(1, pos)
                    ga.articulo.id = Trim(TextBoxID.Text)
                    ga.articulo.nombre = Trim(TextBoxNombre.Text)
                ga.articulo.Categoria = RTrim(ComboBoxCategoria.SelectedItem)
                ga.articulo.ancho = Trim(CSng(TextBoxAncho.Text))
                    ga.articulo.largo = Trim(CSng(TextBoxLargo.Text))
                    ga.articulo.color = Trim(ComboBoxColor.SelectedItem)
                    ga.articulo.precio = Trim(CSng(TextBoxPrecio.Text))
                    ga.articulo.stock = Trim(CSng(TextBoxStock.Text))
                    ga.articulo.proveedor = Trim(TextBoxProveedor.Text)

                    FilePut(1, ga.articulo, )

                    FileClose(1)


                    MsgBox("Producto modificado con éxito", 64, "Articulo Guardado")
                    limpiarPantalla()
                    ' cargarDatos()
                Catch ex As Exception
                    'aqui buscamos el Error en GestionErrores
                    Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

                    'guardamos el Exception
                    errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

                    'si no ecuentramos el error mostrar mensaje del exepcion capturada
                    If buscarError = False Then
                        MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
                    End If

                End Try

            End If
        End Sub

        'eliminar articulo
        Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or ComboBoxCategoria.Text = "" Or TextBoxAncho.Text = "" Or TextBoxLargo.Text = "" Or ComboBoxColor.Text = "" Or TextBoxPrecio.Text = "" Or TextBoxStock.Text = "" Or TextBoxProveedor.Text = "" Then
                MsgBox("Porfavor rellene los campos o xeleccione un articulo . ", 64, "Gestion Articulos")
            Else
                Try

                    Dim pos, valor As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Write, , Len(ga.articulo))
                    valor = MsgBox("¿Esta seguro de que desea Elminar Articulo?", 36, "Gestion Articulos")
                    If valor = MsgBoxResult.Yes Then
                        ga.articulo.id = ""
                        ga.articulo.nombre = ""
                        ga.articulo.Categoria = ""
                        ga.articulo.ancho = ""
                        ga.articulo.largo = ""
                        ga.articulo.color = ""
                        ga.articulo.precio = 0
                        ga.articulo.stock = 0
                        ga.articulo.proveedor = ""

                        FilePut(1, ga.articulo, pos)

                        PictureBoxProducto.Image.Save(ga.rutaImgen & TextBoxID.Text & ".jpg")
                        MsgBox("Producto Elimnado con éxito", 64, "Gestion Articulos")
                        limpiarPantalla()
                        cargarDatos()
                    End If



                Catch ex As Exception
                    'aqui buscamos el Error en GestionErrores
                    Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

                    'guardamos el Exception
                    errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

                    'si no ecuentramos el error mostrar mensaje del exepcion capturada
                    If buscarError = False Then
                        MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
                    End If

                End Try
                FileClose(1)

            End If
        End Sub


        'Metodo para anadir una imagen de producto
        Private Sub ButtonExaminar_Click(sender As Object, e As EventArgs) Handles ButtonExaminar.Click
        Try
            'objeto de openfiledialog
            Dim odf As New OpenFileDialog()
            odf.Title = "Seleccione una imagen del producto"
            'tipo de fichiero
            odf.Filter = "JPG Files|*.jpg"
            'inicio de la ruta
            odf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            If odf.ShowDialog() = DialogResult.OK Then
                'Abremos fichiero
                Dim fs As FileStream = File.Open(odf.FileName, FileMode.Open)
                'cogemos el imagen obj bmp
                Dim bmp As New Bitmap(fs)
                fs.Close()
                'cargamos la foto en el picturebox
                PictureBoxProducto.Image = Image.FromFile(odf.FileName)
            End If


        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            If buscarError = False Then
                MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try
    End Sub

        Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            PantallaPrincipal.Enabled = True
        PantallaPrincipal.Show()
        PantallaPrincipal.CargarButtonsDinamicos()
        Me.Dispose()
    End Sub

    Private Sub ButtonMostrarTodo_Click(sender As Object, e As EventArgs) Handles ButtonMostrarTodo.Click
        limpiarPantalla()
        cargarDatos()
    End Sub
End Class

