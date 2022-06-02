Imports System.IO
Public Class Articulos
    Public errores As New Errores
    Public gestionError As New GestionErrores





    Public ruta As String = "Articulos\articulos.txt"
    Public rutaImgen As String = "ImagenProducto\"


    'Constructor
    Public Sub New()
        MyBase.New()
        Try
            ' se va a crear un directorio y un archivo, comprobando si existe o no
            If Not Directory.Exists("Articulos") Then
                Directory.CreateDirectory("Articulos")
            End If
            If File.Exists(ruta) = False Then
                File.Create(ruta).Dispose()
            End If


            If Not Directory.Exists("ImagenProducto") Then
                Directory.CreateDirectory("ImagenProducto")
            End If
            If File.Exists(ruta) = False Then
                File.Create(ruta).Dispose()
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



    'definicion de los datos de form gestion Articulos
    Structure structureArticulo
        Public id As String
        <VBFixedString(50)> Public nombre As String
        <VBFixedString(20)> Public Categoria As String
        Public ancho As Single
        Public largo As Single
        <VBFixedString(20)> Public color As String
        Public precio As Single
        Public stock As Single
        <VBFixedString(20)> Public proveedor As String
    End Structure

    Public articulo As New structureArticulo


End Class
