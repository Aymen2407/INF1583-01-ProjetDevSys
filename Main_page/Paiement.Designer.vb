<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paiement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelFacture = New System.Windows.Forms.Label()
        Me.CheckBoxCarte = New System.Windows.Forms.CheckBox()
        Me.CheckBoxChèque = New System.Windows.Forms.CheckBox()
        Me.TextBoxDateEx = New System.Windows.Forms.TextBox()
        Me.CheckBoxPrélèvement = New System.Windows.Forms.CheckBox()
        Me.LabelSuccursale = New System.Windows.Forms.Label()
        Me.TextBoxCVV = New System.Windows.Forms.TextBox()
        Me.LabelNumeroCompte = New System.Windows.Forms.Label()
        Me.TextBoxNCompte = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxNIP = New System.Windows.Forms.TextBox()
        Me.LabelNIP = New System.Windows.Forms.Label()
        Me.GroupBoxPrélèvement = New System.Windows.Forms.GroupBox()
        Me.GroupBoxChèque = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxCarte = New System.Windows.Forms.GroupBox()
        Me.LabelNumeroCarte = New System.Windows.Forms.Label()
        Me.LabelDateEx = New System.Windows.Forms.Label()
        Me.LabelCvv = New System.Windows.Forms.Label()
        Me.TextBoxNumeroCarte = New System.Windows.Forms.TextBox()
        Me.GroupBoxPayement = New System.Windows.Forms.GroupBox()
        Me.ButtonPaye = New System.Windows.Forms.Button()
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.GroupBoxChèque.SuspendLayout()
        Me.GroupBoxCarte.SuspendLayout()
        Me.GroupBoxPayement.SuspendLayout()
        Me.GroupBoxFacture.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelFacture
        '
        Me.LabelFacture.AutoSize = True
        Me.LabelFacture.ForeColor = System.Drawing.Color.Red
        Me.LabelFacture.Location = New System.Drawing.Point(110, 76)
        Me.LabelFacture.Name = "LabelFacture"
        Me.LabelFacture.Size = New System.Drawing.Size(0, 16)
        Me.LabelFacture.TabIndex = 19
        '
        'CheckBoxCarte
        '
        Me.CheckBoxCarte.AutoSize = True
        Me.CheckBoxCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxCarte.ForeColor = System.Drawing.Color.Navy
        Me.CheckBoxCarte.Location = New System.Drawing.Point(8, 64)
        Me.CheckBoxCarte.Margin = New System.Windows.Forms.Padding(5)
        Me.CheckBoxCarte.Name = "CheckBoxCarte"
        Me.CheckBoxCarte.Size = New System.Drawing.Size(135, 32)
        Me.CheckBoxCarte.TabIndex = 22
        Me.CheckBoxCarte.Text = "Carte credit"
        Me.CheckBoxCarte.UseVisualStyleBackColor = True
        '
        'CheckBoxChèque
        '
        Me.CheckBoxChèque.AutoSize = True
        Me.CheckBoxChèque.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxChèque.ForeColor = System.Drawing.Color.Navy
        Me.CheckBoxChèque.Location = New System.Drawing.Point(8, 98)
        Me.CheckBoxChèque.Margin = New System.Windows.Forms.Padding(5)
        Me.CheckBoxChèque.Name = "CheckBoxChèque"
        Me.CheckBoxChèque.Size = New System.Drawing.Size(159, 32)
        Me.CheckBoxChèque.TabIndex = 23
        Me.CheckBoxChèque.Text = "Compte Client"
        Me.CheckBoxChèque.UseVisualStyleBackColor = True
        '
        'TextBoxDateEx
        '
        Me.TextBoxDateEx.Location = New System.Drawing.Point(179, 28)
        Me.TextBoxDateEx.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxDateEx.Name = "TextBoxDateEx"
        Me.TextBoxDateEx.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxDateEx.TabIndex = 3
        '
        'CheckBoxPrélèvement
        '
        Me.CheckBoxPrélèvement.AutoSize = True
        Me.CheckBoxPrélèvement.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxPrélèvement.ForeColor = System.Drawing.Color.Navy
        Me.CheckBoxPrélèvement.Location = New System.Drawing.Point(8, 30)
        Me.CheckBoxPrélèvement.Margin = New System.Windows.Forms.Padding(5)
        Me.CheckBoxPrélèvement.Name = "CheckBoxPrélèvement"
        Me.CheckBoxPrélèvement.Size = New System.Drawing.Size(187, 32)
        Me.CheckBoxPrélèvement.TabIndex = 21
        Me.CheckBoxPrélèvement.Text = "Argent Comptant"
        Me.CheckBoxPrélèvement.UseVisualStyleBackColor = True
        '
        'LabelSuccursale
        '
        Me.LabelSuccursale.AutoSize = True
        Me.LabelSuccursale.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelSuccursale.ForeColor = System.Drawing.Color.Navy
        Me.LabelSuccursale.Location = New System.Drawing.Point(609, 228)
        Me.LabelSuccursale.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelSuccursale.Name = "LabelSuccursale"
        Me.LabelSuccursale.Size = New System.Drawing.Size(204, 28)
        Me.LabelSuccursale.TabIndex = 2
        Me.LabelSuccursale.Text = "Numéro de succursale"
        '
        'TextBoxCVV
        '
        Me.TextBoxCVV.Location = New System.Drawing.Point(179, 92)
        Me.TextBoxCVV.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxCVV.Name = "TextBoxCVV"
        Me.TextBoxCVV.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxCVV.TabIndex = 10
        '
        'LabelNumeroCompte
        '
        Me.LabelNumeroCompte.AutoSize = True
        Me.LabelNumeroCompte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNumeroCompte.Location = New System.Drawing.Point(402, 85)
        Me.LabelNumeroCompte.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelNumeroCompte.Name = "LabelNumeroCompte"
        Me.LabelNumeroCompte.Size = New System.Drawing.Size(183, 28)
        Me.LabelNumeroCompte.TabIndex = 8
        Me.LabelNumeroCompte.Text = "Numéro de compte"
        '
        'TextBoxNCompte
        '
        Me.TextBoxNCompte.Location = New System.Drawing.Point(638, 126)
        Me.TextBoxNCompte.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxNCompte.Name = "TextBoxNCompte"
        Me.TextBoxNCompte.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNCompte.TabIndex = 14
        Me.TextBoxNCompte.WordWrap = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Button1.Location = New System.Drawing.Point(660, 494)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 42)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(638, 73)
        Me.TextBoxNIP.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNIP.TabIndex = 12
        '
        'LabelNIP
        '
        Me.LabelNIP.AutoSize = True
        Me.LabelNIP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNIP.Location = New System.Drawing.Point(402, 126)
        Me.LabelNIP.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelNIP.Name = "LabelNIP"
        Me.LabelNIP.Size = New System.Drawing.Size(43, 28)
        Me.LabelNIP.TabIndex = 7
        Me.LabelNIP.Text = "NIP"
        '
        'GroupBoxPrélèvement
        '
        Me.GroupBoxPrélèvement.Location = New System.Drawing.Point(349, 46)
        Me.GroupBoxPrélèvement.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxPrélèvement.Name = "GroupBoxPrélèvement"
        Me.GroupBoxPrélèvement.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxPrélèvement.Size = New System.Drawing.Size(475, 144)
        Me.GroupBoxPrélèvement.TabIndex = 18
        Me.GroupBoxPrélèvement.TabStop = False
        Me.GroupBoxPrélèvement.Visible = False
        '
        'GroupBoxChèque
        '
        Me.GroupBoxChèque.Controls.Add(Me.Label7)
        Me.GroupBoxChèque.Controls.Add(Me.Label6)
        Me.GroupBoxChèque.Controls.Add(Me.TextBox1)
        Me.GroupBoxChèque.Controls.Add(Me.Label5)
        Me.GroupBoxChèque.Controls.Add(Me.Label4)
        Me.GroupBoxChèque.Controls.Add(Me.Label3)
        Me.GroupBoxChèque.Controls.Add(Me.Label2)
        Me.GroupBoxChèque.Controls.Add(Me.Label1)
        Me.GroupBoxChèque.Controls.Add(Me.LabelSuccursale)
        Me.GroupBoxChèque.Location = New System.Drawing.Point(349, 209)
        Me.GroupBoxChèque.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxChèque.Name = "GroupBoxChèque"
        Me.GroupBoxChèque.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxChèque.Size = New System.Drawing.Size(475, 256)
        Me.GroupBoxChèque.TabIndex = 19
        Me.GroupBoxChèque.TabStop = False
        Me.GroupBoxChèque.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(260, 166)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 28)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "$0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(260, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 28)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Montant à Payer"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(287, 92)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 43)
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(29, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 28)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Vous devez au Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(29, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 28)
        Me.Label4.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(29, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 28)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Montant Remis par Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(29, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 28)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Montant à Payer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 28)
        Me.Label1.TabIndex = 28
        '
        'GroupBoxCarte
        '
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxCVV)
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxDateEx)
        Me.GroupBoxCarte.Controls.Add(Me.LabelNumeroCarte)
        Me.GroupBoxCarte.Controls.Add(Me.LabelDateEx)
        Me.GroupBoxCarte.Controls.Add(Me.LabelCvv)
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxNumeroCarte)
        Me.GroupBoxCarte.Location = New System.Drawing.Point(10, 209)
        Me.GroupBoxCarte.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxCarte.Name = "GroupBoxCarte"
        Me.GroupBoxCarte.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxCarte.Size = New System.Drawing.Size(329, 256)
        Me.GroupBoxCarte.TabIndex = 20
        Me.GroupBoxCarte.TabStop = False
        Me.GroupBoxCarte.Visible = False
        '
        'LabelNumeroCarte
        '
        Me.LabelNumeroCarte.AutoSize = True
        Me.LabelNumeroCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNumeroCarte.Location = New System.Drawing.Point(10, 33)
        Me.LabelNumeroCarte.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelNumeroCarte.Name = "LabelNumeroCarte"
        Me.LabelNumeroCarte.Size = New System.Drawing.Size(159, 28)
        Me.LabelNumeroCarte.TabIndex = 5
        Me.LabelNumeroCarte.Text = "Numéro de carte"
        '
        'LabelDateEx
        '
        Me.LabelDateEx.AutoSize = True
        Me.LabelDateEx.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelDateEx.Location = New System.Drawing.Point(10, 101)
        Me.LabelDateEx.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelDateEx.Name = "LabelDateEx"
        Me.LabelDateEx.Size = New System.Drawing.Size(163, 28)
        Me.LabelDateEx.TabIndex = 6
        Me.LabelDateEx.Text = "Date d'expiration"
        '
        'LabelCvv
        '
        Me.LabelCvv.AutoSize = True
        Me.LabelCvv.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelCvv.Location = New System.Drawing.Point(10, 166)
        Me.LabelCvv.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelCvv.Name = "LabelCvv"
        Me.LabelCvv.Size = New System.Drawing.Size(48, 28)
        Me.LabelCvv.TabIndex = 11
        Me.LabelCvv.Text = "CVV"
        '
        'TextBoxNumeroCarte
        '
        Me.TextBoxNumeroCarte.Location = New System.Drawing.Point(179, 157)
        Me.TextBoxNumeroCarte.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxNumeroCarte.Name = "TextBoxNumeroCarte"
        Me.TextBoxNumeroCarte.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNumeroCarte.TabIndex = 2
        '
        'GroupBoxPayement
        '
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxPrélèvement)
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxCarte)
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxChèque)
        Me.GroupBoxPayement.Location = New System.Drawing.Point(10, 46)
        Me.GroupBoxPayement.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxPayement.Name = "GroupBoxPayement"
        Me.GroupBoxPayement.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxPayement.Size = New System.Drawing.Size(331, 144)
        Me.GroupBoxPayement.TabIndex = 24
        Me.GroupBoxPayement.TabStop = False
        '
        'ButtonPaye
        '
        Me.ButtonPaye.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.ButtonPaye.Location = New System.Drawing.Point(473, 494)
        Me.ButtonPaye.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonPaye.Name = "ButtonPaye"
        Me.ButtonPaye.Size = New System.Drawing.Size(177, 42)
        Me.ButtonPaye.TabIndex = 0
        Me.ButtonPaye.Text = "Payer Maintenant"
        Me.ButtonPaye.UseVisualStyleBackColor = True
        '
        'GroupBoxFacture
        '
        Me.GroupBoxFacture.AutoSize = True
        Me.GroupBoxFacture.Controls.Add(Me.LabelNumeroCompte)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNCompte)
        Me.GroupBoxFacture.Controls.Add(Me.Button1)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNIP)
        Me.GroupBoxFacture.Controls.Add(Me.ButtonPaye)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNIP)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPrélèvement)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxChèque)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPayement)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxCarte)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(4, 3)
        Me.GroupBoxFacture.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxFacture.Size = New System.Drawing.Size(855, 582)
        Me.GroupBoxFacture.TabIndex = 18
        Me.GroupBoxFacture.TabStop = False
        Me.GroupBoxFacture.Text = "Paiement de la Facture"
        '
        'Paiement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 587)
        Me.Controls.Add(Me.LabelFacture)
        Me.Controls.Add(Me.GroupBoxFacture)
        Me.Name = "Paiement"
        Me.Text = "Paiement"
        Me.GroupBoxChèque.ResumeLayout(False)
        Me.GroupBoxChèque.PerformLayout()
        Me.GroupBoxCarte.ResumeLayout(False)
        Me.GroupBoxCarte.PerformLayout()
        Me.GroupBoxPayement.ResumeLayout(False)
        Me.GroupBoxPayement.PerformLayout()
        Me.GroupBoxFacture.ResumeLayout(False)
        Me.GroupBoxFacture.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelFacture As Label
    Friend WithEvents CheckBoxCarte As CheckBox
    Friend WithEvents CheckBoxChèque As CheckBox
    Friend WithEvents TextBoxDateEx As TextBox
    Friend WithEvents CheckBoxPrélèvement As CheckBox
    Friend WithEvents LabelSuccursale As Label
    Friend WithEvents TextBoxCVV As TextBox
    Friend WithEvents LabelNumeroCompte As Label
    Friend WithEvents TextBoxNCompte As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxNIP As TextBox
    Friend WithEvents LabelNIP As Label
    Friend WithEvents GroupBoxPrélèvement As GroupBox
    Friend WithEvents GroupBoxChèque As GroupBox
    Friend WithEvents GroupBoxCarte As GroupBox
    Friend WithEvents LabelNumeroCarte As Label
    Friend WithEvents LabelDateEx As Label
    Friend WithEvents LabelCvv As Label
    Friend WithEvents TextBoxNumeroCarte As TextBox
    Friend WithEvents GroupBoxPayement As GroupBox
    Friend WithEvents ButtonPaye As Button
    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
