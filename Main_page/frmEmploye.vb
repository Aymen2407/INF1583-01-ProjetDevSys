Public Class frmEmploye
    Sub listAdd()
        Dim newItem As New ListViewItem(TextBox1.Text)
        newItem.SubItems.Add(TextBox2.Text)
        newItem.SubItems.Add(TextBox3.Text)
        newItem.SubItems.Add(TextBox4.Text)
        ListView1.Items.Add(newItem)
    End Sub
    Private Sub frmEmploye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("ID employé(e)", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nom et prénom", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Heure de travail", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Responsabilité", 100, HorizontalAlignment.Center)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call listAdd()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        Call listAdd()
    End Sub
End Class