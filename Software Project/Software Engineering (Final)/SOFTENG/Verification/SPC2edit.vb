Public Class SPC2edit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1SC2.Click
        Lbl_SP2C_name.Text = SP2C_name.Text
        Lbl_SP2C_price.Text = SP2C_price.Text
        Lbl_SP2C_pax.Text = SP2C_pax.Text
        Lbl_SP2C_entry1.Text = SP2C_entry1.Text
        Lbl_SP2C_entry2.Text = SP2C_entry2.Text
        Lbl_SP2C_entry3.Text = SP2C_entry3.Text
        Lbl_SP2C_entry4.Text = SP2C_entry4.Text
        Lbl_SP2C_entry5.Text = SP2C_entry5.Text
        Lbl_SP2C_entry6.Text = SP2C_entry6.Text
        Lbl_SP2C_entry7.Text = SP2C_entry7.Text
        Lbl_SP2C_entry8.Text = SP2C_entry8.Text
        Lbl_SP2C_entry9.Text = SP2C_entry9.Text
        Lbl_SP2C_entry10.Text = SP2C_entry10.Text
        Lbl_SP2C_entry11.Text = SP2C_entry11.Text
        Lbl_SP2C_entry12.Text = SP2C_entry12.Text
        Lbl_SP2C_add1.Text = SP2C_add1.Text
        Lbl_SP2C_add2.Text = SP2C_add2.Text
        Lbl_SP2C_add3.Text = SP2C_add3.Text
        Lbl_SP2C_add4.Text = SP2C_add4.Text
        Lbl_SP2C_add5.Text = SP2C_add5.Text
        Lbl_SP2C_add6.Text = SP2C_add6.Text
        Lbl_SP2C_add7.Text = SP2C_add7.Text
        Lbl_SP2C_add8.Text = SP2C_add8.Text
        Lbl_SP2C_add9.Text = SP2C_add9.Text
        Lbl_SP2C_add10.Text = SP2C_add10.Text
        Lbl_SP2C_add11.Text = SP2C_add11.Text
        Lbl_SP2C_add12.Text = SP2C_add12.Text
        Lbl_SP2C_add1p.Text = SP2C_add1p.Text
        Lbl_SP2C_add2p.Text = SP2C_add2p.Text
        Lbl_SP2C_add3p.Text = SP2C_add3p.Text
        Lbl_SP2C_add4p.Text = SP2C_add4p.Text
        Lbl_SP2C_add5p.Text = SP2C_add5p.Text
        Lbl_SP2C_add6p.Text = SP2C_add6p.Text
        Lbl_SP2C_add7p.Text = SP2C_add7p.Text
        Lbl_SP2C_add8p.Text = SP2C_add8p.Text
        Lbl_SP2C_add9p.Text = SP2C_add9p.Text
        Lbl_SP2C_add10p.Text = SP2C_add10p.Text
        Lbl_SP2C_add11p.Text = SP2C_add11p.Text
        Lbl_SP2C_add12p.Text = SP2C_add12p.Text
        Lbl_SP2C_inc1.Text = SP2C_inc1.Text
        Lbl_SP2C_inc2.Text = SP2C_inc2.Text
        Lbl_SP2C_inc3.Text = SP2C_inc3.Text
        Lbl_SP2C_inc4.Text = SP2C_inc4.Text
        Lbl_SP2C_inc5.Text = SP2C_inc5.Text
        Lbl_SP2C_inc6.Text = SP2C_inc6.Text
        Lbl_SP2C_inc7.Text = SP2C_inc7.Text
        Lbl_SP2C_inc8.Text = SP2C_inc8.Text
        Lbl_SP2C_inc9.Text = SP2C_inc9.Text
        Lbl_SP2C_inc10.Text = SP2C_inc10.Text
        Lbl_SP2C_inc11.Text = SP2C_inc11.Text
        Lbl_SP2C_inc12.Text = SP2C_inc12.Text
        Lbl_SP2C_inc13.Text = SP2C_inc13.Text
        Lbl_SP2C_inc14.Text = SP2C_inc14.Text
        Lbl_SP2C_inc15.Text = SP2C_inc15.Text
        Lbl_SP2C_inc16.Text = SP2C_inc16.Text
        Lbl_SP2C_inc17.Text = SP2C_inc17.Text
        Lbl_SP2C_inc18.Text = SP2C_inc18.Text
        Lbl_SP2C_service1.Text = SP2C_service1.Text
        Lbl_SP2C_service2.Text = SP2C_service2.Text
        Lbl_SP2C_service3.Text = SP2C_service3.Text
        Lbl_SP2C_service4.Text = SP2C_service4.Text
        Lbl_SP2C_service5.Text = SP2C_service5.Text
        Lbl_SP2C_service6.Text = SP2C_service6.Text
        Lbl_SP2C_service7.Text = SP2C_service7.Text
        Lbl_SP2C_service8.Text = SP2C_service8.Text
        Lbl_SP2C_service9.Text = SP2C_service9.Text
        Lbl_SP2C_service10.Text = SP2C_service10.Text
        Lbl_SP2C_service11.Text = SP2C_service11.Text
        Lbl_SP2C_service1p.Text = SP2C_service1p.Text
        Lbl_SP2C_service2p.Text = SP2C_service2p.Text
        Lbl_SP2C_service3p.Text = SP2C_service3p.Text
        Lbl_SP2C_service4p.Text = SP2C_service4p.Text
        Lbl_SP2C_service5p.Text = SP2C_service5p.Text
        Lbl_SP2C_service6p.Text = SP2C_service6p.Text
        Lbl_SP2C_service7p.Text = SP2C_service7p.Text
        Lbl_SP2C_service8p.Text = SP2C_service8p.Text
        Lbl_SP2C_service9p.Text = SP2C_service9p.Text
        Lbl_SP2C_service10p.Text = SP2C_service10p.Text
        Lbl_SP2C_service11p.Text = SP2C_service11p.Text
        Lbl_SP2C_service12p.Text = SP2C_service12p.Text
        Lbl_SP2C_Description.Text = Lbl_SP2C_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SP2C_name.Text = Lbl_SP2C_name.Text
        SP2C_price.Text = Lbl_SP2C_price.Text
        SP2C_pax.Text = Lbl_SP2C_pax.Text
        SP2C_entry1.Text = Lbl_SP2C_entry1.Text
        SP2C_entry2.Text = Lbl_SP2C_entry2.Text
        SP2C_entry3.Text = Lbl_SP2C_entry3.Text
        SP2C_entry4.Text = Lbl_SP2C_entry4.Text
        SP2C_entry5.Text = Lbl_SP2C_entry5.Text
        SP2C_entry6.Text = Lbl_SP2C_entry6.Text
        SP2C_entry7.Text = Lbl_SP2C_entry7.Text
        SP2C_entry8.Text = Lbl_SP2C_entry8.Text
        SP2C_entry9.Text = Lbl_SP2C_entry9.Text
        SP2C_entry10.Text = Lbl_SP2C_entry10.Text
        SP2C_entry11.Text = Lbl_SP2C_entry11.Text
        SP2C_entry12.Text = Lbl_SP2C_entry12.Text
        SP2C_add1.Text = Lbl_SP2C_add1.Text
        SP2C_add2.Text = Lbl_SP2C_add2.Text
        SP2C_add3.Text = Lbl_SP2C_add3.Text
        SP2C_add4.Text = Lbl_SP2C_add4.Text
        SP2C_add5.Text = Lbl_SP2C_add5.Text
        SP2C_add6.Text = Lbl_SP2C_add6.Text
        SP2C_add7.Text = Lbl_SP2C_add7.Text
        SP2C_add8.Text = Lbl_SP2C_add8.Text
        SP2C_add9.Text = Lbl_SP2C_add9.Text
        SP2C_add10.Text = Lbl_SP2C_add10.Text
        SP2C_add11.Text = Lbl_SP2C_add11.Text
        SP2C_add12.Text = Lbl_SP2C_add12.Text
        SP2C_add1p.Text = Lbl_SP2C_add1p.Text
        SP2C_add2p.Text = Lbl_SP2C_add2p.Text
        SP2C_add3p.Text = Lbl_SP2C_add3p.Text
        SP2C_add4p.Text = Lbl_SP2C_add4p.Text
        SP2C_add5p.Text = Lbl_SP2C_add5p.Text
        SP2C_add6p.Text = Lbl_SP2C_add6p.Text
        SP2C_add7p.Text = Lbl_SP2C_add7p.Text
        SP2C_add8p.Text = Lbl_SP2C_add8p.Text
        SP2C_add9p.Text = Lbl_SP2C_add9p.Text
        SP2C_add10p.Text = Lbl_SP2C_add10p.Text
        SP2C_add11p.Text = Lbl_SP2C_add11p.Text
        SP2C_add12p.Text = Lbl_SP2C_add12p.Text
        SP2C_inc1.Text = Lbl_SP2C_inc1.Text
        SP2C_inc2.Text = Lbl_SP2C_inc2.Text
        SP2C_inc3.Text = Lbl_SP2C_inc3.Text
        SP2C_inc4.Text = Lbl_SP2C_inc4.Text
        SP2C_inc5.Text = Lbl_SP2C_inc5.Text
        SP2C_inc6.Text = Lbl_SP2C_inc6.Text
        SP2C_inc7.Text = Lbl_SP2C_inc7.Text
        SP2C_inc8.Text = Lbl_SP2C_inc8.Text
        SP2C_inc9.Text = Lbl_SP2C_inc9.Text
        SP2C_inc10.Text = Lbl_SP2C_inc10.Text
        SP2C_inc11.Text = Lbl_SP2C_inc11.Text
        SP2C_inc12.Text = Lbl_SP2C_inc12.Text
        SP2C_inc13.Text = Lbl_SP2C_inc13.Text
        SP2C_inc14.Text = Lbl_SP2C_inc14.Text
        SP2C_inc15.Text = Lbl_SP2C_inc15.Text
        SP2C_inc16.Text = Lbl_SP2C_inc16.Text
        SP2C_inc17.Text = Lbl_SP2C_inc17.Text
        SP2C_inc18.Text = Lbl_SP2C_inc18.Text
        SP2C_service1.Text = Lbl_SP2C_service1.Text
        SP2C_service2.Text = Lbl_SP2C_service2.Text
        SP2C_service3.Text = Lbl_SP2C_service3.Text
        SP2C_service4.Text = Lbl_SP2C_service4.Text
        SP2C_service5.Text = Lbl_SP2C_service5.Text
        SP2C_service6.Text = Lbl_SP2C_service6.Text
        SP2C_service7.Text = Lbl_SP2C_service7.Text
        SP2C_service8.Text = Lbl_SP2C_service8.Text
        SP2C_service9.Text = Lbl_SP2C_service9.Text
        SP2C_service10.Text = Lbl_SP2C_service10.Text
        SP2C_service11.Text = Lbl_SP2C_service11.Text
        SP2C_service1p.Text = Lbl_SP2C_service1p.Text
        SP2C_service2p.Text = Lbl_SP2C_service2p.Text
        SP2C_service3p.Text = Lbl_SP2C_service3p.Text
        SP2C_service4p.Text = Lbl_SP2C_service4p.Text
        SP2C_service5p.Text = Lbl_SP2C_service5p.Text
        SP2C_service6p.Text = Lbl_SP2C_service6p.Text
        SP2C_service7p.Text = Lbl_SP2C_service7p.Text
        SP2C_service8p.Text = Lbl_SP2C_service8p.Text
        SP2C_service9p.Text = Lbl_SP2C_service9p.Text
        SP2C_service10p.Text = Lbl_SP2C_service10p.Text
        SP2C_service11p.Text = Lbl_SP2C_service11p.Text
        SP2C_service12p.Text = Lbl_SP2C_service12p.Text
        SP2C_what.Text = Lbl_SP2C_what.Text
    End Sub

    Private Sub P1A_entry1_TextChanged(sender As Object, e As EventArgs) Handles SP2C_entry1.TextChanged

    End Sub

    Private Sub P1A_entry2_TextChanged(sender As Object, e As EventArgs) Handles SP2C_entry2.TextChanged

    End Sub

    Private Sub P1A_add6p_TextChanged(sender As Object, e As EventArgs) Handles SP2C_add6p.TextChanged

    End Sub

    Private Sub Lbl_P1A_inc5_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_inc5.Click

    End Sub

    Private Sub Lbl_P1A_service8_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_service8.Click

    End Sub

    Private Sub P2A_entry11_TextChanged(sender As Object, e As EventArgs) Handles SP2C_entry11.TextChanged

    End Sub

    Private Sub P2A_inc1_TextChanged(sender As Object, e As EventArgs) Handles SP2C_inc1.TextChanged

    End Sub

    Private Sub Lbl_P3A_entry8_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_entry8.Click

    End Sub

    Private Sub Lbl_P3A_inc16_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_inc16.Click

    End Sub

    Private Sub P4A_service12p_TextChanged(sender As Object, e As EventArgs) Handles SP2C_service12p.TextChanged

    End Sub

    Private Sub P2B_entry9_TextChanged(sender As Object, e As EventArgs) Handles SP2C_entry9.TextChanged

    End Sub

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lbl_P4B_add2p_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_add2p.Click

    End Sub

    Private Sub P4B_price_TextChanged(sender As Object, e As EventArgs) Handles SP2C_price.TextChanged

    End Sub

    Private Sub Lbl_P1C_service9_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_service9.Click

    End Sub

    Private Sub Lbl_P2C_entry7_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_entry7.Click

    End Sub

    Private Sub P2C_inc16_TextChanged(sender As Object, e As EventArgs) Handles SP2C_inc16.TextChanged

    End Sub

    Private Sub Lbl_P4C_entry4_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_entry4.Click

    End Sub

    Private Sub Lbl_P1D_what_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_what.Click

    End Sub

    Private Sub Lbl_P1D_inc8_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_inc8.Click

    End Sub

    Private Sub P1D_add2_TextChanged(sender As Object, e As EventArgs) Handles SP2C_add2.TextChanged

    End Sub

    Private Sub Lbl_SP2A_inc2_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_inc2.Click

    End Sub

    Private Sub Lbl_SP2A_inc4_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_inc4.Click

    End Sub

    Private Sub Lbl_SP2A_inc9_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_inc9.Click

    End Sub

    Private Sub Lbl_SP2A_inc12_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_inc12.Click

    End Sub

    Private Sub Lbl_SP2B_add1_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_add1.Click

    End Sub

    Private Sub Lbl_SP2A_service12p_Click(sender As Object, e As EventArgs) Handles Lbl_SP2C_service12p.Click

    End Sub

    Private Sub SP2B_inc9_TextChanged(sender As Object, e As EventArgs) Handles SP2C_inc9.TextChanged

    End Sub
End Class