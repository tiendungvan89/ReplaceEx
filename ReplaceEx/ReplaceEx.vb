Imports System.IO
Imports System.Text
Imports DiffPlex
Imports DiffPlex.DiffBuilder
Public Class ReplaceEx

#Region "Private Field"
    Private fileList As List(Of String)
    Private srcDstList As List(Of SrcDst)
#End Region

#Region "Event"
    Private Sub ReplaceEx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvScript.AllowUserToResizeColumns = True
    End Sub

    Private Sub btnSrcPath_Click(sender As Object, e As EventArgs) Handles btnSrcPath.Click
        Dim wFolderBrowserDlg As New FolderBrowserDialog()
        Dim wPattern As String = "*"

        wFolderBrowserDlg.ShowNewFolderButton = False
        wFolderBrowserDlg.Description = "Select source's folder to replace"
        If wFolderBrowserDlg.ShowDialog(Me) <> DialogResult.OK Then
            Return
        End If

        txtSrcPath.Text = wFolderBrowserDlg.SelectedPath

        Dim folderInfo As New DirectoryInfo(txtSrcPath.Text)
        If Not folderInfo.Exists() Then
            Return
        End If

        If Not String.IsNullOrWhiteSpace(txtFileExt.Text) Then
            wPattern = txtFileExt.Text.Trim()
        End If
        fileList = folderInfo.GetFiles(wPattern, SearchOption.AllDirectories).Select(Function(d) d.FullName).ToList()
    End Sub

    Private Sub txtSrcPath_Leave(sender As Object, e As EventArgs) Handles txtSrcPath.Leave
        Dim wPattern As String = "*"
        Dim folderInfo As New DirectoryInfo(txtSrcPath.Text)

        If String.IsNullOrWhiteSpace(txtSrcPath.Text) Then
            txtSrcPath.Focus()
            Return
        End If

        If Not folderInfo.Exists() Then
            txtSrcPath.Focus()
            Return
        End If

        If Not String.IsNullOrWhiteSpace(txtFileExt.Text) Then
            wPattern = txtFileExt.Text.Trim()
        End If
        fileList = folderInfo.GetFiles(wPattern, SearchOption.AllDirectories).Select(Function(d) d.FullName).ToList()
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Me.Replace()
    End Sub

    Private Sub OnProcessKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, dgvScript.KeyDown
        If e.KeyCode = Keys.Escape Then
            '[ESC]
            Me.Close()

        ElseIf e.KeyCode = Keys.V AndAlso e.Control Then
            '[Ctrl + V]
            OnPaste()
        End If
    End Sub

#End Region


#Region "Private Method"
    Private Sub OnPaste()
        '[Ctrl + V]
        Dim wScriptStr = Clipboard.GetText()
        If String.IsNullOrWhiteSpace(wScriptStr) Then
            Return
        End If

        srcDstList = ReadScriptReplace(wScriptStr)
        DisplayScript(srcDstList)
    End Sub

    Private Function ReadScriptReplace(wFindStr As String) As List(Of SrcDst)
        Dim wSeparators As Char() = New Char() {vbTab}
        Dim wResult As New List(Of SrcDst)

        If String.IsNullOrEmpty(wFindStr) Then
            Return wResult
        End If

        'Dim wFindStrRows As String() = wFindStr.Split(New Char() {vbCrLf}, StringSplitOptions.RemoveEmptyEntries) 'TODO: add option to choose
        Dim wReplaceStrRows As String() = wFindStr.Split(New Char() {vbCrLf})
        For Each row As String In wReplaceStrRows
            row = row.Replace(vbLf, String.Empty)
            Dim wArySrcDst As String() = row.Split(wSeparators, StringSplitOptions.RemoveEmptyEntries)

            Dim wSD As New SrcDst()
            wSD.Src = String.Empty
            wSD.Dst = String.Empty

            If wArySrcDst.Length >= 2 Then
                wSD.Src = Trim(wArySrcDst(0))
                wSD.Dst = Trim(wArySrcDst(1))
            End If

            wResult.Add(wSD)
        Next

        Return wResult
    End Function

    Private Function Replace() As Boolean
        Dim rtnVal As Boolean = True

        'Check before process
        If Not CheckReplacement() Then
            Return False
        End If

        'Create Backup File before replace
        Me.CreateBackupFile()

        Try

            For Each filePath In fileList
                Dim wfileInfo As FileInfo = New FileInfo(filePath)
                Dim wLines As String() = Nothing
                Dim wReplaceCnt As Integer = 0

                If Not wfileInfo.Exists() Then
                    If MsgBox("File: [" & filePath & "] is not existed, continue process?", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
                        Return False
                    End If
                    Continue For
                End If

                wLines = File.ReadAllLines(filePath)
                For i As Integer = 0 To wLines.Length - 1
                    For Each wSD In srcDstList
                        If wLines(i).Contains(wSD.Src) Then
                            wLines(i) = wLines(i).Replace(wSD.Src, wSD.Dst)
                            wReplaceCnt += 1
                        End If
                    Next
                Next

                If wReplaceCnt <> 0 Then
                    File.WriteAllLines(filePath, wLines)
                End If
            Next

        Catch ex As Exception
            rtnVal = False
        End Try

        Return rtnVal
    End Function

    Private Function CheckReplacement() As Boolean
        If fileList Is Nothing OrElse fileList.Count = 0 Then
            MsgBox("Have no file to replace")
            Return False
        End If

        If srcDstList Is Nothing OrElse srcDstList.Count = 0 Then
            MsgBox("Have no replacement script")
            Return False
        End If

        Return True
    End Function

    Private Function CreateBackupFile() As Boolean
        Dim rtnVal As Boolean = True
        Try
            'TODO: create backup before replace
        Catch ex As Exception
            rtnVal = False
        End Try
        Return rtnVal
    End Function

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim dlgSave As New SaveFileDialog()
        dlgSave.Filter = "Xml file|*.xml"
        dlgSave.InitialDirectory = strPath
        dlgSave.FileName = "REPLACE_SCRIPT" & Date.Now.ToString("yyyyMMdd") & ".xml"
        Dim dlgRs As DialogResult = dlgSave.ShowDialog()

        If dlgRs = DialogResult.OK Then
            Try
                WriteReplaceScriptToFile(Me.srcDstList, dlgSave.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        Dim dlgOpen As New OpenFileDialog()
        dlgOpen.Filter = "Xml file|*.xml"
        Dim strPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

        Dim dlgRs As DialogResult = dlgOpen.ShowDialog()
        If dlgRs = DialogResult.OK Then
            Dim wList As List(Of SrcDst) = ReadReplaceScriptFromFile(dlgOpen.FileName)
            If wList IsNot Nothing Then
                DisplayScript(wList)
            End If
        End If
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        dgvScript.MaxRows = 0
        dgvScript.MaxCols = 0
    End Sub

    Private Sub DisplayScript(list As List(Of SrcDst))
        If list IsNot Nothing AndAlso list.Count > 0 Then
            dgvScript.VisibleCols = 2
            dgvScript.MaxCols = 2
            dgvScript.MaxRows = list.Count

            dgvScript.SetColumnHeaderText(0, "Source")
            dgvScript.SetColumnHeaderText(1, "Destination")
            Dim wRow As Integer = -1
            For Each sd As SrcDst In list
                wRow += 1
                dgvScript.SetText(wRow, 0, sd.Src)
                dgvScript.SetText(wRow, 1, sd.Dst)
            Next

            For col As Integer = 0 To dgvScript.MaxCols - 1
                dgvScript.Columns(col).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvScript.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        End If
    End Sub


    Public Shared Sub WriteReplaceScriptToFile(wSrcDst As List(Of SrcDst), wFiles As String)
        If wSrcDst Is Nothing OrElse wSrcDst.Count <= 0 Then
            Return
        End If

        Dim file As System.IO.StreamWriter = Nothing
        Dim writer As System.Xml.Serialization.XmlSerializer = Nothing

        Try
            writer = New System.Xml.Serialization.XmlSerializer(wSrcDst.GetType())
            file = New System.IO.StreamWriter(wFiles)
            writer.Serialize(file, wSrcDst)
        Finally
            If writer IsNot Nothing Then
                writer = Nothing
            End If

            If file IsNot Nothing Then
                file.Close()
                file.Dispose()
                file = Nothing
            End If
        End Try
    End Sub

    Public Shared Function ReadReplaceScriptFromFile(wFiles As String) As List(Of SrcDst)
        Dim wSubSysList As New List(Of SrcDst)
        Dim reader As System.Xml.Serialization.XmlSerializer = Nothing
        Dim file As System.IO.StreamReader = Nothing
        Try
            reader = New System.Xml.Serialization.XmlSerializer(wSubSysList.GetType())
            file = New System.IO.StreamReader(wFiles)
            wSubSysList = CType(reader.Deserialize(file), List(Of SrcDst))
        Catch ex As Exception
            wSubSysList = Nothing
        Finally
            If reader IsNot Nothing Then
                reader = Nothing
            End If

            If file IsNot Nothing Then
                file.Close()
                file.Dispose()
                file = Nothing
            End If
        End Try
        Return wSubSysList
    End Function


#End Region

End Class
