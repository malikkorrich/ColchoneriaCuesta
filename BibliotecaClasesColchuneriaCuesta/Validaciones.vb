Imports System.Text.RegularExpressions
Public Class Validaciones
    Dim errores As New Errores

    Dim gestionError As New GestionErrores

    Function IsTextValid(ByVal texto As String) As Boolean
        Dim textValid As Boolean
        Dim a As Integer
        Dim c As Char
        'lista de caracteres no validos
        Dim caracNovalid As String = "'"";:¿?¡!·$%&/()=\|@#[]{}*-_+'"
        Try

            For a = 1 To texto.Length
                c = GetChar(texto, a)
                If IsNumeric(c) Then

                    MsgBox("Por favor, introduzca un valor alfabetico.", 64, "Validaciones")

                    caracNovalid = False
                Else

                    For m = 1 To caracNovalid.Length
                        If c = GetChar(caracNovalid, m) Then

                            caracNovalid = False
                            MsgBox("Por favor, introduzca un valor alfabetico.", MsgBoxStyle.Exclamation)

                        End If
                    Next
                End If
            Next


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

        'retun boolean result
        Return textValid

    End Function



    Function IsNumeroValid(ByVal numero As String) As Boolean

        Dim numeroValid As Boolean
        Dim a As Integer
        Dim c As Char

        Try
            For a = 1 To numero.Length
                c = GetChar(numero, a)
                If Not IsNumeric(c) Then
                    numeroValid = False

                    MsgBox("Por favor, introduzca un valor numerico.", 64, "Validaciones")
                    'Err.Raise(482)

                End If
            Next

        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            ' MsgBox("Por favor, introduce solo numeros de nuevo.", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try
        'retun boolean result
        Return numeroValid

    End Function






    Function IsAlfaNumerValid(ByVal alfanum As String) As Boolean
        Dim a, m As Integer
        Dim c As Char
        Dim alfanumValid As Boolean

        'lista de caracteres no validos
        Dim caracNovalid As String = ",;:¿?¡!·$%&/()=\|@#[]{}*-_+'"
        Try
            For a = 1 To alfanum.Length
                c = GetChar(alfanum, a)

                For m = 1 To caracNovalid.Length
                    If c = GetChar(caracNovalid, m) Then

                        alfanumValid = False

                        MsgBox("Por favor, introduzca un valor alfanumerico", 64, "Validaciones")

                    End If
                Next

            Next


        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            ' MsgBox("Por favor, introduce solo numeros de nuevo.", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try
        'retun boolean result
        Return alfanumValid

    End Function





    Function precioValid(ByVal precio As String) As Boolean
        Dim a, m As Integer
        Dim c, c2 As Char
        Dim preciosValid As Boolean

        'lista de caracteres  validos
        Dim numerosvalid As String = ",9856473210"
        Try
            For a = 1 To precio.Length
                c = GetChar(precio, a)
                If IsNumeric(c) Or c = "," Then

                Else
                    preciosValid = False
                    MsgBox("Por favor, pruebe a introduzca solo números y comas .", 64, "Validaciones")

                End If
            Next


        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            ' MsgBox("Por favor, introduce solo numeros de nuevo.", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try
        'retun boolean result
        Return preciosValid

    End Function



    Function anchoLargoValid(ByVal precio As String) As Boolean
        Dim a, m As Integer
        Dim c, c2 As Char
        Dim charValid As Boolean

        'lista de caracteres  validos
        Dim numerosvalid As String = "'"
        Try
            For a = 1 To precio.Length
                c = GetChar(precio, a)
                If IsNumeric(c) Or c = "'" Then

                Else
                    charValid = False

                    MsgBox("Por favor, pruebe a introduzca solo números y comilla", 64, "Validaciones")
                End If
            Next


        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            ' MsgBox("Por favor, introduce solo numeros de nuevo.", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try
        'retun boolean result
        Return charValid

    End Function












    Function telfonoValid(ByVal telefono As String) As Boolean
        Dim a As Integer
        Dim c As Char
        Dim numeroValid As Boolean


        Try
            For a = 1 To telefono.Length
                c = GetChar(telefono, a)
                If Not IsNumeric(c) Then
                    numeroValid = False

                    'test lanzar y identificar expcion una expcion
                    ' Err.Raise(481)

                    MsgBox("Por favor, introduzca un valor numrtico.", 64, "Validaciones")

                End If
            Next


        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            ' MsgBox("Por favor, introduce solo numeros de nuevo.", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try
        'retun boolean result
        Return numeroValid

    End Function







    Function dniValid(ByVal dni As String) As Boolean
        Dim a As Integer
        Dim c As Char
        Dim dni_Valid As Boolean

        'lista de caracteres no validos
        Dim caracNovalid As String = ",;:¿?¡!·$%&/()=\|@#[]{}*-_+'"
        Try
            For a = 1 To dni.Length
                c = GetChar(dni, a)

                For m = 1 To caracNovalid.Length
                    If c = GetChar(caracNovalid, m) Then

                        dni_Valid = False

                        MsgBox("Por favor, introduzca un caractere alfanumerico.", 64, "Validaciones")


                    End If
                Next

            Next



        Catch ex As Exception
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            ' MsgBox("Por favor, introduce solo numeros de nuevo.", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try
        'retun boolean result
        Return dni_Valid

    End Function






    Public Function EmailValid(ByVal email As String) As Boolean
        Dim email_Valid As Boolean
        Try
            ' retorna true o false   
            If Regex.IsMatch(email, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$") Then
            Else
                email_Valid = False

                MsgBox("Por favor, introduzca un correo valido.", 64, "Validaciones")
            End If


        Catch ex As Exception
            Return False
            'aqui buscamos el Error en GestionErrores
            Dim buscarError As Boolean = gestionError.mostrarError(Err.Number)

            'guardamos el Exception
            errores.guardarError("Excepción nº" & Err.Number & " : " & ex.Message)


            'si no ecuentramos el error mostrar mensaje del exepcion capturada
            ' If buscarError = False Then
            ' MsgBox("Por favor, introduce solo numeros de nuevo.", MsgBoxStyle.Exclamation, ex.Message)
            ' End If

        End Try

        Return email_Valid


    End Function









End Class
