Imports System.IO
Public Class Empleados
    Public errores As New Errores
    Public gestionError As New GestionErrores

    Public ruta As String = "Usuarios\ursuarios.txt"


    'Constructor
    Public Sub New()
        MyBase.New()
        Try
            ' se va a crear un directorio y un archivo, comprobando si existe o no
            If Not Directory.Exists("Usuarios") Then
                Directory.CreateDirectory("Usuarios")
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


    'definicion de los datos de form gestion Usuarios
    Structure structureEmpleados
        Dim id As String
        <VBFixedString(20)> Public nombre As String
        <VBFixedString(20)> Public apellido1 As String
        <VBFixedString(20)> Public apellido2 As String
        <VBFixedString(50)> Public email As String
        Public telefono As Integer
        <VBFixedString(20)> Public rol As String
        <VBFixedString(20)> Public usuario As String
        <VBFixedString(20)> Public conntrasena As String

    End Structure


    Public empleado As New structureEmpleados

End Class
