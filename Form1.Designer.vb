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
        Me.Tabla1 = New System.Windows.Forms.DataGridView()
        Me.Tabla2 = New System.Windows.Forms.DataGridView()
        Me.cmdBoton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabla1
        '
        Me.Tabla1.AllowUserToAddRows = False
        Me.Tabla1.AllowUserToDeleteRows = False
        Me.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla1.ColumnHeadersVisible = False
        Me.Tabla1.Location = New System.Drawing.Point(63, 94)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.RowHeadersVisible = False
        Me.Tabla1.RowHeadersWidth = 82
        Me.Tabla1.RowTemplate.Height = 33
        Me.Tabla1.Size = New System.Drawing.Size(660, 80)
        Me.Tabla1.TabIndex = 0
        '
        'Tabla2
        '
        Me.Tabla2.AllowUserToAddRows = False
        Me.Tabla2.AllowUserToDeleteRows = False
        Me.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla2.ColumnHeadersVisible = False
        Me.Tabla2.Location = New System.Drawing.Point(72, 315)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.ReadOnly = True
        Me.Tabla2.RowHeadersVisible = False
        Me.Tabla2.RowHeadersWidth = 82
        Me.Tabla2.RowTemplate.Height = 33
        Me.Tabla2.Size = New System.Drawing.Size(651, 83)
        Me.Tabla2.TabIndex = 1
        '
        'cmdBoton
        '
        Me.cmdBoton.Location = New System.Drawing.Point(788, 164)
        Me.cmdBoton.Name = "cmdBoton"
        Me.cmdBoton.Size = New System.Drawing.Size(240, 176)
        Me.cmdBoton.TabIndex = 2
        Me.cmdBoton.Text = "Ejecutar"
        Me.cmdBoton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese su vector "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nuevo vector:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 734)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdBoton)
        Me.Controls.Add(Me.Tabla2)
        Me.Controls.Add(Me.Tabla1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabla1 As DataGridView
    Friend WithEvents Tabla2 As DataGridView
    Friend WithEvents cmdBoton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
