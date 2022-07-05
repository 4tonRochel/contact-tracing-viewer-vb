Imports System.IO
Public Class Form1
    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Filter = "C:\Users\SherylMejia\Documents\contact tracing\contact-tracing-vb\contact-tracing-vb | *.txt"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtbxViewer.Text = File.ReadAllText(ofd.FileName)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbxViewer.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim GameExit As DialogResult = MessageBox.Show("Confirm if you want to exit", "CONTACT TRACING VIEWER", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If GameExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
