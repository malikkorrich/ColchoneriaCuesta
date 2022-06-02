<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonAlta = New System.Windows.Forms.Button()
        Me.MenuStripPagPrin = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeCajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormularioPruebaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBoxcID = New System.Windows.Forms.ListBox()
        Me.ListBoxTelefono = New System.Windows.Forms.ListBox()
        Me.ListBoxApellido2 = New System.Windows.Forms.ListBox()
        Me.ListBoxApellido1 = New System.Windows.Forms.ListBox()
        Me.ListBoxNombre = New System.Windows.Forms.ListBox()
        Me.ListBoxDNI = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBusId = New System.Windows.Forms.TextBox()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonBusca = New System.Windows.Forms.Button()
        Me.TextBoxBusNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxApellido2 = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.GroupBox()
        Me.Panel2.SuspendLayout()
        Me.MenuStripPagPrin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ButtonBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 19)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "ID:"
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxID.Location = New System.Drawing.Point(132, 90)
        Me.TextBoxID.MaxLength = 5
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(120, 29)
        Me.TextBoxID.TabIndex = 116
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(73, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 19)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Dni:"
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDNI.Location = New System.Drawing.Point(132, 134)
        Me.TextBoxDNI.MaxLength = 8
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(120, 29)
        Me.TextBoxDNI.TabIndex = 104
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Image = CType(resources.GetObject("VerLaAyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la Ayuda"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ButtonModificar)
        Me.Panel2.Controls.Add(Me.ButtonEliminar)
        Me.Panel2.Controls.Add(Me.ButtonAlta)
        Me.Panel2.Location = New System.Drawing.Point(1126, 361)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 347)
        Me.Panel2.TabIndex = 30
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonModificar.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificar.Location = New System.Drawing.Point(3, 233)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(209, 109)
        Me.ButtonModificar.TabIndex = 3
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonEliminar.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.Location = New System.Drawing.Point(3, 118)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(209, 109)
        Me.ButtonEliminar.TabIndex = 2
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonAlta
        '
        Me.ButtonAlta.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonAlta.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAlta.Location = New System.Drawing.Point(3, 3)
        Me.ButtonAlta.Name = "ButtonAlta"
        Me.ButtonAlta.Size = New System.Drawing.Size(209, 109)
        Me.ButtonAlta.TabIndex = 1
        Me.ButtonAlta.Text = "Alta"
        Me.ButtonAlta.UseVisualStyleBackColor = False
        '
        'MenuStripPagPrin
        '
        Me.MenuStripPagPrin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HerramientasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.CajaToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.FormularioPruebaToolStripMenuItem})
        Me.MenuStripPagPrin.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPagPrin.Name = "MenuStripPagPrin"
        Me.MenuStripPagPrin.Size = New System.Drawing.Size(1919, 24)
        Me.MenuStripPagPrin.TabIndex = 32
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
        'FormularioPruebaToolStripMenuItem
        '
        Me.FormularioPruebaToolStripMenuItem.Name = "FormularioPruebaToolStripMenuItem"
        Me.FormularioPruebaToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.FormularioPruebaToolStripMenuItem.Text = "FormularioPrueba"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(190, 25)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Gestión de Clientes"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(44, 188)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 19)
        Me.Label21.TabIndex = 105
        Me.Label21.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ListBoxcID)
        Me.Panel1.Controls.Add(Me.ListBoxTelefono)
        Me.Panel1.Controls.Add(Me.ListBoxApellido2)
        Me.Panel1.Controls.Add(Me.ListBoxApellido1)
        Me.Panel1.Controls.Add(Me.ListBoxNombre)
        Me.Panel1.Controls.Add(Me.ListBoxDNI)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(35, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1063, 816)
        Me.Panel1.TabIndex = 29
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Gadugi", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(733, 299)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 16)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "Telefono"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Gadugi", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(572, 299)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 16)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Apellido2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Gadugi", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(406, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Apellido1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Gadugi", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(254, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Gadugi", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(120, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 16)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Dni"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gadugi", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(22, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 16)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "ID"
        '
        'ListBoxcID
        '
        Me.ListBoxcID.FormattingEnabled = True
        Me.ListBoxcID.Location = New System.Drawing.Point(3, 325)
        Me.ListBoxcID.Name = "ListBoxcID"
        Me.ListBoxcID.Size = New System.Drawing.Size(65, 95)
        Me.ListBoxcID.TabIndex = 43
        '
        'ListBoxTelefono
        '
        Me.ListBoxTelefono.FormattingEnabled = True
        Me.ListBoxTelefono.Location = New System.Drawing.Point(692, 325)
        Me.ListBoxTelefono.Name = "ListBoxTelefono"
        Me.ListBoxTelefono.Size = New System.Drawing.Size(152, 95)
        Me.ListBoxTelefono.TabIndex = 42
        '
        'ListBoxApellido2
        '
        Me.ListBoxApellido2.FormattingEnabled = True
        Me.ListBoxApellido2.Location = New System.Drawing.Point(530, 325)
        Me.ListBoxApellido2.Name = "ListBoxApellido2"
        Me.ListBoxApellido2.Size = New System.Drawing.Size(156, 95)
        Me.ListBoxApellido2.TabIndex = 41
        '
        'ListBoxApellido1
        '
        Me.ListBoxApellido1.FormattingEnabled = True
        Me.ListBoxApellido1.Location = New System.Drawing.Point(364, 325)
        Me.ListBoxApellido1.Name = "ListBoxApellido1"
        Me.ListBoxApellido1.Size = New System.Drawing.Size(160, 95)
        Me.ListBoxApellido1.TabIndex = 40
        '
        'ListBoxNombre
        '
        Me.ListBoxNombre.FormattingEnabled = True
        Me.ListBoxNombre.Location = New System.Drawing.Point(203, 325)
        Me.ListBoxNombre.Name = "ListBoxNombre"
        Me.ListBoxNombre.Size = New System.Drawing.Size(155, 95)
        Me.ListBoxNombre.TabIndex = 39
        '
        'ListBoxDNI
        '
        Me.ListBoxDNI.FormattingEnabled = True
        Me.ListBoxDNI.Location = New System.Drawing.Point(74, 325)
        Me.ListBoxDNI.Name = "ListBoxDNI"
        Me.ListBoxDNI.Size = New System.Drawing.Size(123, 95)
        Me.ListBoxDNI.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBoxBusId)
        Me.GroupBox1.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ButtonBusca)
        Me.GroupBox1.Controls.Add(Me.TextBoxBusNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1042, 270)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'TextBoxBusId
        '
        Me.TextBoxBusId.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusId.Location = New System.Drawing.Point(139, 45)
        Me.TextBoxBusId.MaxLength = 5
        Me.TextBoxBusId.Name = "TextBoxBusId"
        Me.TextBoxBusId.Size = New System.Drawing.Size(203, 29)
        Me.TextBoxBusId.TabIndex = 117
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(747, 158)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(133, 59)
        Me.ButtonLimpiar.TabIndex = 57
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(442, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 19)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Nombre:"
        '
        'ButtonBusca
        '
        Me.ButtonBusca.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonBusca.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBusca.Location = New System.Drawing.Point(527, 160)
        Me.ButtonBusca.Name = "ButtonBusca"
        Me.ButtonBusca.Size = New System.Drawing.Size(133, 59)
        Me.ButtonBusca.TabIndex = 56
        Me.ButtonBusca.Text = "Buscar"
        Me.ButtonBusca.UseVisualStyleBackColor = False
        '
        'TextBoxBusNombre
        '
        Me.TextBoxBusNombre.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusNombre.Location = New System.Drawing.Point(530, 45)
        Me.TextBoxBusNombre.MaxLength = 20
        Me.TextBoxBusNombre.Name = "TextBoxBusNombre"
        Me.TextBoxBusNombre.Size = New System.Drawing.Size(311, 29)
        Me.TextBoxBusNombre.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "ID:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(132, 185)
        Me.TextBoxNombre.MaxLength = 20
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(311, 29)
        Me.TextBoxNombre.TabIndex = 106
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(24, 250)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 19)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "1º apellido:"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(130, 349)
        Me.TextBoxTelefono.MaxLength = 9
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(122, 29)
        Me.TextBoxTelefono.TabIndex = 114
        '
        'TextBoxApellido1
        '
        Me.TextBoxApellido1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApellido1.Location = New System.Drawing.Point(130, 247)
        Me.TextBoxApellido1.MaxLength = 20
        Me.TextBoxApellido1.Name = "TextBoxApellido1"
        Me.TextBoxApellido1.Size = New System.Drawing.Size(311, 29)
        Me.TextBoxApellido1.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 113
        Me.Label5.Tag = ""
        Me.Label5.Text = "Telefono:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 295)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 19)
        Me.Label19.TabIndex = 109
        Me.Label19.Tag = ""
        Me.Label19.Text = "2º apellido:"
        '
        'TextBoxApellido2
        '
        Me.TextBoxApellido2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApellido2.Location = New System.Drawing.Point(130, 292)
        Me.TextBoxApellido2.MaxLength = 20
        Me.TextBoxApellido2.Name = "TextBoxApellido2"
        Me.TextBoxApellido2.Size = New System.Drawing.Size(311, 29)
        Me.TextBoxApellido2.TabIndex = 110
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Controls.Add(Me.Label1)
        Me.ButtonBuscar.Controls.Add(Me.TextBoxID)
        Me.ButtonBuscar.Controls.Add(Me.Label16)
        Me.ButtonBuscar.Controls.Add(Me.Label17)
        Me.ButtonBuscar.Controls.Add(Me.TextBoxDNI)
        Me.ButtonBuscar.Controls.Add(Me.Label21)
        Me.ButtonBuscar.Controls.Add(Me.TextBoxNombre)
        Me.ButtonBuscar.Controls.Add(Me.Label20)
        Me.ButtonBuscar.Controls.Add(Me.TextBoxTelefono)
        Me.ButtonBuscar.Controls.Add(Me.TextBoxApellido1)
        Me.ButtonBuscar.Controls.Add(Me.Label5)
        Me.ButtonBuscar.Controls.Add(Me.Label19)
        Me.ButtonBuscar.Controls.Add(Me.TextBoxApellido2)
        Me.ButtonBuscar.Location = New System.Drawing.Point(1381, 147)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(503, 763)
        Me.ButtonBuscar.TabIndex = 31
        Me.ButtonBuscar.TabStop = False
        '
        'GestionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1919, 968)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStripPagPrin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Name = "GestionClientes"
        Me.Text = "GestionClientes"
        Me.Panel2.ResumeLayout(False)
        Me.MenuStripPagPrin.ResumeLayout(False)
        Me.MenuStripPagPrin.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ButtonBuscar.ResumeLayout(False)
        Me.ButtonBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents VerLaAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonAlta As Button
    Friend WithEvents MenuStripPagPrin As MenuStrip
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeCajasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormularioPruebaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label16 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBoxcID As ListBox
    Friend WithEvents ListBoxTelefono As ListBox
    Friend WithEvents ListBoxApellido2 As ListBox
    Friend WithEvents ListBoxApellido1 As ListBox
    Friend WithEvents ListBoxNombre As ListBox
    Friend WithEvents ListBoxDNI As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxBusId As TextBox
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonBusca As Button
    Friend WithEvents TextBoxBusNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxApellido1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxApellido2 As TextBox
    Friend WithEvents ButtonBuscar As GroupBox
End Class
