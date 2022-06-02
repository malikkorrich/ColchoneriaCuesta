Public Class FormularioProbarFile

    Dim articulo As New Estructurearticulos

    'Para boton Añadir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Abre Fichiero si no esta lo crea sino 
        'Converte single al string CStr(single)
        Try
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or TextBoxCategoria.Text = "" Then
                MsgBox("Porfavor rellena los campos")
            Else
                'precio csng(textbprecio.txt)
                FileOpen(1, "Cuesta_3.txt", OpenMode.Append)
                Write(1, TextBoxID.Text, TextBoxNombre.Text, TextBoxCategoria.Text, (TextBoxAncho.Text),
                      TextBoxLargo.Text, TextBoxcolor.Text, CSng(TextBoxprecio.Text), CInt(TextBoxstock.Text),
                      TextBoxproveedor.Text, TextBoxrutaimagen.Text)
                FileClose(1)
                MsgBox("Fichiero Guardado")
                TextBoxCategoria.Clear()
                TextBoxNombre.Clear()
                TextBoxID.Clear()
                TextBoxAncho.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error ", "Erro Guardar Fichiero")
        End Try

    End Sub


    'Para boton Leer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Vuelca contenido del fihciero sequencial en listbox

        'Try
        'abro fichiero para lectura /Eof marka final del fichiero
        FileOpen(1, "Cuesta_3.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, articulo.id)
            Input(1, articulo.Nombre)
            Input(1, articulo.Categoria)
            Input(1, articulo.ancho)
            Input(1, articulo.Largo)
            Input(1, articulo.Color)
            Input(1, articulo.Precio)
            Input(1, articulo.Stock)
            Input(1, articulo.Proveedor)
            Input(1, articulo.RutaImagen)

            ListBoxID.Items.Add(articulo.id)
            ListBoxNombre.Items.Add(articulo.Nombre)
            ListBoxCategoria.Items.Add(articulo.Categoria)
            ListBoxAncho.Items.Add(articulo.ancho)
            ListBoxLargo.Items.Add(articulo.Largo)
            ListBoxColor.Items.Add(articulo.Color)
            ListBoxPrecio.Items.Add(articulo.Precio)
            ListBoxStock.Items.Add(articulo.Stock)
            ListBoxProveedor.Items.Add(articulo.Proveedor)
            ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

        End While
        FileClose(1)
        ' Catch ex As Exception
        'MsgBox(ex.Message)
        '   End Try
    End Sub


    Public Sub limpiarPantalla()
        TextBoxID.Clear()
        TextBoxNombre.Clear()
        TextBoxCategoria.Clear()
        TextBoxAncho.Clear()

        ListBoxID.Items.Clear()
        ListBoxNombre.Items.Clear()
        ListBoxCategoria.Items.Clear()
        ListBoxAncho.Items.Clear()
        ListBoxLargo.Items.Clear()
        ListBoxColor.Items.Clear()
        ListBoxPrecio.Items.Clear()
        ListBoxStock.Items.Clear()
        ListBoxProveedor.Items.Clear()
        ListBoxRutaImagen.Items.Clear()

    End Sub

    'Para boton Buscar 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Try
        'Condicion campo vacío
        If TextBoxID.Text <> "" Or TextBoxNombre.Text <> "" Or TextBoxCategoria.Text <> "" Or TextBoxAncho.Text <> "" Then
            'Variable Bandera boobleana que detecta si se encotrno o no un resgistro
            Dim flag As Boolean = False

            'Condicion de si se han escrito datos en campo ID o Nombre


            'Abrimos el Fichero en cuestion
            FileOpen(1, "Cuesta_3.txt", OpenMode.Input)
            'While que lee los datos hasta el fin de fichero (EOF)
            While Not EOF(1)

                'Se lee el campo o los campos que se van a usar para la busqueda
                If TextBoxID.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)

                    'Buscamos alguna coincidencia gracias al bucle While
                    If articulo.id = TextBoxID.Text Then
                        'Se leen los campos que pertenecen a ese ID ya encontrado 
                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)


                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If
                ElseIf TextBoxNombre.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.Nombre = TextBoxNombre.Text Then
                        'Se leen los campos que pertenecen a ese ID ya encontrado 



                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If
                ElseIf TextBoxCategoria.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.Categoria = TextBoxCategoria.Text Then
                        'Se leen los campos que pertenecen a ese ID ya encontrado 



                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)
                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If
                ElseIf TextBoxAncho.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.ancho = TextBoxAncho.Text Then

                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If
                ElseIf TextBoxLargo.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.Largo = TextBoxLargo.Text Then

                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If
                ElseIf TextBoxcolor.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.Color = TextBoxcolor.Text Then

                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If

                ElseIf TextBoxprecio.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.Precio = TextBoxprecio.Text Then

                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If
                ElseIf TextBoxstock.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.Stock = TextBoxstock.Text Then

                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If

                ElseIf TextBoxproveedor.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.Proveedor = TextBoxproveedor.Text Then

                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If

                ElseIf TextBoxrutaimagen.Text <> "" Then
                    Input(1, articulo.id)
                    Input(1, articulo.Nombre)
                    Input(1, articulo.Categoria)
                    Input(1, articulo.ancho)
                    Input(1, articulo.Largo)
                    Input(1, articulo.Color)
                    Input(1, articulo.Precio)
                    Input(1, articulo.Stock)
                    Input(1, articulo.Proveedor)
                    Input(1, articulo.RutaImagen)
                    If articulo.RutaImagen = TextBoxrutaimagen.Text Then

                        'Cargamos los datos en ListBox
                        ListBoxID.Items.Add(articulo.id)
                        ListBoxNombre.Items.Add(articulo.Nombre)
                        ListBoxCategoria.Items.Add(articulo.Categoria)
                        ListBoxAncho.Items.Add(articulo.ancho)
                        ListBoxLargo.Items.Add(articulo.Largo)
                        ListBoxColor.Items.Add(articulo.Color)
                        ListBoxPrecio.Items.Add(articulo.Precio)
                        ListBoxStock.Items.Add(articulo.Stock)
                        ListBoxProveedor.Items.Add(articulo.Proveedor)
                        ListBoxRutaImagen.Items.Add(articulo.RutaImagen)

                        flag = True
                        'Exit While 'Ordenamos salir del bucle
                    End If
                Else
                    MsgBox("Otra cosa")
                End If



            End While
            FileClose(1)
            If flag = False Then
                MsgBox("Registro no Econtrado")
            End If
        Else
            MsgBox("Los campos estan vacios weyG")
        End If
        'Catch ex As Exception
        '     MsgBox(ex.Message)
        ' End Try
    End Sub

    'Para eliminar 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If TextBoxID.Text = "" Or TextBoxNombre.Text = "" Or TextBoxCategoria.Text = "" Then
                MsgBox("Porfavor rellena los campos")
            Else
                'precio csng(textbprecio.txt)
                FileOpen(1, "Cuesta_3.txt", OpenMode.Append)
                Write(1, TextBoxID.Text, TextBoxNombre.Text, TextBoxCategoria.Text, CSng(TextBoxAncho.Text))
                FileClose(1)
                MsgBox("Fichiero Guardado")
                TextBoxCategoria.Clear()
                TextBoxNombre.Clear()
                TextBoxID.Clear()
                TextBoxAncho.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error ", "Erro Guardar Fichiero")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        limpiarPantalla()

    End Sub

    Private Sub FormularioProbarFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class