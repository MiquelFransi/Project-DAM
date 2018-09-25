<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuari
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
        Me.Nom = New System.Windows.Forms.Label()
        Me.Contrasenya = New System.Windows.Forms.Label()
        Me.Correu = New System.Windows.Forms.Label()
        Me.Localitzacio = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Registre = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DNI = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.Location = New System.Drawing.Point(71, 83)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(32, 13)
        Me.Nom.TabIndex = 0
        Me.Nom.Text = "Nom:"
        '
        'Contrasenya
        '
        Me.Contrasenya.AutoSize = True
        Me.Contrasenya.Location = New System.Drawing.Point(71, 158)
        Me.Contrasenya.Name = "Contrasenya"
        Me.Contrasenya.Size = New System.Drawing.Size(69, 13)
        Me.Contrasenya.TabIndex = 1
        Me.Contrasenya.Text = "Contrasenya:"
        '
        'Correu
        '
        Me.Correu.AutoSize = True
        Me.Correu.Location = New System.Drawing.Point(74, 235)
        Me.Correu.Name = "Correu"
        Me.Correu.Size = New System.Drawing.Size(51, 13)
        Me.Correu.TabIndex = 2
        Me.Correu.Text = "Provincia"
        '
        'Localitzacio
        '
        Me.Localitzacio.AutoSize = True
        Me.Localitzacio.Location = New System.Drawing.Point(71, 303)
        Me.Localitzacio.Name = "Localitzacio"
        Me.Localitzacio.Size = New System.Drawing.Size(48, 13)
        Me.Localitzacio.TabIndex = 3
        Me.Localitzacio.Text = "Població"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(186, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(186, 158)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(186, 232)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(186, 303)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Registre
        '
        Me.Registre.Location = New System.Drawing.Point(197, 407)
        Me.Registre.Name = "Registre"
        Me.Registre.Size = New System.Drawing.Size(111, 23)
        Me.Registre.TabIndex = 8
        Me.Registre.Text = "Registrar-se"
        Me.Registre.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(186, 366)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(133, 20)
        Me.TextBox5.TabIndex = 9
        '
        'DNI
        '
        Me.DNI.AutoSize = True
        Me.DNI.Location = New System.Drawing.Point(77, 372)
        Me.DNI.Name = "DNI"
        Me.DNI.Size = New System.Drawing.Size(29, 13)
        Me.DNI.TabIndex = 10
        Me.DNI.Text = "DNI:"
        '
        'Usuari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 486)
        Me.Controls.Add(Me.DNI)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Registre)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Localitzacio)
        Me.Controls.Add(Me.Correu)
        Me.Controls.Add(Me.Contrasenya)
        Me.Controls.Add(Me.Nom)
        Me.Name = "Usuari"
        Me.Text = "Usuari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nom As Label
    Friend WithEvents Contrasenya As Label
    Friend WithEvents Correu As Label
    Friend WithEvents Localitzacio As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Registre As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DNI As Label
End Class
