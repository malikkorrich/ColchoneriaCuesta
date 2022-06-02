<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ver_caja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelImporteCaja = New System.Windows.Forms.Label()
        Me.LabelFechaCaja = New System.Windows.Forms.Label()
        Me.LabelHoraCaja = New System.Windows.Forms.Label()
        Me.LabelImporte = New System.Windows.Forms.Label()
        Me.ListBoxFecha = New System.Windows.Forms.ListBox()
        Me.ListBoxHora = New System.Windows.Forms.ListBox()
        Me.ListBoxImporte = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonMostrarTodo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(684, 24)
        Me.MenuStripPagPrin.TabIndex = 5
        Me.MenuStripPagPrin.Text = "MenuStrip1"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.BlocNotasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'BlocNotasToolStripMenuItem
        '
        Me.BlocNotasToolStripMenuItem.Name = "BlocNotasToolStripMenuItem"
        Me.BlocNotasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BlocNotasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlocNotasToolStripMenuItem.Text = "Bloc Notas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir..."
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLaAyudaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la Ayuda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(484, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(335, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(212, 20)
        Me.DateTimePicker1.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Total Caja"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelImporteCaja
        '
        Me.LabelImporteCaja.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelImporteCaja.Location = New System.Drawing.Point(430, 149)
        Me.LabelImporteCaja.Name = "LabelImporteCaja"
        Me.LabelImporteCaja.Size = New System.Drawing.Size(103, 19)
        Me.LabelImporteCaja.TabIndex = 60
        Me.LabelImporteCaja.Text = "Label4"
        Me.LabelImporteCaja.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelFechaCaja
        '
        Me.LabelFechaCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFechaCaja.AutoSize = True
        Me.LabelFechaCaja.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaCaja.Location = New System.Drawing.Point(66, 12)
        Me.LabelFechaCaja.Name = "LabelFechaCaja"
        Me.LabelFechaCaja.Size = New System.Drawing.Size(47, 17)
        Me.LabelFechaCaja.TabIndex = 73
        Me.LabelFechaCaja.Text = "Fecha "
        Me.LabelFechaCaja.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelHoraCaja
        '
        Me.LabelHoraCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHoraCaja.AutoSize = True
        Me.LabelHoraCaja.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHoraCaja.Location = New System.Drawing.Point(150, 13)
        Me.LabelHoraCaja.Name = "LabelHoraCaja"
        Me.LabelHoraCaja.Size = New System.Drawing.Size(38, 17)
        Me.LabelHoraCaja.TabIndex = 74
        Me.LabelHoraCaja.Text = "Hora"
        Me.LabelHoraCaja.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelImporte
        '
        Me.LabelImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelImporte.AutoSize = True
        Me.LabelImporte.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelImporte.Location = New System.Drawing.Point(222, 12)
        Me.LabelImporte.Name = "LabelImporte"
        Me.LabelImporte.Size = New System.Drawing.Size(57, 17)
        Me.LabelImporte.TabIndex = 75
        Me.LabelImporte.Text = "Importe"
        Me.LabelImporte.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListBoxFecha
        '
        Me.ListBoxFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxFecha.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxFecha.FormattingEnabled = True
        Me.ListBoxFecha.ItemHeight = 16
        Me.ListBoxFecha.Location = New System.Drawing.Point(69, 32)
        Me.ListBoxFecha.Name = "ListBoxFecha"
        Me.ListBoxFecha.Size = New System.Drawing.Size(88, 256)
        Me.ListBoxFecha.TabIndex = 66
        '
        'ListBoxHora
        '
        Me.ListBoxHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxHora.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxHora.FormattingEnabled = True
        Me.ListBoxHora.ItemHeight = 16
        Me.ListBoxHora.Location = New System.Drawing.Point(153, 32)
        Me.ListBoxHora.Name = "ListBoxHora"
        Me.ListBoxHora.Size = New System.Drawing.Size(73, 256)
        Me.ListBoxHora.TabIndex = 68
        '
        'ListBoxImporte
        '
        Me.ListBoxImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxImporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxImporte.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxImporte.FormattingEnabled = True
        Me.ListBoxImporte.ItemHeight = 16
        Me.ListBoxImporte.Location = New System.Drawing.Point(225, 32)
        Me.ListBoxImporte.Name = "ListBoxImporte"
        Me.ListBoxImporte.Size = New System.Drawing.Size(94, 256)
        Me.ListBoxImporte.TabIndex = 67
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonMostrarTodo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ListBoxImporte)
        Me.Panel1.Controls.Add(Me.ListBoxHora)
        Me.Panel1.Controls.Add(Me.ListBoxFecha)
        Me.Panel1.Controls.Add(Me.LabelImporte)
        Me.Panel1.Controls.Add(Me.LabelHoraCaja)
        Me.Panel1.Controls.Add(Me.LabelFechaCaja)
        Me.Panel1.Controls.Add(Me.LabelImporteCaja)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 311)
        Me.Panel1.TabIndex = 4
        '
        'ButtonMostrarTodo
        '
        Me.ButtonMostrarTodo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonMostrarTodo.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonMostrarTodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonMostrarTodo.Font = New System.Drawing.Font("Gadugi", 12.0!)
        Me.ButtonMostrarTodo.Location = New System.Drawing.Point(437, 207)
        Me.ButtonMostrarTodo.Name = "ButtonMostrarTodo"
        Me.ButtonMostrarTodo.Size = New System.Drawing.Size(110, 48)
        Me.ButtonMostrarTodo.TabIndex = 79
        Me.ButtonMostrarTodo.Text = "Mostrar Todo"
        Me.ButtonMostrarTodo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(529, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 19)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "€"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ver_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 341)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 380)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 380)
        Me.Name = "ver_caja"
        Me.Text = "ver_caja"
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelImporteCaja As Label
    Friend WithEvents LabelFechaCaja As Label
    Friend WithEvents LabelHoraCaja As Label
    Friend WithEvents LabelImporte As Label
    Friend WithEvents ListBoxFecha As ListBox
    Friend WithEvents ListBoxHora As ListBox
    Friend WithEvents ListBoxImporte As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonMostrarTodo As Button
End Class
