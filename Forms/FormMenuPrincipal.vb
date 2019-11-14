Public Class FormMenuPrincipal

    Private FormActual As Form = Nothing

    Public Sub AbrirFormHijo(ByVal FormHijo As Form)
        If FormActual IsNot Nothing Then FormActual.Close()
        FormActual = FormHijo
        FormHijo.TopLevel = False
        FormHijo.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        FormHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FormHijo)
        PanelContenedor.Tag = FormHijo
        FormHijo.BringToFront()
        FormHijo.Show()


    End Sub


    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        AbrirFormHijo(New FormClientes)
        'FormClientes.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastosToolStripMenuItem.Click
        AbrirFormHijo(New FormGastos)
        'FormGastos.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        FormUsuarios.Show()
    End Sub

    Private Sub RubrosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubrosToolStripMenuItem1.Click
        AbrirFormHijo(New FormRubro)
        'FormRubro.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        AbrirFormHijo(New FormProveedores)
        'FormProveedores.Show()
    End Sub

    Private Sub StockDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockDeProductosToolStripMenuItem.Click
        AbrirFormHijo(New LstProductos)
        'LstProductos.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        'FormVentasDetalle.Show()

        AbrirFormHijo(New FormVentasDetalle )
    End Sub
End Class
