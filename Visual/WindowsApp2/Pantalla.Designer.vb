<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pantalla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla))
        Me.bt_Registrar = New System.Windows.Forms.Button()
        Me.bt_iniciar = New System.Windows.Forms.Button()
        Me.Contrasenya = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.label_contra = New System.Windows.Forms.Label()
        Me.Label1_usuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.Label1_selec_idioma = New System.Windows.Forms.Label()
        Me.dioma = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BotoMenuVertical = New System.Windows.Forms.PictureBox()
        Me.FAQ = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotoMenuVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_Registrar
        '
        Me.bt_Registrar.BackColor = System.Drawing.Color.Silver
        Me.bt_Registrar.Location = New System.Drawing.Point(142, 280)
        Me.bt_Registrar.Name = "bt_Registrar"
        Me.bt_Registrar.Size = New System.Drawing.Size(90, 35)
        Me.bt_Registrar.TabIndex = 0
        Me.bt_Registrar.Text = "Registrar-se"
        Me.bt_Registrar.UseVisualStyleBackColor = False
        '
        'bt_iniciar
        '
        Me.bt_iniciar.BackColor = System.Drawing.Color.Silver
        Me.bt_iniciar.Location = New System.Drawing.Point(142, 219)
        Me.bt_iniciar.Name = "bt_iniciar"
        Me.bt_iniciar.Size = New System.Drawing.Size(90, 37)
        Me.bt_iniciar.TabIndex = 2
        Me.bt_iniciar.Text = "Iniciar"
        Me.bt_iniciar.UseVisualStyleBackColor = False
        '
        'Contrasenya
        '
        Me.Contrasenya.Location = New System.Drawing.Point(127, 125)
        Me.Contrasenya.Name = "Contrasenya"
        Me.Contrasenya.Size = New System.Drawing.Size(133, 25)
        Me.Contrasenya.TabIndex = 27
        Me.Contrasenya.Text = "123"
        Me.Contrasenya.UseSystemPasswordChar = True
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(127, 61)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(133, 25)
        Me.user.TabIndex = 26
        Me.user.Text = "info1"
        '
        'label_contra
        '
        Me.label_contra.AutoSize = True
        Me.label_contra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_contra.Location = New System.Drawing.Point(12, 128)
        Me.label_contra.Name = "label_contra"
        Me.label_contra.Size = New System.Drawing.Size(81, 20)
        Me.label_contra.TabIndex = 23
        Me.label_contra.Text = "Contrasenya:"
        '
        'Label1_usuario
        '
        Me.Label1_usuario.AutoSize = True
        Me.Label1_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1_usuario.Location = New System.Drawing.Point(15, 64)
        Me.Label1_usuario.Name = "Label1_usuario"
        Me.Label1_usuario.Size = New System.Drawing.Size(48, 20)
        Me.Label1_usuario.TabIndex = 22
        Me.Label1_usuario.Text = "Usuari:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.bt_Registrar)
        Me.Panel1.Controls.Add(Me.Contrasenya)
        Me.Panel1.Controls.Add(Me.bt_iniciar)
        Me.Panel1.Controls.Add(Me.user)
        Me.Panel1.Controls.Add(Me.Label1_usuario)
        Me.Panel1.Controls.Add(Me.label_contra)
        Me.Panel1.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.Panel1.Location = New System.Drawing.Point(164, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 368)
        Me.Panel1.TabIndex = 28
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.Black
        Me.Menu.Controls.Add(Me.Label1_selec_idioma)
        Me.Menu.Controls.Add(Me.dioma)
        Me.Menu.Controls.Add(Me.PictureBox1)
        Me.Menu.Controls.Add(Me.BotoMenuVertical)
        Me.Menu.Controls.Add(Me.FAQ)
        Me.Menu.Font = New System.Drawing.Font("Blackoak Std", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Location = New System.Drawing.Point(0, 1)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(150, 505)
        Me.Menu.TabIndex = 29
        '
        'Label1_selec_idioma
        '
        Me.Label1_selec_idioma.AutoSize = True
        Me.Label1_selec_idioma.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.Label1_selec_idioma.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1_selec_idioma.Location = New System.Drawing.Point(12, 382)
        Me.Label1_selec_idioma.Name = "Label1_selec_idioma"
        Me.Label1_selec_idioma.Size = New System.Drawing.Size(47, 20)
        Me.Label1_selec_idioma.TabIndex = 32
        Me.Label1_selec_idioma.Text = "Label1"
        '
        'dioma
        '
        Me.dioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dioma.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.dioma.FormattingEnabled = True
        Me.dioma.Items.AddRange(New Object() {"Català", "Anglès"})
        Me.dioma.Location = New System.Drawing.Point(11, 416)
        Me.dioma.Name = "dioma"
        Me.dioma.Size = New System.Drawing.Size(121, 28)
        Me.dioma.TabIndex = 31
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
        'Pantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 503)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Pantalla"
        Me.Text = "INICIAR SESSIÓ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotoMenuVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bt_Registrar As Button
    Friend WithEvents bt_iniciar As Button
    Friend WithEvents Contrasenya As TextBox
    Friend WithEvents user As TextBox
    Friend WithEvents label_contra As Label
    Friend WithEvents Label1_usuario As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Menu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotoMenuVertical As PictureBox
    Friend WithEvents FAQ As Label
    Friend WithEvents dioma As ComboBox
    Friend WithEvents Label1_selec_idioma As Label
End Class
