<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacture
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
        Me.LblPrixTotalF = New System.Windows.Forms.Label()
        Me.BttnPayement = New System.Windows.Forms.Button()
        Me.LblTVQ = New System.Windows.Forms.Label()
        Me.DateTimePickerFacture = New System.Windows.Forms.DateTimePicker()
        Me.LblTPS = New System.Windows.Forms.Label()
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelTVQ = New System.Windows.Forms.Label()
        Me.LblDateFacture = New System.Windows.Forms.Label()
        Me.LabelTPS = New System.Windows.Forms.Label()
        Me.TextBoxNFacture = New System.Windows.Forms.TextBox()
        Me.LabelSousTotal = New System.Windows.Forms.Label()
        Me.LblNFacture = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxFacture.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPrixTotalF
        '
        Me.LblPrixTotalF.AutoSize = True
        Me.LblPrixTotalF.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixTotalF.Location = New System.Drawing.Point(365, 351)
        Me.LblPrixTotalF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrixTotalF.Name = "LblPrixTotalF"
        Me.LblPrixTotalF.Size = New System.Drawing.Size(77, 32)
        Me.LblPrixTotalF.TabIndex = 50
        Me.LblPrixTotalF.Text = "$0.00"
        '
        'BttnPayement
        '
        Me.BttnPayement.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.BttnPayement.ForeColor = System.Drawing.Color.Navy
        Me.BttnPayement.Location = New System.Drawing.Point(476, 405)
        Me.BttnPayement.Margin = New System.Windows.Forms.Padding(4)
        Me.BttnPayement.Name = "BttnPayement"
        Me.BttnPayement.Size = New System.Drawing.Size(152, 41)
        Me.BttnPayement.TabIndex = 51
        Me.BttnPayement.Text = "PAIEMENT"
        Me.BttnPayement.UseVisualStyleBackColor = True
        '
        'LblTVQ
        '
        Me.LblTVQ.AutoSize = True
        Me.LblTVQ.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTVQ.Location = New System.Drawing.Point(366, 318)
        Me.LblTVQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTVQ.Name = "LblTVQ"
        Me.LblTVQ.Size = New System.Drawing.Size(65, 28)
        Me.LblTVQ.TabIndex = 49
        Me.LblTVQ.Text = "$0.00"
        '
        'DateTimePickerFacture
        '
        Me.DateTimePickerFacture.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFacture.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight
        Me.DateTimePickerFacture.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFacture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFacture.Location = New System.Drawing.Point(156, 73)
        Me.DateTimePickerFacture.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerFacture.Name = "DateTimePickerFacture"
        Me.DateTimePickerFacture.Size = New System.Drawing.Size(204, 29)
        Me.DateTimePickerFacture.TabIndex = 15
        Me.DateTimePickerFacture.Value = New Date(2021, 12, 6, 0, 0, 0, 0)
        '
        'LblTPS
        '
        Me.LblTPS.AutoSize = True
        Me.LblTPS.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTPS.Location = New System.Drawing.Point(366, 281)
        Me.LblTPS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTPS.Name = "LblTPS"
        Me.LblTPS.Size = New System.Drawing.Size(65, 28)
        Me.LblTPS.TabIndex = 48
        Me.LblTPS.Text = "$0.00"
        '
        'GroupBoxFacture
        '
        Me.GroupBoxFacture.Controls.Add(Me.ComboBox2)
        Me.GroupBoxFacture.Controls.Add(Me.Label2)
        Me.GroupBoxFacture.Controls.Add(Me.TextBox1)
        Me.GroupBoxFacture.Controls.Add(Me.ComboBox1)
        Me.GroupBoxFacture.Controls.Add(Me.Label1)
        Me.GroupBoxFacture.Controls.Add(Me.LblPrixTotalF)
        Me.GroupBoxFacture.Controls.Add(Me.BttnPayement)
        Me.GroupBoxFacture.Controls.Add(Me.LblTVQ)
        Me.GroupBoxFacture.Controls.Add(Me.DateTimePickerFacture)
        Me.GroupBoxFacture.Controls.Add(Me.LblTPS)
        Me.GroupBoxFacture.Controls.Add(Me.LabelTotal)
        Me.GroupBoxFacture.Controls.Add(Me.LabelTVQ)
        Me.GroupBoxFacture.Controls.Add(Me.LblDateFacture)
        Me.GroupBoxFacture.Controls.Add(Me.LabelTPS)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNFacture)
        Me.GroupBoxFacture.Controls.Add(Me.LabelSousTotal)
        Me.GroupBoxFacture.Controls.Add(Me.LblNFacture)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(63, 27)
        Me.GroupBoxFacture.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxFacture.Size = New System.Drawing.Size(831, 493)
        Me.GroupBoxFacture.TabIndex = 54
        Me.GroupBoxFacture.TabStop = False
        Me.GroupBoxFacture.Text = "Facture"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(371, 239)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 39)
        Me.TextBox1.TabIndex = 54
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Regulier", "Extra", "Suprême"})
        Me.ComboBox1.Location = New System.Drawing.Point(372, 188)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 40)
        Me.ComboBox1.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(21, 200)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 28)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Type de Carburant"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.Navy
        Me.LabelTotal.Location = New System.Drawing.Point(20, 355)
        Me.LabelTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(66, 28)
        Me.LabelTotal.TabIndex = 46
        Me.LabelTotal.Text = "TOTAL"
        '
        'LabelTVQ
        '
        Me.LabelTVQ.AutoSize = True
        Me.LabelTVQ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTVQ.ForeColor = System.Drawing.Color.Navy
        Me.LabelTVQ.Location = New System.Drawing.Point(21, 318)
        Me.LabelTVQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTVQ.Name = "LabelTVQ"
        Me.LabelTVQ.Size = New System.Drawing.Size(118, 28)
        Me.LabelTVQ.TabIndex = 45
        Me.LabelTVQ.Text = "TVQ 9.979%"
        '
        'LblDateFacture
        '
        Me.LblDateFacture.AutoSize = True
        Me.LblDateFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateFacture.ForeColor = System.Drawing.Color.Black
        Me.LblDateFacture.Location = New System.Drawing.Point(20, 73)
        Me.LblDateFacture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDateFacture.Name = "LblDateFacture"
        Me.LblDateFacture.Size = New System.Drawing.Size(121, 28)
        Me.LblDateFacture.TabIndex = 17
        Me.LblDateFacture.Text = "Date Facture"
        '
        'LabelTPS
        '
        Me.LabelTPS.AutoSize = True
        Me.LabelTPS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTPS.ForeColor = System.Drawing.Color.Navy
        Me.LabelTPS.Location = New System.Drawing.Point(21, 281)
        Me.LabelTPS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTPS.Name = "LabelTPS"
        Me.LabelTPS.Size = New System.Drawing.Size(76, 28)
        Me.LabelTPS.TabIndex = 44
        Me.LabelTPS.Text = "TPS 5%"
        '
        'TextBoxNFacture
        '
        Me.TextBoxNFacture.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxNFacture.Location = New System.Drawing.Point(476, 16)
        Me.TextBoxNFacture.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNFacture.Name = "TextBoxNFacture"
        Me.TextBoxNFacture.Size = New System.Drawing.Size(204, 39)
        Me.TextBoxNFacture.TabIndex = 18
        '
        'LabelSousTotal
        '
        Me.LabelSousTotal.AutoSize = True
        Me.LabelSousTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSousTotal.ForeColor = System.Drawing.Color.Navy
        Me.LabelSousTotal.Location = New System.Drawing.Point(20, 244)
        Me.LabelSousTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSousTotal.Name = "LabelSousTotal"
        Me.LabelSousTotal.Size = New System.Drawing.Size(125, 28)
        Me.LabelSousTotal.TabIndex = 43
        Me.LabelSousTotal.Text = "SOUS-TOTAL"
        '
        'LblNFacture
        '
        Me.LblNFacture.AutoSize = True
        Me.LblNFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNFacture.ForeColor = System.Drawing.Color.Black
        Me.LblNFacture.Location = New System.Drawing.Point(272, 23)
        Me.LblNFacture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNFacture.Name = "LblNFacture"
        Me.LblNFacture.Size = New System.Drawing.Size(152, 28)
        Me.LblNFacture.TabIndex = 15
        Me.LblNFacture.Text = "Numéro Facture"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Pompe1", "Pompe2", "Pompe3", "Pompe4", "Pompe5"})
        Me.ComboBox2.Location = New System.Drawing.Point(372, 134)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(193, 40)
        Me.ComboBox2.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(21, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 28)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "La Pompe Choisi"
        '
        'FrmFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 547)
        Me.Controls.Add(Me.GroupBoxFacture)
        Me.Name = "FrmFacture"
        Me.Text = "Facture"
        Me.GroupBoxFacture.ResumeLayout(False)
        Me.GroupBoxFacture.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblPrixTotalF As Label
    Friend WithEvents BttnPayement As Button
    Friend WithEvents LblTVQ As Label
    Friend WithEvents DateTimePickerFacture As DateTimePicker
    Friend WithEvents LblTPS As Label
    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelTVQ As Label
    Friend WithEvents LblDateFacture As Label
    Friend WithEvents LabelTPS As Label
    Friend WithEvents TextBoxNFacture As TextBox
    Friend WithEvents LabelSousTotal As Label
    Friend WithEvents LblNFacture As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
End Class
