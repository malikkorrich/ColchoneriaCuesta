Imports System.IO

Public Class Errores
    Dim errores As New GestionErrores
    Dim fichero As FileStream
    Dim sw As StreamWriter

    Public Sub New()
        MyBase.New()

        'Gestion de directory y del fichiro errores (creación del directorio y del fichero donde guardaremos los errores)
        Try
            If Not Directory.Exists("Errores") Then
                Directory.CreateDirectory("Errores")
            End If

            'Creamos el fichero si no existe
            If File.Exists("Errores/errores.txt") = False Then
                File.Create("Errores/errores.txt")
            End If

        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = errores.mostrarError(Err.Number)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            If buscarError = False Then
                MsgBox("Error : " & ex.Message, MsgBoxStyle.Exclamation)
            End If

        End Try

    End Sub

    'metodo para grabar los errrors

    Public Sub guardarError(ByVal mensajeError As String)
        Try
            fichero = New FileStream("Errores/errores.txt", FileMode.Append, FileAccess.Write)
            Dim contenedorError As String
            sw = New StreamWriter(fichero)

            'aqui guardamos el error y la fecha
            contenedorError = Format(Now, " - dd-mm-yyyy - ") & TimeString & " || " & mensajeError
            'escribimos el error 
            sw.WriteLine(contenedorError)

        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = errores.mostrarError(Err.Number)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            If buscarError = False Then
                MsgBox("Error nº: " & Err.Number & ". " & ex.Message, MsgBoxStyle.Exclamation, ex.Message)
            End If

        End Try

        'Cerrar fichero y el StreamWriter
        sw.Close()
        fichero.Close()

    End Sub

End Class
