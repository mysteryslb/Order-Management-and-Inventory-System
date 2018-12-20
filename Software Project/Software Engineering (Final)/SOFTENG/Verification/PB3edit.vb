Public Class PB3edit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1B3.Click
        Lbl_P3B_name.Text = P3B_name.Text
        Lbl_P3B_price.Text = P3B_price.Text
        Lbl_P3B_pax.Text = P3B_pax.Text
        Lbl_P3B_entry1.Text = P3B_entry1.Text
        Lbl_P3B_entry2.Text = P3B_entry2.Text
        Lbl_P3B_entry3.Text = P3B_entry3.Text
        Lbl_P3B_entry4.Text = P3B_entry4.Text
        Lbl_P3B_entry5.Text = P3B_entry5.Text
        Lbl_P3B_entry6.Text = P3B_entry6.Text
        Lbl_P3B_entry7.Text = P3B_entry7.Text
        Lbl_P3B_entry8.Text = P3B_entry8.Text
        Lbl_P3B_entry9.Text = P3B_entry9.Text
        Lbl_P3B_entry10.Text = P3B_entry10.Text
        Lbl_P3B_entry11.Text = P3B_entry11.Text
        Lbl_P3B_entry12.Text = P3B_entry12.Text
        Lbl_P3B_add1.Text = P3B_add1.Text
        Lbl_P3B_add2.Text = P3B_add2.Text
        Lbl_P3B_add3.Text = P3B_add3.Text
        Lbl_P3B_add4.Text = P3B_add4.Text
        Lbl_P3B_add5.Text = P3B_add5.Text
        Lbl_P3B_add6.Text = P3B_add6.Text
        Lbl_P3B_add7.Text = P3B_add7.Text
        Lbl_P3B_add8.Text = P3B_add8.Text
        Lbl_P3B_add9.Text = P3B_add9.Text
        Lbl_P3B_add10.Text = P3B_add10.Text
        Lbl_P3B_add11.Text = P3B_add11.Text
        Lbl_P3B_add12.Text = P3B_add12.Text
        Lbl_P3B_add1p.Text = P3B_add1p.Text
        Lbl_P3B_add2p.Text = P3B_add2p.Text
        Lbl_P3B_add3p.Text = P3B_add3p.Text
        Lbl_P3B_add4p.Text = P3B_add4p.Text
        Lbl_P3B_add5p.Text = P3B_add5p.Text
        Lbl_P3B_add6p.Text = P3B_add6p.Text
        Lbl_P3B_add7p.Text = P3B_add7p.Text
        Lbl_P3B_add8p.Text = P3B_add8p.Text
        Lbl_P3B_add9p.Text = P3B_add9p.Text
        Lbl_P3B_add10p.Text = P3B_add10p.Text
        Lbl_P3B_add11p.Text = P3B_add11p.Text
        Lbl_P3B_add12p.Text = P3B_add12p.Text
        Lbl_P3B_inc1.Text = P3B_inc1.Text
        Lbl_P3B_inc2.Text = P3B_inc2.Text
        Lbl_P3B_inc3.Text = P3B_inc3.Text
        Lbl_P3B_inc4.Text = P3B_inc4.Text
        Lbl_P3B_inc5.Text = P3B_inc5.Text
        Lbl_P3B_inc6.Text = P3B_inc6.Text
        Lbl_P3B_inc7.Text = P3B_inc7.Text
        Lbl_P3B_inc8.Text = P3B_inc8.Text
        Lbl_P3B_inc9.Text = P3B_inc9.Text
        Lbl_P3B_inc10.Text = P3B_inc10.Text
        Lbl_P3B_inc11.Text = P3B_inc11.Text
        Lbl_P3B_inc12.Text = P3B_inc12.Text
        Lbl_P3B_inc13.Text = P3B_inc13.Text
        Lbl_P3B_inc14.Text = P3B_inc14.Text
        Lbl_P3B_inc15.Text = P3B_inc15.Text
        Lbl_P3B_inc16.Text = P3B_inc16.Text
        Lbl_P3B_inc17.Text = P3B_inc17.Text
        Lbl_P3B_inc18.Text = P3B_inc18.Text
        Lbl_P3B_service1.Text = P3B_service1.Text
        Lbl_P3B_service2.Text = P3B_service2.Text
        Lbl_P3B_service3.Text = P3B_service3.Text
        Lbl_P3B_service4.Text = P3B_service4.Text
        Lbl_P3B_service5.Text = P3B_service5.Text
        Lbl_P3B_service6.Text = P3B_service6.Text
        Lbl_P3B_service7.Text = P3B_service7.Text
        Lbl_P3B_service8.Text = P3B_service8.Text
        Lbl_P3B_service9.Text = P3B_service9.Text
        Lbl_P3B_service10.Text = P3B_service10.Text
        Lbl_P3B_service11.Text = P3B_service11.Text
        Lbl_P3B_service1p.Text = P3B_service1p.Text
        Lbl_P3B_service2p.Text = P3B_service2p.Text
        Lbl_P3B_service3p.Text = P3B_service3p.Text
        Lbl_P3B_service4p.Text = P3B_service4p.Text
        Lbl_P3B_service5p.Text = P3B_service5p.Text
        Lbl_P3B_service6p.Text = P3B_service6p.Text
        Lbl_P3B_service7p.Text = P3B_service7p.Text
        Lbl_P3B_service8p.Text = P3B_service8p.Text
        Lbl_P3B_service9p.Text = P3B_service9p.Text
        Lbl_P3B_service10p.Text = P3B_service10p.Text
        Lbl_P3B_service11p.Text = P3B_service11p.Text
        Lbl_P3B_service12p.Text = P3B_service12p.Text
        Lbl_P3B_Description.Text = Lbl_P3B_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P3B_name.Text = Lbl_P3B_name.Text
        P3B_price.Text = Lbl_P3B_price.Text
        P3B_pax.Text = Lbl_P3B_pax.Text
        P3B_entry1.Text = Lbl_P3B_entry1.Text
        P3B_entry2.Text = Lbl_P3B_entry2.Text
        P3B_entry3.Text = Lbl_P3B_entry3.Text
        P3B_entry4.Text = Lbl_P3B_entry4.Text
        P3B_entry5.Text = Lbl_P3B_entry5.Text
        P3B_entry6.Text = Lbl_P3B_entry6.Text
        P3B_entry7.Text = Lbl_P3B_entry7.Text
        P3B_entry8.Text = Lbl_P3B_entry8.Text
        P3B_entry9.Text = Lbl_P3B_entry9.Text
        P3B_entry10.Text = Lbl_P3B_entry10.Text
        P3B_entry11.Text = Lbl_P3B_entry11.Text
        P3B_entry12.Text = Lbl_P3B_entry12.Text
        P3B_add1.Text = Lbl_P3B_add1.Text
        P3B_add2.Text = Lbl_P3B_add2.Text
        P3B_add3.Text = Lbl_P3B_add3.Text
        P3B_add4.Text = Lbl_P3B_add4.Text
        P3B_add5.Text = Lbl_P3B_add5.Text
        P3B_add6.Text = Lbl_P3B_add6.Text
        P3B_add7.Text = Lbl_P3B_add7.Text
        P3B_add8.Text = Lbl_P3B_add8.Text
        P3B_add9.Text = Lbl_P3B_add9.Text
        P3B_add10.Text = Lbl_P3B_add10.Text
        P3B_add11.Text = Lbl_P3B_add11.Text
        P3B_add12.Text = Lbl_P3B_add12.Text
        P3B_add1p.Text = Lbl_P3B_add1p.Text
        P3B_add2p.Text = Lbl_P3B_add2p.Text
        P3B_add3p.Text = Lbl_P3B_add3p.Text
        P3B_add4p.Text = Lbl_P3B_add4p.Text
        P3B_add5p.Text = Lbl_P3B_add5p.Text
        P3B_add6p.Text = Lbl_P3B_add6p.Text
        P3B_add7p.Text = Lbl_P3B_add7p.Text
        P3B_add8p.Text = Lbl_P3B_add8p.Text
        P3B_add9p.Text = Lbl_P3B_add9p.Text
        P3B_add10p.Text = Lbl_P3B_add10p.Text
        P3B_add11p.Text = Lbl_P3B_add11p.Text
        P3B_add12p.Text = Lbl_P3B_add12p.Text
        P3B_inc1.Text = Lbl_P3B_inc1.Text
        P3B_inc2.Text = Lbl_P3B_inc2.Text
        P3B_inc3.Text = Lbl_P3B_inc3.Text
        P3B_inc4.Text = Lbl_P3B_inc4.Text
        P3B_inc5.Text = Lbl_P3B_inc5.Text
        P3B_inc6.Text = Lbl_P3B_inc6.Text
        P3B_inc7.Text = Lbl_P3B_inc7.Text
        P3B_inc8.Text = Lbl_P3B_inc8.Text
        P3B_inc9.Text = Lbl_P3B_inc9.Text
        P3B_inc10.Text = Lbl_P3B_inc10.Text
        P3B_inc11.Text = Lbl_P3B_inc11.Text
        P3B_inc12.Text = Lbl_P3B_inc12.Text
        P3B_inc13.Text = Lbl_P3B_inc13.Text
        P3B_inc14.Text = Lbl_P3B_inc14.Text
        P3B_inc15.Text = Lbl_P3B_inc15.Text
        P3B_inc16.Text = Lbl_P3B_inc16.Text
        P3B_inc17.Text = Lbl_P3B_inc17.Text
        P3B_inc18.Text = Lbl_P3B_inc18.Text
        P3B_service1.Text = Lbl_P3B_service1.Text
        P3B_service2.Text = Lbl_P3B_service2.Text
        P3B_service3.Text = Lbl_P3B_service3.Text
        P3B_service4.Text = Lbl_P3B_service4.Text
        P3B_service5.Text = Lbl_P3B_service5.Text
        P3B_service6.Text = Lbl_P3B_service6.Text
        P3B_service7.Text = Lbl_P3B_service7.Text
        P3B_service8.Text = Lbl_P3B_service8.Text
        P3B_service9.Text = Lbl_P3B_service9.Text
        P3B_service10.Text = Lbl_P3B_service10.Text
        P3B_service11.Text = Lbl_P3B_service11.Text
        P3B_service1p.Text = Lbl_P3B_service1p.Text
        P3B_service2p.Text = Lbl_P3B_service2p.Text
        P3B_service3p.Text = Lbl_P3B_service3p.Text
        P3B_service4p.Text = Lbl_P3B_service4p.Text
        P3B_service5p.Text = Lbl_P3B_service5p.Text
        P3B_service6p.Text = Lbl_P3B_service6p.Text
        P3B_service7p.Text = Lbl_P3B_service7p.Text
        P3B_service8p.Text = Lbl_P3B_service8p.Text
        P3B_service9p.Text = Lbl_P3B_service9p.Text
        P3B_service10p.Text = Lbl_P3B_service10p.Text
        P3B_service11p.Text = Lbl_P3B_service11p.Text
        P3B_service12p.Text = Lbl_P3B_service12p.Text
        P3B_what.Text = Lbl_P3B_what.Text
    End Sub

    Private Sub P1A_entry1_TextChanged(sender As Object, e As EventArgs) Handles P3B_entry1.TextChanged

    End Sub

    Private Sub P1A_entry2_TextChanged(sender As Object, e As EventArgs) Handles P3B_entry2.TextChanged

    End Sub

    Private Sub P1A_add6p_TextChanged(sender As Object, e As EventArgs) Handles P3B_add6p.TextChanged

    End Sub

    Private Sub Lbl_P1A_inc5_Click(sender As Object, e As EventArgs) Handles Lbl_P3B_inc5.Click

    End Sub

    Private Sub Lbl_P1A_service8_Click(sender As Object, e As EventArgs) Handles Lbl_P3B_service8.Click

    End Sub

    Private Sub P2A_entry11_TextChanged(sender As Object, e As EventArgs) Handles P3B_entry11.TextChanged

    End Sub

    Private Sub P2A_inc1_TextChanged(sender As Object, e As EventArgs) Handles P3B_inc1.TextChanged

    End Sub

    Private Sub Lbl_P3A_entry8_Click(sender As Object, e As EventArgs) Handles Lbl_P3B_entry8.Click

    End Sub

    Private Sub Lbl_P3A_inc16_Click(sender As Object, e As EventArgs) Handles Lbl_P3B_inc16.Click

    End Sub

    Private Sub P4A_service12p_TextChanged(sender As Object, e As EventArgs) Handles P3B_service12p.TextChanged

    End Sub

    Private Sub P2B_entry9_TextChanged(sender As Object, e As EventArgs) Handles P3B_entry9.TextChanged

    End Sub

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs)

    End Sub
End Class