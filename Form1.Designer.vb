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
        Me.SuspendLayout()
        '
        'ButtonRutaAdjuntos
        '
        Me.ButtonRutaAdjuntos.Location = New System.Drawing.Point(336, 37)
        Me.ButtonRutaAdjuntos.Name = "ButtonRutaAdjuntos"
        Me.ButtonRutaAdjuntos.Size = New System.Drawing.Size(24, 23)
        Me.ButtonRutaAdjuntos.TabIndex = 0
        Me.ButtonRutaAdjuntos.Text = "..."
        Me.ButtonRutaAdjuntos.UseVisualStyleBackColor = True
        '
        'LabelRutaAdjuntos
        '
        Me.LabelRutaAdjuntos.AutoSize = True
        Me.LabelRutaAdjuntos.Location = New System.Drawing.Point(12, 42)
        Me.LabelRutaAdjuntos.Name = "LabelRutaAdjuntos"
        Me.LabelRutaAdjuntos.Size = New System.Drawing.Size(77, 13)
        Me.LabelRutaAdjuntos.TabIndex = 1
        Me.LabelRutaAdjuntos.Text = "Ruta Adjuntos:"
        '
        'TextBoxRutaAdjuntos
        '
        Me.TextBoxRutaAdjuntos.Location = New System.Drawing.Point(95, 39)
        Me.TextBoxRutaAdjuntos.Name = "TextBoxRutaAdjuntos"
        Me.TextBoxRutaAdjuntos.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxRutaAdjuntos.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 262)
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

End Class
