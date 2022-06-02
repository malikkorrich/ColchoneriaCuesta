<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItems
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBoxPrecio = New System.Windows.Forms.ListBox()
        Me.ListBoxStock = New System.Windows.Forms.ListBox()
        Me.ListBoxDescripcion = New System.Windows.Forms.ListBox()
        Me.LabelImporteCaja = New System.Windows.Forms.Label()
        Me.LabelHoraCaja = New System.Windows.Forms.Label()
        Me.LabelFechaCaja = New System.Windows.Forms.Label()
        Me.LabelNumCaja = New System.Windows.Forms.Label()
        Me.ListBoxID = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 637)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ListBoxPrecio)
        Me.Panel2.Controls.Add(Me.ListBoxStock)
        Me.Panel2.Controls.Add(Me.ListBoxDescripcion)
        Me.Panel2.Controls.Add(Me.LabelImporteCaja)
        Me.Panel2.Controls.Add(Me.LabelHoraCaja)
        Me.Panel2.Controls.Add(Me.LabelFechaCaja)
        Me.Panel2.Controls.Add(Me.LabelNumCaja)
        Me.Panel2.Controls.Add(Me.ListBoxID)
        Me.Panel2.Location = New System.Drawing.Point(76, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 552)
        Me.Panel2.TabIndex = 84
        '
        'ListBoxPrecio
        '
        Me.ListBoxPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxPrecio.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPrecio.FormattingEnabled = True
        Me.ListBoxPrecio.ItemHeight = 16
        Me.ListBoxPrecio.Location = New System.Drawing.Point(451, 69)
        Me.ListBoxPrecio.Name = "ListBoxPrecio"
        Me.ListBoxPrecio.Size = New System.Drawing.Size(83, 432)
        Me.ListBoxPrecio.TabIndex = 85
        '
        'ListBoxStock
        '
        Me.ListBoxStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxStock.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxStock.FormattingEnabled = True
        Me.ListBoxStock.ItemHeight = 16
        Me.ListBoxStock.Location = New System.Drawing.Point(376, 69)
        Me.ListBoxStock.Name = "ListBoxStock"
        Me.ListBoxStock.Size = New System.Drawing.Size(78, 432)
        Me.ListBoxStock.TabIndex = 86
        '
        'ListBoxDescripcion
        '
        Me.ListBoxDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxDescripcion.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDescripcion.FormattingEnabled = True
        Me.ListBoxDescripcion.ItemHeight = 16
        Me.ListBoxDescripcion.Location = New System.Drawing.Point(76, 69)
        Me.ListBoxDescripcion.Name = "ListBoxDescripcion"
        Me.ListBoxDescripcion.Size = New System.Drawing.Size(304, 432)
        Me.ListBoxDescripcion.TabIndex = 84
        '
        'LabelImporteCaja
        '
        Me.LabelImporteCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelImporteCaja.AutoSize = True
        Me.LabelImporteCaja.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelImporteCaja.Location = New System.Drawing.Point(448, 32)
        Me.LabelImporteCaja.Name = "LabelImporteCaja"
        Me.LabelImporteCaja.Size = New System.Drawing.Size(50, 17)
        Me.LabelImporteCaja.TabIndex = 91
        Me.LabelImporteCaja.Text = "Precio "
        Me.LabelImporteCaja.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelHoraCaja
        '
        Me.LabelHoraCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHoraCaja.AutoSize = True
        Me.LabelHoraCaja.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHoraCaja.Location = New System.Drawing.Point(373, 32)
        Me.LabelHoraCaja.Name = "LabelHoraCaja"
        Me.LabelHoraCaja.Size = New System.Drawing.Size(41, 17)
        Me.LabelHoraCaja.TabIndex = 90
        Me.LabelHoraCaja.Text = "Stock"
        Me.LabelHoraCaja.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelFechaCaja
        '
        Me.LabelFechaCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFechaCaja.AutoSize = True
        Me.LabelFechaCaja.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaCaja.Location = New System.Drawing.Point(73, 33)
        Me.LabelFechaCaja.Name = "LabelFechaCaja"
        Me.LabelFechaCaja.Size = New System.Drawing.Size(80, 17)
        Me.LabelFechaCaja.TabIndex = 89
        Me.LabelFechaCaja.Text = "Descripcion"
        Me.LabelFechaCaja.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelNumCaja
        '
        Me.LabelNumCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelNumCaja.AutoSize = True
        Me.LabelNumCaja.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumCaja.Location = New System.Drawing.Point(18, 32)
        Me.LabelNumCaja.Name = "LabelNumCaja"
        Me.LabelNumCaja.Size = New System.Drawing.Size(22, 17)
        Me.LabelNumCaja.TabIndex = 88
        Me.LabelNumCaja.Text = "ID"
        Me.LabelNumCaja.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListBoxID
        '
        Me.ListBoxID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxID.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxID.FormattingEnabled = True
        Me.ListBoxID.ItemHeight = 16
        Me.ListBoxID.Location = New System.Drawing.Point(21, 69)
        Me.ListBoxID.Name = "ListBoxID"
        Me.ListBoxID.Size = New System.Drawing.Size(60, 432)
        Me.ListBoxID.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'FormItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrueba"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelImporteCaja As Label
    Friend WithEvents LabelHoraCaja As Label
    Friend WithEvents LabelFechaCaja As Label
    Friend WithEvents LabelNumCaja As Label
    Friend WithEvents ListBoxID As ListBox
    Friend WithEvents ListBoxStock As ListBox
    Friend WithEvents ListBoxPrecio As ListBox
    Friend WithEvents ListBoxDescripcion As ListBox
End Class
