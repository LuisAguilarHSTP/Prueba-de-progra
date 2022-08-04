<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColores
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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAnaranjado = New System.Windows.Forms.Button()
        Me.btnRosado = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.Red
        Me.btnRojo.Location = New System.Drawing.Point(66, 42)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 23)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'btnAzul
        '
        Me.btnAzul.BackColor = System.Drawing.Color.Cyan
        Me.btnAzul.Location = New System.Drawing.Point(66, 94)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(75, 23)
        Me.btnAzul.TabIndex = 1
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = False
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.LawnGreen
        Me.btnVerde.Location = New System.Drawing.Point(66, 147)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(75, 23)
        Me.btnVerde.TabIndex = 2
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'btnAnaranjado
        '
        Me.btnAnaranjado.BackColor = System.Drawing.Color.Orange
        Me.btnAnaranjado.Location = New System.Drawing.Point(66, 206)
        Me.btnAnaranjado.Name = "btnAnaranjado"
        Me.btnAnaranjado.Size = New System.Drawing.Size(75, 23)
        Me.btnAnaranjado.TabIndex = 3
        Me.btnAnaranjado.Text = "Anaranjado"
        Me.btnAnaranjado.UseVisualStyleBackColor = False
        '
        'btnRosado
        '
        Me.btnRosado.BackColor = System.Drawing.Color.Pink
        Me.btnRosado.Location = New System.Drawing.Point(66, 266)
        Me.btnRosado.Name = "btnRosado"
        Me.btnRosado.Size = New System.Drawing.Size(75, 23)
        Me.btnRosado.TabIndex = 4
        Me.btnRosado.Text = "Rosado"
        Me.btnRosado.UseVisualStyleBackColor = False
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(346, 42)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(381, 247)
        Me.txtColores.TabIndex = 5
        '
        'FrmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(800, 347)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnRosado)
        Me.Controls.Add(Me.btnAnaranjado)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnRojo)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Name = "FrmColores"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents btnAzul As Button
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnAnaranjado As Button
    Friend WithEvents btnRosado As Button
    Friend WithEvents txtColores As TextBox
End Class
