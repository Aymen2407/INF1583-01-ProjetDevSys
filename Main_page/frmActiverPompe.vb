Public Class frmActiverPompe

    Private Sub frmActiverPompe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Pompe 1 : Activée")
        ListBox1.Items.Add("Pompe 2 : Activée")
        ListBox1.Items.Add("Pompe 3 : Désactivée")
        ListBox1.Items.Add("Pompe 4 : Activée")
        ListBox1.Items.Add("Pompe 5 : Activée")
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous Activer La Pompe Séléctionnée ?",
    "Important",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Pompe 1 : Activée")
            ListBox1.Items.Add("Pompe 2 : Activée")
            ListBox1.Items.Add("Pompe 3 : Activée")
            ListBox1.Items.Add("Pompe 4 : Activée")
            ListBox1.Items.Add("Pompe 5 : Activée")
            MessageBox.Show("La Pompe Séléctionnée est activée")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous Désactiver La Pompe Séléctionnée ?",
    "Important",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Pompe 1 : Activée")
            ListBox1.Items.Add("Pompe 2 : Activée")
            ListBox1.Items.Add("Pompe 3 : Activée")
            ListBox1.Items.Add("Pompe 4 : Désactivée")
            ListBox1.Items.Add("Pompe 5 : Activée")
            MessageBox.Show("La Pompe Séléctionnée est désactivée")
        End If
    End Sub
End Class