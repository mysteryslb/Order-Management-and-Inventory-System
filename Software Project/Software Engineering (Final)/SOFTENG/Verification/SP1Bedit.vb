Public Class SP1Bedit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1SP1B.Click
        Lbl_SP1B_name.Text = SP1B_name.Text
        Lbl_SP1B_price.Text = SP1B_price.Text
        Lbl_SP1B_pax.Text = SP1B_pax.Text
        Lbl_SP1B_entry1.Text = SP1B_entry1.Text
        Lbl_SP1B_entry2.Text = SP1B_entry2.Text
        Lbl_SP1B_entry3.Text = SP1B_entry3.Text
        Lbl_SP1B_entry4.Text = SP1B_entry4.Text
        Lbl_SP1B_entry5.Text = SP1B_entry5.Text
        Lbl_SP1B_entry6.Text = SP1B_entry6.Text
        Lbl_SP1B_entry7.Text = SP1B_entry7.Text
        Lbl_SP1B_entry8.Text = SP1B_entry8.Text
        Lbl_SP1B_entry9.Text = SP1B_entry9.Text
        Lbl_SP1B_entry10.Text = SP1B_entry10.Text
        Lbl_SP1B_entry11.Text = SP1B_entry11.Text
        Lbl_SP1B_entry12.Text = SP1B_entry12.Text
        Lbl_SP1B_add1.Text = SP1B_add1.Text
        Lbl_SP1B_adF1.Text = SP1B_adF1.Text
        Lbl_SP1B_add3.Text = SP1B_add3.Text
        Lbl_SP1B_add4.Text = SP1B_add4.Text
        Lbl_SP1B_add5.Text = SP1B_add5.Text
        Lbl_SP1B_add6.Text = SP1B_add6.Text
        Lbl_SP1B_add7.Text = SP1B_add7.Text
        Lbl_SP1B_add8.Text = SP1B_add8.Text
        Lbl_SP1B_add9.Text = SP1B_add9.Text
        Lbl_SP1B_add10.Text = SP1B_add10.Text
        Lbl_SP1B_add11.Text = SP1B_add11.Text
        Lbl_SP1B_add12.Text = SP1B_add12.Text
        Lbl_SP1B_add1p.Text = SP1B_add1p.Text
        Lbl_SP1B_adF1p.Text = SP1B_adF1p.Text
        Lbl_SP1B_add3p.Text = SP1B_add3p.Text
        Lbl_SP1B_add4p.Text = SP1B_add4p.Text
        Lbl_SP1B_add5p.Text = SP1B_add5p.Text
        Lbl_SP1B_add6p.Text = SP1B_add6p.Text
        Lbl_SP1B_add7p.Text = SP1B_add7p.Text
        Lbl_SP1B_add8p.Text = SP1B_add8p.Text
        Lbl_SP1B_add9p.Text = SP1B_add9p.Text
        Lbl_SP1B_add10p.Text = SP1B_add10p.Text
        Lbl_SP1B_add11p.Text = SP1B_add11p.Text
        Lbl_SP1B_add12p.Text = SP1B_add12p.Text
        Lbl_SP1B_inc1.Text = SP1B_inc1.Text
        Lbl_SP1B_inc2.Text = SP1B_inc2.Text
        Lbl_SP1B_inc3.Text = SP1B_inc3.Text
        Lbl_SP1B_inc4.Text = SP1B_inc4.Text
        Lbl_SP1B_inc5.Text = SP1B_inc5.Text
        Lbl_SP1B_inc6.Text = SP1B_inc6.Text
        Lbl_SP1B_inc7.Text = SP1B_inc7.Text
        Lbl_SP1B_inc8.Text = SP1B_inc8.Text
        Lbl_SP1B_inc9.Text = SP1B_inc9.Text
        Lbl_SP1B_inc10.Text = SP1B_inc10.Text
        Lbl_SP1B_inc11.Text = SP1B_inc11.Text
        Lbl_SP1B_inc12.Text = SP1B_inc12.Text
        Lbl_SP1B_inc13.Text = SP1B_inc13.Text
        Lbl_SP1B_inc14.Text = SP1B_inc14.Text
        Lbl_SP1B_inc15.Text = SP1B_inc15.Text
        Lbl_SP1B_inc16.Text = SP1B_inc16.Text
        Lbl_SP1B_inc17.Text = SP1B_inc17.Text
        Lbl_SP1B_inc18.Text = SP1B_inc18.Text
        Lbl_SP1B_service1.Text = SP1B_service1.Text
        Lbl_SP1B_service2.Text = SP1B_service2.Text
        Lbl_SP1B_servicE3.Text = SP1B_servicE3.Text
        Lbl_SP1B_service4.Text = SP1B_service4.Text
        Lbl_SP1B_service5.Text = SP1B_service5.Text
        Lbl_SP1B_service6.Text = SP1B_service6.Text
        Lbl_SP1B_service7.Text = SP1B_service7.Text
        Lbl_SP1B_service8.Text = SP1B_service8.Text
        Lbl_SP1B_service9.Text = SP1B_service9.Text
        Lbl_SP1B_service10.Text = SP1B_service10.Text
        Lbl_SP1B_service11.Text = SP1B_service11.Text
        Lbl_SP1B_service1p.Text = SP1B_service1p.Text
        Lbl_SP1B_service2p.Text = SP1B_service2p.Text
        Lbl_SP1B_servicE3p.Text = SP1B_servicE3p.Text
        Lbl_SP1B_service4p.Text = SP1B_service4p.Text
        Lbl_SP1B_service5p.Text = SP1B_service5p.Text
        Lbl_SP1B_service6p.Text = SP1B_service6p.Text
        Lbl_SP1B_service7p.Text = SP1B_service7p.Text
        Lbl_SP1B_service8p.Text = SP1B_service8p.Text
        Lbl_SP1B_service9p.Text = SP1B_service9p.Text
        Lbl_SP1B_service10p.Text = SP1B_service10p.Text
        Lbl_SP1B_service11p.Text = SP1B_service11p.Text
        Lbl_SP1B_service12p.Text = SP1B_service12p.Text
        Lbl_SP1B_Description.Text = Lbl_SP1B_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SP1B_name.Text = Lbl_SP1B_name.Text
        SP1B_price.Text = Lbl_SP1B_price.Text
        SP1B_pax.Text = Lbl_SP1B_pax.Text
        SP1B_entry1.Text = Lbl_SP1B_entry1.Text
        SP1B_entry2.Text = Lbl_SP1B_entry2.Text
        SP1B_entry3.Text = Lbl_SP1B_entry3.Text
        SP1B_entry4.Text = Lbl_SP1B_entry4.Text
        SP1B_entry5.Text = Lbl_SP1B_entry5.Text
        SP1B_entry6.Text = Lbl_SP1B_entry6.Text
        SP1B_entry7.Text = Lbl_SP1B_entry7.Text
        SP1B_entry8.Text = Lbl_SP1B_entry8.Text
        SP1B_entry9.Text = Lbl_SP1B_entry9.Text
        SP1B_entry10.Text = Lbl_SP1B_entry10.Text
        SP1B_entry11.Text = Lbl_SP1B_entry11.Text
        SP1B_entry12.Text = Lbl_SP1B_entry12.Text
        SP1B_add1.Text = Lbl_SP1B_add1.Text
        SP1B_adF1.Text = Lbl_SP1B_adF1.Text
        SP1B_add3.Text = Lbl_SP1B_add3.Text
        SP1B_add4.Text = Lbl_SP1B_add4.Text
        SP1B_add5.Text = Lbl_SP1B_add5.Text
        SP1B_add6.Text = Lbl_SP1B_add6.Text
        SP1B_add7.Text = Lbl_SP1B_add7.Text
        SP1B_add8.Text = Lbl_SP1B_add8.Text
        SP1B_add9.Text = Lbl_SP1B_add9.Text
        SP1B_add10.Text = Lbl_SP1B_add10.Text
        SP1B_add11.Text = Lbl_SP1B_add11.Text
        SP1B_add12.Text = Lbl_SP1B_add12.Text
        SP1B_add1p.Text = Lbl_SP1B_add1p.Text
        SP1B_adF1p.Text = Lbl_SP1B_adF1p.Text
        SP1B_add3p.Text = Lbl_SP1B_add3p.Text
        SP1B_add4p.Text = Lbl_SP1B_add4p.Text
        SP1B_add5p.Text = Lbl_SP1B_add5p.Text
        SP1B_add6p.Text = Lbl_SP1B_add6p.Text
        SP1B_add7p.Text = Lbl_SP1B_add7p.Text
        SP1B_add8p.Text = Lbl_SP1B_add8p.Text
        SP1B_add9p.Text = Lbl_SP1B_add9p.Text
        SP1B_add10p.Text = Lbl_SP1B_add10p.Text
        SP1B_add11p.Text = Lbl_SP1B_add11p.Text
        SP1B_add12p.Text = Lbl_SP1B_add12p.Text
        SP1B_inc1.Text = Lbl_SP1B_inc1.Text
        SP1B_inc2.Text = Lbl_SP1B_inc2.Text
        SP1B_inc3.Text = Lbl_SP1B_inc3.Text
        SP1B_inc4.Text = Lbl_SP1B_inc4.Text
        SP1B_inc5.Text = Lbl_SP1B_inc5.Text
        SP1B_inc6.Text = Lbl_SP1B_inc6.Text
        SP1B_inc7.Text = Lbl_SP1B_inc7.Text
        SP1B_inc8.Text = Lbl_SP1B_inc8.Text
        SP1B_inc9.Text = Lbl_SP1B_inc9.Text
        SP1B_inc10.Text = Lbl_SP1B_inc10.Text
        SP1B_inc11.Text = Lbl_SP1B_inc11.Text
        SP1B_inc12.Text = Lbl_SP1B_inc12.Text
        SP1B_inc13.Text = Lbl_SP1B_inc13.Text
        SP1B_inc14.Text = Lbl_SP1B_inc14.Text
        SP1B_inc15.Text = Lbl_SP1B_inc15.Text
        SP1B_inc16.Text = Lbl_SP1B_inc16.Text
        SP1B_inc17.Text = Lbl_SP1B_inc17.Text
        SP1B_inc18.Text = Lbl_SP1B_inc18.Text
        SP1B_service1.Text = Lbl_SP1B_service1.Text
        SP1B_service2.Text = Lbl_SP1B_service2.Text
        SP1B_servicE3.Text = Lbl_SP1B_servicE3.Text
        SP1B_service4.Text = Lbl_SP1B_service4.Text
        SP1B_service5.Text = Lbl_SP1B_service5.Text
        SP1B_service6.Text = Lbl_SP1B_service6.Text
        SP1B_service7.Text = Lbl_SP1B_service7.Text
        SP1B_service8.Text = Lbl_SP1B_service8.Text
        SP1B_service9.Text = Lbl_SP1B_service9.Text
        SP1B_service10.Text = Lbl_SP1B_service10.Text
        SP1B_service11.Text = Lbl_SP1B_service11.Text
        SP1B_service1p.Text = Lbl_SP1B_service1p.Text
        SP1B_service2p.Text = Lbl_SP1B_service2p.Text
        SP1B_servicE3p.Text = Lbl_SP1B_servicE3p.Text
        SP1B_service4p.Text = Lbl_SP1B_service4p.Text
        SP1B_service5p.Text = Lbl_SP1B_service5p.Text
        SP1B_service6p.Text = Lbl_SP1B_service6p.Text
        SP1B_service7p.Text = Lbl_SP1B_service7p.Text
        SP1B_service8p.Text = Lbl_SP1B_service8p.Text
        SP1B_service9p.Text = Lbl_SP1B_service9p.Text
        SP1B_service10p.Text = Lbl_SP1B_service10p.Text
        SP1B_service11p.Text = Lbl_SP1B_service11p.Text
        SP1B_service12p.Text = Lbl_SP1B_service12p.Text
        SP1B_what.Text = Lbl_SP1B_what.Text
    End Sub

    Private Sub Lbl_P1B_service10p_Click(sender As Object, e As EventArgs) Handles Lbl_SP1B_service10p.Click

    End Sub

    Private Sub Lbl_P1B_service7p_Click(sender As Object, e As EventArgs) Handles Lbl_SP1B_service7p.Click

    End Sub

    Private Sub P3D_inc13_TextChanged(sender As Object, e As EventArgs) Handles SP1B_inc13.TextChanged

    End Sub

    Private Sub Lbl_P1E_price_Click(sender As Object, e As EventArgs) Handles Lbl_SP1B_price.Click

    End Sub
End Class