Public Class GestionErrores


    'Metodo Boolean para Buscar y mostrar Error
    Public Function mostrarError(ByVal numeroError As Integer) As Boolean


        Dim mensajeError As String = Err.Description

        Select Case numeroError

                'System.ArgumentException
            Case 5

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.OverflowException
            Case 6

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.OutOfMemoryException
            Case 7

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IndexOutOfRangeException
            Case 9

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.InvalidCastException
            Case 13

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.TypeLoadException
            Case 48

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 51

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 52

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.FileNotFoundException
            Case 53

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 55

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 57

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 58

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 61

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.EndOfStreamException
            Case 62

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 68

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 70

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 71

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 74

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.IOException
            Case 75

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.IO.FileNotFoundException
            Case 76

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 321

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 322

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 380

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 381

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.MissingFieldException
            Case 422

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 423

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 424

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.MissingMemberException
            Case 438

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 460

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 463

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 481

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

                'System.Exception
            Case 482

                MsgBox(mensajeError, MsgBoxStyle.Exclamation, Err.Description)
                Return True

        End Select

        'Si El error no esta en la lista devuelve un false
        Return False
    End Function



End Class
