Public Class log
    Private Sub BtnGithub_Click(sender As Object, e As EventArgs) Handles BtnSaveLog.Click
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk
        Try
            My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, TxtLog.Text, False)
            MsgBox("Log saved!", MsgBoxStyle.Information)
        Catch ex As Exception
            TxtLog.AppendText("Log save failed: " & ex.ToString() & vbNewLine & vbNewLine)
            MsgBox("Error while saving log!", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class