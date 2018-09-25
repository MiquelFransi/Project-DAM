<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacte
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
        Me.Cognom = New System.Windows.Forms.Label()
        Me.Correu = New System.Windows.Forms.Label()
        Me.Missatge = New System.Windows.Forms.Label()
        Me.Enviar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.Location = New System.Drawing.Point(90, 69)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(36, 13)
        Me.Nom.TabIndex = 0
        Me.Nom.Text = "Nom*:"
        '
        'Cognom
        '
        Me.Cognom.AutoSize = True
        Me.Cognom.Location = New System.Drawing.Point(90, 127)
        Me.Cognom.Name = "Cognom"
        Me.Cognom.Size = New System.Drawing.Size(53, 13)
        Me.Cognom.TabIndex = 1
        Me.Cognom.Text = "Cognom*:"
        '
        'Correu
        '
        Me.Correu.AutoSize = True
        Me.Correu.Location = New System.Drawing.Point(90, 181)
        Me.Correu.Name = "Correu"
        Me.Correu.Size = New System.Drawing.Size(45, 13)
        Me.Correu.TabIndex = 2
        Me.Correu.Text = "Correu*:"
        '
        'Missatge
        '
        Me.Missatge.AutoSize = True
        Me.Missatge.Location = New System.Drawing.Point(87, 234)
        Me.Missatge.Name = "Missatge"
        Me.Missatge.Size = New System.Drawing.Size(56, 13)
        Me.Missatge.TabIndex = 3
        Me.Missatge.Text = "Missatge*:"
        '
        'Enviar
        '
        Me.Enviar.Location = New System.Drawing.Point(321, 372)
        Me.Enviar.Name = "Enviar"
        Me.Enviar.Size = New System.Drawing.Size(89, 31)
        Me.Enviar.TabIndex = 4
        Me.Enviar.Text = "Enviar"
        Me.Enviar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 124)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(159, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(183, 181)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(159, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(183, 226)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(367, 107)
        Me.TextBox4.TabIndex = 8
        '
        'Contacte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Enviar)
        Me.Controls.Add(Me.Missatge)
        Me.Controls.Add(Me.Correu)
        Me.Controls.Add(Me.Cognom)
        Me.Controls.Add(Me.Nom)
        Me.Name = "Contacte"
        Me.Text = "Contacte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nom As Label
    Friend WithEvents Cognom As Label
    Friend WithEvents Correu As Label
    Friend WithEvents Missatge As Label
    Friend WithEvents Enviar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
