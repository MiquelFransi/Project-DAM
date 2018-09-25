<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrarse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrarse))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.nomU = New System.Windows.Forms.TextBox()
        Me.label_nom = New System.Windows.Forms.Label()
        Me.usuariU = New System.Windows.Forms.TextBox()
        Me.Label1_usuario = New System.Windows.Forms.Label()
        Me.label_dni = New System.Windows.Forms.Label()
        Me.DNIU = New System.Windows.Forms.TextBox()
        Me.bt_Registrar = New System.Windows.Forms.Button()
        Me.PoblacioU = New System.Windows.Forms.TextBox()
        Me.provinciaU = New System.Windows.Forms.TextBox()
        Me.ContrasenyaU = New System.Windows.Forms.TextBox()
        Me.cognomU = New System.Windows.Forms.TextBox()
        Me.label_Poblacio = New System.Windows.Forms.Label()
        Me.label_Provincia = New System.Windows.Forms.Label()
        Me.label_contra = New System.Windows.Forms.Label()
        Me.label_cognom = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NomFitxer = New System.Windows.Forms.Label()
        Me.cognomInf = New System.Windows.Forms.TextBox()
        Me.cognomI = New System.Windows.Forms.Label()
        Me.usuariInf = New System.Windows.Forms.TextBox()
        Me.userI = New System.Windows.Forms.Label()
        Me.dniI = New System.Windows.Forms.Label()
        Me.dniInf = New System.Windows.Forms.TextBox()
        Me.poblacioInf = New System.Windows.Forms.TextBox()
        Me.provincaiInf = New System.Windows.Forms.TextBox()
        Me.contrasenyaInf = New System.Windows.Forms.TextBox()
        Me.nomInf = New System.Windows.Forms.TextBox()
        Me.pobI = New System.Windows.Forms.Label()
        Me.provinI = New System.Windows.Forms.Label()
        Me.passI = New System.Windows.Forms.Label()
        Me.nomI = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt_Registrar2 = New System.Windows.Forms.Button()
        Me.curricuI = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.Label1_selec_idioma = New System.Windows.Forms.Label()
        Me.dioma = New System.Windows.Forms.ComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.darrere = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BotoMenuVertical = New System.Windows.Forms.PictureBox()
        Me.FAQ = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Menu.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotoMenuVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(155, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(611, 443)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.nomU)
        Me.TabPage1.Controls.Add(Me.label_nom)
        Me.TabPage1.Controls.Add(Me.usuariU)
        Me.TabPage1.Controls.Add(Me.Label1_usuario)
        Me.TabPage1.Controls.Add(Me.label_dni)
        Me.TabPage1.Controls.Add(Me.DNIU)
        Me.TabPage1.Controls.Add(Me.bt_Registrar)
        Me.TabPage1.Controls.Add(Me.PoblacioU)
        Me.TabPage1.Controls.Add(Me.provinciaU)
        Me.TabPage1.Controls.Add(Me.ContrasenyaU)
        Me.TabPage1.Controls.Add(Me.cognomU)
        Me.TabPage1.Controls.Add(Me.label_Poblacio)
        Me.TabPage1.Controls.Add(Me.label_Provincia)
        Me.TabPage1.Controls.Add(Me.label_contra)
        Me.TabPage1.Controls.Add(Me.label_cognom)
        Me.TabPage1.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(603, 417)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Usuari"
        '
        'nomU
        '
        Me.nomU.Location = New System.Drawing.Point(259, 44)
        Me.nomU.Name = "nomU"
        Me.nomU.Size = New System.Drawing.Size(133, 25)
        Me.nomU.TabIndex = 1
        '
        'label_nom
        '
        Me.label_nom.AutoSize = True
        Me.label_nom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_nom.Location = New System.Drawing.Point(150, 49)
        Me.label_nom.Name = "label_nom"
        Me.label_nom.Size = New System.Drawing.Size(39, 20)
        Me.label_nom.TabIndex = 24
        Me.label_nom.Text = "Nom:"
        '
        'usuariU
        '
        Me.usuariU.Location = New System.Drawing.Point(259, 117)
        Me.usuariU.Name = "usuariU"
        Me.usuariU.Size = New System.Drawing.Size(133, 25)
        Me.usuariU.TabIndex = 3
        '
        'Label1_usuario
        '
        Me.Label1_usuario.AutoSize = True
        Me.Label1_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1_usuario.Location = New System.Drawing.Point(150, 122)
        Me.Label1_usuario.Name = "Label1_usuario"
        Me.Label1_usuario.Size = New System.Drawing.Size(48, 20)
        Me.Label1_usuario.TabIndex = 22
        Me.Label1_usuario.Text = "Usuari:"
        '
        'label_dni
        '
        Me.label_dni.AutoSize = True
        Me.label_dni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_dni.Location = New System.Drawing.Point(156, 285)
        Me.label_dni.Name = "label_dni"
        Me.label_dni.Size = New System.Drawing.Size(33, 20)
        Me.label_dni.TabIndex = 21
        Me.label_dni.Text = "DNI:"
        '
        'DNIU
        '
        Me.DNIU.Location = New System.Drawing.Point(259, 281)
        Me.DNIU.MaxLength = 9
        Me.DNIU.Name = "DNIU"
        Me.DNIU.Size = New System.Drawing.Size(133, 25)
        Me.DNIU.TabIndex = 7
        '
        'bt_Registrar
        '
        Me.bt_Registrar.BackColor = System.Drawing.Color.Silver
        Me.bt_Registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_Registrar.Location = New System.Drawing.Point(430, 340)
        Me.bt_Registrar.Name = "bt_Registrar"
        Me.bt_Registrar.Size = New System.Drawing.Size(111, 30)
        Me.bt_Registrar.TabIndex = 19
        Me.bt_Registrar.Text = "Registrar-se"
        Me.bt_Registrar.UseVisualStyleBackColor = False
        '
        'PoblacioU
        '
        Me.PoblacioU.Location = New System.Drawing.Point(259, 241)
        Me.PoblacioU.Name = "PoblacioU"
        Me.PoblacioU.Size = New System.Drawing.Size(133, 25)
        Me.PoblacioU.TabIndex = 6
        '
        'provinciaU
        '
        Me.provinciaU.Location = New System.Drawing.Point(259, 197)
        Me.provinciaU.Name = "provinciaU"
        Me.provinciaU.Size = New System.Drawing.Size(133, 25)
        Me.provinciaU.TabIndex = 5
        '
        'ContrasenyaU
        '
        Me.ContrasenyaU.Location = New System.Drawing.Point(259, 156)
        Me.ContrasenyaU.Name = "ContrasenyaU"
        Me.ContrasenyaU.Size = New System.Drawing.Size(133, 25)
        Me.ContrasenyaU.TabIndex = 4
        Me.ContrasenyaU.UseSystemPasswordChar = True
        '
        'cognomU
        '
        Me.cognomU.Location = New System.Drawing.Point(259, 80)
        Me.cognomU.Name = "cognomU"
        Me.cognomU.Size = New System.Drawing.Size(133, 25)
        Me.cognomU.TabIndex = 2
        '
        'label_Poblacio
        '
        Me.label_Poblacio.AutoSize = True
        Me.label_Poblacio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_Poblacio.Location = New System.Drawing.Point(150, 244)
        Me.label_Poblacio.Name = "label_Poblacio"
        Me.label_Poblacio.Size = New System.Drawing.Size(61, 20)
        Me.label_Poblacio.TabIndex = 14
        Me.label_Poblacio.Text = "Població:"
        '
        'label_Provincia
        '
        Me.label_Provincia.AutoSize = True
        Me.label_Provincia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_Provincia.Location = New System.Drawing.Point(150, 197)
        Me.label_Provincia.Name = "label_Provincia"
        Me.label_Provincia.Size = New System.Drawing.Size(63, 20)
        Me.label_Provincia.TabIndex = 13
        Me.label_Provincia.Text = "Provincia:"
        '
        'label_contra
        '
        Me.label_contra.AutoSize = True
        Me.label_contra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_contra.Location = New System.Drawing.Point(150, 156)
        Me.label_contra.Name = "label_contra"
        Me.label_contra.Size = New System.Drawing.Size(81, 20)
        Me.label_contra.TabIndex = 12
        Me.label_contra.Text = "Contrasenya:"
        '
        'label_cognom
        '
        Me.label_cognom.AutoSize = True
        Me.label_cognom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_cognom.Location = New System.Drawing.Point(150, 83)
        Me.label_cognom.Name = "label_cognom"
        Me.label_cognom.Size = New System.Drawing.Size(60, 20)
        Me.label_cognom.TabIndex = 11
        Me.label_cognom.Text = "Cognom:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.NomFitxer)
        Me.TabPage2.Controls.Add(Me.cognomInf)
        Me.TabPage2.Controls.Add(Me.cognomI)
        Me.TabPage2.Controls.Add(Me.usuariInf)
        Me.TabPage2.Controls.Add(Me.userI)
        Me.TabPage2.Controls.Add(Me.dniI)
        Me.TabPage2.Controls.Add(Me.dniInf)
        Me.TabPage2.Controls.Add(Me.poblacioInf)
        Me.TabPage2.Controls.Add(Me.provincaiInf)
        Me.TabPage2.Controls.Add(Me.contrasenyaInf)
        Me.TabPage2.Controls.Add(Me.nomInf)
        Me.TabPage2.Controls.Add(Me.pobI)
        Me.TabPage2.Controls.Add(Me.provinI)
        Me.TabPage2.Controls.Add(Me.passI)
        Me.TabPage2.Controls.Add(Me.nomI)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.bt_Registrar2)
        Me.TabPage2.Controls.Add(Me.curricuI)
        Me.TabPage2.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(603, 417)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Informàtic"
        '
        'NomFitxer
        '
        Me.NomFitxer.AutoSize = True
        Me.NomFitxer.Location = New System.Drawing.Point(256, 336)
        Me.NomFitxer.Name = "NomFitxer"
        Me.NomFitxer.Size = New System.Drawing.Size(0, 20)
        Me.NomFitxer.TabIndex = 74
        '
        'cognomInf
        '
        Me.cognomInf.Location = New System.Drawing.Point(260, 82)
        Me.cognomInf.Name = "cognomInf"
        Me.cognomInf.Size = New System.Drawing.Size(133, 25)
        Me.cognomInf.TabIndex = 65
        '
        'cognomI
        '
        Me.cognomI.AutoSize = True
        Me.cognomI.Location = New System.Drawing.Point(151, 87)
        Me.cognomI.Name = "cognomI"
        Me.cognomI.Size = New System.Drawing.Size(60, 20)
        Me.cognomI.TabIndex = 72
        Me.cognomI.Text = "Cognom:"
        '
        'usuariInf
        '
        Me.usuariInf.Location = New System.Drawing.Point(260, 117)
        Me.usuariInf.Name = "usuariInf"
        Me.usuariInf.Size = New System.Drawing.Size(133, 25)
        Me.usuariInf.TabIndex = 66
        '
        'userI
        '
        Me.userI.AutoSize = True
        Me.userI.Location = New System.Drawing.Point(151, 121)
        Me.userI.Name = "userI"
        Me.userI.Size = New System.Drawing.Size(48, 20)
        Me.userI.TabIndex = 70
        Me.userI.Text = "Usuari:"
        '
        'dniI
        '
        Me.dniI.AutoSize = True
        Me.dniI.Location = New System.Drawing.Point(151, 285)
        Me.dniI.Name = "dniI"
        Me.dniI.Size = New System.Drawing.Size(33, 20)
        Me.dniI.TabIndex = 69
        Me.dniI.Text = "DNI:"
        '
        'dniInf
        '
        Me.dniInf.Location = New System.Drawing.Point(260, 280)
        Me.dniInf.MaxLength = 9
        Me.dniInf.Name = "dniInf"
        Me.dniInf.Size = New System.Drawing.Size(133, 25)
        Me.dniInf.TabIndex = 70
        '
        'poblacioInf
        '
        Me.poblacioInf.Location = New System.Drawing.Point(260, 240)
        Me.poblacioInf.Name = "poblacioInf"
        Me.poblacioInf.Size = New System.Drawing.Size(133, 25)
        Me.poblacioInf.TabIndex = 69
        '
        'provincaiInf
        '
        Me.provincaiInf.Location = New System.Drawing.Point(260, 198)
        Me.provincaiInf.Name = "provincaiInf"
        Me.provincaiInf.Size = New System.Drawing.Size(133, 25)
        Me.provincaiInf.TabIndex = 68
        '
        'contrasenyaInf
        '
        Me.contrasenyaInf.Location = New System.Drawing.Point(260, 155)
        Me.contrasenyaInf.Name = "contrasenyaInf"
        Me.contrasenyaInf.Size = New System.Drawing.Size(133, 25)
        Me.contrasenyaInf.TabIndex = 67
        Me.contrasenyaInf.UseSystemPasswordChar = True
        '
        'nomInf
        '
        Me.nomInf.Location = New System.Drawing.Point(260, 45)
        Me.nomInf.Name = "nomInf"
        Me.nomInf.Size = New System.Drawing.Size(133, 25)
        Me.nomInf.TabIndex = 64
        '
        'pobI
        '
        Me.pobI.AutoSize = True
        Me.pobI.Location = New System.Drawing.Point(151, 243)
        Me.pobI.Name = "pobI"
        Me.pobI.Size = New System.Drawing.Size(61, 20)
        Me.pobI.TabIndex = 63
        Me.pobI.Text = "Població:"
        '
        'provinI
        '
        Me.provinI.AutoSize = True
        Me.provinI.Location = New System.Drawing.Point(151, 200)
        Me.provinI.Name = "provinI"
        Me.provinI.Size = New System.Drawing.Size(63, 20)
        Me.provinI.TabIndex = 62
        Me.provinI.Text = "Província:"
        '
        'passI
        '
        Me.passI.AutoSize = True
        Me.passI.Location = New System.Drawing.Point(151, 156)
        Me.passI.Name = "passI"
        Me.passI.Size = New System.Drawing.Size(81, 20)
        Me.passI.TabIndex = 61
        Me.passI.Text = "Contrasenya:"
        '
        'nomI
        '
        Me.nomI.AutoSize = True
        Me.nomI.Location = New System.Drawing.Point(151, 50)
        Me.nomI.Name = "nomI"
        Me.nomI.Size = New System.Drawing.Size(39, 20)
        Me.nomI.TabIndex = 60
        Me.nomI.Text = "Nom:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(393, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 27)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bt_Registrar2
        '
        Me.bt_Registrar2.BackColor = System.Drawing.Color.Silver
        Me.bt_Registrar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bt_Registrar2.Location = New System.Drawing.Point(468, 377)
        Me.bt_Registrar2.Name = "bt_Registrar2"
        Me.bt_Registrar2.Size = New System.Drawing.Size(110, 32)
        Me.bt_Registrar2.TabIndex = 72
        Me.bt_Registrar2.Text = "Registrar-se"
        Me.bt_Registrar2.UseVisualStyleBackColor = False
        '
        'curricuI
        '
        Me.curricuI.AutoSize = True
        Me.curricuI.Location = New System.Drawing.Point(151, 338)
        Me.curricuI.Name = "curricuI"
        Me.curricuI.Size = New System.Drawing.Size(74, 20)
        Me.curricuI.TabIndex = 45
        Me.curricuI.Text = "Curriculum:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.Black
        Me.Menu.Controls.Add(Me.Label1_selec_idioma)
        Me.Menu.Controls.Add(Me.dioma)
        Me.Menu.Controls.Add(Me.PictureBox4)
        Me.Menu.Controls.Add(Me.darrere)
        Me.Menu.Controls.Add(Me.PictureBox1)
        Me.Menu.Controls.Add(Me.BotoMenuVertical)
        Me.Menu.Controls.Add(Me.FAQ)
        Me.Menu.Font = New System.Drawing.Font("Blackoak Std", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Location = New System.Drawing.Point(-1, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(150, 613)
        Me.Menu.TabIndex = 10
        '
        'Label1_selec_idioma
        '
        Me.Label1_selec_idioma.AutoSize = True
        Me.Label1_selec_idioma.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.Label1_selec_idioma.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1_selec_idioma.Location = New System.Drawing.Point(9, 364)
        Me.Label1_selec_idioma.Name = "Label1_selec_idioma"
        Me.Label1_selec_idioma.Size = New System.Drawing.Size(47, 20)
        Me.Label1_selec_idioma.TabIndex = 78
        Me.Label1_selec_idioma.Text = "Label1"
        '
        'dioma
        '
        Me.dioma.BackColor = System.Drawing.SystemColors.Control
        Me.dioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dioma.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.dioma.FormattingEnabled = True
        Me.dioma.Items.AddRange(New Object() {"Català", "Anglès"})
        Me.dioma.Location = New System.Drawing.Point(13, 399)
        Me.dioma.Name = "dioma"
        Me.dioma.Size = New System.Drawing.Size(121, 28)
        Me.dioma.TabIndex = 77
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Location = New System.Drawing.Point(14, 457)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.TabIndex = 76
        Me.PictureBox4.TabStop = False
        '
        'darrere
        '
        Me.darrere.AutoSize = True
        Me.darrere.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.darrere.ForeColor = System.Drawing.SystemColors.Control
        Me.darrere.Location = New System.Drawing.Point(60, 468)
        Me.darrere.Name = "darrere"
        Me.darrere.Size = New System.Drawing.Size(39, 16)
        Me.darrere.TabIndex = 75
        Me.darrere.Text = "Tornar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(14, 226)
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
        'FAQ
        '
        Me.FAQ.AutoSize = True
        Me.FAQ.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAQ.ForeColor = System.Drawing.SystemColors.Control
        Me.FAQ.Location = New System.Drawing.Point(60, 235)
        Me.FAQ.Name = "FAQ"
        Me.FAQ.Size = New System.Drawing.Size(29, 16)
        Me.FAQ.TabIndex = 5
        Me.FAQ.Text = "FAQ"
        '
        'Registrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(790, 511)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Registrarse"
        Me.Text = "Registrarse"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotoMenuVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents label_dni As Label
    Friend WithEvents DNIU As TextBox
    Friend WithEvents bt_Registrar As Button
    Friend WithEvents PoblacioU As TextBox
    Friend WithEvents provinciaU As TextBox
    Friend WithEvents ContrasenyaU As TextBox
    Friend WithEvents cognomU As TextBox
    Friend WithEvents label_Poblacio As Label
    Friend WithEvents label_Provincia As Label
    Friend WithEvents label_contra As Label
    Friend WithEvents label_cognom As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents bt_Registrar2 As Button
    Friend WithEvents curricuI As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Menu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotoMenuVertical As PictureBox
    Friend WithEvents FAQ As Label
    Friend WithEvents usuariU As TextBox
    Friend WithEvents Label1_usuario As Label
    Friend WithEvents usuariInf As TextBox
    Friend WithEvents userI As Label
    Friend WithEvents dniI As Label
    Friend WithEvents dniInf As TextBox
    Friend WithEvents poblacioInf As TextBox
    Friend WithEvents provincaiInf As TextBox
    Friend WithEvents contrasenyaInf As TextBox
    Friend WithEvents nomInf As TextBox
    Friend WithEvents pobI As Label
    Friend WithEvents provinI As Label
    Friend WithEvents passI As Label
    Friend WithEvents nomI As Label
    Friend WithEvents nomU As TextBox
    Friend WithEvents label_nom As Label
    Friend WithEvents cognomInf As TextBox
    Friend WithEvents cognomI As Label
    Friend WithEvents NomFitxer As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents darrere As Label
    Friend WithEvents Label1_selec_idioma As Label
    Friend WithEvents dioma As ComboBox
End Class
