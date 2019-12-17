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
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RubrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StockDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PanelContenedor = New System.Windows.Forms.Panel
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.OliveDrab
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem1, Me.GastosToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(110, 698)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.AutoSize = False
        Me.ProductosToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab
        Me.ProductosToolStripMenuItem.BackgroundImage = Global.TesisMercado.My.Resources.Resources.ark
        Me.ProductosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubrosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.StockDeProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(104, 130)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        Me.ProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RubrosToolStripMenuItem1
        '
        Me.RubrosToolStripMenuItem1.Name = "RubrosToolStripMenuItem1"
        Me.RubrosToolStripMenuItem1.Size = New System.Drawing.Size(272, 34)
        Me.RubrosToolStripMenuItem1.Text = "Rubros"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(272, 34)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'StockDeProductosToolStripMenuItem
        '
        Me.StockDeProductosToolStripMenuItem.Name = "StockDeProductosToolStripMenuItem"
        Me.StockDeProductosToolStripMenuItem.Size = New System.Drawing.Size(272, 34)
        Me.StockDeProductosToolStripMenuItem.Text = "Stock de Productos"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.AutoSize = False
        Me.ClientesToolStripMenuItem1.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientesToolStripMenuItem1.BackgroundImage = Global.TesisMercado.My.Resources.Resources.User
        Me.ClientesToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientesToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.ClientesToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(99, 130)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        Me.ClientesToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.Transparent
        Me.PanelContenedor.BackgroundImage = Global.TesisMercado.My.Resources.Resources.FONDO31
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(110, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(825, 698)
        Me.PanelContenedor.TabIndex = 3
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.AutoSize = False
        Me.VentasToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab
        Me.VentasToolStripMenuItem.BackgroundImage = Global.TesisMercado.My.Resources.Resources.db_list
        Me.VentasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.VentasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(99, 130)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        Me.VentasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.VentasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.AutoSize = False
        Me.GastosToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab
        Me.GastosToolStripMenuItem.BackgroundImage = Global.TesisMercado.My.Resources.Resources.Folder_1
        Me.GastosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GastosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.GastosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(99, 130)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        Me.GastosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.OliveDrab
        Me.ToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(99, 130)
        Me.ToolStripMenuItem1.Text = "Ayuda"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
