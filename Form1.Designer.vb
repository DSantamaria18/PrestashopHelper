<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonRutaAdjuntos = New System.Windows.Forms.Button()
        Me.LabelRutaAdjuntos = New System.Windows.Forms.Label()
        Me.TextBoxRutaAdjuntos = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialogRutaAdjuntos = New System.Windows.Forms.FolderBrowserDialog()
        Me.LabelSalida = New System.Windows.Forms.Label()
        Me.TextBoxSalida = New System.Windows.Forms.TextBox()
        Me.ButtonSalida = New System.Windows.Forms.Button()
        Me.TextBoxProductos = New System.Windows.Forms.TextBox()
        Me.LabelFicheroProductos = New System.Windows.Forms.Label()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonProcesar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonRutaAdjuntos
        '
        Me.ButtonRutaAdjuntos.Location = New System.Drawing.Point(366, 36)
        Me.ButtonRutaAdjuntos.Name = "ButtonRutaAdjuntos"
        Me.ButtonRutaAdjuntos.Size = New System.Drawing.Size(24, 23)
        Me.ButtonRutaAdjuntos.TabIndex = 0
        Me.ButtonRutaAdjuntos.Text = "..."
        Me.ButtonRutaAdjuntos.UseVisualStyleBackColor = True
        '
        'LabelRutaAdjuntos
        '
        Me.LabelRutaAdjuntos.AutoSize = True
        Me.LabelRutaAdjuntos.Location = New System.Drawing.Point(50, 41)
        Me.LabelRutaAdjuntos.Name = "LabelRutaAdjuntos"
        Me.LabelRutaAdjuntos.Size = New System.Drawing.Size(69, 13)
        Me.LabelRutaAdjuntos.TabIndex = 1
        Me.LabelRutaAdjuntos.Text = "Attachments:"
        '
        'TextBoxRutaAdjuntos
        '
        Me.TextBoxRutaAdjuntos.Location = New System.Drawing.Point(125, 39)
        Me.TextBoxRutaAdjuntos.Name = "TextBoxRutaAdjuntos"
        Me.TextBoxRutaAdjuntos.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxRutaAdjuntos.TabIndex = 2
        '
        'LabelSalida
        '
        Me.LabelSalida.AutoSize = True
        Me.LabelSalida.Location = New System.Drawing.Point(61, 141)
        Me.LabelSalida.Name = "LabelSalida"
        Me.LabelSalida.Size = New System.Drawing.Size(58, 13)
        Me.LabelSalida.TabIndex = 3
        Me.LabelSalida.Text = "Output Dir:"
        '
        'TextBoxSalida
        '
        Me.TextBoxSalida.Location = New System.Drawing.Point(125, 138)
        Me.TextBoxSalida.Name = "TextBoxSalida"
        Me.TextBoxSalida.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxSalida.TabIndex = 4
        '
        'ButtonSalida
        '
        Me.ButtonSalida.Location = New System.Drawing.Point(366, 136)
        Me.ButtonSalida.Name = "ButtonSalida"
        Me.ButtonSalida.Size = New System.Drawing.Size(24, 23)
        Me.ButtonSalida.TabIndex = 5
        Me.ButtonSalida.Text = "..."
        Me.ButtonSalida.UseVisualStyleBackColor = True
        '
        'TextBoxProductos
        '
        Me.TextBoxProductos.Location = New System.Drawing.Point(125, 65)
        Me.TextBoxProductos.Name = "TextBoxProductos"
        Me.TextBoxProductos.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxProductos.TabIndex = 8
        '
        'LabelFicheroProductos
        '
        Me.LabelFicheroProductos.AutoSize = True
        Me.LabelFicheroProductos.Location = New System.Drawing.Point(24, 68)
        Me.LabelFicheroProductos.Name = "LabelFicheroProductos"
        Me.LabelFicheroProductos.Size = New System.Drawing.Size(95, 13)
        Me.LabelFicheroProductos.TabIndex = 7
        Me.LabelFicheroProductos.Text = "Products CSV File:"
        '
        'ButtonProductos
        '
        Me.ButtonProductos.Location = New System.Drawing.Point(366, 63)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(24, 23)
        Me.ButtonProductos.TabIndex = 6
        Me.ButtonProductos.Text = "..."
        Me.ButtonProductos.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Productod.csv"
        '
        'ButtonProcesar
        '
        Me.ButtonProcesar.Location = New System.Drawing.Point(457, 26)
        Me.ButtonProcesar.Name = "ButtonProcesar"
        Me.ButtonProcesar.Size = New System.Drawing.Size(75, 69)
        Me.ButtonProcesar.TabIndex = 9
        Me.ButtonProcesar.Text = "Generate"
        Me.ButtonProcesar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(457, 113)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 69)
        Me.ButtonSalir.TabIndex = 10
        Me.ButtonSalir.Text = "Exit"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 195)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonProcesar)
        Me.Controls.Add(Me.TextBoxProductos)
        Me.Controls.Add(Me.LabelFicheroProductos)
        Me.Controls.Add(Me.ButtonProductos)
        Me.Controls.Add(Me.ButtonSalida)
        Me.Controls.Add(Me.TextBoxSalida)
        Me.Controls.Add(Me.LabelSalida)
        Me.Controls.Add(Me.TextBoxRutaAdjuntos)
        Me.Controls.Add(Me.LabelRutaAdjuntos)
        Me.Controls.Add(Me.ButtonRutaAdjuntos)
        Me.Name = "Form1"
        Me.Text = "Prestashop Helper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonRutaAdjuntos As System.Windows.Forms.Button
    Friend WithEvents LabelRutaAdjuntos As System.Windows.Forms.Label
    Friend WithEvents TextBoxRutaAdjuntos As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialogRutaAdjuntos As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LabelSalida As System.Windows.Forms.Label
    Friend WithEvents TextBoxSalida As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSalida As System.Windows.Forms.Button
    Friend WithEvents TextBoxProductos As System.Windows.Forms.TextBox
    Friend WithEvents LabelFicheroProductos As System.Windows.Forms.Label
    Friend WithEvents ButtonProductos As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonProcesar As System.Windows.Forms.Button
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button

End Class
