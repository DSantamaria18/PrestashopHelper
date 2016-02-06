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
        Me.TextBoxTitles = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TextBoxDescs = New System.Windows.Forms.TextBox()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.CheckBoxFirstRow = New System.Windows.Forms.CheckBox()
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
        Me.LabelSalida.Location = New System.Drawing.Point(61, 167)
        Me.LabelSalida.Name = "LabelSalida"
        Me.LabelSalida.Size = New System.Drawing.Size(58, 13)
        Me.LabelSalida.TabIndex = 3
        Me.LabelSalida.Text = "Output Dir:"
        '
        'TextBoxSalida
        '
        Me.TextBoxSalida.Location = New System.Drawing.Point(125, 164)
        Me.TextBoxSalida.Name = "TextBoxSalida"
        Me.TextBoxSalida.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxSalida.TabIndex = 4
        '
        'ButtonSalida
        '
        Me.ButtonSalida.Location = New System.Drawing.Point(366, 162)
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
        'TextBoxTitles
        '
        Me.TextBoxTitles.Location = New System.Drawing.Point(125, 112)
        Me.TextBoxTitles.Name = "TextBoxTitles"
        Me.TextBoxTitles.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxTitles.TabIndex = 12
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(62, 115)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(57, 13)
        Me.LabelName.TabIndex = 11
        Me.LabelName.Text = "File Titles: "
        '
        'TextBoxDescs
        '
        Me.TextBoxDescs.Location = New System.Drawing.Point(125, 138)
        Me.TextBoxDescs.Name = "TextBoxDescs"
        Me.TextBoxDescs.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxDescs.TabIndex = 14
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(32, 141)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(87, 13)
        Me.LabelDescription.TabIndex = 13
        Me.LabelDescription.Text = "File Descriptions:"
        '
        'CheckBoxFirstRow
        '
        Me.CheckBoxFirstRow.AutoSize = True
        Me.CheckBoxFirstRow.Location = New System.Drawing.Point(125, 91)
        Me.CheckBoxFirstRow.Name = "CheckBoxFirstRow"
        Me.CheckBoxFirstRow.Size = New System.Drawing.Size(179, 17)
        Me.CheckBoxFirstRow.TabIndex = 15
        Me.CheckBoxFirstRow.Text = "First row contains column names"
        Me.CheckBoxFirstRow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 201)
        Me.Controls.Add(Me.CheckBoxFirstRow)
        Me.Controls.Add(Me.TextBoxDescs)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.TextBoxTitles)
        Me.Controls.Add(Me.LabelName)
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
    Friend WithEvents TextBoxTitles As System.Windows.Forms.TextBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescs As System.Windows.Forms.TextBox
    Friend WithEvents LabelDescription As System.Windows.Forms.Label
    Friend WithEvents CheckBoxFirstRow As System.Windows.Forms.CheckBox

End Class
