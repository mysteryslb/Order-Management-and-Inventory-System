Public Class PE3edit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1E3.Click
        Lbl_P3E_name.Text = P3E_name.Text
        Lbl_P3E_price.Text = P3E_price.Text
        Lbl_P3E_pax.Text = P3E_pax.Text
        Lbl_P3E_entry1.Text = P3E_entry1.Text
        Lbl_P3E_entry2.Text = P3E_entry2.Text
        Lbl_P3E_entry3.Text = P3E_entry3.Text
        Lbl_P3E_entry4.Text = P3E_entry4.Text
        Lbl_P3E_entry5.Text = P3E_entry5.Text
        Lbl_P3E_entry6.Text = P3E_entry6.Text
        Lbl_P3E_entry7.Text = P3E_entry7.Text
        Lbl_P3E_entry8.Text = P3E_entry8.Text
        Lbl_P3E_entry9.Text = P3E_entry9.Text
        Lbl_P3E_entry10.Text = P3E_entry10.Text
        Lbl_P3E_entry11.Text = P3E_entry11.Text
        Lbl_P3E_entry12.Text = P3E_entry12.Text
        Lbl_P3E_add1.Text = P3E_add1.Text
        Lbl_P3E_add2.Text = P3E_add2.Text
        Lbl_P3E_add3.Text = P3E_add3.Text
        Lbl_P3E_add4.Text = P3E_add4.Text
        Lbl_P3E_add5.Text = P3E_add5.Text
        Lbl_P3E_add6.Text = P3E_add6.Text
        Lbl_P3E_add7.Text = P3E_add7.Text
        Lbl_P3E_add8.Text = P3E_add8.Text
        Lbl_P3E_add9.Text = P3E_add9.Text
        Lbl_P3E_add10.Text = P3E_add10.Text
        Lbl_P3E_add11.Text = P3E_add11.Text
        Lbl_P3E_add12.Text = P3E_add12.Text
        Lbl_P3E_add1p.Text = P3E_add1p.Text
        Lbl_P3E_add2p.Text = P3E_add2p.Text
        Lbl_P3E_add3p.Text = P3E_add3p.Text
        Lbl_P3E_add4p.Text = P3E_add4p.Text
        Lbl_P3E_add5p.Text = P3E_add5p.Text
        Lbl_P3E_add6p.Text = P3E_add6p.Text
        Lbl_P3E_add7p.Text = P3E_add7p.Text
        Lbl_P3E_add8p.Text = P3E_add8p.Text
        Lbl_P3E_add9p.Text = P3E_add9p.Text
        Lbl_P3E_add10p.Text = P3E_add10p.Text
        Lbl_P3E_add11p.Text = P3E_add11p.Text
        Lbl_P3E_add12p.Text = P3E_add12p.Text
        Lbl_P3E_inc1.Text = P3E_inc1.Text
        Lbl_P3E_inc2.Text = P3E_inc2.Text
        Lbl_P3E_inc3.Text = P3E_inc3.Text
        Lbl_P3E_inc4.Text = P3E_inc4.Text
        Lbl_P3E_inc5.Text = P3E_inc5.Text
        Lbl_P3E_inc6.Text = P3E_inc6.Text
        Lbl_P3E_inc7.Text = P3E_inc7.Text
        Lbl_P3E_inc8.Text = P3E_inc8.Text
        Lbl_P3E_inc9.Text = P3E_inc9.Text
        Lbl_P3E_inc10.Text = P3E_inc10.Text
        Lbl_P3E_inc11.Text = P3E_inc11.Text
        Lbl_P3E_inc12.Text = P3E_inc12.Text
        Lbl_P3E_inc13.Text = P3E_inc13.Text
        Lbl_P3E_inc14.Text = P3E_inc14.Text
        Lbl_P3E_inc15.Text = P3E_inc15.Text
        Lbl_P3E_inc16.Text = P3E_inc16.Text
        Lbl_P3E_inc17.Text = P3E_inc17.Text
        Lbl_P3E_inc18.Text = P3E_inc18.Text
        Lbl_P3E_service1.Text = P3E_service1.Text
        Lbl_P3E_service2.Text = P3E_service2.Text
        Lbl_P3E_service3.Text = P3E_service3.Text
        Lbl_P3E_service4.Text = P3E_service4.Text
        Lbl_P3E_service5.Text = P3E_service5.Text
        Lbl_P3E_service6.Text = P3E_service6.Text
        Lbl_P3E_service7.Text = P3E_service7.Text
        Lbl_P3E_service8.Text = P3E_service8.Text
        Lbl_P3E_service9.Text = P3E_service9.Text
        Lbl_P3E_service10.Text = P3E_service10.Text
        Lbl_P3E_service11.Text = P3E_service11.Text
        Lbl_P3E_service1p.Text = P3E_service1p.Text
        Lbl_P3E_service2p.Text = P3E_service2p.Text
        Lbl_P3E_service3p.Text = P3E_service3p.Text
        Lbl_P3E_service4p.Text = P3E_service4p.Text
        Lbl_P3E_service5p.Text = P3E_service5p.Text
        Lbl_P3E_service6p.Text = P3E_service6p.Text
        Lbl_P3E_service7p.Text = P3E_service7p.Text
        Lbl_P3E_service8p.Text = P3E_service8p.Text
        Lbl_P3E_service9p.Text = P3E_service9p.Text
        Lbl_P3E_service10p.Text = P3E_service10p.Text
        Lbl_P3E_service11p.Text = P3E_service11p.Text
        Lbl_P3E_service12p.Text = P3E_service12p.Text
        Lbl_P3E_Description.Text = Lbl_P3E_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P3E_name.Text = Lbl_P3E_name.Text
        P3E_price.Text = Lbl_P3E_price.Text
        P3E_pax.Text = Lbl_P3E_pax.Text
        P3E_entry1.Text = Lbl_P3E_entry1.Text
        P3E_entry2.Text = Lbl_P3E_entry2.Text
        P3E_entry3.Text = Lbl_P3E_entry3.Text
        P3E_entry4.Text = Lbl_P3E_entry4.Text
        P3E_entry5.Text = Lbl_P3E_entry5.Text
        P3E_entry6.Text = Lbl_P3E_entry6.Text
        P3E_entry7.Text = Lbl_P3E_entry7.Text
        P3E_entry8.Text = Lbl_P3E_entry8.Text
        P3E_entry9.Text = Lbl_P3E_entry9.Text
        P3E_entry10.Text = Lbl_P3E_entry10.Text
        P3E_entry11.Text = Lbl_P3E_entry11.Text
        P3E_entry12.Text = Lbl_P3E_entry12.Text
        P3E_add1.Text = Lbl_P3E_add1.Text
        P3E_add2.Text = Lbl_P3E_add2.Text
        P3E_add3.Text = Lbl_P3E_add3.Text
        P3E_add4.Text = Lbl_P3E_add4.Text
        P3E_add5.Text = Lbl_P3E_add5.Text
        P3E_add6.Text = Lbl_P3E_add6.Text
        P3E_add7.Text = Lbl_P3E_add7.Text
        P3E_add8.Text = Lbl_P3E_add8.Text
        P3E_add9.Text = Lbl_P3E_add9.Text
        P3E_add10.Text = Lbl_P3E_add10.Text
        P3E_add11.Text = Lbl_P3E_add11.Text
        P3E_add12.Text = Lbl_P3E_add12.Text
        P3E_add1p.Text = Lbl_P3E_add1p.Text
        P3E_add2p.Text = Lbl_P3E_add2p.Text
        P3E_add3p.Text = Lbl_P3E_add3p.Text
        P3E_add4p.Text = Lbl_P3E_add4p.Text
        P3E_add5p.Text = Lbl_P3E_add5p.Text
        P3E_add6p.Text = Lbl_P3E_add6p.Text
        P3E_add7p.Text = Lbl_P3E_add7p.Text
        P3E_add8p.Text = Lbl_P3E_add8p.Text
        P3E_add9p.Text = Lbl_P3E_add9p.Text
        P3E_add10p.Text = Lbl_P3E_add10p.Text
        P3E_add11p.Text = Lbl_P3E_add11p.Text
        P3E_add12p.Text = Lbl_P3E_add12p.Text
        P3E_inc1.Text = Lbl_P3E_inc1.Text
        P3E_inc2.Text = Lbl_P3E_inc2.Text
        P3E_inc3.Text = Lbl_P3E_inc3.Text
        P3E_inc4.Text = Lbl_P3E_inc4.Text
        P3E_inc5.Text = Lbl_P3E_inc5.Text
        P3E_inc6.Text = Lbl_P3E_inc6.Text
        P3E_inc7.Text = Lbl_P3E_inc7.Text
        P3E_inc8.Text = Lbl_P3E_inc8.Text
        P3E_inc9.Text = Lbl_P3E_inc9.Text
        P3E_inc10.Text = Lbl_P3E_inc10.Text
        P3E_inc11.Text = Lbl_P3E_inc11.Text
        P3E_inc12.Text = Lbl_P3E_inc12.Text
        P3E_inc13.Text = Lbl_P3E_inc13.Text
        P3E_inc14.Text = Lbl_P3E_inc14.Text
        P3E_inc15.Text = Lbl_P3E_inc15.Text
        P3E_inc16.Text = Lbl_P3E_inc16.Text
        P3E_inc17.Text = Lbl_P3E_inc17.Text
        P3E_inc18.Text = Lbl_P3E_inc18.Text
        P3E_service1.Text = Lbl_P3E_service1.Text
        P3E_service2.Text = Lbl_P3E_service2.Text
        P3E_service3.Text = Lbl_P3E_service3.Text
        P3E_service4.Text = Lbl_P3E_service4.Text
        P3E_service5.Text = Lbl_P3E_service5.Text
        P3E_service6.Text = Lbl_P3E_service6.Text
        P3E_service7.Text = Lbl_P3E_service7.Text
        P3E_service8.Text = Lbl_P3E_service8.Text
        P3E_service9.Text = Lbl_P3E_service9.Text
        P3E_service10.Text = Lbl_P3E_service10.Text
        P3E_service11.Text = Lbl_P3E_service11.Text
        P3E_service1p.Text = Lbl_P3E_service1p.Text
        P3E_service2p.Text = Lbl_P3E_service2p.Text
        P3E_service3p.Text = Lbl_P3E_service3p.Text
        P3E_service4p.Text = Lbl_P3E_service4p.Text
        P3E_service5p.Text = Lbl_P3E_service5p.Text
        P3E_service6p.Text = Lbl_P3E_service6p.Text
        P3E_service7p.Text = Lbl_P3E_service7p.Text
        P3E_service8p.Text = Lbl_P3E_service8p.Text
        P3E_service9p.Text = Lbl_P3E_service9p.Text
        P3E_service10p.Text = Lbl_P3E_service10p.Text
        P3E_service11p.Text = Lbl_P3E_service11p.Text
        P3E_service12p.Text = Lbl_P3E_service12p.Text
        P3E_what.Text = Lbl_P3E_what.Text
    End Sub

    Private Sub Lbl_P1A_service10p_Click(sender As Object, e As EventArgs) Handles Lbl_P3E_service10p.Click

    End Sub

    Private Sub Lbl_P1A_service7p_Click(sender As Object, e As EventArgs) Handles Lbl_P3E_service7p.Click

    End Sub

    Private Sub P3D_inc13_TextChanged(sender As Object, e As EventArgs) Handles P3E_inc13.TextChanged

    End Sub

    Private Sub Lbl_P1E_price_Click(sender As Object, e As EventArgs) Handles Lbl_P3E_price.Click

    End Sub
End Class