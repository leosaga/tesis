<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGastosDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.LabelDescripcion = New System.Windows.Forms.Label
        Me.LabelMonto = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnfactura = New System.Windows.Forms.TextBox
        Me.TxtId = New System.Windows.Forms.TextBox
        Me.LabelID = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAceptar.Location = New System.Drawing.Point(110, 131)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(112, 39)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCancelar.Location = New System.Drawing.Point(316, 131)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 39)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(110, 67)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(251, 20)
        Me.txtdescripcion.TabIndex = 2
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Location = New System.Drawing.Point(41, 70)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LabelDescripcion.TabIndex = 3
        Me.LabelDescripcion.Text = "Descripcion"
        '
        'LabelMonto
        '
        Me.LabelMonto.AutoSize = True
        Me.LabelMonto.Location = New System.Drawing.Point(67, 96)
        Me.LabelMonto.Name = "LabelMonto"
        Me.LabelMonto.Size = New System.Drawing.Size(37, 13)
        Me.LabelMonto.TabIndex = 4
        Me.LabelMonto.Text = "Monto"
        '
        'dtpfecha
        '
        Me.dtpfecha.Enabled = False
        Me.dtpfecha.Location = New System.Drawing.Point(228, 12)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(110, 93)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(251, 20)
        Me.txtmonto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numero de Factura"
        '
        'txtnfactura
        '
        Me.txtnfactura.Location = New System.Drawing.Point(110, 41)
        Me.txtnfactura.Name = "txtnfactura"
        Me.txtnfactura.Size = New System.Drawing.Size(251, 20)
        Me.txtnfactura.TabIndex = 1
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(110, 15)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 9
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(86, 15)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(18, 13)
        Me.LabelID.TabIndex = 10
        Me.LabelID.Text = "ID"
        '
        'FormGastosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 183)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.txtnfactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.LabelMonto)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "FormGastosDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos Detalle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LabelDescripcion As System.Windows.Forms.Label
    Friend WithEvents LabelMonto As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnfactura As System.Windows.Forms.TextBox
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents LabelID As System.Windows.Forms.Label
End Class
