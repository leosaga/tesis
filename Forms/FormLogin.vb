Public Class FormLogin

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        If txtUsuario.Text = "Admin" And txtPassword.Text = "12345" And ComboUsuario.SelectedItem = "Administrador" Then
            FormMenuPrincipal.Show()

        Else
            MsgBox("Usuario o Contraseña Incorrecta")

            txtUsuario.Text = ""
            txtPassword.Text = ""
            ComboUsuario.SelectedItem = ""


        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        If MsgBox("Desea Salir Del Programa...???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.Yes Then

            End

        End If

    End Sub
End Class