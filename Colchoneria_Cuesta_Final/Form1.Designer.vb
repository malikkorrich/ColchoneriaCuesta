<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelCesta = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBoxPrecioTotal = New System.Windows.Forms.ListBox()
        Me.ListBoxPrecioUnidad = New System.Windows.Forms.ListBox()
        Me.ListBoxDescripcion = New System.Windows.Forms.ListBox()
        Me.LabelSimboloEuro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxUnidades = New System.Windows.Forms.ListBox()
        Me.LabelTotalAPagar = New System.Windows.Forms.Label()
        Me.LabelTotalAPagarNumerico = New System.Windows.Forms.Label()
        Me.ButtonQuitarLista = New System.Windows.Forms.Button()
        Me.ListBoxID = New System.Windows.Forms.ListBox()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelADevolverNumerico = New System.Windows.Forms.Label()
        Me.TextBoxEntregaNumerico = New System.Windows.Forms.TextBox()
        Me.GroupBoxMetodoPago = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTarjeta = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEfectivo = New System.Windows.Forms.RadioButton()
        Me.LabelEntrega = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelADevolver = New System.Windows.Forms.Label()
        Me.ButtonCobrar = New System.Windows.Forms.Button()
        Me.PanelBotonesPagPrin = New System.Windows.Forms.Panel()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeCajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormularioPruebaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel1.SuspendLayout()
        Me.PanelCesta.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxMetodoPago.SuspendLayout()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PanelCesta)
        Me.Panel1.Controls.Add(Me.PanelBotonesPagPrin)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 600)
        Me.Panel1.TabIndex = 5
        '
        'PanelCesta
        '
        Me.PanelCesta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCesta.Controls.Add(Me.Panel2)
        Me.PanelCesta.Controls.Add(Me.LabelHora)
        Me.PanelCesta.Controls.Add(Me.LabelFecha)
        Me.PanelCesta.Controls.Add(Me.Label2)
        Me.PanelCesta.Controls.Add(Me.Panel3)
        Me.PanelCesta.Location = New System.Drawing.Point(882, 0)
        Me.PanelCesta.Name = "PanelCesta"
        Me.PanelCesta.Size = New System.Drawing.Size(430, 600)
        Me.PanelCesta.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ListBoxPrecioTotal)
        Me.Panel2.Controls.Add(Me.ListBoxPrecioUnidad)
        Me.Panel2.Controls.Add(Me.ListBoxDescripcion)
        Me.Panel2.Controls.Add(Me.LabelSimboloEuro)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ListBoxUnidades)
        Me.Panel2.Controls.Add(Me.LabelTotalAPagar)
        Me.Panel2.Controls.Add(Me.LabelTotalAPagarNumerico)
        Me.Panel2.Controls.Add(Me.ButtonQuitarLista)
        Me.Panel2.Controls.Add(Me.ListBoxID)
        Me.Panel2.Location = New System.Drawing.Point(25, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 406)
        Me.Panel2.TabIndex = 6
        '
        'ListBoxPrecioTotal
        '
        Me.ListBoxPrecioTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxPrecioTotal.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPrecioTotal.FormattingEnabled = True
        Me.ListBoxPrecioTotal.ItemHeight = 16
        Me.ListBoxPrecioTotal.Location = New System.Drawing.Point(317, 43)
        Me.ListBoxPrecioTotal.Name = "ListBoxPrecioTotal"
        Me.ListBoxPrecioTotal.Size = New System.Drawing.Size(48, 304)
        Me.ListBoxPrecioTotal.TabIndex = 53
        '
        'ListBoxPrecioUnidad
        '
        Me.ListBoxPrecioUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxPrecioUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxPrecioUnidad.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPrecioUnidad.FormattingEnabled = True
        Me.ListBoxPrecioUnidad.ItemHeight = 16
        Me.ListBoxPrecioUnidad.Location = New System.Drawing.Point(273, 43)
        Me.ListBoxPrecioUnidad.Name = "ListBoxPrecioUnidad"
        Me.ListBoxPrecioUnidad.Size = New System.Drawing.Size(45, 304)
        Me.ListBoxPrecioUnidad.TabIndex = 64
        '
        'ListBoxDescripcion
        '
        Me.ListBoxDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxDescripcion.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDescripcion.FormattingEnabled = True
        Me.ListBoxDescripcion.ItemHeight = 16
        Me.ListBoxDescripcion.Location = New System.Drawing.Point(70, 43)
        Me.ListBoxDescripcion.Name = "ListBoxDescripcion"
        Me.ListBoxDescripcion.Size = New System.Drawing.Size(206, 304)
        Me.ListBoxDescripcion.TabIndex = 52
        '
        'LabelSimboloEuro
        '
        Me.LabelSimboloEuro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSimboloEuro.AutoSize = True
        Me.LabelSimboloEuro.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSimboloEuro.Location = New System.Drawing.Point(204, 373)
        Me.LabelSimboloEuro.Name = "LabelSimboloEuro"
        Me.LabelSimboloEuro.Size = New System.Drawing.Size(18, 19)
        Me.LabelSimboloEuro.TabIndex = 76
        Me.LabelSimboloEuro.Text = "€"
        Me.LabelSimboloEuro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 19)
        Me.Label7.TabIndex = 75
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 37)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Precio Ud."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(318, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 42)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Precio Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Producto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Uds."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListBoxUnidades
        '
        Me.ListBoxUnidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBoxUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxUnidades.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxUnidades.FormattingEnabled = True
        Me.ListBoxUnidades.ItemHeight = 16
        Me.ListBoxUnidades.Location = New System.Drawing.Point(25, 43)
        Me.ListBoxUnidades.Name = "ListBoxUnidades"
        Me.ListBoxUnidades.Size = New System.Drawing.Size(56, 304)
        Me.ListBoxUnidades.TabIndex = 65
        '
        'LabelTotalAPagar
        '
        Me.LabelTotalAPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTotalAPagar.AutoSize = True
        Me.LabelTotalAPagar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAPagar.Location = New System.Drawing.Point(21, 373)
        Me.LabelTotalAPagar.Name = "LabelTotalAPagar"
        Me.LabelTotalAPagar.Size = New System.Drawing.Size(102, 19)
        Me.LabelTotalAPagar.TabIndex = 62
        Me.LabelTotalAPagar.Text = "Total a pagar:"
        Me.LabelTotalAPagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelTotalAPagarNumerico
        '
        Me.LabelTotalAPagarNumerico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTotalAPagarNumerico.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAPagarNumerico.Location = New System.Drawing.Point(123, 373)
        Me.LabelTotalAPagarNumerico.Name = "LabelTotalAPagarNumerico"
        Me.LabelTotalAPagarNumerico.Size = New System.Drawing.Size(77, 19)
        Me.LabelTotalAPagarNumerico.TabIndex = 63
        Me.LabelTotalAPagarNumerico.Text = "0"
        Me.LabelTotalAPagarNumerico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonQuitarLista
        '
        Me.ButtonQuitarLista.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonQuitarLista.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonQuitarLista.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonQuitarLista.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitarLista.Location = New System.Drawing.Point(250, 360)
        Me.ButtonQuitarLista.Name = "ButtonQuitarLista"
        Me.ButtonQuitarLista.Size = New System.Drawing.Size(110, 40)
        Me.ButtonQuitarLista.TabIndex = 58
        Me.ButtonQuitarLista.Text = "Quitar"
        Me.ButtonQuitarLista.UseVisualStyleBackColor = False
        '
        'ListBoxID
        '
        Me.ListBoxID.FormattingEnabled = True
        Me.ListBoxID.Location = New System.Drawing.Point(-41, 4)
        Me.ListBoxID.Name = "ListBoxID"
        Me.ListBoxID.Size = New System.Drawing.Size(66, 95)
        Me.ListBoxID.TabIndex = 77
        Me.ListBoxID.Visible = False
        '
        'LabelHora
        '
        Me.LabelHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.Location = New System.Drawing.Point(344, 0)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(46, 19)
        Me.LabelHora.TabIndex = 46
        Me.LabelHora.Text = "Hora"
        '
        'LabelFecha
        '
        Me.LabelFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(46, 0)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(53, 19)
        Me.LabelFecha.TabIndex = 47
        Me.LabelFecha.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.LabelADevolverNumerico)
        Me.Panel3.Controls.Add(Me.TextBoxEntregaNumerico)
        Me.Panel3.Controls.Add(Me.GroupBoxMetodoPago)
        Me.Panel3.Controls.Add(Me.LabelEntrega)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.LabelADevolver)
        Me.Panel3.Controls.Add(Me.ButtonCobrar)
        Me.Panel3.Location = New System.Drawing.Point(25, 434)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 141)
        Me.Panel3.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(204, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 19)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "€"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(204, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 19)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "€"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelADevolverNumerico
        '
        Me.LabelADevolverNumerico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelADevolverNumerico.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelADevolverNumerico.Location = New System.Drawing.Point(123, 105)
        Me.LabelADevolverNumerico.Name = "LabelADevolverNumerico"
        Me.LabelADevolverNumerico.Size = New System.Drawing.Size(77, 19)
        Me.LabelADevolverNumerico.TabIndex = 68
        Me.LabelADevolverNumerico.Text = "0"
        Me.LabelADevolverNumerico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxEntregaNumerico
        '
        Me.TextBoxEntregaNumerico.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEntregaNumerico.Location = New System.Drawing.Point(143, 70)
        Me.TextBoxEntregaNumerico.Name = "TextBoxEntregaNumerico"
        Me.TextBoxEntregaNumerico.Size = New System.Drawing.Size(57, 27)
        Me.TextBoxEntregaNumerico.TabIndex = 67
        Me.TextBoxEntregaNumerico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBoxMetodoPago
        '
        Me.GroupBoxMetodoPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBoxMetodoPago.Controls.Add(Me.RadioButtonTarjeta)
        Me.GroupBoxMetodoPago.Controls.Add(Me.RadioButtonEfectivo)
        Me.GroupBoxMetodoPago.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMetodoPago.Location = New System.Drawing.Point(25, 3)
        Me.GroupBoxMetodoPago.Name = "GroupBoxMetodoPago"
        Me.GroupBoxMetodoPago.Size = New System.Drawing.Size(340, 50)
        Me.GroupBoxMetodoPago.TabIndex = 66
        Me.GroupBoxMetodoPago.TabStop = False
        Me.GroupBoxMetodoPago.Text = "Método de Pago"
        '
        'RadioButtonTarjeta
        '
        Me.RadioButtonTarjeta.AutoSize = True
        Me.RadioButtonTarjeta.Location = New System.Drawing.Point(161, 19)
        Me.RadioButtonTarjeta.Name = "RadioButtonTarjeta"
        Me.RadioButtonTarjeta.Size = New System.Drawing.Size(74, 23)
        Me.RadioButtonTarjeta.TabIndex = 1
        Me.RadioButtonTarjeta.TabStop = True
        Me.RadioButtonTarjeta.Text = "Tarjeta"
        Me.RadioButtonTarjeta.UseVisualStyleBackColor = True
        '
        'RadioButtonEfectivo
        '
        Me.RadioButtonEfectivo.AutoSize = True
        Me.RadioButtonEfectivo.Location = New System.Drawing.Point(21, 19)
        Me.RadioButtonEfectivo.Name = "RadioButtonEfectivo"
        Me.RadioButtonEfectivo.Size = New System.Drawing.Size(81, 23)
        Me.RadioButtonEfectivo.TabIndex = 0
        Me.RadioButtonEfectivo.TabStop = True
        Me.RadioButtonEfectivo.Text = "Efectivo"
        Me.RadioButtonEfectivo.UseVisualStyleBackColor = True
        '
        'LabelEntrega
        '
        Me.LabelEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEntrega.AutoSize = True
        Me.LabelEntrega.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEntrega.Location = New System.Drawing.Point(49, 69)
        Me.LabelEntrega.Name = "LabelEntrega"
        Me.LabelEntrega.Size = New System.Drawing.Size(65, 19)
        Me.LabelEntrega.TabIndex = 63
        Me.LabelEntrega.Text = "Entrega:"
        Me.LabelEntrega.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = " "
        '
        'LabelADevolver
        '
        Me.LabelADevolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelADevolver.AutoSize = True
        Me.LabelADevolver.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelADevolver.Location = New System.Drawing.Point(37, 105)
        Me.LabelADevolver.Name = "LabelADevolver"
        Me.LabelADevolver.Size = New System.Drawing.Size(86, 19)
        Me.LabelADevolver.TabIndex = 60
        Me.LabelADevolver.Text = "A devolver:"
        Me.LabelADevolver.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ButtonCobrar
        '
        Me.ButtonCobrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonCobrar.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonCobrar.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCobrar.Location = New System.Drawing.Point(250, 70)
        Me.ButtonCobrar.Name = "ButtonCobrar"
        Me.ButtonCobrar.Size = New System.Drawing.Size(110, 40)
        Me.ButtonCobrar.TabIndex = 58
        Me.ButtonCobrar.Text = "Cobrar"
        Me.ButtonCobrar.UseVisualStyleBackColor = False
        '
        'PanelBotonesPagPrin
        '
        Me.PanelBotonesPagPrin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBotonesPagPrin.AutoScroll = True
        Me.PanelBotonesPagPrin.Location = New System.Drawing.Point(30, 16)
        Me.PanelBotonesPagPrin.Margin = New System.Windows.Forms.Padding(1)
        Me.PanelBotonesPagPrin.Name = "PanelBotonesPagPrin"
        Me.PanelBotonesPagPrin.Size = New System.Drawing.Size(832, 559)
        Me.PanelBotonesPagPrin.TabIndex = 29
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.CajaToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.FormularioPruebaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStripPagPrin.TabIndex = 4
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
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'BlocNotasToolStripMenuItem
        '
        Me.BlocNotasToolStripMenuItem.Image = CType(resources.GetObject("BlocNotasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BlocNotasToolStripMenuItem.Name = "BlocNotasToolStripMenuItem"
        Me.BlocNotasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.BlocNotasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlocNotasToolStripMenuItem.Text = "Bloc Notas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir..."
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'GestiónDeProductosToolStripMenuItem
        '
        Me.GestiónDeProductosToolStripMenuItem.Name = "GestiónDeProductosToolStripMenuItem"
        Me.GestiónDeProductosToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.GestiónDeProductosToolStripMenuItem.Text = "Gestión de Productos"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        Me.EmpleadosToolStripMenuItem.ToolTipText = "Se mostrará la ventana de Gestion de Empleado"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Image = CType(resources.GetObject("GestionDeEmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'GestiónDeClientesToolStripMenuItem
        '
        Me.GestiónDeClientesToolStripMenuItem.Image = CType(resources.GetObject("GestiónDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestiónDeClientesToolStripMenuItem.Name = "GestiónDeClientesToolStripMenuItem"
        Me.GestiónDeClientesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GestiónDeClientesToolStripMenuItem.Text = "Gestión de Clientes"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerCajaToolStripMenuItem, Me.HacerToolStripMenuItem, Me.HistorialDeCajasToolStripMenuItem})
        Me.CajaToolStripMenuItem.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'VerCajaToolStripMenuItem
        '
        Me.VerCajaToolStripMenuItem.Image = CType(resources.GetObject("VerCajaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerCajaToolStripMenuItem.Name = "VerCajaToolStripMenuItem"
        Me.VerCajaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.VerCajaToolStripMenuItem.Text = "Ver caja"
        '
        'HacerToolStripMenuItem
        '
        Me.HacerToolStripMenuItem.Image = CType(resources.GetObject("HacerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HacerToolStripMenuItem.Name = "HacerToolStripMenuItem"
        Me.HacerToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.HacerToolStripMenuItem.Text = "Hacer Caja"
        '
        'HistorialDeCajasToolStripMenuItem
        '
        Me.HistorialDeCajasToolStripMenuItem.Image = CType(resources.GetObject("HistorialDeCajasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistorialDeCajasToolStripMenuItem.Name = "HistorialDeCajasToolStripMenuItem"
        Me.HistorialDeCajasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.HistorialDeCajasToolStripMenuItem.Text = "Historial de Cajas"
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
        Me.VerLaAyudaToolStripMenuItem.Image = CType(resources.GetObject("VerLaAyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la Ayuda"
        '
        'FormularioPruebaToolStripMenuItem
        '
        Me.FormularioPruebaToolStripMenuItem.Name = "FormularioPruebaToolStripMenuItem"
        Me.FormularioPruebaToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.FormularioPruebaToolStripMenuItem.Text = "FormularioPrueba"
        '
        'Timer1
        '
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\malik\source\repos\Colchoneria_Cuesta_Final\Ayuda software Casa del Libr" &
    "o.chm"
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 639)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PantallaPrincipal"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.PanelCesta.ResumeLayout(False)
        Me.PanelCesta.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBoxMetodoPago.ResumeLayout(False)
        Me.GroupBoxMetodoPago.PerformLayout()
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelCesta As Panel
    Friend WithEvents LabelHora As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonCobrar As Button
    Friend WithEvents PanelBotonesPagPrin As Panel
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeCajasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListBoxPrecioTotal As ListBox
    Friend WithEvents ListBoxDescripcion As ListBox
    Friend WithEvents LabelEntrega As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelADevolver As Label
    Friend WithEvents LabelTotalAPagar As Label
    Friend WithEvents LabelTotalAPagarNumerico As Label
    Friend WithEvents ButtonQuitarLista As Button
    Friend WithEvents GroupBoxMetodoPago As GroupBox
    Friend WithEvents RadioButtonTarjeta As RadioButton
    Friend WithEvents RadioButtonEfectivo As RadioButton
    Friend WithEvents ListBoxPrecioUnidad As ListBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ListBoxUnidades As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GestiónDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxEntregaNumerico As TextBox
    Friend WithEvents LabelSimboloEuro As Label
    Friend WithEvents FormularioPruebaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelADevolverNumerico As Label
    Friend WithEvents ListBoxID As ListBox
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
