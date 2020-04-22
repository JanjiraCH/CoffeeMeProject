Imports System.Runtime.CompilerServices

Module Module2


    Public IsBeginDreg As Boolean
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    <Extension()> Public Sub _SetMovableControl(ctrl As Control, frm As Form)
        AddHandler ctrl.MouseDown, Sub(sender As Object, ByVal e As MouseEventArgs) ControlMouseDown(sender, e)
        AddHandler ctrl.MouseUp, Sub(sender As Object, ByVal e As MouseEventArgs) ControlMouseUp(sender, e)
        AddHandler ctrl.MouseMove, Sub(sender As Object, ByVal e As MouseEventArgs) ControlMouseMove(sender, e, frm)
    End Sub

    Private Sub ControlMouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsBeginDreg = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub ControlMouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsBeginDreg = False
        End If
    End Sub

    Private Sub ControlMouseMove(sender As Object, e As MouseEventArgs, frm As Form)
        If IsBeginDreg Then
            Dim temp As Point = New Point()
            temp.X = frm.Location.X + (e.X - MouseDownX)
            temp.Y = frm.Location.Y + (e.Y - MouseDownY)
            frm.Location = temp
            temp = Nothing
        End If
    End Sub
End Module
