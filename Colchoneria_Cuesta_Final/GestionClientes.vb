
Imports BibliotecaClasesColchuneriaCuesta
    Imports System.IO
    Public Class GestionClientes
        'instanciamos un Objeto de clase Validaciones
        Dim validacion As New Validaciones
        Dim errores As New Errores
        Dim gc As New Clientes
        Dim gestionError As New GestionErrores


        Private Sub GestionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            'Estamos metiendo aqui datos.
            limpiarPantalla()

            'cargar Datos datos
            cargarDatos()
        End Sub

        'metodo para cargar datos
        Public Sub cargarDatos()

            FileOpen(1, gc.ruta, OpenMode.Random, OpenAccess.Read, , Len(gc.cliente))
            Seek(1, 1)
            While Not EOF(1)
                FileGet(1, gc.cliente, )
                ListBoxcID.Items.Add(gc.cliente.id)
                ListBoxDNI.Items.Add(gc.cliente.dni)
                ListBoxNombre.Items.Add(gc.cliente.nombre)
                ListBoxApellido1.Items.Add(gc.cliente.apellido1)
                ListBoxApellido2.Items.Add(gc.cliente.apellido2)
                ListBoxTelefono.Items.Add(gc.cliente.telefono)
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
        Private Sub GestiónDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeProductosToolStripMenuItem.Click
            GestionArticulos.Show()
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

        Private Sub TextBoxBusDni_TextChanged(sender As Object, e As EventArgs)
            If Not validacion.IsNumeroValid(TextBoxNombre.Text) Then


                'TextBoxID.Clear()
                ' TextBoxID.Focus()

            Else
            End If
        End Sub



        Private Sub TextBoxBusNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusNombre.TextChanged
            If Not validacion.IsTextValid(TextBoxBusNombre.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If
        End Sub



        '********** Validacion Registros de Gestion *********************
        Private Sub TextBoxID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged
            If Not validacion.IsNumeroValid(TextBoxID.Text) Then


                'TextBoxID.Clear()
                ' TextBoxID.Focus()

            Else
            End If
        End Sub

        Private Sub TextBoxDNI_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDNI.TextChanged
            If Not validacion.dniValid(TextBoxDNI.Text) Then

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

        Private Sub TextBoxTelefono_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTelefono.TextChanged
            If Not validacion.telfonoValid(TextBoxTelefono.Text) Then

                '  MsgBox("el comapo id es incorrecto desde form !...")
                ' TextBoxbusApellido1.Clear()
                'TextBoxbusApellido1.Focus()

            Else

            End If
        End Sub

        Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        End Sub


        Public Scrolling As Boolean
        '*************************
        'Para el ListBoxID
        '**************************
        Private Sub ListBoxID_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxcID.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxID_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxcID.MouseMove
            If Scrolling Then
                Me.ListBoxDNI.TopIndex = Me.ListBoxcID.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxcID.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxcID.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxcID.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxcID.TopIndex



            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxID_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxcID.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxcID.DoubleClick
            If ListBoxcID.SelectedIndex <> ListBoxDNI.SelectedIndex And
                ListBoxcID.SelectedIndex <> ListBoxNombre.SelectedIndex And
                ListBoxcID.SelectedIndex <> ListBoxApellido1.SelectedIndex And
                ListBoxcID.SelectedIndex <> ListBoxApellido2.SelectedIndex And
                ListBoxcID.SelectedIndex <> ListBoxTelefono.SelectedIndex Then



                ListBoxDNI.SetSelected(ListBoxcID.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxcID.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxcID.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxcID.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxcID.SelectedIndex, True)


            End If
        End Sub



        '*************************
        'Para el ListBoxNombre
        '**************************
        Private Sub ListBoxNombre_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDNI.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxNombre_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDNI.MouseMove
            If Scrolling Then
                Me.ListBoxcID.TopIndex = Me.ListBoxDNI.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxDNI.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxDNI.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxDNI.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxDNI.TopIndex


            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxNombre_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDNI.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDNI.DoubleClick
            If ListBoxDNI.SelectedIndex <> ListBoxcID.SelectedIndex And
                ListBoxDNI.SelectedIndex <> ListBoxNombre.SelectedIndex And
                ListBoxDNI.SelectedIndex <> ListBoxApellido1.SelectedIndex And
                ListBoxDNI.SelectedIndex <> ListBoxApellido2.SelectedIndex And
                ListBoxDNI.SelectedIndex <> ListBoxTelefono.SelectedIndex Then


                ListBoxcID.SetSelected(ListBoxDNI.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxDNI.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxDNI.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxDNI.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxDNI.SelectedIndex, True)


            End If
        End Sub



        '*************************
        'Para el ListBoxCategoria
        '**************************
        Private Sub ListBoxCategoria_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxNombre.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxCategoria_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxNombre.MouseMove
            If Scrolling Then
                Me.ListBoxcID.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxDNI.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxNombre.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxNombre.TopIndex


            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxCategoria_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxNombre.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNombre.DoubleClick
            If ListBoxNombre.SelectedIndex <> ListBoxcID.SelectedIndex And
                ListBoxNombre.SelectedIndex <> ListBoxDNI.SelectedIndex And
                ListBoxNombre.SelectedIndex <> ListBoxApellido1.SelectedIndex And
                ListBoxNombre.SelectedIndex <> ListBoxApellido2.SelectedIndex And
                ListBoxNombre.SelectedIndex <> ListBoxTelefono.SelectedIndex Then


                ListBoxcID.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxDNI.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxNombre.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxNombre.SelectedIndex, True)


            End If
        End Sub



        '*************************
        'Para el ListBoxAncho
        '**************************
        Private Sub ListBoxAncho_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido1.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxAncho_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido1.MouseMove
            If Scrolling Then
                Me.ListBoxcID.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxDNI.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxApellido1.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxApellido1.TopIndex


            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxAncho_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido1.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxAncho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido1.DoubleClick
            If ListBoxApellido1.SelectedIndex <> ListBoxcID.SelectedIndex And
                ListBoxApellido1.SelectedIndex <> ListBoxDNI.SelectedIndex And
                ListBoxApellido1.SelectedIndex <> ListBoxNombre.SelectedIndex And
                ListBoxApellido1.SelectedIndex <> ListBoxApellido2.SelectedIndex And
                ListBoxApellido1.SelectedIndex <> ListBoxTelefono.SelectedIndex Then



                ListBoxcID.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxDNI.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxApellido1.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxApellido1.SelectedIndex, True)


            End If
        End Sub



        '*************************
        'Para el ListBoxLargo
        '**************************
        Private Sub ListBoxLargo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido2.MouseDown
            If e.Button = MouseButtons.Left Then
                Scrolling = True
            Else
                Scrolling = False
            End If
        End Sub
        'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
        Private Sub ListBoxLargo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido2.MouseMove
            If Scrolling Then
                Me.ListBoxcID.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxDNI.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxApellido2.TopIndex
                Me.ListBoxTelefono.TopIndex = Me.ListBoxApellido2.TopIndex


            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxLargo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxApellido2.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxLargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido2.DoubleClick
            If ListBoxApellido2.SelectedIndex <> ListBoxcID.SelectedIndex And
                ListBoxApellido2.SelectedIndex <> ListBoxDNI.SelectedIndex And
                ListBoxApellido2.SelectedIndex <> ListBoxNombre.SelectedIndex And
                ListBoxApellido2.SelectedIndex <> ListBoxApellido1.SelectedIndex And
                ListBoxApellido2.SelectedIndex <> ListBoxTelefono.SelectedIndex Then



                ListBoxcID.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxDNI.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxApellido2.SelectedIndex, True)
                ListBoxTelefono.SetSelected(ListBoxApellido2.SelectedIndex, True)


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
                Me.ListBoxcID.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxDNI.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxNombre.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxApellido1.TopIndex = Me.ListBoxTelefono.TopIndex
                Me.ListBoxApellido2.TopIndex = Me.ListBoxTelefono.TopIndex


            End If
            Scrolling = False
        End Sub
        'Método que cambia el
        Private Sub ListBoxColor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxTelefono.MouseUp
            Scrolling = False
        End Sub

        'Para controlar que se seleccione la misma línea
        Private Sub ListBoxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTelefono.DoubleClick
            If ListBoxTelefono.SelectedIndex <> ListBoxcID.SelectedIndex And
                ListBoxTelefono.SelectedIndex <> ListBoxDNI.SelectedIndex And
                ListBoxTelefono.SelectedIndex <> ListBoxNombre.SelectedIndex And
                ListBoxTelefono.SelectedIndex <> ListBoxApellido1.SelectedIndex And
                ListBoxTelefono.SelectedIndex <> ListBoxApellido2.SelectedIndex Then



                ListBoxcID.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxDNI.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxNombre.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxApellido1.SetSelected(ListBoxTelefono.SelectedIndex, True)
                ListBoxApellido2.SetSelected(ListBoxTelefono.SelectedIndex, True)


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

        '****************************************************************************





        'metodo para limpiar la pantalla

        Public Sub limpiarPantalla()
            TextBoxID.Clear()
            TextBoxDNI.Clear()
            TextBoxNombre.Clear()

            TextBoxNombre.Clear()
            TextBoxBusNombre.Clear()
            TextBoxApellido1.Clear()
            TextBoxApellido2.Clear()
            TextBoxTelefono.Clear()


            'limpiar listbox
            ListBoxcID.Items.Clear()
            ListBoxDNI.Items.Clear()
            ListBoxNombre.Items.Clear()

            ListBoxApellido1.Items.Clear()
            ListBoxApellido2.Items.Clear()
            ListBoxTelefono.Items.Clear()



        End Sub
        'andir un cliente
        Private Sub ButtonAlta_Click(sender As Object, e As EventArgs) Handles ButtonAlta.Click
            'comprobar si los compos estan llenos 
            If TextBoxID.Text = "" Or TextBoxDNI.Text = "" Or TextBoxNombre.Text = "" Or TextBoxApellido1.Text = "" Or TextBoxTelefono.Text = "" Then
                MsgBox("Porfavor rellene los campos.", 64, "Gestion Clientes")
            Else

                Try

                    Dim pos As Integer
                    pos = Val(TextBoxID.Text)
                    FileOpen(1, gc.ruta, OpenMode.Random, OpenAccess.Write, , Len(gc.cliente))

                    'nos posicionamos
                    '   Seek(1, pos)
                    'leemeos
                    '   FileGet(1, gc.cliente, )
                    'comprobar si articulo existe
                    'si exsiste leyemos añdimos los datos listbox
                    ' If gc.cliente.id > 0 Then
                    '  MsgBox("Cliente ya exsite . Alta fallida ", 64, "Gestion Clientes")




                    '  Else
                    gc.cliente.id = Trim(TextBoxID.Text)
                    gc.cliente.dni = Trim(TextBoxDNI.Text)
                    gc.cliente.nombre = Trim(TextBoxNombre.Text)
                    gc.cliente.apellido1 = Trim(TextBoxApellido1.Text)
                    gc.cliente.apellido2 = Trim(TextBoxApellido2.Text)
                    gc.cliente.telefono = Trim(Val(TextBoxTelefono.Text))
                    FilePut(1, gc.cliente, pos)


                    MsgBox("Cliente guardado con éxito", 64, "Gestion Clientes")

                    limpiarPantalla()
                    '  End If




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


        'eliminar un cliente
        Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
            If TextBoxDNI.Text = "" Or TextBoxNombre.Text = "" Or TextBoxApellido1.Text = "" Or TextBoxTelefono.Text = "" Then
                MsgBox("Porfavor rellene los campos o seleccione un cliente . ", 64, "Gestion Clientes")
            Else
                Try


                    Dim pos, valor As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, gc.ruta, OpenMode.Random, OpenAccess.Write, , Len(gc.cliente))
                    valor = MsgBox("¿Esta seguro de que desea Elminar Articulo?", 36, "Gestion Clientes")
                    If valor = MsgBoxResult.Yes Then

                        gc.cliente.id = ""
                        gc.cliente.dni = ""
                        gc.cliente.nombre = ""
                        gc.cliente.apellido1 = ""
                        gc.cliente.apellido2 = ""
                        gc.cliente.telefono = 0


                        FilePut(1, gc.cliente, pos)
                        MsgBox("cliente Elimnado con éxito", 64, "Gestion Clientes")
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
        'modificar un cliente
        Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
            If TextBoxDNI.Text = "" Or TextBoxNombre.Text = "" Or TextBoxApellido1.Text = "" Or TextBoxTelefono.Text = "" Then
                MsgBox("Porfavor rellene los campos o seleccione un cliente . ", 64, "Gestion Clientes")
            Else
                Try

                    Dim pos As Integer
                    pos = Val(TextBoxID.Text)

                    FileOpen(1, gc.ruta, OpenMode.Random, OpenAccess.Write, , Len(gc.cliente))
                    Seek(1, pos)
                    gc.cliente.id = TextBoxID.Text
                    gc.cliente.dni = TextBoxDNI.Text
                    gc.cliente.nombre = TextBoxNombre.Text
                    gc.cliente.apellido1 = TextBoxApellido1.Text
                    gc.cliente.apellido2 = TextBoxApellido2.Text
                    gc.cliente.telefono = Val(TextBoxTelefono.Text)

                    FilePut(1, gc.cliente, )




                    MsgBox("Cliente modificado con éxito", 64, "Gestion Clientes")
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

        'buscar un cliente 
        Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles ButtonBusca.Click

            If TextBoxBusId.Text = "" And TextBoxBusNombre.Text = "" Then
                MsgBox("Porfavor rellene un campo de Busqueda. ", 64, "Gestion Clientes")
            Else
                Try


                    Dim pos As Integer
                    'aqui la posicion que busacamos
                    pos = Val(TextBoxBusId.Text)

                    'abremos flujos
                    FileOpen(1, gc.ruta, OpenMode.Random, OpenAccess.Read, , Len(gc.cliente))
                    'nos posicionamos
                    Seek(1, pos)
                    'leemeos
                    FileGet(1, gc.cliente, )
                    'si exsiste leyemos añdimos los datos listbox
                    If gc.cliente.id > 0 Then

                        If (ListBoxcID.Items.Contains(gc.cliente.id)) Then

                            MsgBox("Cliente ya existe  . ", 64, "Gestion Clientes")
                        Else
                            ListBoxcID.Items.Add(gc.cliente.id)
                            ListBoxDNI.Items.Add(gc.cliente.dni)
                            ListBoxNombre.Items.Add(gc.cliente.nombre)
                            ListBoxApellido1.Items.Add(gc.cliente.apellido1)
                            ListBoxApellido2.Items.Add(gc.cliente.apellido2)
                            ListBoxTelefono.Items.Add(gc.cliente.telefono)

                        End If



                    Else

                        MsgBox("Cliente no exsite . Busqueda fallida ", 64, "Gestion Clientes")
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

        Private Sub ListBoxcID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxcID.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxcID.SelectedItem
            TextBoxDNI.Text = ListBoxDNI.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
        End Sub

        Private Sub ListBoxDNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDNI.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxcID.SelectedItem
            TextBoxDNI.Text = ListBoxDNI.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
        End Sub

        Private Sub ListBoxNombre_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBoxNombre.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxcID.SelectedItem
            TextBoxDNI.Text = ListBoxDNI.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
        End Sub

        Private Sub ListBoxApellido1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido1.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxcID.SelectedItem
            TextBoxDNI.Text = ListBoxDNI.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
        End Sub

        Private Sub ListBoxApellido2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxApellido2.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxcID.SelectedItem
            TextBoxDNI.Text = ListBoxDNI.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
        End Sub

        Private Sub ListBoxTelefono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTelefono.SelectedIndexChanged
            'anadir selected item de listbox a los textbox
            TextBoxID.Text = ListBoxcID.SelectedItem
            TextBoxDNI.Text = ListBoxDNI.SelectedItem
            TextBoxNombre.Text = ListBoxNombre.SelectedItem
            TextBoxApellido1.Text = ListBoxApellido1.SelectedItem
            TextBoxApellido2.Text = ListBoxApellido2.SelectedItem
            TextBoxTelefono.Text = ListBoxTelefono.SelectedItem
        End Sub

        Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            PantallaPrincipal.Enabled = True
            PantallaPrincipal.Show()
            Me.Dispose()
        End Sub
    End Class




