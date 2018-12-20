Public Class PA2edit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1A2.Click
        Lbl_P2A_name.Text = P2A_name.Text
        Lbl_P2A_price.Text = P2A_price.Text
        Lbl_P2A_pax.Text = P2A_pax.Text
        Lbl_P2A_entry1.Text = P2A_entry1.Text
        Lbl_P2A_entry2.Text = P2A_entry2.Text
        Lbl_P2A_entry3.Text = P2A_entry3.Text
        Lbl_P2A_entry4.Text = P2A_entry4.Text
        Lbl_P2A_entry5.Text = P2A_entry5.Text
        Lbl_P2A_entry6.Text = P2A_entry6.Text
        Lbl_P2A_entry7.Text = P2A_entry7.Text
        Lbl_P2A_entry8.Text = P2A_entry8.Text
        Lbl_P2A_entry9.Text = P2A_entry9.Text
        Lbl_P2A_entry10.Text = P2A_entry10.Text
        Lbl_P2A_entry11.Text = P2A_entry11.Text
        Lbl_P2A_entry12.Text = P2A_entry12.Text
        Lbl_P2A_add1.Text = P2A_add1.Text
        Lbl_P2A_add2.Text = P2A_add2.Text
        Lbl_P2A_add3.Text = P2A_add3.Text
        Lbl_P2A_add4.Text = P2A_add4.Text
        Lbl_P2A_add5.Text = P2A_add5.Text
        Lbl_P2A_add6.Text = P2A_add6.Text
        Lbl_P2A_add7.Text = P2A_add7.Text
        Lbl_P2A_add8.Text = P2A_add8.Text
        Lbl_P2A_add9.Text = P2A_add9.Text
        Lbl_P2A_add10.Text = P2A_add10.Text
        Lbl_P2A_add11.Text = P2A_add11.Text
        Lbl_P2A_add12.Text = P2A_add12.Text
        Lbl_P2A_add1p.Text = P2A_add1p.Text
        Lbl_P2A_add2p.Text = P2A_add2p.Text
        Lbl_P2A_add3p.Text = P2A_add3p.Text
        Lbl_P2A_add4p.Text = P2A_add4p.Text
        Lbl_P2A_add5p.Text = P2A_add5p.Text
        Lbl_P2A_add6p.Text = P2A_add6p.Text
        Lbl_P2A_add7p.Text = P2A_add7p.Text
        Lbl_P2A_add8p.Text = P2A_add8p.Text
        Lbl_P2A_add9p.Text = P2A_add9p.Text
        Lbl_P2A_add10p.Text = P2A_add10p.Text
        Lbl_P2A_add11p.Text = P2A_add11p.Text
        Lbl_P2A_add12p.Text = P2A_add12p.Text
        Lbl_P2A_inc1.Text = P2A_inc1.Text
        Lbl_P2A_inc2.Text = P2A_inc2.Text
        Lbl_P2A_inc3.Text = P2A_inc3.Text
        Lbl_P2A_inc4.Text = P2A_inc4.Text
        Lbl_P2A_inc5.Text = P2A_inc5.Text
        Lbl_P2A_inc6.Text = P2A_inc6.Text
        Lbl_P2A_inc7.Text = P2A_inc7.Text
        Lbl_P2A_inc8.Text = P2A_inc8.Text
        Lbl_P2A_inc9.Text = P2A_inc9.Text
        Lbl_P2A_inc10.Text = P2A_inc10.Text
        Lbl_P2A_inc11.Text = P2A_inc11.Text
        Lbl_P2A_inc12.Text = P2A_inc12.Text
        Lbl_P2A_inc13.Text = P2A_inc13.Text
        Lbl_P2A_inc14.Text = P2A_inc14.Text
        Lbl_P2A_inc15.Text = P2A_inc15.Text
        Lbl_P2A_inc16.Text = P2A_inc16.Text
        Lbl_P2A_inc17.Text = P2A_inc17.Text
        Lbl_P2A_inc18.Text = P2A_inc18.Text
        Lbl_P2A_service1.Text = P2A_service1.Text
        Lbl_P2A_service2.Text = P2A_service2.Text
        Lbl_P2A_service3.Text = P2A_service3.Text
        Lbl_P2A_service4.Text = P2A_service4.Text
        Lbl_P2A_service5.Text = P2A_service5.Text
        Lbl_P2A_service6.Text = P2A_service6.Text
        Lbl_P2A_service7.Text = P2A_service7.Text
        Lbl_P2A_service8.Text = P2A_service8.Text
        Lbl_P2A_service9.Text = P2A_service9.Text
        Lbl_P2A_service10.Text = P2A_service10.Text
        Lbl_P2A_service11.Text = P2A_service11.Text
        Lbl_P2A_service1p.Text = P2A_service1p.Text
        Lbl_P2A_service2p.Text = P2A_service2p.Text
        Lbl_P2A_service3p.Text = P2A_service3p.Text
        Lbl_P2A_service4p.Text = P2A_service4p.Text
        Lbl_P2A_service5p.Text = P2A_service5p.Text
        Lbl_P2A_service6p.Text = P2A_service6p.Text
        Lbl_P2A_service7p.Text = P2A_service7p.Text
        Lbl_P2A_service8p.Text = P2A_service8p.Text
        Lbl_P2A_service9p.Text = P2A_service9p.Text
        Lbl_P2A_service10p.Text = P2A_service10p.Text
        Lbl_P2A_service11p.Text = P2A_service11p.Text
        Lbl_P2A_service12p.Text = P2A_service12p.Text
        Lbl_P2A_Description.Text = Lbl_P2A_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P2A_name.Text = Lbl_P2A_name.Text
        P2A_price.Text = Lbl_P2A_price.Text
        P2A_pax.Text = Lbl_P2A_pax.Text
        P2A_entry1.Text = Lbl_P2A_entry1.Text
        P2A_entry2.Text = Lbl_P2A_entry2.Text
        P2A_entry3.Text = Lbl_P2A_entry3.Text
        P2A_entry4.Text = Lbl_P2A_entry4.Text
        P2A_entry5.Text = Lbl_P2A_entry5.Text
        P2A_entry6.Text = Lbl_P2A_entry6.Text
        P2A_entry7.Text = Lbl_P2A_entry7.Text
        P2A_entry8.Text = Lbl_P2A_entry8.Text
        P2A_entry9.Text = Lbl_P2A_entry9.Text
        P2A_entry10.Text = Lbl_P2A_entry10.Text
        P2A_entry11.Text = Lbl_P2A_entry11.Text
        P2A_entry12.Text = Lbl_P2A_entry12.Text
        P2A_add1.Text = Lbl_P2A_add1.Text
        P2A_add2.Text = Lbl_P2A_add2.Text
        P2A_add3.Text = Lbl_P2A_add3.Text
        P2A_add4.Text = Lbl_P2A_add4.Text
        P2A_add5.Text = Lbl_P2A_add5.Text
        P2A_add6.Text = Lbl_P2A_add6.Text
        P2A_add7.Text = Lbl_P2A_add7.Text
        P2A_add8.Text = Lbl_P2A_add8.Text
        P2A_add9.Text = Lbl_P2A_add9.Text
        P2A_add10.Text = Lbl_P2A_add10.Text
        P2A_add11.Text = Lbl_P2A_add11.Text
        P2A_add12.Text = Lbl_P2A_add12.Text
        P2A_add1p.Text = Lbl_P2A_add1p.Text
        P2A_add2p.Text = Lbl_P2A_add2p.Text
        P2A_add3p.Text = Lbl_P2A_add3p.Text
        P2A_add4p.Text = Lbl_P2A_add4p.Text
        P2A_add5p.Text = Lbl_P2A_add5p.Text
        P2A_add6p.Text = Lbl_P2A_add6p.Text
        P2A_add7p.Text = Lbl_P2A_add7p.Text
        P2A_add8p.Text = Lbl_P2A_add8p.Text
        P2A_add9p.Text = Lbl_P2A_add9p.Text
        P2A_add10p.Text = Lbl_P2A_add10p.Text
        P2A_add11p.Text = Lbl_P2A_add11p.Text
        P2A_add12p.Text = Lbl_P2A_add12p.Text
        P2A_inc1.Text = Lbl_P2A_inc1.Text
        P2A_inc2.Text = Lbl_P2A_inc2.Text
        P2A_inc3.Text = Lbl_P2A_inc3.Text
        P2A_inc4.Text = Lbl_P2A_inc4.Text
        P2A_inc5.Text = Lbl_P2A_inc5.Text
        P2A_inc6.Text = Lbl_P2A_inc6.Text
        P2A_inc7.Text = Lbl_P2A_inc7.Text
        P2A_inc8.Text = Lbl_P2A_inc8.Text
        P2A_inc9.Text = Lbl_P2A_inc9.Text
        P2A_inc10.Text = Lbl_P2A_inc10.Text
        P2A_inc11.Text = Lbl_P2A_inc11.Text
        P2A_inc12.Text = Lbl_P2A_inc12.Text
        P2A_inc13.Text = Lbl_P2A_inc13.Text
        P2A_inc14.Text = Lbl_P2A_inc14.Text
        P2A_inc15.Text = Lbl_P2A_inc15.Text
        P2A_inc16.Text = Lbl_P2A_inc16.Text
        P2A_inc17.Text = Lbl_P2A_inc17.Text
        P2A_inc18.Text = Lbl_P2A_inc18.Text
        P2A_service1.Text = Lbl_P2A_service1.Text
        P2A_service2.Text = Lbl_P2A_service2.Text
        P2A_service3.Text = Lbl_P2A_service3.Text
        P2A_service4.Text = Lbl_P2A_service4.Text
        P2A_service5.Text = Lbl_P2A_service5.Text
        P2A_service6.Text = Lbl_P2A_service6.Text
        P2A_service7.Text = Lbl_P2A_service7.Text
        P2A_service8.Text = Lbl_P2A_service8.Text
        P2A_service9.Text = Lbl_P2A_service9.Text
        P2A_service10.Text = Lbl_P2A_service10.Text
        P2A_service11.Text = Lbl_P2A_service11.Text
        P2A_service1p.Text = Lbl_P2A_service1p.Text
        P2A_service2p.Text = Lbl_P2A_service2p.Text
        P2A_service3p.Text = Lbl_P2A_service3p.Text
        P2A_service4p.Text = Lbl_P2A_service4p.Text
        P2A_service5p.Text = Lbl_P2A_service5p.Text
        P2A_service6p.Text = Lbl_P2A_service6p.Text
        P2A_service7p.Text = Lbl_P2A_service7p.Text
        P2A_service8p.Text = Lbl_P2A_service8p.Text
        P2A_service9p.Text = Lbl_P2A_service9p.Text
        P2A_service10p.Text = Lbl_P2A_service10p.Text
        P2A_service11p.Text = Lbl_P2A_service11p.Text
        P2A_service12p.Text = Lbl_P2A_service12p.Text
        P2A_what.Text = Lbl_P2A_what.Text
    End Sub

    Private Sub P1A_entry1_TextChanged(sender As Object, e As EventArgs) Handles P2A_entry1.TextChanged

    End Sub

    Private Sub P1A_entry2_TextChanged(sender As Object, e As EventArgs) Handles P2A_entry2.TextChanged

    End Sub

    Private Sub P1A_add6p_TextChanged(sender As Object, e As EventArgs) Handles P2A_add6p.TextChanged

    End Sub

    Private Sub Lbl_P1A_inc5_Click(sender As Object, e As EventArgs) Handles Lbl_P2A_inc5.Click

    End Sub

    Private Sub Lbl_P1A_service8_Click(sender As Object, e As EventArgs) Handles Lbl_P2A_service8.Click

    End Sub
End Class