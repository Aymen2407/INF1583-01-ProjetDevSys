﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransCredit
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"984562", "Pompe3", "Regulier", "38.96$", "2021/11/23"}, -1)
        Me.Credit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.N_Facture = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pompe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeCarburant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Montant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TransacDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Credit
        '
        Me.Credit.Location = New System.Drawing.Point(280, 415)
        Me.Credit.Name = "Credit"
        Me.Credit.Size = New System.Drawing.Size(75, 23)
        Me.Credit.TabIndex = 12
        Me.Credit.Text = "Ok"
        Me.Credit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 38)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Transactions par Carte de Credit"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.N_Facture, Me.Pompe, Me.TypeCarburant, Me.Montant, Me.TransacDate})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(69, 75)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(537, 300)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'N_Facture
        '
        Me.N_Facture.Text = "N_Facture"
        Me.N_Facture.Width = 105
        '
        'Pompe
        '
        Me.Pompe.Text = "Pompe"
        Me.Pompe.Width = 94
        '
        'TypeCarburant
        '
        Me.TypeCarburant.Text = "TypeCarburant"
        Me.TypeCarburant.Width = 126
        '
        'Montant
        '
        Me.Montant.Text = "Montant"
        Me.Montant.Width = 92
        '
        'TransacDate
        '
        Me.TransacDate.Text = "Date"
        Me.TransacDate.Width = 189
        '
        'TransCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Credit)
        Me.Name = "TransCredit"
        Me.Text = "Credit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Credit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents N_Facture As ColumnHeader
    Friend WithEvents Pompe As ColumnHeader
    Friend WithEvents TypeCarburant As ColumnHeader
    Friend WithEvents Montant As ColumnHeader
    Friend WithEvents TransacDate As ColumnHeader
End Class
