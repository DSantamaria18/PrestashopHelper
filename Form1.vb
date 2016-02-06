Public Class Form1

    Private Sub ButtonRutaAdjuntos_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRutaAdjuntos.Click
        Try
            ' Configuración del FolderBrowserDialog  
            With FolderBrowserDialogRutaAdjuntos
                .Reset() ' resetea  
                ' leyenda  
                .Description = " Selecciona la carpeta con los adjuntos "
                ' Path por defecto: Escritorio "  
                .SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                .RootFolder = Environment.SpecialFolder.Desktop
                ' deshabilita el botón " crear nueva carpeta "  
                .ShowNewFolderButton = False
                Dim ret As DialogResult = .ShowDialog ' abre el diálogo  
                If ret = Windows.Forms.DialogResult.OK Then
                    TextBoxRutaAdjuntos.Text = .SelectedPath
                End If
                .Dispose()
            End With
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonSalida_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSalida.Click
        Try
            ' Configuración del FolderBrowserDialog  
            With FolderBrowserDialogRutaAdjuntos
                .Reset() ' resetea  
                ' leyenda  
                .Description = " Selecciona la carpeta con los adjuntos "
                ' Path por defecto: Escritorio "  
                .SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                .RootFolder = Environment.SpecialFolder.Desktop
                ' deshabilita el botón " crear nueva carpeta "  
                .ShowNewFolderButton = False
                Dim ret As DialogResult = .ShowDialog ' abre el diálogo  
                If ret = Windows.Forms.DialogResult.OK Then
                    TextBoxSalida.Text = .SelectedPath
                End If
                .Dispose()
            End With
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
