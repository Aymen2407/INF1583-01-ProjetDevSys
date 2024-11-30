Imports System.Drawing.Printing


Public Class Chargement
    Public WithEvents PrintDocument1 As PrintDocument = New PrintDocument
    Public PrintDialog1 As New PrintDialog
    Public PageSetupDialog1 As New PageSetupDialog
    Public PictureBox1 As New PictureBox

    Private Sub Chargement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()

        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"

        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"
        Label1.Text = "Traitement du Paiement......"

        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."

        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."

        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."

        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."
        Label1.Text = "Activation de La Pompe...."

        Label1.Text = "Activation de La Pompe...."

        Label1.Text = "Activation de La Pompe...."
        Form1.Show()
        Label1.Text = "Impression du Reçu....."




        ' Specify a PrintDocument instance for the PrintPreviewDialog component.
        PrintPreviewDialog1.Document = Me.PrintDocument1
        PrintPreviewDialog1.Show()
        Me.Close()
        Paiement.Close()
        FrmFacture.Close()

    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        'load the picture image into the picturebox
        PictureBox1.Image = Image.FromFile("C:\Users\bena84\OneDrive - Université du Québec en Outaouais\Bureau\Dev\ProjetDevSys\INF1583-01-ProjetDevSys\Main_page\gas-fuel-receipt-maker-15830962323.png")
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom


    End Sub



End Class