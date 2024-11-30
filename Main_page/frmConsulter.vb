Public Class frmConsulter
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case "Pompe1"
                Pompe1.Show()
            Case "Pompe2"
                Pompe2.Show()
            Case "Pompe4"
                Pompe4.Show()
        End Select
    End Sub

    Private Sub frmConsulter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class