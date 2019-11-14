<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstProveedores
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvlistaproductos = New System.Windows.Forms.DataGridView
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        CType(Me.dgvlistaproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvlistaproductos
        '
        Me.dgvlistaproductos.AccessibleName = ""
        Me.dgvlistaproductos.AllowUserToAddRows = False
        Me.dgvlistaproductos.AllowUserToDeleteRows = False
        Me.dgvlistaproductos.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        Me.dgvlistaproductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlistaproductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvlistaproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistaproductos.Location = New System.Drawing.Point(12, 9)
        Me.dgvlistaproductos.Name = "dgvlistaproductos"
        Me.dgvlistaproductos.ReadOnly = True
        Me.dgvlistaproductos.RowHeadersVisible = False
        Me.dgvlistaproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlistaproductos.Size = New System.Drawing.Size(435, 346)
        Me.dgvlistaproductos.TabIndex = 13
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleName = ""
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCancelar.Location = New System.Drawing.Point(335, 361)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 39)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleName = ""
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAceptar.Location = New System.Drawing.Point(217, 359)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(112, 39)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'listaproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 408)
        Me.Controls.Add(Me.dgvlistaproductos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "listaproductos"
        Me.Text = "listaproductos"
        CType(Me.dgvlistaproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvlistaproductos As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
