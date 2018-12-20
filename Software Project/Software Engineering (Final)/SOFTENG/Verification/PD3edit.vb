Public Class PD3edit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1D3.Click
        Lbl_P3D_name.Text = P3D_name.Text
        Lbl_P3D_price.Text = P3D_price.Text
        Lbl_P3D_pax.Text = P3D_pax.Text
        Lbl_P3D_entry1.Text = P3D_entry1.Text
        Lbl_P3D_entry2.Text = P3D_entry2.Text
        Lbl_P3D_entry3.Text = P3D_entry3.Text
        Lbl_P3D_entry4.Text = P3D_entry4.Text
        Lbl_P3D_entry5.Text = P3D_entry5.Text
        Lbl_P3D_entry6.Text = P3D_entry6.Text
        Lbl_P3D_entry7.Text = P3D_entry7.Text
        Lbl_P3D_entry8.Text = P3D_entry8.Text
        Lbl_P3D_entry9.Text = P3D_entry9.Text
        Lbl_P3D_entry10.Text = P3D_entry10.Text
        Lbl_P3D_entry11.Text = P3D_entry11.Text
        Lbl_P3D_entry12.Text = P3D_entry12.Text
        Lbl_P3D_add1.Text = P3D_add1.Text
        Lbl_P3D_add2.Text = P3D_add2.Text
        Lbl_P3D_add3.Text = P3D_add3.Text
        Lbl_P3D_add4.Text = P3D_add4.Text
        Lbl_P3D_add5.Text = P3D_add5.Text
        Lbl_P3D_add6.Text = P3D_add6.Text
        Lbl_P3D_add7.Text = P3D_add7.Text
        Lbl_P3D_add8.Text = P3D_add8.Text
        Lbl_P3D_add9.Text = P3D_add9.Text
        Lbl_P3D_add10.Text = P3D_add10.Text
        Lbl_P3D_add11.Text = P3D_add11.Text
        Lbl_P3D_add12.Text = P3D_add12.Text
        Lbl_P3D_add1p.Text = P3D_add1p.Text
        Lbl_P3D_add2p.Text = P3D_add2p.Text
        Lbl_P3D_add3p.Text = P3D_add3p.Text
        Lbl_P3D_add4p.Text = P3D_add4p.Text
        Lbl_P3D_add5p.Text = P3D_add5p.Text
        Lbl_P3D_add6p.Text = P3D_add6p.Text
        Lbl_P3D_add7p.Text = P3D_add7p.Text
        Lbl_P3D_add8p.Text = P3D_add8p.Text
        Lbl_P3D_add9p.Text = P3D_add9p.Text
        Lbl_P3D_add10p.Text = P3D_add10p.Text
        Lbl_P3D_add11p.Text = P3D_add11p.Text
        Lbl_P3D_add12p.Text = P3D_add12p.Text
        Lbl_P3D_inc1.Text = P3D_inc1.Text
        Lbl_P3D_inc2.Text = P3D_inc2.Text
        Lbl_P3D_inc3.Text = P3D_inc3.Text
        Lbl_P3D_inc4.Text = P3D_inc4.Text
        Lbl_P3D_inc5.Text = P3D_inc5.Text
        Lbl_P3D_inc6.Text = P3D_inc6.Text
        Lbl_P3D_inc7.Text = P3D_inc7.Text
        Lbl_P3D_inc8.Text = P3D_inc8.Text
        Lbl_P3D_inc9.Text = P3D_inc9.Text
        Lbl_P3D_inc10.Text = P3D_inc10.Text
        Lbl_P3D_inc11.Text = P3D_inc11.Text
        Lbl_P3D_inc12.Text = P3D_inc12.Text
        Lbl_P3D_inc13.Text = P3D_inc13.Text
        Lbl_P3D_inc14.Text = P3D_inc14.Text
        Lbl_P3D_inc15.Text = P3D_inc15.Text
        Lbl_P3D_inc16.Text = P3D_inc16.Text
        Lbl_P3D_inc17.Text = P3D_inc17.Text
        Lbl_P3D_inc18.Text = P3D_inc18.Text
        Lbl_P3D_service1.Text = P3D_service1.Text
        Lbl_P3D_service2.Text = P3D_service2.Text
        Lbl_P3D_service3.Text = P3D_service3.Text
        Lbl_P3D_service4.Text = P3D_service4.Text
        Lbl_P3D_service5.Text = P3D_service5.Text
        Lbl_P3D_service6.Text = P3D_service6.Text
        Lbl_P3D_service7.Text = P3D_service7.Text
        Lbl_P3D_service8.Text = P3D_service8.Text
        Lbl_P3D_service9.Text = P3D_service9.Text
        Lbl_P3D_service10.Text = P3D_service10.Text
        Lbl_P3D_service11.Text = P3D_service11.Text
        Lbl_P3D_service1p.Text = P3D_service1p.Text
        Lbl_P3D_service2p.Text = P3D_service2p.Text
        Lbl_P3D_service3p.Text = P3D_service3p.Text
        Lbl_P3D_service4p.Text = P3D_service4p.Text
        Lbl_P3D_service5p.Text = P3D_service5p.Text
        Lbl_P3D_service6p.Text = P3D_service6p.Text
        Lbl_P3D_service7p.Text = P3D_service7p.Text
        Lbl_P3D_service8p.Text = P3D_service8p.Text
        Lbl_P3D_service9p.Text = P3D_service9p.Text
        Lbl_P3D_service10p.Text = P3D_service10p.Text
        Lbl_P3D_service11p.Text = P3D_service11p.Text
        Lbl_P3D_service12p.Text = P3D_service12p.Text
        Lbl_P3D_Description.Text = Lbl_P3D_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P3D_name.Text = Lbl_P3D_name.Text
        P3D_price.Text = Lbl_P3D_price.Text
        P3D_pax.Text = Lbl_P3D_pax.Text
        P3D_entry1.Text = Lbl_P3D_entry1.Text
        P3D_entry2.Text = Lbl_P3D_entry2.Text
        P3D_entry3.Text = Lbl_P3D_entry3.Text
        P3D_entry4.Text = Lbl_P3D_entry4.Text
        P3D_entry5.Text = Lbl_P3D_entry5.Text
        P3D_entry6.Text = Lbl_P3D_entry6.Text
        P3D_entry7.Text = Lbl_P3D_entry7.Text
        P3D_entry8.Text = Lbl_P3D_entry8.Text
        P3D_entry9.Text = Lbl_P3D_entry9.Text
        P3D_entry10.Text = Lbl_P3D_entry10.Text
        P3D_entry11.Text = Lbl_P3D_entry11.Text
        P3D_entry12.Text = Lbl_P3D_entry12.Text
        P3D_add1.Text = Lbl_P3D_add1.Text
        P3D_add2.Text = Lbl_P3D_add2.Text
        P3D_add3.Text = Lbl_P3D_add3.Text
        P3D_add4.Text = Lbl_P3D_add4.Text
        P3D_add5.Text = Lbl_P3D_add5.Text
        P3D_add6.Text = Lbl_P3D_add6.Text
        P3D_add7.Text = Lbl_P3D_add7.Text
        P3D_add8.Text = Lbl_P3D_add8.Text
        P3D_add9.Text = Lbl_P3D_add9.Text
        P3D_add10.Text = Lbl_P3D_add10.Text
        P3D_add11.Text = Lbl_P3D_add11.Text
        P3D_add12.Text = Lbl_P3D_add12.Text
        P3D_add1p.Text = Lbl_P3D_add1p.Text
        P3D_add2p.Text = Lbl_P3D_add2p.Text
        P3D_add3p.Text = Lbl_P3D_add3p.Text
        P3D_add4p.Text = Lbl_P3D_add4p.Text
        P3D_add5p.Text = Lbl_P3D_add5p.Text
        P3D_add6p.Text = Lbl_P3D_add6p.Text
        P3D_add7p.Text = Lbl_P3D_add7p.Text
        P3D_add8p.Text = Lbl_P3D_add8p.Text
        P3D_add9p.Text = Lbl_P3D_add9p.Text
        P3D_add10p.Text = Lbl_P3D_add10p.Text
        P3D_add11p.Text = Lbl_P3D_add11p.Text
        P3D_add12p.Text = Lbl_P3D_add12p.Text
        P3D_inc1.Text = Lbl_P3D_inc1.Text
        P3D_inc2.Text = Lbl_P3D_inc2.Text
        P3D_inc3.Text = Lbl_P3D_inc3.Text
        P3D_inc4.Text = Lbl_P3D_inc4.Text
        P3D_inc5.Text = Lbl_P3D_inc5.Text
        P3D_inc6.Text = Lbl_P3D_inc6.Text
        P3D_inc7.Text = Lbl_P3D_inc7.Text
        P3D_inc8.Text = Lbl_P3D_inc8.Text
        P3D_inc9.Text = Lbl_P3D_inc9.Text
        P3D_inc10.Text = Lbl_P3D_inc10.Text
        P3D_inc11.Text = Lbl_P3D_inc11.Text
        P3D_inc12.Text = Lbl_P3D_inc12.Text
        P3D_inc13.Text = Lbl_P3D_inc13.Text
        P3D_inc14.Text = Lbl_P3D_inc14.Text
        P3D_inc15.Text = Lbl_P3D_inc15.Text
        P3D_inc16.Text = Lbl_P3D_inc16.Text
        P3D_inc17.Text = Lbl_P3D_inc17.Text
        P3D_inc18.Text = Lbl_P3D_inc18.Text
        P3D_service1.Text = Lbl_P3D_service1.Text
        P3D_service2.Text = Lbl_P3D_service2.Text
        P3D_service3.Text = Lbl_P3D_service3.Text
        P3D_service4.Text = Lbl_P3D_service4.Text
        P3D_service5.Text = Lbl_P3D_service5.Text
        P3D_service6.Text = Lbl_P3D_service6.Text
        P3D_service7.Text = Lbl_P3D_service7.Text
        P3D_service8.Text = Lbl_P3D_service8.Text
        P3D_service9.Text = Lbl_P3D_service9.Text
        P3D_service10.Text = Lbl_P3D_service10.Text
        P3D_service11.Text = Lbl_P3D_service11.Text
        P3D_service1p.Text = Lbl_P3D_service1p.Text
        P3D_service2p.Text = Lbl_P3D_service2p.Text
        P3D_service3p.Text = Lbl_P3D_service3p.Text
        P3D_service4p.Text = Lbl_P3D_service4p.Text
        P3D_service5p.Text = Lbl_P3D_service5p.Text
        P3D_service6p.Text = Lbl_P3D_service6p.Text
        P3D_service7p.Text = Lbl_P3D_service7p.Text
        P3D_service8p.Text = Lbl_P3D_service8p.Text
        P3D_service9p.Text = Lbl_P3D_service9p.Text
        P3D_service10p.Text = Lbl_P3D_service10p.Text
        P3D_service11p.Text = Lbl_P3D_service11p.Text
        P3D_service12p.Text = Lbl_P3D_service12p.Text
        P3D_what.Text = Lbl_P3D_what.Text
    End Sub

    Private Sub Lbl_P1A_service10p_Click(sender As Object, e As EventArgs) Handles Lbl_P3D_service10p.Click

    End Sub

    Private Sub Lbl_P1A_service7p_Click(sender As Object, e As EventArgs) Handles Lbl_P3D_service7p.Click

    End Sub

    Private Sub P3D_inc13_TextChanged(sender As Object, e As EventArgs) Handles P3D_inc13.TextChanged

    End Sub
End Class