Public Class FrmFacture
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Sub BttnPayement_Click(sender As Object, e As EventArgs) Handles BttnPayement.Click
        Paiement.Show() 'Appel de la forme payement 
    End Sub
    Private Sub FrmFacture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxNFacture.Text = GetRandom(100000, 999999)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LblTPS.Text = TextBox1.Text * 0.05 & "$"
        LblTVQ.Text = TextBox1.Text * 0.09975 & "$"
        LblPrixTotalF.Text = TextBox1.Text * (1.05 + 0.09975) & "$"
    End Sub

End Class