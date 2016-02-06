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
                .Description = " Selecciona la carpeta de salida "
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

    Private Sub ButtonProductos_Click(sender As System.Object, e As System.EventArgs) Handles ButtonProductos.Click
        Try
            ' Configuración del FolderBrowserDialog  
            With OpenFileDialog1
                .Reset() ' resetea  
                ' Path por defecto: Escritorio "  
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                ' deshabilita el botón " crear nueva carpeta "  
                Dim ret As DialogResult = .ShowDialog ' abre el diálogo  
                If ret = Windows.Forms.DialogResult.OK Then
                    TextBoxProductos.Text = .FileName
                End If
                .Dispose()
            End With
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonSalir_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSalir.Click
        Me.Close()

    End Sub

    Private Sub ButtonProcesar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonProcesar.Click
        Dim attFolder As New System.IO.DirectoryInfo(TextBoxRutaAdjuntos.Text)
        Dim outDir As String = TextBoxSalida.Text
        Dim 
        If Not System.IO.Directory.Exists(outDir) Then
            System.IO.Directory.CreateDirectory(outDir)
        End If
    End Sub

    Private Sub LabelSalida_Click(sender As System.Object, e As System.EventArgs) Handles LabelSalida.Click

    End Sub
End Class
