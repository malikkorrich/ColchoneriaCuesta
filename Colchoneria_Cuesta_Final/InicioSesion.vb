
Imports BibliotecaClasesColchuneriaCuesta
    Public Class InicioSesion
        Dim gestionError As New GestionErrores
        Dim errores As New Errores
        Dim ge As New Empleados
        Private Const ruta As String = "Usuarios\ursuarios.txt"
        Dim flag As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'quitar button close del formulario
        Me.ControlBox = False
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("http://www.colchoneriacuestavallehermoso.com/Contacto/")
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click

        If MsgBox("¿Esta seguro de que desea salir de la aplicación?", 36, "Salir") = 6 Then
            Application.Exit()
        End If
    End Sub
    Private Sub btInicioSesion_Click(sender As Object, e As EventArgs) Handles ButtonInicioSesion.Click
        If TextBoxUsuario.Text = "" Or TextBoxContrasenna.Text = "" Then
            MsgBox("Porfavor rellene los campos de entrada. ", 64, "Mensajes del Sistema")
        Else
            Try
                Dim pos As Integer
                pos = 0
                FileOpen(1, ge.ruta, OpenMode.Random, OpenAccess.Read, , Len(ge.empleado))
                'nos posicionamos
                Seek(1, pos)
                'leemeos
                'comprobar si articulo existe
                'si exsiste leyemos añdimos los datos listbox
                While Not EOF(1)
                    FileGet(1, ge.empleado, )
                    ' If TextBoxUsuario.Text = ge.empleado.usuario And TextBoxContrasenna.Text = ge.empleado.conntrasena Then
                    If Trim(TextBoxUsuario.Text) = Trim(ge.empleado.usuario) And Trim(TextBoxContrasenna.Text) = Trim(ge.empleado.conntrasena) Then
                        MsgBox("Bienvenido :" & ge.empleado.nombre, 64, "Mensajes del Sistema")
                        'Controlamos los roles
                        If (Trim(ge.empleado.rol) = "Administrador") Then
                            ' MsgBox("eres admin", 6, "Mensajes del Sistema")
                            flag = True
                            Me.Hide()
                            PantallaPrincipal.Show()
                        ElseIf (Trim(ge.empleado.rol) = "Usuario") Then
                            flag = True
                            ' MsgBox("eres userrio")
                            Me.Hide()

                            'Rol Usuario (disabilitar Menu del formulario)

                            PantallaPrincipal.MenuStripPagPrin.Items(2).Enabled = False  'gestion empleadoa
                            PantallaPrincipal.MenuStripPagPrin.Items(4).Enabled = False ' caja

                            GestionArticulos.MenuStripPagPrin.Items(1).Enabled = False  'gestion empleadoa
                            GestionArticulos.MenuStripPagPrin.Items(3).Enabled = False   'caja

                            GestionClientes.MenuStripPagPrin.Items(2).Enabled = False  'gestion empleadoa
                            GestionClientes.MenuStripPagPrin.Items(3).Enabled = False  'caja

                            'Aparece la pantalla principal
                            PantallaPrincipal.Show()

                        End If
                        Exit While
                    End If
                    pos += 1
                End While


                If flag = False Then
                    MsgBox("Usuario y contraseña invalidos, verifique", 6, "Mensajes del Sistema")
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

    Public Sub limpiarPantalla()
        TextBoxUsuario.Clear()
        TextBoxContrasenna.Clear()
    End Sub

End Class

