Imports System.IO
Public Class Clientes


    Public errores As New Errores
    Public gestionError As New GestionErrores



    Public ruta As String = "Clientes\clientes.txt"



    'Constructor
    Public Sub New()
        MyBase.New()
        Try
            ' se va a crear un directorio y un archivo, comprobando si existe o no
            If Not Directory.Exists("Clientes") Then
                Directory.CreateDirectory("Clientes")
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



    'definicion de los datos de form gestion Clientes
    Structure structureCliente
        Public id As String
        <VBFixedString(8)> Public dni As String
        <VBFixedString(20)> Public nombre As String
        <VBFixedString(20)> Public apellido1 As String
        Public telefono As Integer
        <VBFixedString(20)> Public apellido2 As String
    End Structure

    Public cliente As New structureCliente





End Class
