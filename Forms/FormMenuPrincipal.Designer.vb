<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RubrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StockDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PanelContenedor = New System.Windows.Forms.Panel
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem1, Me.GastosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(105, 698)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.AutoSize = False
        Me.VentasToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(99, 130)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.AutoSize = False
        Me.ProductosToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubrosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.StockDeProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(99, 130)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'RubrosToolStripMenuItem1
        '
        Me.RubrosToolStripMenuItem1.Name = "RubrosToolStripMenuItem1"
        Me.RubrosToolStripMenuItem1.Size = New System.Drawing.Size(213, 26)
        Me.RubrosToolStripMenuItem1.Text = "Rubros"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(213, 26)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'StockDeProductosToolStripMenuItem
        '
        Me.StockDeProductosToolStripMenuItem.Name = "StockDeProductosToolStripMenuItem"
        Me.StockDeProductosToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.StockDeProductosToolStripMenuItem.Text = "Stock de Productos"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.AutoSize = False
        Me.ClientesToolStripMenuItem1.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientesToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(99, 130)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.AutoSize = False
        Me.GastosToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen
        Me.GastosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GastosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(99, 130)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.Transparent
        Me.PanelContenedor.BackgroundImage = Global.TesisMercado.My.Resources.Resources.FONDO31
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(105, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(830, 698)
        Me.PanelContenedor.TabIndex = 3
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 698)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel

End Class
