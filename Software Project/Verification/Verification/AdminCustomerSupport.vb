Public Class AdminCustomerSupport
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateOrderMain.Show()
    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BtnOwner_Click(sender As Object, e As EventArgs) Handles BtnOwner.Click
        Application.Exit()
    End Sub
End Class