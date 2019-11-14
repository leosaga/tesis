
Public Class Funciones
    Public Function validarCampos(ByVal formulario As Form, ByVal controlador As ErrorProvider) As Boolean
        Dim miControl As Control
        validarCampos = True
        For Each miControl In formulario.Controls
            If miControl.Tag = "*" Then
                If TypeOf (miControl) Is TextBox Then
                    Try
                        If miControl.Text.Length = 0 Then
                            Throw New Exception("Por favor Ingrese un Dato.")
                        Else
                            controlador.SetError(miControl, "")
                        End If
                    Catch ex As Exception
                        controlador.SetError(miControl, ex.Message)
                        validarCampos = False

                    End Try

                ElseIf TypeOf (miControl) Is ComboBox Then
                    Try
                        If miControl.Text = "" Then
                            Throw New Exception("Por favor Ingrese un Dato.")
                        Else
                            controlador.SetError(miControl, "")
                        End If

                    Catch ex As Exception
                        controlador.SetError(miControl, ex.Message)
                        validarCampos = False

                    End Try

                ElseIf TypeOf (miControl) Is MaskedTextBox Then
                    Try
                        If miControl.Text = "" Then
                            Throw New Exception("Por favor Ingrese un Dato.")
                        Else
                            controlador.SetError(miControl, "")
                        End If

                    Catch ex As Exception
                        controlador.SetError(miControl, ex.Message)
                        validarCampos = False

                    End Try


                End If
            End If
        Next

    End Function
End Class
