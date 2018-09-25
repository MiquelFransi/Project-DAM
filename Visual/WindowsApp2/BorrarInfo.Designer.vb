<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrarInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrarInfo))
        Me.label_baixa = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.darrere = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_baixa
        '
        Me.label_baixa.BackColor = System.Drawing.Color.Silver
        Me.label_baixa.Location = New System.Drawing.Point(158, 161)
        Me.label_baixa.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.label_baixa.Name = "label_baixa"
        Me.label_baixa.Size = New System.Drawing.Size(118, 46)
        Me.label_baixa.TabIndex = 0
        Me.label_baixa.Text = "Donar-se de baixa"
        Me.label_baixa.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.TabIndex = 78
        Me.PictureBox4.TabStop = False
        '
        'darrere
        '
        Me.darrere.AutoSize = True
        Me.darrere.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.darrere.ForeColor = System.Drawing.SystemColors.Control
        Me.darrere.Location = New System.Drawing.Point(58, 23)
        Me.darrere.Name = "darrere"
        Me.darrere.Size = New System.Drawing.Size(39, 16)
        Me.darrere.TabIndex = 77
        Me.darrere.Text = "Tornar"
        '
        'BorrarInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(448, 390)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.darrere)
        Me.Controls.Add(Me.label_baixa)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "BorrarInfo"
        Me.Text = "BORRAR INFORMÀTIC"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_baixa As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents darrere As Label
End Class
