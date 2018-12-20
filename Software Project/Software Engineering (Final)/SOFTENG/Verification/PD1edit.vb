Public Class PD1edit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1D1.Click
        Lbl_P1D_name.Text = P1D_name.Text
        Lbl_P1D_price.Text = P1D_price.Text
        Lbl_P1D_pax.Text = P1D_pax.Text
        Lbl_P1D_entry1.Text = P1D_entry1.Text
        Lbl_P1D_entry2.Text = P1D_entry2.Text
        Lbl_P1D_entry3.Text = P1D_entry3.Text
        Lbl_P1D_entry4.Text = P1D_entry4.Text
        Lbl_P1D_entry5.Text = P1D_entry5.Text
        Lbl_P1D_entry6.Text = P1D_entry6.Text
        Lbl_P1D_entry7.Text = P1D_entry7.Text
        Lbl_P1D_entry8.Text = P1D_entry8.Text
        Lbl_P1D_entry9.Text = P1D_entry9.Text
        Lbl_P1D_entry10.Text = P1D_entry10.Text
        Lbl_P1D_entry11.Text = P1D_entry11.Text
        Lbl_P1D_entry12.Text = P1D_entry12.Text
        Lbl_P1D_add1.Text = P1D_add1.Text
        Lbl_P1D_add2.Text = P1D_add2.Text
        Lbl_P1D_add3.Text = P1D_add3.Text
        Lbl_P1D_add4.Text = P1D_add4.Text
        Lbl_P1D_add5.Text = P1D_add5.Text
        Lbl_P1D_add6.Text = P1D_add6.Text
        Lbl_P1D_add7.Text = P1D_add7.Text
        Lbl_P1D_add8.Text = P1D_add8.Text
        Lbl_P1D_add9.Text = P1D_add9.Text
        Lbl_P1D_add10.Text = P1D_add10.Text
        Lbl_P1D_add11.Text = P1D_add11.Text
        Lbl_P1D_add12.Text = P1D_add12.Text
        Lbl_P1D_add1p.Text = P1D_add1p.Text
        Lbl_P1D_add2p.Text = P1D_add2p.Text
        Lbl_P1D_add3p.Text = P1D_add3p.Text
        Lbl_P1D_add4p.Text = P1D_add4p.Text
        Lbl_P1D_add5p.Text = P1D_add5p.Text
        Lbl_P1D_add6p.Text = P1D_add6p.Text
        Lbl_P1D_add7p.Text = P1D_add7p.Text
        Lbl_P1D_add8p.Text = P1D_add8p.Text
        Lbl_P1D_add9p.Text = P1D_add9p.Text
        Lbl_P1D_add10p.Text = P1D_add10p.Text
        Lbl_P1D_add11p.Text = P1D_add11p.Text
        Lbl_P1D_add12p.Text = P1D_add12p.Text
        Lbl_P1D_inc1.Text = P1D_inc1.Text
        Lbl_P1D_inc2.Text = P1D_inc2.Text
        Lbl_P1D_inc3.Text = P1D_inc3.Text
        Lbl_P1D_inc4.Text = P1D_inc4.Text
        Lbl_P1D_inc5.Text = P1D_inc5.Text
        Lbl_P1D_inc6.Text = P1D_inc6.Text
        Lbl_P1D_inc7.Text = P1D_inc7.Text
        Lbl_P1D_inc8.Text = P1D_inc8.Text
        Lbl_P1D_inc9.Text = P1D_inc9.Text
        Lbl_P1D_inc10.Text = P1D_inc10.Text
        Lbl_P1D_inc11.Text = P1D_inc11.Text
        Lbl_P1D_inc12.Text = P1D_inc12.Text
        Lbl_P1D_inc13.Text = P1D_inc13.Text
        Lbl_P1D_inc14.Text = P1D_inc14.Text
        Lbl_P1D_inc15.Text = P1D_inc15.Text
        Lbl_P1D_inc16.Text = P1D_inc16.Text
        Lbl_P1D_inc17.Text = P1D_inc17.Text
        Lbl_P1D_inc18.Text = P1D_inc18.Text
        Lbl_P1D_service1.Text = P1D_service1.Text
        Lbl_P1D_service2.Text = P1D_service2.Text
        Lbl_P1D_service3.Text = P1D_service3.Text
        Lbl_P1D_service4.Text = P1D_service4.Text
        Lbl_P1D_service5.Text = P1D_service5.Text
        Lbl_P1D_service6.Text = P1D_service6.Text
        Lbl_P1D_service7.Text = P1D_service7.Text
        Lbl_P1D_service8.Text = P1D_service8.Text
        Lbl_P1D_service9.Text = P1D_service9.Text
        Lbl_P1D_service10.Text = P1D_service10.Text
        Lbl_P1D_service11.Text = P1D_service11.Text
        Lbl_P1D_service1p.Text = P1D_service1p.Text
        Lbl_P1D_service2p.Text = P1D_service2p.Text
        Lbl_P1D_service3p.Text = P1D_service3p.Text
        Lbl_P1D_service4p.Text = P1D_service4p.Text
        Lbl_P1D_service5p.Text = P1D_service5p.Text
        Lbl_P1D_service6p.Text = P1D_service6p.Text
        Lbl_P1D_service7p.Text = P1D_service7p.Text
        Lbl_P1D_service8p.Text = P1D_service8p.Text
        Lbl_P1D_service9p.Text = P1D_service9p.Text
        Lbl_P1D_service10p.Text = P1D_service10p.Text
        Lbl_P1D_service11p.Text = P1D_service11p.Text
        Lbl_P1D_service12p.Text = P1D_service12p.Text
        Lbl_P1D_Description.Text = Lbl_P1D_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P1D_name.Text = Lbl_P1D_name.Text
        P1D_price.Text = Lbl_P1D_price.Text
        P1D_pax.Text = Lbl_P1D_pax.Text
        P1D_entry1.Text = Lbl_P1D_entry1.Text
        P1D_entry2.Text = Lbl_P1D_entry2.Text
        P1D_entry3.Text = Lbl_P1D_entry3.Text
        P1D_entry4.Text = Lbl_P1D_entry4.Text
        P1D_entry5.Text = Lbl_P1D_entry5.Text
        P1D_entry6.Text = Lbl_P1D_entry6.Text
        P1D_entry7.Text = Lbl_P1D_entry7.Text
        P1D_entry8.Text = Lbl_P1D_entry8.Text
        P1D_entry9.Text = Lbl_P1D_entry9.Text
        P1D_entry10.Text = Lbl_P1D_entry10.Text
        P1D_entry11.Text = Lbl_P1D_entry11.Text
        P1D_entry12.Text = Lbl_P1D_entry12.Text
        P1D_add1.Text = Lbl_P1D_add1.Text
        P1D_add2.Text = Lbl_P1D_add2.Text
        P1D_add3.Text = Lbl_P1D_add3.Text
        P1D_add4.Text = Lbl_P1D_add4.Text
        P1D_add5.Text = Lbl_P1D_add5.Text
        P1D_add6.Text = Lbl_P1D_add6.Text
        P1D_add7.Text = Lbl_P1D_add7.Text
        P1D_add8.Text = Lbl_P1D_add8.Text
        P1D_add9.Text = Lbl_P1D_add9.Text
        P1D_add10.Text = Lbl_P1D_add10.Text
        P1D_add11.Text = Lbl_P1D_add11.Text
        P1D_add12.Text = Lbl_P1D_add12.Text
        P1D_add1p.Text = Lbl_P1D_add1p.Text
        P1D_add2p.Text = Lbl_P1D_add2p.Text
        P1D_add3p.Text = Lbl_P1D_add3p.Text
        P1D_add4p.Text = Lbl_P1D_add4p.Text
        P1D_add5p.Text = Lbl_P1D_add5p.Text
        P1D_add6p.Text = Lbl_P1D_add6p.Text
        P1D_add7p.Text = Lbl_P1D_add7p.Text
        P1D_add8p.Text = Lbl_P1D_add8p.Text
        P1D_add9p.Text = Lbl_P1D_add9p.Text
        P1D_add10p.Text = Lbl_P1D_add10p.Text
        P1D_add11p.Text = Lbl_P1D_add11p.Text
        P1D_add12p.Text = Lbl_P1D_add12p.Text
        P1D_inc1.Text = Lbl_P1D_inc1.Text
        P1D_inc2.Text = Lbl_P1D_inc2.Text
        P1D_inc3.Text = Lbl_P1D_inc3.Text
        P1D_inc4.Text = Lbl_P1D_inc4.Text
        P1D_inc5.Text = Lbl_P1D_inc5.Text
        P1D_inc6.Text = Lbl_P1D_inc6.Text
        P1D_inc7.Text = Lbl_P1D_inc7.Text
        P1D_inc8.Text = Lbl_P1D_inc8.Text
        P1D_inc9.Text = Lbl_P1D_inc9.Text
        P1D_inc10.Text = Lbl_P1D_inc10.Text
        P1D_inc11.Text = Lbl_P1D_inc11.Text
        P1D_inc12.Text = Lbl_P1D_inc12.Text
        P1D_inc13.Text = Lbl_P1D_inc13.Text
        P1D_inc14.Text = Lbl_P1D_inc14.Text
        P1D_inc15.Text = Lbl_P1D_inc15.Text
        P1D_inc16.Text = Lbl_P1D_inc16.Text
        P1D_inc17.Text = Lbl_P1D_inc17.Text
        P1D_inc18.Text = Lbl_P1D_inc18.Text
        P1D_service1.Text = Lbl_P1D_service1.Text
        P1D_service2.Text = Lbl_P1D_service2.Text
        P1D_service3.Text = Lbl_P1D_service3.Text
        P1D_service4.Text = Lbl_P1D_service4.Text
        P1D_service5.Text = Lbl_P1D_service5.Text
        P1D_service6.Text = Lbl_P1D_service6.Text
        P1D_service7.Text = Lbl_P1D_service7.Text
        P1D_service8.Text = Lbl_P1D_service8.Text
        P1D_service9.Text = Lbl_P1D_service9.Text
        P1D_service10.Text = Lbl_P1D_service10.Text
        P1D_service11.Text = Lbl_P1D_service11.Text
        P1D_service1p.Text = Lbl_P1D_service1p.Text
        P1D_service2p.Text = Lbl_P1D_service2p.Text
        P1D_service3p.Text = Lbl_P1D_service3p.Text
        P1D_service4p.Text = Lbl_P1D_service4p.Text
        P1D_service5p.Text = Lbl_P1D_service5p.Text
        P1D_service6p.Text = Lbl_P1D_service6p.Text
        P1D_service7p.Text = Lbl_P1D_service7p.Text
        P1D_service8p.Text = Lbl_P1D_service8p.Text
        P1D_service9p.Text = Lbl_P1D_service9p.Text
        P1D_service10p.Text = Lbl_P1D_service10p.Text
        P1D_service11p.Text = Lbl_P1D_service11p.Text
        P1D_service12p.Text = Lbl_P1D_service12p.Text
        P1D_what.Text = Lbl_P1D_what.Text
    End Sub

    Private Sub P1A_entry1_TextChanged(sender As Object, e As EventArgs) Handles P1D_entry1.TextChanged

    End Sub

    Private Sub P1A_entry2_TextChanged(sender As Object, e As EventArgs) Handles P1D_entry2.TextChanged

    End Sub

    Private Sub P1A_add6p_TextChanged(sender As Object, e As EventArgs) Handles P1D_add6p.TextChanged

    End Sub

    Private Sub Lbl_P1A_inc5_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_inc5.Click

    End Sub

    Private Sub Lbl_P1A_service8_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_service8.Click

    End Sub

    Private Sub P2A_entry11_TextChanged(sender As Object, e As EventArgs) Handles P1D_entry11.TextChanged

    End Sub

    Private Sub P2A_inc1_TextChanged(sender As Object, e As EventArgs) Handles P1D_inc1.TextChanged

    End Sub

    Private Sub Lbl_P3A_entry8_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_entry8.Click

    End Sub

    Private Sub Lbl_P3A_inc16_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_inc16.Click

    End Sub

    Private Sub P4A_service12p_TextChanged(sender As Object, e As EventArgs) Handles P1D_service12p.TextChanged

    End Sub

    Private Sub P2B_entry9_TextChanged(sender As Object, e As EventArgs) Handles P1D_entry9.TextChanged

    End Sub

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lbl_P4B_add2p_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_add2p.Click

    End Sub

    Private Sub P4B_price_TextChanged(sender As Object, e As EventArgs) Handles P1D_price.TextChanged

    End Sub

    Private Sub Lbl_P1C_service9_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_service9.Click

    End Sub

    Private Sub Lbl_P2C_entry7_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_entry7.Click

    End Sub

    Private Sub P2C_inc16_TextChanged(sender As Object, e As EventArgs) Handles P1D_inc16.TextChanged

    End Sub

    Private Sub Lbl_P4C_entry4_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_entry4.Click

    End Sub

    Private Sub Lbl_P1D_what_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_what.Click

    End Sub

    Private Sub Lbl_P1D_inc8_Click(sender As Object, e As EventArgs) Handles Lbl_P1D_inc8.Click

    End Sub
End Class