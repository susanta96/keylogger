
Public Class Frm1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            Frm2.Show()
            Me.Hide()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 10
        End If
    End Sub

    Private Sub Frm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
