Partial Public Class LoginForm
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Control
        For Each a In Me.Controls
            'clear all textboxes'
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        PictureBox1_MouseLeave(sender, e)
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = New Bitmap(My.Resources.preview2)
    End Sub
    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = New Bitmap(My.Resources.Jlogo)
    End Sub


    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim accounts = Me.AccountListTableAdapter.UserPasswordString(TxtUser.Text, TxtPass.Text, TxtRole.Text)
        If accounts Is Nothing Then
            TxtError.Text = "*Invalid Input. Please Try Again."
            TxtUser.Text = ""
            TxtPass.Text = ""
            TxtRole.Text = ""
        Else
            If TxtRole.Text = "owner" Then
                AdminOwner.Show()
                Me.Hide()
            ElseIf TxtRole.Text = "customersupport" Then
                AdminCustomerSupport.Show()
                Me.Hide()
            ElseIf TxtRole.Text = "finance" Then
                AdminFinance.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub

    Private Sub AccountListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AccountListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AccountsDataSet)
    End Sub


    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged
    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            TxtPass.PasswordChar = ControlChars.NullChar
        Else
            TxtPass.PasswordChar = "*"c
        End If
    End Sub
End Class
