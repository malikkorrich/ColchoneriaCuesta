Imports BibliotecaClasesColchuneriaCuesta
Imports System.IO



Public Class FormItems
    'instanciamos un Objeto de clase Validaciones
    Dim validacion As New Validaciones
    Dim errores As New Errores

    Dim gestionError As New GestionErrores
    Dim ga As New Articulos

    Private Sub FormPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileOpen(1, "Cuesta_3.txt", OpenMode.Append)
        FileClose(1)
        VolcarDatos()


    End Sub

    Private Sub ListBoxNumeroCaja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxID.DoubleClick
        If ListBoxID.SelectedIndex <> ListBoxDescripcion.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxPrecio.SelectedIndex Then

            ListBoxDescripcion.SetSelected(ListBoxID.SelectedIndex, True)
            ListBoxStock.SetSelected(ListBoxID.SelectedIndex, True)
            ListBoxPrecio.SetSelected(ListBoxID.SelectedIndex, True)
        End If
    End Sub

    Dim articulo As New Estructurearticulos
    Private Sub VolcarDatos()
        'Vuelca contenido del fihciero sequencial en listbox
        ListBoxID.Items.Clear()
        ListBoxDescripcion.Items.Clear()
        ListBoxStock.Items.Clear()
        ListBoxPrecio.Items.Clear()
        Try
            FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Read, , Len(ga.articulo))
            Seek(1, 1)
            While Not EOF(1)
                FileGet(1, ga.articulo, )


                ListBoxID.Items.Add(ga.articulo.id)

                ListBoxDescripcion.Items.Add(ga.articulo.nombre & " " & ga.articulo.ancho & "x" & ga.articulo.largo & " " & ga.articulo.color)
                ListBoxStock.Items.Add(ga.articulo.stock)
                ListBoxPrecio.Items.Add(ga.articulo.precio)


            End While

        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            Errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)

            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            If buscarError = False Then
                MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try

        FileClose(1)



    End Sub


    Private Sub ListBoxFormularioItems_DoubleClick2(sender As Object, e As EventArgs) Handles ListBoxID.DoubleClick, ListBoxDescripcion.DoubleClick, ListBoxStock.DoubleClick, ListBoxPrecio.DoubleClick
        Dim flag As Boolean = False
        Dim existe As Boolean = False
        Dim listId As Integer = 0

        Try
            FileOpen(1, ga.ruta, OpenMode.Random, OpenAccess.Read, , Len(ga.articulo))
            Seek(1, 1)
            While Not EOF(1)
                FileGet(1, ga.articulo, )





                'si campo coresponde al que buscamos

                If ga.articulo.id = ListBoxID.SelectedItem Then
                    'Se recorre la lista principal
                    For a As Integer = 0 To PantallaPrincipal.ListBoxID.Items.Count - 1
                        If PantallaPrincipal.ListBoxID.Items(a).ToString = ga.articulo.id Then
                            existe = True
                            listId = a
                            Exit For
                        End If
                    Next

                    If existe Then
                        Dim numItems As Integer = PantallaPrincipal.ListBoxUnidades.Items(listId).ToString + 1
                        PantallaPrincipal.ListBoxUnidades.Items(listId) = numItems
                        PantallaPrincipal.ListBoxPrecioTotal.Items(listId) = (numItems * ga.articulo.precio)
                    Else
                        'Cargamos los datos necesarios en la cesta de compra 
                        PantallaPrincipal.ListBoxID.Items.Add(ga.articulo.id)
                        PantallaPrincipal.ListBoxUnidades.Items.Add(1) '***************
                        PantallaPrincipal.ListBoxDescripcion.Items.Add(ga.articulo.Categoria & " " & ga.articulo.ancho & "x" & ga.articulo.largo & " " & ga.articulo.color)
                        PantallaPrincipal.ListBoxPrecioUnidad.Items.Add(ga.articulo.precio)
                        PantallaPrincipal.ListBoxPrecioTotal.Items.Add(ga.articulo.precio) '*****
                    End If

                    'Para el label Total a pagar 
                    sumadorPrecio = sumadorPrecio + ga.articulo.precio
                    PantallaPrincipal.LabelTotalAPagarNumerico.Text = (sumadorPrecio)

                    PantallaPrincipal.ButtonQuitarLista.Enabled = True
                    flag = True
                    'salimos de bulce
                    Exit While
                End If
            End While
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
        If flag = False Then
            MsgBox("Registro no Econtrado")
        End If

    End Sub



    Private Sub Form1_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PantallaPrincipal.Enabled = True
        PantallaPrincipal.Show()
        Me.Dispose()


    End Sub







    'Ordenar las ListBox en caso de que haya Scroll
    Dim Scrolling As Boolean

    'Para el ListBoxID

    Private Sub ListBoxID_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxID.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxID.MouseMove
        If Scrolling Then
            Me.ListBoxDescripcion.TopIndex = Me.ListBoxID.TopIndex
            Me.ListBoxStock.TopIndex = Me.ListBoxID.TopIndex
            Me.ListBoxPrecio.TopIndex = Me.ListBoxID.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxID_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxID.MouseUp
        Scrolling = False
    End Sub

    'Para controlar que se seleccione la misma línea
    Private Sub ListBoxID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxID.SelectedIndexChanged
        If ListBoxID.SelectedIndex <> ListBoxDescripcion.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxID.SelectedIndex <> ListBoxPrecio.SelectedIndex Then

            ListBoxDescripcion.SetSelected(ListBoxID.SelectedIndex, True)
            ListBoxStock.SetSelected(ListBoxID.SelectedIndex, True)
            ListBoxPrecio.SetSelected(ListBoxID.SelectedIndex, True)
        End If
    End Sub


    'Para el ListBoxDescripcion

    Private Sub ListBoxDescripcion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDescripcion.MouseDown
        If e.Button = MouseButtons.Left Then
            Scrolling = True
        Else
            Scrolling = False
        End If
    End Sub
    'Método que recibe el Boolean de list box y revisa si se ha hecho Scrolling
    Private Sub ListBoxDescripcion_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDescripcion.MouseMove
        If Scrolling Then
            Me.ListBoxID.TopIndex = Me.ListBoxDescripcion.TopIndex
            Me.ListBoxStock.TopIndex = Me.ListBoxDescripcion.TopIndex
            Me.ListBoxPrecio.TopIndex = Me.ListBoxDescripcion.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxDescripcion_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxDescripcion.MouseUp
        Scrolling = False
    End Sub

    'Para controlar que se seleccione la misma línea
    Private Sub ListBoxDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDescripcion.SelectedIndexChanged
        If ListBoxDescripcion.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxDescripcion.SelectedIndex <> ListBoxStock.SelectedIndex And
            ListBoxDescripcion.SelectedIndex <> ListBoxPrecio.SelectedIndex Then

            ListBoxID.SetSelected(ListBoxDescripcion.SelectedIndex, True)
            ListBoxStock.SetSelected(ListBoxDescripcion.SelectedIndex, True)
            ListBoxPrecio.SetSelected(ListBoxDescripcion.SelectedIndex, True)
        End If
    End Sub

    'Para el ListBoxStock

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
            Me.ListBoxDescripcion.TopIndex = Me.ListBoxStock.TopIndex
            Me.ListBoxPrecio.TopIndex = Me.ListBoxStock.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxStock_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxStock.MouseUp
        Scrolling = False
    End Sub

    'Para controlar que se seleccione la misma línea
    Private Sub ListBoxStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxStock.SelectedIndexChanged
        If ListBoxStock.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxDescripcion.SelectedIndex And
            ListBoxStock.SelectedIndex <> ListBoxPrecio.SelectedIndex Then

            ListBoxID.SetSelected(ListBoxStock.SelectedIndex, True)
            ListBoxDescripcion.SetSelected(ListBoxStock.SelectedIndex, True)
            ListBoxPrecio.SetSelected(ListBoxStock.SelectedIndex, True)
        End If
    End Sub


    'Para el ListBoxPrecio

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
            Me.ListBoxDescripcion.TopIndex = Me.ListBoxPrecio.TopIndex
            Me.ListBoxStock.TopIndex = Me.ListBoxPrecio.TopIndex
        End If
        Scrolling = False
    End Sub
    'Método que cambia el
    Private Sub ListBoxPrecio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPrecio.MouseUp
        Scrolling = False
    End Sub

    'Para controlar que se seleccione la misma línea
    Private Sub ListBoxPrecio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrecio.SelectedIndexChanged
        If ListBoxPrecio.SelectedIndex <> ListBoxID.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxDescripcion.SelectedIndex And
            ListBoxPrecio.SelectedIndex <> ListBoxStock.SelectedIndex Then

            ListBoxID.SetSelected(ListBoxPrecio.SelectedIndex, True)
            ListBoxDescripcion.SetSelected(ListBoxPrecio.SelectedIndex, True)
            ListBoxStock.SetSelected(ListBoxPrecio.SelectedIndex, True)
        End If
    End Sub



End Class