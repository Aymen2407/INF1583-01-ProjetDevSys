Public Class Paiement

    Private Sub CheckedListBoxModePaiement_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxNIP_TextChanged(sender As Object, e As EventArgs)

        ' LabelFacture.Visible = True
    End Sub

    Private Sub GroupBoxFacture_Enter(sender As Object, e As EventArgs) Handles GroupBoxFacture.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBoxPayement.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBoxPrélèvement.Enter


    End Sub

    Private Sub LabelNumeroCompte_Click(sender As Object, e As EventArgs) Handles LabelNumeroCompte.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LabelDateEx_Click(sender As Object, e As EventArgs) Handles LabelDateEx.Click

    End Sub

    Private Sub LabelSuccursale_Click(sender As Object, e As EventArgs) Handles LabelSuccursale.Click

    End Sub

    Private Sub TextBoxNComptec_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxDateEx_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDateEx.TextChanged

    End Sub

    Private Sub TextBoxNumeroCarte_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumeroCarte.TextChanged

    End Sub

    Private Sub LabelNumeroCarte_Click(sender As Object, e As EventArgs) Handles LabelNumeroCarte.Click

    End Sub

    Private Sub Paiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = FrmFacture.TextBox1.Text & "$"
    End Sub

    Private Sub ButtonPaye_Click(sender As Object, e As EventArgs) Handles ButtonPaye.Click
        Chargement.Show()
    End Sub

    Private Sub CheckBoxPrélèvement_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPrélèvement.CheckedChanged
        CheckBoxCarte.CheckState = False
        CheckBoxChèque.CheckState = False
        GroupBoxChèque.Visible = True
    End Sub

    Private Sub CheckBoxCarte_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCarte.CheckedChanged
        CheckBoxChèque.CheckState = False
        CheckBoxPrélèvement.CheckState = False
        GroupBoxCarte.Visible = True
    End Sub

    Private Sub CheckBoxChèque_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxChèque.CheckedChanged
        CheckBoxCarte.CheckState = False
        CheckBoxPrélèvement.CheckState = False
        GroupBoxPrélèvement.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim result As Double
        result = TextBox1.Text - Label6.Text
        Label7.Text = result & "$"
    End Sub
End Class