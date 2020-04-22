Imports System.Runtime.CompilerServices

Module Module1
    <Extension()> Public Function IsEmpty(ByVal str As String) As Boolean
        Return String.IsNullOrWhiteSpace(str)
    End Function
    <Extension()> Public Function _IsEmpty(ByVal str As String) As Boolean
        Return String.IsNullOrWhiteSpace(str)
    End Function

    Public Function _Confirm(msg As String) As Boolean
        Return MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Sub _Error(msg As String)
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub _Success(msg As String)
        MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
