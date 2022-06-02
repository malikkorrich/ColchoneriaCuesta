
Imports BibliotecaClasesColchuneriaCuesta
    Public Class GestionEmpleados
        'instanciamos un Objeto de clase Validaciones
        Dim validacion As New Validaciones
        Dim errores As New Errores

        Dim gestionError As New GestionErrores
        Dim ge As New Empleados

        Private Sub GestionEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            limpiarPantalla()
            ' cargar datos
            cargarDatos()
        End Sub

        'metodo para cargar datos
        Public Sub cargarDatos()

            FileOpen(1, ge.ruta, OpenMode.Random, OpenAccess.Read, , Len(ge.empleado))
            Seek(1, 1)
            While Not EOF(1)
                FileGet(1, ge.empleado, )

                ListBoxID.Items.Add(ge.empleado.id)
                ListBoxNombre.Items.Add(ge.empleado.nombre)
                ListBoxApellido1.Items.Add(ge.empleado.apellido1)
                ListBoxApellido2.Items.Add(ge.empleado.apellido2)
                ListBoxEmail.Items.Add(ge.empleado.email)
                ListBoxTelefono.Items.Add(ge.empleado.telefono)
                ListBoxUsuario.Items.Add(ge.empleado.usuario)
                ListBoxContrasena.Items.Add(ge.empleado.conntrasena)
                ListBoxRol.Items.Add(ge.empleado.rol)
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



        Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
            Ayuda.Show()
            Me.Enabled = False
        End Sub

        '********** Validacion Registros de Busqueda *********************
        Private Sub TextBoxbusId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxbusId.TextChanged
            If Not validacion.IsNumeroValid(TextBoxbusId.Text) Then

                '   MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusID.Clear()
                ' TextBoxbusID.Focus()

            Else

            End If
        End Sub



        Private Sub TextBoxbusNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxbusNombre.TextChanged
            If Not validacion.IsTextValid(TextBoxbusNombre.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If
        End Sub





        '********** Validacion Registros de Gestion *********************

        Private Sub TextBoxID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged
            If Not validacion.IsNumeroValid(TextBoxID.Text) Then

                '   MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusID.Clear()
                ' TextBoxbusID.Focus()

            Else

            End If
        End Sub

        Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged
            If Not validacion.IsTextValid(TextBoxNombre.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If

        End Sub

        Private Sub TextBoxApellido_TextChanged(sender As Object, e As EventArgs) Handles TextBoxApellido1.TextChanged
            If Not validacion.IsTextValid(TextBoxApellido1.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If

        End Sub

        Private Sub TextBoxApellido2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxApellido2.TextChanged
            If Not validacion.IsTextValid(TextBoxApellido2.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If

        End Sub

        Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged

        End Sub
        Private Sub TextBoxEmail_Validated(sender As Object, e As EventArgs) Handles TextBoxEmail.Validated
            If Not validacion.EmailValid(TextBoxEmail.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If

        End Sub


        Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuario.TextChanged
            If Not validacion.IsAlfaNumerValid(TextBoxUsuario.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If

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
                Me.ListBoxApellido1.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxID.TopIndex

                Me.ListBoxUsuario.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxID.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxID.TopIndex
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
            ListBoxID.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxContrasena.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxNombre.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxID.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxID.SelectedIndex, True)
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
                Me.ListBoxApellido1.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxUsuario.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxNombre.TopIndex
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
            ListBoxNombre.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxContrasena.SelectedIndex And
            ListBoxNombre.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxNombre.SelectedIndex, True)
            End If
        End Sub



        '*************************
        'Para el ListBoxCategoria
        '**************************
        Private Sub ListBoxCategoria_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido1.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxCategoria_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido1.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxUsuario.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxApellido1.TopIndex
            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxCategoria_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido1.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido1.DoubleClick
            If ListBoxApellido1.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxApellido1.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxApellido1.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxApellido1.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxApellido1.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxApellido1.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxApellido1.SelectedIndex <> ListBoxContrasena.SelectedIndex And
            ListBoxApellido1.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxApellido1.SelectedIndex, True)
            End If
        End Sub



        '*************************
        'Para el ListBoxAncho
        '**************************
        Private Sub ListBoxAncho_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido2.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxAncho_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido2.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxUsuario.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxApellido2.TopIndex
            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxAncho_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido2.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxAncho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido2.DoubleClick
            If ListBoxApellido2.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxApellido2.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxApellido2.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxApellido2.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxApellido2.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxApellido2.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxApellido2.SelectedIndex <> ListBoxContrasena.SelectedIndex And
            ListBoxApellido2.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxApellido2.SelectedIndex, True)
            End If
        End Sub



        '*************************
        'Para el ListBoxLargo
        '**************************
        Private Sub ListBoxLargo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxEmail.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxLargo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxEmail.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxEmail.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxEmail.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxEmail.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxEmail.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxEmail.TopIndex
                Me.ListBoxUsuario.TopIndex = Me.ListBoxEmail.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxEmail.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxEmail.TopIndex
            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxLargo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxEmail.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxLargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmail.DoubleClick
            If ListBoxEmail.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxEmail.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxEmail.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxEmail.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxEmail.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxEmail.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxEmail.SelectedIndex <> ListBoxContrasena.SelectedIndex And
            ListBoxEmail.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxEmail.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxEmail.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxEmail.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxEmail.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxEmail.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxEmail.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxEmail.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxEmail.SelectedIndex, True)
            End If
        End Sub


        '*************************
        'Para el ListBoxColor
        '**************************
        Private Sub ListBoxColor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxTelefono.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxColor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxTelefono.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxUsuario.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxTelefono.TopIndex
            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxColor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxTelefono.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTelefono.DoubleClick
            If ListBoxTelefono.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxTelefono.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxTelefono.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxTelefono.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxTelefono.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxTelefono.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxTelefono.SelectedIndex <> ListBoxContrasena.SelectedIndex And
            ListBoxTelefono.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxTelefono.SelectedIndex, True)
            End If
        End Sub



        '*************************
        'Para el ListBoxPrecio
        '**************************
        Private Sub ListBoxPrecio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxPrecio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If Scrolling Then

            End If
            Scrolling = False
        End Sub





        '*************************
        'Para el ListBoxStock
        '**************************
        Private Sub ListBoxStock_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxUsuario.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxStock_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxUsuario.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxUsuario.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxUsuario.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxUsuario.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxUsuario.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxUsuario.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxUsuario.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxUsuario.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxUsuario.TopIndex
            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxStock_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxUsuario.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxUsuario.DoubleClick
            If ListBoxUsuario.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxUsuario.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxUsuario.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxUsuario.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxUsuario.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxUsuario.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxUsuario.SelectedIndex <> ListBoxContrasena.SelectedIndex And
            ListBoxUsuario.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxUsuario.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxUsuario.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxUsuario.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxUsuario.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxUsuario.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxUsuario.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxUsuario.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxUsuario.SelectedIndex, True)
            End If
        End Sub



        '*************************
        'Para el ListBoxProveedor
        '**************************
        Private Sub ListBoxProveedor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxContrasena.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxProveedor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxContrasena.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxContrasena.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxContrasena.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxContrasena.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxContrasena.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxContrasena.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxContrasena.TopIndex
                Me.ListBoxUsuario.TopIndex = Me.ListBoxContrasena.TopIndex
                Me.ListBoxRol.TopIndex = Me.ListBoxContrasena.TopIndex
            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxProveedor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxContrasena.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxContrasena.DoubleClick
            If ListBoxContrasena.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxContrasena.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxContrasena.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxContrasena.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxContrasena.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxContrasena.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxContrasena.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxContrasena.SelectedIndex <> ListBoxRol.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxContrasena.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxContrasena.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxContrasena.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxContrasena.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxContrasena.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxContrasena.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxContrasena.SelectedIndex, True)
                ListBoxRol.SetSelected(ListBoxContrasena.SelectedIndex, True)
            End If
        End Sub



        '*************************
        'Para el ListBoxRutaImagen
        '**************************
        Private Sub ListBoxRutaImagen_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxRol.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxRutaImagen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxRol.MouseMove
            If Scrolling Then
                Me.ListBoxID.TopIndex = Me.ListBoxRol.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxRol.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxRol.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxRol.TopIndex
                Me.ListBoxEmail.TopIndex = Me.ListBoxRol.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxRol.TopIndex
                Me.ListBoxUsuario.TopIndex = Me.ListBoxRol.TopIndex
                Me.ListBoxContrasena.TopIndex = Me.ListBoxRol.TopIndex
            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxRutaImagen_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxRol.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxRutaImagen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxRol.DoubleClick
            If ListBoxRol.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxRol.SelectedIndex <> ListBoxNombre.SelectedIndex And
            ListBoxRol.SelectedIndex <> ListBoxApellido1.SelectedIndex And
            ListBoxRol.SelectedIndex <> ListBoxApellido2.SelectedIndex And
            ListBoxRol.SelectedIndex <> ListBoxEmail.SelectedIndex And
            ListBoxRol.SelectedIndex <> ListBoxTelefono.SelectedIndex And
            ListBoxRol.SelectedIndex <> ListBoxUsuario.SelectedIndex And
            ListBoxRol.SelectedIndex <> ListBoxContrasena.SelectedIndex Then

                ListBoxID.SetSelected(ListBoxRol.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxRol.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxRol.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxRol.SelectedIndex, True)
                ListBoxEmail.SetSelected(ListBoxRol.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxRol.SelectedIndex, True)
                ListBoxUsuario.SetSelected(ListBoxRol.SelectedIndex, True)
                ListBoxContrasena.SetSelected(ListBoxRol.SelectedIndex, True)
            End If
        End Sub




        'limpiar pantalla
        Public Sub limpiarPantalla()
            TextBoxID.Clear()
            TextBoxbusId.Clear()
            TextBoxNombre.Clear()
            TextBoxbusNombre.Clear()
            TextBoxApellido1.Clear()
            TextBoxApellido2.Clear()
            TextBoxEmail.Clear()
            TextBoxTelefono.Clear()
            TextBoxUsuario.Clear()
            TextBoxConntrasena.Clear()
            ComboBoxRol.ResetText()


            ListBoxID.Items.Clear()
            ListBoxNombre.Items.Clear()
            ListBoxApellido1.Items.Clear()
            ListBoxApellido2.Items.Clear()
            ListBoxEmail.Items.Clear()
            ListBoxTelefono.Items.Clear()
            ListBoxUsuario.Items.Clear()
            ListBoxContrasena.Items.Clear()
            ListBoxRol.Items.Clear()



        End Sub

        ' Public Function existeEmpleado() As Boolean
        '  Dim r As Boolean
        '  Try

        ' Dim pos As Integer
        ' pos = Val(TextBoxID.Text)
        '  FileOpen(1, ge.ruta, OpenMode.Random, OpenAccess.Read, , Len(ge.empleado))
        '  Seek(1, pos)
        '  FileGet(1, ge.empleado, )
        'If ge.empleado.id > 0 Then
        '     MsgBox("Cliente ya exsite . Alta fallida ", 64, "Gestion Clientes")

        ' r = True
        '     Else r = False
        '     End If
        '   Catch ex As Exception
        'aqui buscamos el Error en GestionErrores
        '    Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

        'guardamos el Exception
        '    errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

        'si no ecuentramos el error mostrar mensaje del exepcion capturada
        '    If buscarError = False Then
        '     MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
        '     End If


        ' End Try
        ' FileClose(1)

        '  Return r
        ' End Function


        Private Sub ButtonAlta_Click(sender As Object, e As EventArgs) Handles ButtonAlta.Click
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or TextBoxApellido1.Text = "" Or TextBoxEmail.Text = "" Or TextBoxTelefono.Text = "" Or TextBoxUsuario.Text = "" Or TextBoxConntrasena.Text = "" Or ComboBoxRol.Text = "" Then
                MsgBox("Porfavor rellene los campos . ", 64, "Gestion Empleados")


            Else

                Try

                    Dim pos As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, ge.ruta, OpenMode.Random, OpenAccess.Write, , Len(ge.empleado))

                    ge.empleado.id = Trim(TextBoxID.Text)
                    ge.empleado.nombre = Trim(TextBoxNombre.Text)
                    ge.empleado.apellido1 = Trim(TextBoxApellido1.Text)
                    ge.empleado.apellido2 = Trim(TextBoxApellido2.Text)
                    ge.empleado.email = Trim(TextBoxEmail.Text)
                    ge.empleado.rol = Trim(ComboBoxRol.SelectedItem)
                    ge.empleado.usuario = Trim(TextBoxUsuario.Text)
                    ge.empleado.conntrasena = Trim(TextBoxConntrasena.Text)
                    ge.empleado.telefono = Trim(Val(TextBoxTelefono.Text))
                    FilePut(1, ge.empleado, pos)



                    MsgBox("Empleado guardado con éxito", 64, "Gestion Clientes")

                    limpiarPantalla()






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
            '





        End Sub

        Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
            If TextBoxbusId.Text = "" And TextBoxbusNombre.Text = "" And TextBoxbusNombre.Text = "" Then
                MsgBox("Porfavor rellene un campo de Busqueda. ", 64, "Gestion Empleados")
            Else
                Try


                    Dim pos As Integer
                    'aqui la posicion que busacamos
                    pos = Val(TextBoxbusId.Text)

                    'abremos flujos
                    FileOpen(1, ge.ruta, OpenMode.Random, OpenAccess.Read, , Len(ge.empleado))
                    'nos posicionamos
                    Seek(1, pos)
                    'leemeos
                    FileGet(1, ge.empleado, )
                    'si exsiste leyemos añdimos los datos listbox
                    If ge.empleado.id > 0 Then

                        If (ListBoxID.Items.Contains(ge.empleado.id)) Then

                            MsgBox("Articulo ya existe . ", 64, "Gestion Articulos")
                        Else
                            ListBoxID.Items.Add(ge.empleado.id)
                            ListBoxNombre.Items.Add(ge.empleado.nombre)
                            ListBoxApellido1.Items.Add(ge.empleado.apellido1)
                            ListBoxApellido2.Items.Add(ge.empleado.apellido2)
                            ListBoxEmail.Items.Add(ge.empleado.email)
                            ListBoxTelefono.Items.Add(ge.empleado.telefono)
                            ListBoxUsuario.Items.Add(ge.empleado.usuario)
                            ListBoxContrasena.Items.Add(ge.empleado.conntrasena)
                            ListBoxRol.Items.Add(ge.empleado.rol)

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

        Private Sub ListBoxID_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxID.SelectedIndexChanged
            TextBoxID.Text = Trim(ListBoxID.SelectedItem)
            TextBoxNombre.Text = Trim(ListBoxNombre.SelectedItem)
            TextBoxApellido1.Text = Trim(ListBoxApellido1.SelectedItem)
            TextBoxApellido2.Text = Trim(ListBoxApellido2.SelectedItem)
            TextBoxEmail.Text = Trim(ListBoxEmail.SelectedItem)
            TextBoxTelefono.Text = Trim(ListBoxTelefono.SelectedItem)
            TextBoxUsuario.Text = Trim(ListBoxUsuario.SelectedItem)
            TextBoxConntrasena.Text = Trim(ListBoxContrasena.SelectedItem)
            ComboBoxRol.Text = Trim(ComboBoxRol.SelectedItem)
        End Sub

        Private Sub ListBoxNombre_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxNombre.SelectedIndexChanged
            TextBoxID.Text = Trim(ListBoxID.SelectedItem)
            TextBoxNombre.Text = Trim(ListBoxNombre.SelectedItem)
            TextBoxApellido1.Text = Trim(ListBoxApellido1.SelectedItem)
            TextBoxApellido2.Text = Trim(ListBoxApellido2.SelectedItem)
            TextBoxEmail.Text = Trim(ListBoxEmail.SelectedItem)
            TextBoxTelefono.Text = Trim(ListBoxTelefono.SelectedItem)
            TextBoxUsuario.Text = Trim(ListBoxUsuario.SelectedItem)
            TextBoxConntrasena.Text = Trim(ListBoxContrasena.SelectedItem)
            ComboBoxRol.Text = Trim(ComboBoxRol.SelectedItem)
        End Sub

        Private Sub ListBoxApellido1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido1.SelectedIndexChanged
            TextBoxID.Text = ListBoxID.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxEmail.Text = ListBoxEmail.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
            TextBoxUsuario.Text = ListBoxUsuario.SelectedItem
            TextBoxConntrasena.Text = ListBoxContrasena.SelectedItem
            ComboBoxRol.Text = ComboBoxRol.SelectedItem
        End Sub

        Private Sub ListBoxApellido2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido2.SelectedIndexChanged
            TextBoxID.Text = ListBoxID.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxEmail.Text = ListBoxEmail.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
            TextBoxUsuario.Text = ListBoxUsuario.SelectedItem
            TextBoxConntrasena.Text = ListBoxContrasena.SelectedItem
            ComboBoxRol.Text = ComboBoxRol.SelectedItem
        End Sub

        Private Sub ListBoxEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmail.SelectedIndexChanged
            TextBoxID.Text = ListBoxID.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxEmail.Text = ListBoxEmail.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
            TextBoxUsuario.Text = ListBoxUsuario.SelectedItem
            TextBoxConntrasena.Text = ListBoxContrasena.SelectedItem
            ComboBoxRol.Text = ComboBoxRol.SelectedItem
        End Sub

        Private Sub ListBoxTelefono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTelefono.SelectedIndexChanged
            TextBoxID.Text = ListBoxID.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxEmail.Text = ListBoxEmail.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
            TextBoxUsuario.Text = ListBoxUsuario.SelectedItem
            TextBoxConntrasena.Text = ListBoxContrasena.SelectedItem
            ComboBoxRol.Text = ComboBoxRol.SelectedItem
        End Sub

        Private Sub ListBoxUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxUsuario.SelectedIndexChanged
            TextBoxID.Text = ListBoxID.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxEmail.Text = ListBoxEmail.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
            TextBoxUsuario.Text = ListBoxUsuario.SelectedItem
            TextBoxConntrasena.Text = ListBoxContrasena.SelectedItem
            ComboBoxRol.Text = ComboBoxRol.SelectedItem
        End Sub

        Private Sub ListBoxContrasena_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxContrasena.SelectedIndexChanged
            TextBoxID.Text = ListBoxID.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxEmail.Text = ListBoxEmail.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
            TextBoxUsuario.Text = ListBoxUsuario.SelectedItem
            TextBoxConntrasena.Text = ListBoxContrasena.SelectedItem
            ComboBoxRol.Text = ComboBoxRol.SelectedItem
        End Sub

        Private Sub ListBoxRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxRol.SelectedIndexChanged
            TextBoxID.Text = ListBoxID.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxEmail.Text = ListBoxEmail.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
            TextBoxUsuario.Text = ListBoxUsuario.SelectedItem
            TextBoxConntrasena.Text = ListBoxContrasena.SelectedItem
            ComboBoxRol.Text = ComboBoxRol.SelectedItem
        End Sub

        Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or TextBoxApellido1.Text = "" Or TextBoxEmail.Text = "" Or TextBoxTelefono.Text = "" Or TextBoxUsuario.Text = "" Or TextBoxConntrasena.Text = "" Or ComboBoxRol.Text = "" Then
                MsgBox("Porfavor rellene los campos . ", 64, "Gestion Empleados")


            Else
                Try

                    Dim pos As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, ge.ruta, OpenMode.Random, OpenAccess.Write, , Len(ge.empleado))
                    Seek(1, pos)
                    ge.empleado.id = TextBoxID.Text
                    ge.empleado.nombre = TextBoxNombre.Text
                    ge.empleado.apellido1 = TextBoxApellido1.Text
                    ge.empleado.apellido2 = TextBoxApellido2.Text
                    ge.empleado.email = TextBoxEmail.Text
                    ge.empleado.telefono = Val(TextBoxTelefono.Text)
                    ge.empleado.usuario = TextBoxUsuario.Text
                    ge.empleado.conntrasena = TextBoxConntrasena.Text
                    ge.empleado.rol = ComboBoxRol.SelectedItem

                    FilePut(1, ge.empleado, )




                    MsgBox("Producto modificado con éxito", 64, "Articulo Guardado")
                    limpiarPantalla()

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

        'eliminar articulo
        Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or TextBoxApellido1.Text = "" Or TextBoxEmail.Text = "" Or TextBoxTelefono.Text = "" Or TextBoxUsuario.Text = "" Or TextBoxConntrasena.Text = "" Or ComboBoxRol.Text = "" Then
                MsgBox("Porfavor rellene los campos . ", 64, "Gestion Empleados")


            Else
                Try

                    Dim pos, valor As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, ge.ruta, OpenMode.Random, OpenAccess.Write, , Len(ge.empleado))
                    valor = MsgBox("¿Esta seguro de que desea Elminar Articulo?", 36, "Gestion Empleados")
                    If valor = MsgBoxResult.Yes Then
                        ge.empleado.id = ""
                        ge.empleado.nombre = ""
                        ge.empleado.apellido1 = ""
                        ge.empleado.apellido2 = ""
                        ge.empleado.email = ""
                        ge.empleado.telefono = 0
                        ge.empleado.usuario = ""
                        ge.empleado.conntrasena = ""
                        ge.empleado.rol = ""

                        FilePut(1, ge.empleado, pos)
                        MsgBox("Empleado Elimnado con éxito", 64, "Gestion Empleados")
                        limpiarPantalla()

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

        Private Sub TextBoxTelefono_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTelefono.TextChanged
            If Not validacion.IsNumeroValid(TextBoxID.Text) Then


                'TextBoxID.Clear()
                ' TextBoxID.Focus()

            Else
            End If
        End Sub

        Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            PantallaPrincipal.Enabled = True
            PantallaPrincipal.Show()
            Me.Dispose()
        End Sub

    End Class
