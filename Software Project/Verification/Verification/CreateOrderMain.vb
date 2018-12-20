Public Class CreateOrderMain
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub Min_Click(sender As Object, e As EventArgs) Handles Min.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Ext_Click(sender As Object, e As EventArgs) Handles Ext.Click
        Application.Exit()
    End Sub

    Private Sub CreateOrderMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adapteeeeeeeeeeeeeeeer'
        AddmainTxt.Enabled = False
        AddSoupTxt.Enabled = False
        AddPastaTxt.Enabled = False
        AddOtherTxt.Enabled = False
        Buttonplus.Enabled = False
        ButtonMinus.Enabled = False
        ButtonMultiply.Enabled = False
        ButtonDivide.Enabled = False
        ButtonEqual.Enabled = False
        Call AddOrder()
    End Sub

    Private Sub AddOrder()
        'Bindiiiiiiiiiiiiiiing'
        GenderComboBox.SelectedItem = Nothing
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            If Not IsDataComplete() Then
                Exit Sub
            End If
            'dataaaaaaaaaaaaaaaaaaaaaaa'
            MessageBox.Show("Order created! ^_^")
            Call AddOrder()
        Catch ex As Exception
            MessageBox.Show("Error! : " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Select Case MsgBox("Do you really want to go back? All unsaved data will be lost. ^_^", MsgBoxStyle.YesNo, "BACK")
            Case MsgBoxResult.Yes
                Me.Close()
                AdminCustomerSupport.Show()
            Case MsgBoxResult.No
                Return
        End Select
    End Sub

    Private Function IsDataComplete() As Boolean

        Dim ErrMsg As String = ""
        If FNameTxt.Text = "" OrElse MNameTxt.Text = "" OrElse LNameTxt.Text = "" _
            OrElse AddressTxt.Text = "" OrElse EmailTxt.Text = "" _
            OrElse GenderComboBox.Text = "" OrElse AgeMaskedTxt.Text = "" OrElse CPNumberMtxt.Text = "" Then
            ErrMsg = "Please enter all the missing required fields. ^_^"
        ElseIf Not AgeMaskedTxt.Text.Length = 2 Then
            ErrMsg = "Please enter only 2 digits in AGE Field. ^_^"
        ElseIf Not CPNumberMtxt.Text.Length = 11 Then
            ErrMsg = "Please enter only 11 digits in CONTACT NUMBER Field. ^_^"
        End If

        If ErrMsg <> "" Then
            MessageBox.Show(ErrMsg)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub FNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FNameTxt.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub MNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MNameTxt.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub LNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LNameTxt.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub CurrentDate_CheckedChanged(sender As Object, e As EventArgs) Handles CurrentDate.CheckedChanged
        OrderDate.Text = OrderDayComboBox.SelectedItem & " " & OrderMonthComboBox.SelectedItem & " " & OrderYearMTxt.Text
        If CurrentDate.Checked = True Then
            OrderDate.Text = DateTime.Now.ToString("dd MMMM yyyy")
        Else
            OrderDate.Text = OrderDayComboBox.SelectedItem & " " & OrderMonthComboBox.SelectedItem & " " & OrderYearMTxt.Text
        End If
    End Sub

    Private Sub ServiceDate_TextChanged(sender As Object, e As EventArgs) Handles ServiceDate.TextChanged
        ServiceDate.Text = ServiceDayComboBox.SelectedItem & " " & ServiceMonthComboBox.SelectedItem & " " & ServiceYearMTxt.Text
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

    End Sub

    Dim operate1 As String
    Dim firstnum1 As Double
    Dim secondnum1 As Double
    Dim answer1 As Double


    Private Sub ButtonClear1_Click(sender As Object, e As EventArgs) Handles ButtonClear1.Click
        CalcLbl1.Text = "0"
        LblShowCalc1.Text = " "
    End Sub

    Private Sub ButtonDelete1_Click(sender As Object, e As EventArgs) Handles ButtonDelete1.Click
        If CalcLbl1.Text.Length > 0 Then
            CalcLbl1.Text = CalcLbl1.Text.Remove(CalcLbl1.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub ButtonDeci1_Click(sender As Object, e As EventArgs) Handles ButtonDeci1.Click
        If InStr(CalcLbl1.Text, ".") = 0 Then
            CalcLbl1.Text = CalcLbl1.Text + "."
        End If
    End Sub

    Private Sub ButtonEqual1_Click(sender As Object, e As EventArgs) Handles ButtonEqual1.Click
        secondnum1 = CalcLbl1.Text
        If operate1 = "+" Then
            answer1 = firstnum1 + secondnum1
            CalcLbl1.Text = answer1
            LblShowCalc1.Text = " "
        ElseIf operate1 = "-" Then
            answer1 = firstnum1 - secondnum1
            CalcLbl1.Text = answer1
            LblShowCalc1.Text = " "
        ElseIf operate1 = "/" Then
            answer1 = firstnum1 / secondnum1
            CalcLbl1.Text = answer1
            LblShowCalc1.Text = " "
        ElseIf operate1 = "*" Then
            answer1 = firstnum1 * secondnum1
            CalcLbl1.Text = answer1
            LblShowCalc1.Text = " "
        End If
    End Sub

    Private Sub CalcLbl1_TextChanged(sender As Object, e As EventArgs) Handles CalcLbl1.TextChanged
        If CalcLbl1.Text = "" Then
            CalcLbl1.Text = "0"
        End If
    End Sub

    Private Sub Addmain_CheckedChanged(sender As Object, e As EventArgs) Handles Addmain.CheckedChanged
        If Addmain.Checked = True Then
            AddmainTxt.Enabled = True
        Else
            AddmainTxt.Enabled = False
        End If
    End Sub

    Private Sub AddPasta_CheckedChanged(sender As Object, e As EventArgs) Handles AddPasta.CheckedChanged
        If AddPasta.Checked = True Then
            AddPastaTxt.Enabled = True
        Else
            AddPastaTxt.Enabled = False
        End If
    End Sub

    Private Sub AddSoup_CheckedChanged(sender As Object, e As EventArgs) Handles AddSoup.CheckedChanged
        If AddSoup.Checked = True Then
            AddSoupTxt.Enabled = True
        Else
            AddSoupTxt.Enabled = False
        End If
    End Sub

    Private Sub AddOther_CheckedChanged(sender As Object, e As EventArgs) Handles AddOther.CheckedChanged
        If AddOther.Checked = True Then
            AddOtherTxt.Enabled = True
        Else
            AddOtherTxt.Enabled = False
        End If
    End Sub

    Private Sub Btn_Click1(sender As Object, e As EventArgs) Handles Button28.Click, Button27.Click, Button26.Click, Button24.Click, Button23.Click, Button22.Click, Button20.Click, Button19.Click, Button18.Click, Button16.Click
        Buttonplus1.Enabled = True
        ButtonMinus1.Enabled = True
        ButtonMultiply1.Enabled = True
        ButtonDivide1.Enabled = True
        ButtonEqual1.Enabled = True
        Dim b1 As Button = sender
        If CalcLbl1.Text = "0" Then
            CalcLbl1.Text = b1.Text
        Else
            CalcLbl1.Text = CalcLbl1.Text + b1.Text
        End If
    End Sub

    Private Sub arithmetic_button1(sender As Object, e As EventArgs) Handles TabPage4.Click, Buttonplus1.Click, ButtonMultiply1.Click, ButtonMinus1.Click, ButtonDivide1.Click
        Buttonplus1.Enabled = False
        ButtonMinus1.Enabled = False
        ButtonMultiply1.Enabled = False
        ButtonDivide1.Enabled = False
        ButtonEqual1.Enabled = False
        Dim operates1 As Button = sender
        firstnum1 = CalcLbl1.Text
        LblShowCalc1.Text = CalcLbl1.Text
        CalcLbl1.Text = " "
        operate1 = operates1.Text
        LblShowCalc1.Text = LblShowCalc1.Text + " " + operate1
    End Sub

    Private Sub PA1_Click(sender As Object, e As EventArgs) Handles PA1.Click
        PA1a.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PMainTotal.TextChanged

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        SubPackage.Text = PackageCB.SelectedItem
        SubPType.Text = PackageTypeCB.SelectedItem
        SumName.Text = FNameTxt.Text & " " & MNameTxt.Text & ". " & LNameTxt.Text
        SumAddress.Text = AddressTxt.Text
        SumGender.Text = GenderComboBox.SelectedItem
        SumAge.Text = AgeMaskedTxt.Text
        SumODate.Text = OrderDate.Text
        SumSDate.Text = ServiceDate.Text
        SumPName.Text = PackageCB.SelectedItem
        SumPType.Text = PackageTypeCB.SelectedItem
        SumLocation.Text = VenueTxt.Text
        SumCN.Text = CPNumberMtxt.Text
        SumEmail.Text = EmailTxt.Text
    End Sub


End Class