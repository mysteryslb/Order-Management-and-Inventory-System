Public Class Start
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
