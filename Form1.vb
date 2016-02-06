Imports System.IO

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
        Me.Enabled = False
        If TextBoxSalida.Text.Length > 0 Then
            Dim outDir As String = TextBoxSalida.Text
            'If outdir doesn't exist, we'll create it
            If Not Directory.Exists(outDir) Then
                Directory.CreateDirectory(outDir)
            End If
        Else
            Dim outDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        End If

        If Not Directory.Exists(TextBoxRutaAdjuntos.Text) Then
            MsgBox("Attachments folder not found", MsgBoxStyle.Critical)
        Else
            Dim attFolder As New DirectoryInfo(TextBoxRutaAdjuntos.Text)
            Dim prodsFile As String = TextBoxProductos.Text
            Dim title As String = TextBoxTitles.Text.ToUpper    'FS-0000155.PDF'
            Dim desc As String = TextBoxDescs.Text              'Ficha Técnica

            If prodsFile.Length > 0 And title.Length > 0 And desc.Length > 0 Then
                'PROCESS
                generaFicheros()
            Else
                MsgBox("Fill in the fields, please...", MsgBoxStyle.Critical)
            End If
        End If
        Me.Enabled = True
    End Sub

    Private Sub generaFicheros(prodsFile As String)
        Dim prods As String() = File.ReadAllLines(prodsFile) ' Read product's file
        Dim psAtt As New List(Of String)  ' ps_attachment.csv Output file
        Dim psAttLang As New List(Of String) ' ps_attachment_lang.csv file
        Dim psProdAtt As New List(Of String) ' ps_product_attachment.csv file
        Dim current As String()

        For Each _p As String In prods
            current = _p.Split(";")

        Next

    End Sub

    Private Function buscaFT(codigo1, codigo2, rutaFicheros, dirSalida) As String
        Dim res As String = "NULL"
        Dim _dirFiles As New System.IO.DirectoryInfo(rutaFicheros + "\FICHAS\TECNICAS\")
        Dim dirRes = dirSalida + "\FT\"
        If Not Directory.Exists(dirRes) Then
            Directory.CreateDirectory(dirRes)
        End If

        Dim _f As Boolean = False   'Variable para saber si hemos encontrado un fichero
        For Each _file As FileInfo In _dirFiles.GetFiles("*.*", SearchOption.AllDirectories)
            Dim nombreFichero As String() = _file.Name.Split("-")
            For Each cadena As String In nombreFichero
                If cadena.Contains(codigo1) Then
                    _f = True
                    Exit For
                ElseIf cadena.Contains(codigo2) Then
                    _f = True
                    Exit For
                End If
            Next
            If _f Then
                res = "../DOWNLOAD/FT/FT-" + codigo1 + _file.Extension
                File.Copy(_file.FullName, dirRes + "FT-" + codigo1 + _file.Extension, True)
                Exit For
            End If
        Next
        Return res
    End Function

    Private Function buscaFS(codigo1, codigo2, rutaFicheros, dirSalida) As String
        Dim res As String = "NULL"
        Dim _dirFiles As New System.IO.DirectoryInfo(rutaFicheros + "\FICHAS\SEGURIDAD\")
        Dim dirRes = dirSalida + "\FS\"
        If Not Directory.Exists(dirRes) Then
            Directory.CreateDirectory(dirRes)
        End If

        Dim _f As Boolean = False   'Variable para saber si hemos encontrado un fichero
        For Each _file As FileInfo In _dirFiles.GetFiles("*.*", SearchOption.AllDirectories)
            Dim nombreFichero As String() = _file.Name.Split("-")
            For Each cadena As String In nombreFichero
                If cadena.Contains(codigo1) Then
                    _f = True
                    Exit For
                ElseIf cadena.Contains(codigo2) Then
                    _f = True
                    Exit For
                End If
            Next
            If _f Then
                res = "../DOWNLOAD/FS/FS-" + codigo1 + _file.Extension
                File.Copy(_file.FullName, dirRes + "FS-" + codigo1 + _file.Extension, True)
                Exit For
            End If
        Next
        Return res
    End Function
End Class
