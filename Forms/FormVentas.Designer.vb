<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIdVenta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbCliente = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboComprobante = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtPrecio = New System.Windows.Forms.TextBox
        Me.labelPrecio = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIdProducto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dgvventadetalle = New System.Windows.Forms.DataGridView
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtVuelto = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtRecibido = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvventadetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnEliminar.Location = New System.Drawing.Point(1064, 459)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(163, 68)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar Producto"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCancelar.Location = New System.Drawing.Point(1077, 594)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(149, 48)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(195, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Fecha de Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(237, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Id Cliente"
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Location = New System.Drawing.Point(113, 46)
        Me.txtIdVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.ReadOnly = True
        Me.txtIdVenta.Size = New System.Drawing.Size(61, 22)
        Me.txtIdVenta.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(43, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Id Venta"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnImprimir.Location = New System.Drawing.Point(19, 594)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(236, 48)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.CmbCliente)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIdVenta)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1051, 143)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Venta"
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(313, 39)
        Me.CmbCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(269, 24)
        Me.CmbCliente.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(313, 90)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(269, 22)
        Me.DateTimePicker2.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.ComboComprobante)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(617, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(433, 132)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Factura"
        '
        'ComboComprobante
        '
        Me.ComboComprobante.FormattingEnabled = True
        Me.ComboComprobante.Location = New System.Drawing.Point(195, 31)
        Me.ComboComprobante.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboComprobante.Name = "ComboComprobante"
        Me.ComboComprobante.Size = New System.Drawing.Size(168, 24)
        Me.ComboComprobante.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(42, 35)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(145, 17)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Tipo de Comprobante"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Controls.Add(Me.TxtPrecio)
        Me.GroupBox4.Controls.Add(Me.labelPrecio)
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtIdProducto)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 145)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(1051, 159)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de Productos"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(765, 91)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(95, 22)
        Me.TxtPrecio.TabIndex = 44
        '
        'labelPrecio
        '
        Me.labelPrecio.AutoSize = True
        Me.labelPrecio.Location = New System.Drawing.Point(708, 95)
        Me.labelPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPrecio.Name = "labelPrecio"
        Me.labelPrecio.Size = New System.Drawing.Size(48, 17)
        Me.labelPrecio.TabIndex = 43
        Me.labelPrecio.Text = "Precio"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(943, 91)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(99, 22)
        Me.txtCantidad.TabIndex = 42
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnBuscar.Location = New System.Drawing.Point(13, 68)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(163, 68)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar Producto"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(869, 95)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(527, 95)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Codigo"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(588, 91)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(99, 22)
        Me.txtIdProducto.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(184, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(276, 91)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(235, 22)
        Me.txtDescripcion.TabIndex = 26
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAgregar.Location = New System.Drawing.Point(1064, 213)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(163, 68)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvventadetalle
        '
        Me.dgvventadetalle.AllowUserToAddRows = False
        Me.dgvventadetalle.AllowUserToDeleteRows = False
        Me.dgvventadetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green
        Me.dgvventadetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvventadetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvventadetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvventadetalle.Location = New System.Drawing.Point(5, 303)
        Me.dgvventadetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvventadetalle.Name = "dgvventadetalle"
        Me.dgvventadetalle.ReadOnly = True
        Me.dgvventadetalle.RowHeadersVisible = False
        Me.dgvventadetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvventadetalle.Size = New System.Drawing.Size(1049, 224)
        Me.dgvventadetalle.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(243, 542)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Total a Pagar"
        '
        'txtVuelto
        '
        Me.txtVuelto.Enabled = False
        Me.txtVuelto.Location = New System.Drawing.Point(775, 538)
        Me.txtVuelto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.ReadOnly = True
        Me.txtVuelto.Size = New System.Drawing.Size(91, 22)
        Me.txtVuelto.TabIndex = 47
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(345, 538)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(88, 22)
        Me.txtTotal.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(627, 542)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 17)
        Me.Label13.TabIndex = 49
        '
        'txtRecibido
        '
        Me.txtRecibido.Location = New System.Drawing.Point(569, 538)
        Me.txtRecibido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecibido.Name = "txtRecibido"
        Me.txtRecibido.Size = New System.Drawing.Size(99, 22)
        Me.txtRecibido.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(451, 542)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Dinero Recibido"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(679, 542)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Vuelto a Dar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BtnAceptar.Location = New System.Drawing.Point(879, 594)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(149, 48)
        Me.BtnAceptar.TabIndex = 57
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(195, 83)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 21)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.Text = "Pagado"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1232, 657)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtRecibido)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVuelto)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvventadetalle)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvventadetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIdVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvventadetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVuelto As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRecibido As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents ComboComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents labelPrecio As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
