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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Boton = New System.Windows.Forms.Button()
        Me.LblPromedio = New System.Windows.Forms.Label()
        Me.NumerosCargados = New System.Windows.Forms.ListBox()
        Me.LblFin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(238, 22)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(110, 23)
        Me.Boton.TabIndex = 2
        Me.Boton.Text = "Cargar numeros"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'LblPromedio
        '
        Me.LblPromedio.AutoSize = True
        Me.LblPromedio.Location = New System.Drawing.Point(235, 377)
        Me.LblPromedio.Name = "LblPromedio"
        Me.LblPromedio.Size = New System.Drawing.Size(39, 13)
        Me.LblPromedio.TabIndex = 3
        Me.LblPromedio.Text = "Label1"
        '
        'NumerosCargados
        '
        Me.NumerosCargados.FormattingEnabled = True
        Me.NumerosCargados.Location = New System.Drawing.Point(92, 22)
        Me.NumerosCargados.Name = "NumerosCargados"
        Me.NumerosCargados.Size = New System.Drawing.Size(120, 368)
        Me.NumerosCargados.TabIndex = 4
        '
        'LblFin
        '
        Me.LblFin.AutoSize = True
        Me.LblFin.Location = New System.Drawing.Point(235, 353)
        Me.LblFin.Name = "LblFin"
        Me.LblFin.Size = New System.Drawing.Size(39, 13)
        Me.LblFin.TabIndex = 5
        Me.LblFin.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblFin)
        Me.Controls.Add(Me.NumerosCargados)
        Me.Controls.Add(Me.LblPromedio)
        Me.Controls.Add(Me.Boton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Boton As Button
    Friend WithEvents LblPromedio As Label
    Friend WithEvents NumerosCargados As ListBox
    Friend WithEvents LblFin As Label
End Class
