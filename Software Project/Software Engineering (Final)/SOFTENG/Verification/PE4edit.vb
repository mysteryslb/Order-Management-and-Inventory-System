﻿Public Class PE4edit

    Private Sub Refresh1_Click(sender As Object, e As EventArgs) Handles Refresh1E4.Click
        Lbl_P4E_name.Text = P4E_name.Text
        Lbl_P4E_price.Text = P4E_price.Text
        Lbl_P4E_pax.Text = P4E_pax.Text
        Lbl_P4E_entry1.Text = P4E_entry1.Text
        Lbl_P4E_entry2.Text = P4E_entry2.Text
        Lbl_P4E_entry3.Text = P4E_entry3.Text
        Lbl_P4E_entry4.Text = P4E_entry4.Text
        Lbl_P4E_entry5.Text = P4E_entry5.Text
        Lbl_P4E_entry6.Text = P4E_entry6.Text
        Lbl_P4E_entry7.Text = P4E_entry7.Text
        Lbl_P4E_entry8.Text = P4E_entry8.Text
        Lbl_P4E_entry9.Text = P4E_entry9.Text
        Lbl_P4E_entry10.Text = P4E_entry10.Text
        Lbl_P4E_entry11.Text = P4E_entry11.Text
        Lbl_P4E_entry12.Text = P4E_entry12.Text
        Lbl_P4E_add1.Text = P4E_add1.Text
        Lbl_P4E_add2.Text = P4E_add2.Text
        Lbl_P4E_add3.Text = P4E_add3.Text
        Lbl_P4E_add4.Text = P4E_add4.Text
        Lbl_P4E_add5.Text = P4E_add5.Text
        Lbl_P4E_add6.Text = P4E_add6.Text
        Lbl_P4E_add7.Text = P4E_add7.Text
        Lbl_P4E_add8.Text = P4E_add8.Text
        Lbl_P4E_add9.Text = P4E_add9.Text
        Lbl_P4E_add10.Text = P4E_add10.Text
        Lbl_P4E_add11.Text = P4E_add11.Text
        Lbl_P4E_add12.Text = P4E_add12.Text
        Lbl_P4E_add1p.Text = P4E_add1p.Text
        Lbl_P4E_add2p.Text = P4E_add2p.Text
        Lbl_P4E_add3p.Text = P4E_add3p.Text
        Lbl_P4E_add4p.Text = P4E_add4p.Text
        Lbl_P4E_add5p.Text = P4E_add5p.Text
        Lbl_P4E_add6p.Text = P4E_add6p.Text
        Lbl_P4E_add7p.Text = P4E_add7p.Text
        Lbl_P4E_add8p.Text = P4E_add8p.Text
        Lbl_P4E_add9p.Text = P4E_add9p.Text
        Lbl_P4E_add10p.Text = P4E_add10p.Text
        Lbl_P4E_add11p.Text = P4E_add11p.Text
        Lbl_P4E_add12p.Text = P4E_add12p.Text
        Lbl_P4E_inc1.Text = P4E_inc1.Text
        Lbl_P4E_inc2.Text = P4E_inc2.Text
        Lbl_P4E_inc3.Text = P4E_inc3.Text
        Lbl_P4E_inc4.Text = P4E_inc4.Text
        Lbl_P4E_inc5.Text = P4E_inc5.Text
        Lbl_P4E_inc6.Text = P4E_inc6.Text
        Lbl_P4E_inc7.Text = P4E_inc7.Text
        Lbl_P4E_inc8.Text = P4E_inc8.Text
        Lbl_P4E_inc9.Text = P4E_inc9.Text
        Lbl_P4E_inc10.Text = P4E_inc10.Text
        Lbl_P4E_inc11.Text = P4E_inc11.Text
        Lbl_P4E_inc12.Text = P4E_inc12.Text
        Lbl_P4E_inc13.Text = P4E_inc13.Text
        Lbl_P4E_inc14.Text = P4E_inc14.Text
        Lbl_P4E_inc15.Text = P4E_inc15.Text
        Lbl_P4E_inc16.Text = P4E_inc16.Text
        Lbl_P4E_inc17.Text = P4E_inc17.Text
        Lbl_P4E_inc18.Text = P4E_inc18.Text
        Lbl_P4E_service1.Text = P4E_service1.Text
        Lbl_P4E_service2.Text = P4E_service2.Text
        Lbl_P4E_servicE3.Text = P4E_servicE3.Text
        Lbl_P4E_service4.Text = P4E_service4.Text
        Lbl_P4E_service5.Text = P4E_service5.Text
        Lbl_P4E_service6.Text = P4E_service6.Text
        Lbl_P4E_service7.Text = P4E_service7.Text
        Lbl_P4E_service8.Text = P4E_service8.Text
        Lbl_P4E_service9.Text = P4E_service9.Text
        Lbl_P4E_service10.Text = P4E_service10.Text
        Lbl_P4E_service11.Text = P4E_service11.Text
        Lbl_P4E_service1p.Text = P4E_service1p.Text
        Lbl_P4E_service2p.Text = P4E_service2p.Text
        Lbl_P4E_servicE3p.Text = P4E_servicE3p.Text
        Lbl_P4E_service4p.Text = P4E_service4p.Text
        Lbl_P4E_service5p.Text = P4E_service5p.Text
        Lbl_P4E_service6p.Text = P4E_service6p.Text
        Lbl_P4E_service7p.Text = P4E_service7p.Text
        Lbl_P4E_service8p.Text = P4E_service8p.Text
        Lbl_P4E_service9p.Text = P4E_service9p.Text
        Lbl_P4E_service10p.Text = P4E_service10p.Text
        Lbl_P4E_service11p.Text = P4E_service11p.Text
        Lbl_P4E_service12p.Text = P4E_service12p.Text
        Lbl_P4E_Description.Text = Lbl_P4E_Description.Text
    End Sub

    Private Sub SampleEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P4E_name.Text = Lbl_P4E_name.Text
        P4E_price.Text = Lbl_P4E_price.Text
        P4E_pax.Text = Lbl_P4E_pax.Text
        P4E_entry1.Text = Lbl_P4E_entry1.Text
        P4E_entry2.Text = Lbl_P4E_entry2.Text
        P4E_entry3.Text = Lbl_P4E_entry3.Text
        P4E_entry4.Text = Lbl_P4E_entry4.Text
        P4E_entry5.Text = Lbl_P4E_entry5.Text
        P4E_entry6.Text = Lbl_P4E_entry6.Text
        P4E_entry7.Text = Lbl_P4E_entry7.Text
        P4E_entry8.Text = Lbl_P4E_entry8.Text
        P4E_entry9.Text = Lbl_P4E_entry9.Text
        P4E_entry10.Text = Lbl_P4E_entry10.Text
        P4E_entry11.Text = Lbl_P4E_entry11.Text
        P4E_entry12.Text = Lbl_P4E_entry12.Text
        P4E_add1.Text = Lbl_P4E_add1.Text
        P4E_add2.Text = Lbl_P4E_add2.Text
        P4E_add3.Text = Lbl_P4E_add3.Text
        P4E_add4.Text = Lbl_P4E_add4.Text
        P4E_add5.Text = Lbl_P4E_add5.Text
        P4E_add6.Text = Lbl_P4E_add6.Text
        P4E_add7.Text = Lbl_P4E_add7.Text
        P4E_add8.Text = Lbl_P4E_add8.Text
        P4E_add9.Text = Lbl_P4E_add9.Text
        P4E_add10.Text = Lbl_P4E_add10.Text
        P4E_add11.Text = Lbl_P4E_add11.Text
        P4E_add12.Text = Lbl_P4E_add12.Text
        P4E_add1p.Text = Lbl_P4E_add1p.Text
        P4E_add2p.Text = Lbl_P4E_add2p.Text
        P4E_add3p.Text = Lbl_P4E_add3p.Text
        P4E_add4p.Text = Lbl_P4E_add4p.Text
        P4E_add5p.Text = Lbl_P4E_add5p.Text
        P4E_add6p.Text = Lbl_P4E_add6p.Text
        P4E_add7p.Text = Lbl_P4E_add7p.Text
        P4E_add8p.Text = Lbl_P4E_add8p.Text
        P4E_add9p.Text = Lbl_P4E_add9p.Text
        P4E_add10p.Text = Lbl_P4E_add10p.Text
        P4E_add11p.Text = Lbl_P4E_add11p.Text
        P4E_add12p.Text = Lbl_P4E_add12p.Text
        P4E_inc1.Text = Lbl_P4E_inc1.Text
        P4E_inc2.Text = Lbl_P4E_inc2.Text
        P4E_inc3.Text = Lbl_P4E_inc3.Text
        P4E_inc4.Text = Lbl_P4E_inc4.Text
        P4E_inc5.Text = Lbl_P4E_inc5.Text
        P4E_inc6.Text = Lbl_P4E_inc6.Text
        P4E_inc7.Text = Lbl_P4E_inc7.Text
        P4E_inc8.Text = Lbl_P4E_inc8.Text
        P4E_inc9.Text = Lbl_P4E_inc9.Text
        P4E_inc10.Text = Lbl_P4E_inc10.Text
        P4E_inc11.Text = Lbl_P4E_inc11.Text
        P4E_inc12.Text = Lbl_P4E_inc12.Text
        P4E_inc13.Text = Lbl_P4E_inc13.Text
        P4E_inc14.Text = Lbl_P4E_inc14.Text
        P4E_inc15.Text = Lbl_P4E_inc15.Text
        P4E_inc16.Text = Lbl_P4E_inc16.Text
        P4E_inc17.Text = Lbl_P4E_inc17.Text
        P4E_inc18.Text = Lbl_P4E_inc18.Text
        P4E_service1.Text = Lbl_P4E_service1.Text
        P4E_service2.Text = Lbl_P4E_service2.Text
        P4E_servicE3.Text = Lbl_P4E_servicE3.Text
        P4E_service4.Text = Lbl_P4E_service4.Text
        P4E_service5.Text = Lbl_P4E_service5.Text
        P4E_service6.Text = Lbl_P4E_service6.Text
        P4E_service7.Text = Lbl_P4E_service7.Text
        P4E_service8.Text = Lbl_P4E_service8.Text
        P4E_service9.Text = Lbl_P4E_service9.Text
        P4E_service10.Text = Lbl_P4E_service10.Text
        P4E_service11.Text = Lbl_P4E_service11.Text
        P4E_service1p.Text = Lbl_P4E_service1p.Text
        P4E_service2p.Text = Lbl_P4E_service2p.Text
        P4E_servicE3p.Text = Lbl_P4E_servicE3p.Text
        P4E_service4p.Text = Lbl_P4E_service4p.Text
        P4E_service5p.Text = Lbl_P4E_service5p.Text
        P4E_service6p.Text = Lbl_P4E_service6p.Text
        P4E_service7p.Text = Lbl_P4E_service7p.Text
        P4E_service8p.Text = Lbl_P4E_service8p.Text
        P4E_service9p.Text = Lbl_P4E_service9p.Text
        P4E_service10p.Text = Lbl_P4E_service10p.Text
        P4E_service11p.Text = Lbl_P4E_service11p.Text
        P4E_service12p.Text = Lbl_P4E_service12p.Text
        P4E_what.Text = Lbl_P4E_what.Text
    End Sub

    Private Sub Lbl_P1A_service10p_Click(sender As Object, e As EventArgs) Handles Lbl_P4E_service10p.Click

    End Sub

    Private Sub Lbl_P1A_service7p_Click(sender As Object, e As EventArgs) Handles Lbl_P4E_service7p.Click

    End Sub

    Private Sub P3D_inc13_TextChanged(sender As Object, e As EventArgs) Handles P4E_inc13.TextChanged

    End Sub

    Private Sub Lbl_P1E_price_Click(sender As Object, e As EventArgs) Handles Lbl_P4E_price.Click

    End Sub
End Class