<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resgistre
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Usuari = New System.Windows.Forms.Button()
        Me.Informatic = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuari"
        '
        'Usuari
        '
        Me.Usuari.Location = New System.Drawing.Point(209, 113)
        Me.Usuari.Name = "Usuari"
        Me.Usuari.Size = New System.Drawing.Size(92, 23)
        Me.Usuari.TabIndex = 1
        Me.Usuari.Text = "Usuari"
        Me.Usuari.UseVisualStyleBackColor = True
        '
        'Informatic
        '
        Me.Informatic.Location = New System.Drawing.Point(209, 293)
        Me.Informatic.Name = "Informatic"
        Me.Informatic.Size = New System.Drawing.Size(92, 23)
        Me.Informatic.TabIndex = 2
        Me.Informatic.Text = "Informatic"
        Me.Informatic.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Informatic"
        '
        'Resgistre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Informatic)
        Me.Controls.Add(Me.Usuari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Resgistre"
        Me.Text = "Usuari o Informatic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Usuari As Button
    Friend WithEvents Informatic As Button
    Friend WithEvents Label2 As Label
End Class
