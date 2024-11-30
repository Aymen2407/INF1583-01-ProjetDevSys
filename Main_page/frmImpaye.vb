Public Class frmImpaye
    Private Sub frmImpaye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Transaction1")
        ListBox1.Items.Add("Transaction2")
        ListBox1.Items.Add("Transaction3")
        ListBox1.Items.Add("Transaction4")
        ListBox1.Items.Add("Transaction5")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Aide.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()
        MessageBox.Show("Les Transactions ont étés Archivés")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "Transaction1"
                TextBox1.Text = "Transaction1" & vbCrLf & "État de la Transaction : Impayée" & vbCrLf & "Montant de la Transaction : 60.59$" & vbCrLf & "Raison : Vol" & vbCrLf & "Plaque d'immatriculation du Véhicule: HNK5894 "
            Case "Transaction2"
                TextBox1.Text = "Transaction2" & vbCrLf & "État de la Transaction : Impayée" & vbCrLf & "Montant de la Transaction : 30.48$" & vbCrLf & "Raison : Vol" & vbCrLf & "Plaque d'immatriculation du Véhicule: 8HJV918"
            Case "Transaction3"
                TextBox1.Text = "Transaction3" & vbCrLf & "État de la Transaction : Impayée" & vbCrLf & "Montant de la Transaction : 29.37$" & vbCrLf & "Raison : Vol" & vbCrLf & "Plaque d'immatriculation du Véhicule: HVW6762"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class