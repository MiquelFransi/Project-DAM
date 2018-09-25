<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.label_baixa = New System.Windows.Forms.Label()
        Me.FAQ = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Alt = New System.Windows.Forms.RadioButton()
        Me.Mitja = New System.Windows.Forms.RadioButton()
        Me.Baix = New System.Windows.Forms.RadioButton()
        Me.Label_categoria = New System.Windows.Forms.Label()
        Me.categoria = New System.Windows.Forms.ComboBox()
        Me.Label_titol = New System.Windows.Forms.Label()
        Me.titol = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.LabelNievell = New System.Windows.Forms.Label()
        Me.PobIncidencia = New System.Windows.Forms.TextBox()
        Me.ProvInci = New System.Windows.Forms.TextBox()
        Me.label_Poblacio = New System.Windows.Forms.Label()
        Me.label_Provincia = New System.Windows.Forms.Label()
        Me.descrip = New System.Windows.Forms.TextBox()
        Me.label_descr = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Fetes = New System.Windows.Forms.CheckBox()
        Me.DescarregarCur = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mal = New System.Windows.Forms.RadioButton()
        Me.regular = New System.Windows.Forms.RadioButton()
        Me.be = New System.Windows.Forms.RadioButton()
        Me.Label_cat2 = New System.Windows.Forms.Label()
        Me.cateinci = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.label_tit2 = New System.Windows.Forms.Label()
        Me.TitolInci = New System.Windows.Forms.TextBox()
        Me.descripInici = New System.Windows.Forms.TextBox()
        Me.Label_desc2 = New System.Windows.Forms.Label()
        Me.NomInformatic = New System.Windows.Forms.Label()
        Me.Label_informatic = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.noFeta = New System.Windows.Forms.RadioButton()
        Me.siFeta = New System.Windows.Forms.RadioButton()
        Me.Label_Incid = New System.Windows.Forms.Label()
        Me.incidencies = New System.Windows.Forms.ComboBox()
        Me.lavel_valoracio = New System.Windows.Forms.Label()
        Me.Feta = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.Label1_selec_idioma = New System.Windows.Forms.Label()
        Me.dioma = New System.Windows.Forms.ComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.sortir = New System.Windows.Forms.Label()
        Me.cognom = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BotoMenuVertical = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Menu.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotoMenuVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_baixa
        '
        Me.label_baixa.AutoSize = True
        Me.label_baixa.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_baixa.ForeColor = System.Drawing.SystemColors.Control
        Me.label_baixa.Location = New System.Drawing.Point(58, 172)
        Me.label_baixa.Name = "label_baixa"
        Me.label_baixa.Size = New System.Drawing.Size(90, 16)
        Me.label_baixa.TabIndex = 2
        Me.label_baixa.Text = "Donar-se de baixa"
        '
        'FAQ
        '
        Me.FAQ.AutoSize = True
        Me.FAQ.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAQ.ForeColor = System.Drawing.SystemColors.Control
        Me.FAQ.Location = New System.Drawing.Point(57, 224)
        Me.FAQ.Name = "FAQ"
        Me.FAQ.Size = New System.Drawing.Size(29, 16)
        Me.FAQ.TabIndex = 5
        Me.FAQ.Text = "FAQ"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(169, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(704, 537)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label_categoria)
        Me.TabPage1.Controls.Add(Me.categoria)
        Me.TabPage1.Controls.Add(Me.Label_titol)
        Me.TabPage1.Controls.Add(Me.titol)
        Me.TabPage1.Controls.Add(Me.Guardar)
        Me.TabPage1.Controls.Add(Me.LabelNievell)
        Me.TabPage1.Controls.Add(Me.PobIncidencia)
        Me.TabPage1.Controls.Add(Me.ProvInci)
        Me.TabPage1.Controls.Add(Me.label_Poblacio)
        Me.TabPage1.Controls.Add(Me.label_Provincia)
        Me.TabPage1.Controls.Add(Me.descrip)
        Me.TabPage1.Controls.Add(Me.label_descr)
        Me.TabPage1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(696, 511)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Crear Incidencia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Alt)
        Me.GroupBox1.Controls.Add(Me.Mitja)
        Me.GroupBox1.Controls.Add(Me.Baix)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 338)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 47)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'Alt
        '
        Me.Alt.AutoSize = True
        Me.Alt.Location = New System.Drawing.Point(142, 20)
        Me.Alt.Name = "Alt"
        Me.Alt.Size = New System.Drawing.Size(40, 24)
        Me.Alt.TabIndex = 2
        Me.Alt.TabStop = True
        Me.Alt.Text = "Alt"
        Me.Alt.UseVisualStyleBackColor = True
        '
        'Mitja
        '
        Me.Mitja.AutoSize = True
        Me.Mitja.Location = New System.Drawing.Point(67, 20)
        Me.Mitja.Name = "Mitja"
        Me.Mitja.Size = New System.Drawing.Size(54, 24)
        Me.Mitja.TabIndex = 1
        Me.Mitja.TabStop = True
        Me.Mitja.Text = "Mitja"
        Me.Mitja.UseVisualStyleBackColor = True
        '
        'Baix
        '
        Me.Baix.AutoSize = True
        Me.Baix.Location = New System.Drawing.Point(7, 20)
        Me.Baix.Name = "Baix"
        Me.Baix.Size = New System.Drawing.Size(51, 24)
        Me.Baix.TabIndex = 0
        Me.Baix.TabStop = True
        Me.Baix.Text = "Baix"
        Me.Baix.UseVisualStyleBackColor = True
        '
        'Label_categoria
        '
        Me.Label_categoria.AutoSize = True
        Me.Label_categoria.Location = New System.Drawing.Point(47, 314)
        Me.Label_categoria.Name = "Label_categoria"
        Me.Label_categoria.Size = New System.Drawing.Size(63, 20)
        Me.Label_categoria.TabIndex = 27
        Me.Label_categoria.Text = "Categoria"
        '
        'categoria
        '
        Me.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoria.FormattingEnabled = True
        Me.categoria.Location = New System.Drawing.Point(151, 307)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(121, 28)
        Me.categoria.TabIndex = 26
        '
        'Label_titol
        '
        Me.Label_titol.AutoSize = True
        Me.Label_titol.Location = New System.Drawing.Point(51, 64)
        Me.Label_titol.Name = "Label_titol"
        Me.Label_titol.Size = New System.Drawing.Size(34, 20)
        Me.Label_titol.TabIndex = 25
        Me.Label_titol.Text = "Títol"
        '
        'titol
        '
        Me.titol.Location = New System.Drawing.Point(151, 64)
        Me.titol.Name = "titol"
        Me.titol.Size = New System.Drawing.Size(182, 25)
        Me.titol.TabIndex = 24
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.Color.Silver
        Me.Guardar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guardar.Location = New System.Drawing.Point(527, 430)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(106, 28)
        Me.Guardar.TabIndex = 23
        Me.Guardar.Text = "Crear"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'LabelNievell
        '
        Me.LabelNievell.AutoSize = True
        Me.LabelNievell.Location = New System.Drawing.Point(50, 355)
        Me.LabelNievell.Name = "LabelNievell"
        Me.LabelNievell.Size = New System.Drawing.Size(42, 20)
        Me.LabelNievell.TabIndex = 19
        Me.LabelNievell.Text = "Nivell:"
        '
        'PobIncidencia
        '
        Me.PobIncidencia.Location = New System.Drawing.Point(151, 272)
        Me.PobIncidencia.Name = "PobIncidencia"
        Me.PobIncidencia.Size = New System.Drawing.Size(182, 25)
        Me.PobIncidencia.TabIndex = 18
        '
        'ProvInci
        '
        Me.ProvInci.Location = New System.Drawing.Point(151, 236)
        Me.ProvInci.Name = "ProvInci"
        Me.ProvInci.Size = New System.Drawing.Size(182, 25)
        Me.ProvInci.TabIndex = 17
        '
        'label_Poblacio
        '
        Me.label_Poblacio.AutoSize = True
        Me.label_Poblacio.Location = New System.Drawing.Point(47, 276)
        Me.label_Poblacio.Name = "label_Poblacio"
        Me.label_Poblacio.Size = New System.Drawing.Size(61, 20)
        Me.label_Poblacio.TabIndex = 16
        Me.label_Poblacio.Text = "Població:"
        '
        'label_Provincia
        '
        Me.label_Provincia.AutoSize = True
        Me.label_Provincia.Location = New System.Drawing.Point(47, 237)
        Me.label_Provincia.Name = "label_Provincia"
        Me.label_Provincia.Size = New System.Drawing.Size(63, 20)
        Me.label_Provincia.TabIndex = 15
        Me.label_Provincia.Text = "Província:"
        '
        'descrip
        '
        Me.descrip.Location = New System.Drawing.Point(151, 108)
        Me.descrip.Multiline = True
        Me.descrip.Name = "descrip"
        Me.descrip.Size = New System.Drawing.Size(352, 109)
        Me.descrip.TabIndex = 14
        '
        'label_descr
        '
        Me.label_descr.AutoSize = True
        Me.label_descr.Location = New System.Drawing.Point(47, 108)
        Me.label_descr.Name = "label_descr"
        Me.label_descr.Size = New System.Drawing.Size(72, 20)
        Me.label_descr.TabIndex = 13
        Me.label_descr.Text = "Descripció:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.Fetes)
        Me.TabPage2.Controls.Add(Me.DescarregarCur)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Label_cat2)
        Me.TabPage2.Controls.Add(Me.cateinci)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.label_tit2)
        Me.TabPage2.Controls.Add(Me.TitolInci)
        Me.TabPage2.Controls.Add(Me.descripInici)
        Me.TabPage2.Controls.Add(Me.Label_desc2)
        Me.TabPage2.Controls.Add(Me.NomInformatic)
        Me.TabPage2.Controls.Add(Me.Label_informatic)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Label_Incid)
        Me.TabPage2.Controls.Add(Me.incidencies)
        Me.TabPage2.Controls.Add(Me.lavel_valoracio)
        Me.TabPage2.Controls.Add(Me.Feta)
        Me.TabPage2.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(696, 511)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Veure incidencia"
        '
        'Fetes
        '
        Me.Fetes.AutoSize = True
        Me.Fetes.Location = New System.Drawing.Point(314, 59)
        Me.Fetes.Name = "Fetes"
        Me.Fetes.Size = New System.Drawing.Size(59, 24)
        Me.Fetes.TabIndex = 46
        Me.Fetes.Text = "Fetes"
        Me.Fetes.UseVisualStyleBackColor = True
        '
        'DescarregarCur
        '
        Me.DescarregarCur.BackColor = System.Drawing.Color.Silver
        Me.DescarregarCur.ForeColor = System.Drawing.SystemColors.Desktop
        Me.DescarregarCur.Location = New System.Drawing.Point(331, 308)
        Me.DescarregarCur.Name = "DescarregarCur"
        Me.DescarregarCur.Size = New System.Drawing.Size(175, 27)
        Me.DescarregarCur.TabIndex = 45
        Me.DescarregarCur.Text = "Descarregar Curriculum"
        Me.DescarregarCur.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mal)
        Me.GroupBox3.Controls.Add(Me.regular)
        Me.GroupBox3.Controls.Add(Me.be)
        Me.GroupBox3.Location = New System.Drawing.Point(154, 394)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 38)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'mal
        '
        Me.mal.AutoSize = True
        Me.mal.Location = New System.Drawing.Point(6, 10)
        Me.mal.Name = "mal"
        Me.mal.Size = New System.Drawing.Size(83, 24)
        Me.mal.TabIndex = 24
        Me.mal.TabStop = True
        Me.mal.Text = "Malament"
        Me.mal.UseVisualStyleBackColor = True
        '
        'regular
        '
        Me.regular.AutoSize = True
        Me.regular.Location = New System.Drawing.Point(91, 10)
        Me.regular.Name = "regular"
        Me.regular.Size = New System.Drawing.Size(71, 24)
        Me.regular.TabIndex = 25
        Me.regular.TabStop = True
        Me.regular.Text = "Regular"
        Me.regular.UseVisualStyleBackColor = True
        '
        'be
        '
        Me.be.AutoSize = True
        Me.be.Location = New System.Drawing.Point(177, 10)
        Me.be.Name = "be"
        Me.be.Size = New System.Drawing.Size(42, 24)
        Me.be.TabIndex = 26
        Me.be.TabStop = True
        Me.be.Text = "Bé"
        Me.be.UseVisualStyleBackColor = True
        '
        'Label_cat2
        '
        Me.Label_cat2.AutoSize = True
        Me.Label_cat2.Location = New System.Drawing.Point(56, 263)
        Me.Label_cat2.Name = "Label_cat2"
        Me.Label_cat2.Size = New System.Drawing.Size(63, 20)
        Me.Label_cat2.TabIndex = 44
        Me.Label_cat2.Text = "Categoria"
        '
        'cateinci
        '
        Me.cateinci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cateinci.FormattingEnabled = True
        Me.cateinci.Location = New System.Drawing.Point(160, 260)
        Me.cateinci.Name = "cateinci"
        Me.cateinci.Size = New System.Drawing.Size(121, 28)
        Me.cateinci.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button2.Location = New System.Drawing.Point(531, 465)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 28)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'label_tit2
        '
        Me.label_tit2.AutoSize = True
        Me.label_tit2.Location = New System.Drawing.Point(56, 103)
        Me.label_tit2.Name = "label_tit2"
        Me.label_tit2.Size = New System.Drawing.Size(34, 20)
        Me.label_tit2.TabIndex = 38
        Me.label_tit2.Text = "Títol"
        '
        'TitolInci
        '
        Me.TitolInci.Location = New System.Drawing.Point(160, 100)
        Me.TitolInci.Name = "TitolInci"
        Me.TitolInci.Size = New System.Drawing.Size(182, 25)
        Me.TitolInci.TabIndex = 37
        '
        'descripInici
        '
        Me.descripInici.Location = New System.Drawing.Point(160, 134)
        Me.descripInici.Multiline = True
        Me.descripInici.Name = "descripInici"
        Me.descripInici.Size = New System.Drawing.Size(283, 109)
        Me.descripInici.TabIndex = 32
        '
        'Label_desc2
        '
        Me.Label_desc2.AutoSize = True
        Me.Label_desc2.Location = New System.Drawing.Point(56, 134)
        Me.Label_desc2.Name = "Label_desc2"
        Me.Label_desc2.Size = New System.Drawing.Size(72, 20)
        Me.Label_desc2.TabIndex = 31
        Me.Label_desc2.Text = "Descripció:"
        '
        'NomInformatic
        '
        Me.NomInformatic.AutoSize = True
        Me.NomInformatic.Location = New System.Drawing.Point(156, 309)
        Me.NomInformatic.Name = "NomInformatic"
        Me.NomInformatic.Size = New System.Drawing.Size(146, 20)
        Me.NomInformatic.TabIndex = 29
        Me.NomInformatic.Text = "Incidència No assignada"
        '
        'Label_informatic
        '
        Me.Label_informatic.AutoSize = True
        Me.Label_informatic.Location = New System.Drawing.Point(60, 309)
        Me.Label_informatic.Name = "Label_informatic"
        Me.Label_informatic.Size = New System.Drawing.Size(67, 20)
        Me.Label_informatic.TabIndex = 28
        Me.Label_informatic.Text = "Informàtic:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.noFeta)
        Me.GroupBox2.Controls.Add(Me.siFeta)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 38)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'noFeta
        '
        Me.noFeta.AutoSize = True
        Me.noFeta.Location = New System.Drawing.Point(74, 12)
        Me.noFeta.Name = "noFeta"
        Me.noFeta.Size = New System.Drawing.Size(43, 24)
        Me.noFeta.TabIndex = 1
        Me.noFeta.TabStop = True
        Me.noFeta.Text = "No"
        Me.noFeta.UseVisualStyleBackColor = True
        '
        'siFeta
        '
        Me.siFeta.AutoSize = True
        Me.siFeta.Location = New System.Drawing.Point(7, 12)
        Me.siFeta.Name = "siFeta"
        Me.siFeta.Size = New System.Drawing.Size(38, 24)
        Me.siFeta.TabIndex = 0
        Me.siFeta.TabStop = True
        Me.siFeta.Text = "Si"
        Me.siFeta.UseVisualStyleBackColor = True
        '
        'Label_Incid
        '
        Me.Label_Incid.AutoSize = True
        Me.Label_Incid.Location = New System.Drawing.Point(56, 65)
        Me.Label_Incid.Name = "Label_Incid"
        Me.Label_Incid.Size = New System.Drawing.Size(73, 20)
        Me.Label_Incid.TabIndex = 23
        Me.Label_Incid.Text = "Incidències"
        '
        'incidencies
        '
        Me.incidencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.incidencies.FormattingEnabled = True
        Me.incidencies.Location = New System.Drawing.Point(160, 57)
        Me.incidencies.Name = "incidencies"
        Me.incidencies.Size = New System.Drawing.Size(121, 28)
        Me.incidencies.TabIndex = 22
        '
        'lavel_valoracio
        '
        Me.lavel_valoracio.AutoSize = True
        Me.lavel_valoracio.Location = New System.Drawing.Point(63, 402)
        Me.lavel_valoracio.Name = "lavel_valoracio"
        Me.lavel_valoracio.Size = New System.Drawing.Size(64, 20)
        Me.lavel_valoracio.TabIndex = 16
        Me.lavel_valoracio.Text = "Valoració:"
        '
        'Feta
        '
        Me.Feta.AutoSize = True
        Me.Feta.Location = New System.Drawing.Point(63, 352)
        Me.Feta.Name = "Feta"
        Me.Feta.Size = New System.Drawing.Size(37, 20)
        Me.Feta.TabIndex = 15
        Me.Feta.Text = "Feta:"
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.Black
        Me.Menu.Controls.Add(Me.Label1_selec_idioma)
        Me.Menu.Controls.Add(Me.dioma)
        Me.Menu.Controls.Add(Me.PictureBox4)
        Me.Menu.Controls.Add(Me.sortir)
        Me.Menu.Controls.Add(Me.cognom)
        Me.Menu.Controls.Add(Me.nom)
        Me.Menu.Controls.Add(Me.PictureBox2)
        Me.Menu.Controls.Add(Me.PictureBox1)
        Me.Menu.Controls.Add(Me.BotoMenuVertical)
        Me.Menu.Controls.Add(Me.FAQ)
        Me.Menu.Controls.Add(Me.label_baixa)
        Me.Menu.Font = New System.Drawing.Font("Blackoak Std", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Location = New System.Drawing.Point(-2, -2)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(150, 567)
        Me.Menu.TabIndex = 7
        '
        'Label1_selec_idioma
        '
        Me.Label1_selec_idioma.AutoSize = True
        Me.Label1_selec_idioma.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.Label1_selec_idioma.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1_selec_idioma.Location = New System.Drawing.Point(10, 401)
        Me.Label1_selec_idioma.Name = "Label1_selec_idioma"
        Me.Label1_selec_idioma.Size = New System.Drawing.Size(47, 20)
        Me.Label1_selec_idioma.TabIndex = 34
        Me.Label1_selec_idioma.Text = "Label1"
        '
        'dioma
        '
        Me.dioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dioma.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.dioma.FormattingEnabled = True
        Me.dioma.Items.AddRange(New Object() {"Català", "Anglès"})
        Me.dioma.Location = New System.Drawing.Point(14, 436)
        Me.dioma.Name = "dioma"
        Me.dioma.Size = New System.Drawing.Size(121, 28)
        Me.dioma.TabIndex = 33
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Location = New System.Drawing.Point(12, 485)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'sortir
        '
        Me.sortir.AutoSize = True
        Me.sortir.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortir.ForeColor = System.Drawing.SystemColors.Control
        Me.sortir.Location = New System.Drawing.Point(58, 496)
        Me.sortir.Name = "sortir"
        Me.sortir.Size = New System.Drawing.Size(35, 16)
        Me.sortir.TabIndex = 25
        Me.sortir.Text = "Sortir"
        '
        'cognom
        '
        Me.cognom.AutoSize = True
        Me.cognom.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.cognom.ForeColor = System.Drawing.SystemColors.Control
        Me.cognom.Location = New System.Drawing.Point(15, 79)
        Me.cognom.Name = "cognom"
        Me.cognom.Size = New System.Drawing.Size(55, 20)
        Me.cognom.TabIndex = 13
        Me.cognom.Text = "cognom"
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.nom.ForeColor = System.Drawing.SystemColors.Control
        Me.nom.Location = New System.Drawing.Point(15, 54)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(34, 20)
        Me.nom.TabIndex = 12
        Me.nom.Text = "nom"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(12, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 43)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(11, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BotoMenuVertical
        '
        Me.BotoMenuVertical.BackColor = System.Drawing.Color.Transparent
        Me.BotoMenuVertical.ErrorImage = CType(resources.GetObject("BotoMenuVertical.ErrorImage"), System.Drawing.Image)
        Me.BotoMenuVertical.InitialImage = CType(resources.GetObject("BotoMenuVertical.InitialImage"), System.Drawing.Image)
        Me.BotoMenuVertical.Location = New System.Drawing.Point(14, 10)
        Me.BotoMenuVertical.Name = "BotoMenuVertical"
        Me.BotoMenuVertical.Size = New System.Drawing.Size(71, 37)
        Me.BotoMenuVertical.TabIndex = 8
        Me.BotoMenuVertical.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 561)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "PANEL USUARI "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotoMenuVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label_baixa As Label
    Friend WithEvents FAQ As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Guardar As Button
    Friend WithEvents LabelNievell As Label
    Friend WithEvents PobIncidencia As TextBox
    Friend WithEvents ProvInci As TextBox
    Friend WithEvents label_Poblacio As Label
    Friend WithEvents label_Provincia As Label
    Friend WithEvents descrip As TextBox
    Friend WithEvents label_descr As Label
    Friend WithEvents Label_Incid As Label
    Friend WithEvents incidencies As ComboBox
    Friend WithEvents lavel_valoracio As Label
    Friend WithEvents Feta As Label
    Friend WithEvents Menu As Panel
    Friend WithEvents BotoMenuVertical As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cognom As Label
    Friend WithEvents nom As Label
    Friend WithEvents Label_titol As Label
    Friend WithEvents titol As TextBox
    Friend WithEvents Label_categoria As Label
    Friend WithEvents categoria As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Alt As RadioButton
    Friend WithEvents Mitja As RadioButton
    Friend WithEvents Baix As RadioButton
    Friend WithEvents NomInformatic As Label
    Friend WithEvents Label_informatic As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents noFeta As RadioButton
    Friend WithEvents siFeta As RadioButton
    Friend WithEvents be As RadioButton
    Friend WithEvents regular As RadioButton
    Friend WithEvents mal As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents label_tit2 As Label
    Friend WithEvents TitolInci As TextBox
    Friend WithEvents descripInici As TextBox
    Friend WithEvents Label_desc2 As Label
    Friend WithEvents Label_cat2 As Label
    Friend WithEvents cateinci As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents sortir As Label
    Friend WithEvents DescarregarCur As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Fetes As CheckBox
    Friend WithEvents Label1_selec_idioma As Label
    Friend WithEvents dioma As ComboBox
End Class
