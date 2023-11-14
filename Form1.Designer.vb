<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.textBoxUsuario = New System.Windows.Forms.TextBox()
        Me.textBoxContraseña = New System.Windows.Forms.TextBox()
        Me.buttonIniciarSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBoxUsuario
        '
        Me.textBoxUsuario.Location = New System.Drawing.Point(51, 79)
        Me.textBoxUsuario.Name = "textBoxUsuario"
        Me.textBoxUsuario.Size = New System.Drawing.Size(381, 22)
        Me.textBoxUsuario.TabIndex = 0
        '
        'textBoxContraseña
        '
        Me.textBoxContraseña.Location = New System.Drawing.Point(51, 161)
        Me.textBoxContraseña.Name = "textBoxContraseña"
        Me.textBoxContraseña.Size = New System.Drawing.Size(381, 22)
        Me.textBoxContraseña.TabIndex = 1
        '
        'buttonIniciarSesion
        '
        Me.buttonIniciarSesion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.buttonIniciarSesion.Location = New System.Drawing.Point(144, 311)
        Me.buttonIniciarSesion.Name = "buttonIniciarSesion"
        Me.buttonIniciarSesion.Size = New System.Drawing.Size(151, 48)
        Me.buttonIniciarSesion.TabIndex = 2
        Me.buttonIniciarSesion.Text = "Iniciar sesion"
        Me.buttonIniciarSesion.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.buttonIniciarSesion)
        Me.Controls.Add(Me.textBoxContraseña)
        Me.Controls.Add(Me.textBoxUsuario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBoxUsuario As TextBox
    Friend WithEvents textBoxContraseña As TextBox
    Friend WithEvents buttonIniciarSesion As Button
End Class
