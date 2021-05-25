<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Comanda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BT_addSalgado = New System.Windows.Forms.Button()
        Me.BT_addTubaina = New System.Windows.Forms.Button()
        Me.BT_fechaconta = New System.Windows.Forms.Button()
        Me.BT_voltar = New System.Windows.Forms.Button()
        Me.Dados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textoteste = New System.Windows.Forms.Label()
        Me.labeltotal = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_addAgua = New System.Windows.Forms.Button()
        Me.BT_addMINI = New System.Windows.Forms.Button()
        Me.BT_addCafe = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_addKS = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_addlata = New System.Windows.Forms.Button()
        Me.BT_addSUCOCOPO = New System.Windows.Forms.Button()
        Me.BT_addSUCOJARRA = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.Dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_addSalgado
        '
        Me.BT_addSalgado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addSalgado.Location = New System.Drawing.Point(3, 3)
        Me.BT_addSalgado.Name = "BT_addSalgado"
        Me.BT_addSalgado.Size = New System.Drawing.Size(117, 55)
        Me.BT_addSalgado.TabIndex = 1
        Me.BT_addSalgado.Text = "SALGADO ( 1 )"
        Me.BT_addSalgado.UseVisualStyleBackColor = True
        '
        'BT_addTubaina
        '
        Me.BT_addTubaina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addTubaina.Location = New System.Drawing.Point(126, 3)
        Me.BT_addTubaina.Name = "BT_addTubaina"
        Me.BT_addTubaina.Size = New System.Drawing.Size(117, 55)
        Me.BT_addTubaina.TabIndex = 2
        Me.BT_addTubaina.Text = "TUBAINA ( 2 )"
        Me.BT_addTubaina.UseVisualStyleBackColor = True
        '
        'BT_fechaconta
        '
        Me.BT_fechaconta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_fechaconta.Location = New System.Drawing.Point(3, 14)
        Me.BT_fechaconta.Name = "BT_fechaconta"
        Me.BT_fechaconta.Size = New System.Drawing.Size(118, 46)
        Me.BT_fechaconta.TabIndex = 3
        Me.BT_fechaconta.Text = "Fechar Conta ( F )"
        Me.BT_fechaconta.UseVisualStyleBackColor = True
        '
        'BT_voltar
        '
        Me.BT_voltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_voltar.Location = New System.Drawing.Point(1004, 7)
        Me.BT_voltar.Name = "BT_voltar"
        Me.BT_voltar.Size = New System.Drawing.Size(120, 53)
        Me.BT_voltar.TabIndex = 4
        Me.BT_voltar.Text = "Voltar ( Esc )"
        Me.BT_voltar.UseVisualStyleBackColor = True
        '
        'Dados
        '
        Me.Dados.AllowUserToAddRows = False
        Me.Dados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dados.Location = New System.Drawing.Point(10, 140)
        Me.Dados.Margin = New System.Windows.Forms.Padding(10)
        Me.Dados.Name = "Dados"
        Me.Dados.ReadOnly = True
        Me.Dados.RowHeadersVisible = False
        Me.Dados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dados.RowTemplate.Height = 40
        Me.Dados.ShowCellErrors = False
        Me.Dados.Size = New System.Drawing.Size(1117, 461)
        Me.Dados.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Erro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textoteste
        '
        Me.textoteste.AutoSize = True
        Me.textoteste.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textoteste.Location = New System.Drawing.Point(0, 0)
        Me.textoteste.Name = "textoteste"
        Me.textoteste.Size = New System.Drawing.Size(8, 9)
        Me.textoteste.TabIndex = 8
        Me.textoteste.Text = "*"
        '
        'labeltotal
        '
        Me.labeltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labeltotal.AutoSize = True
        Me.labeltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotal.ForeColor = System.Drawing.Color.Red
        Me.labeltotal.Location = New System.Drawing.Point(272, 13)
        Me.labeltotal.Margin = New System.Windows.Forms.Padding(3)
        Me.labeltotal.Name = "labeltotal"
        Me.labeltotal.Size = New System.Drawing.Size(581, 37)
        Me.labeltotal.TabIndex = 9
        Me.labeltotal.Text = "Total"
        Me.labeltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1127, 120)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.BT_addAgua, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BT_addMINI, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BT_addCafe, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(753, 56)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(371, 61)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'BT_addAgua
        '
        Me.BT_addAgua.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addAgua.Location = New System.Drawing.Point(3, 3)
        Me.BT_addAgua.Name = "BT_addAgua"
        Me.BT_addAgua.Size = New System.Drawing.Size(117, 55)
        Me.BT_addAgua.TabIndex = 0
        Me.BT_addAgua.Text = "Agua ( 7 )"
        Me.BT_addAgua.UseVisualStyleBackColor = True
        '
        'BT_addMINI
        '
        Me.BT_addMINI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addMINI.Location = New System.Drawing.Point(126, 3)
        Me.BT_addMINI.Name = "BT_addMINI"
        Me.BT_addMINI.Size = New System.Drawing.Size(117, 55)
        Me.BT_addMINI.TabIndex = 1
        Me.BT_addMINI.Text = "Mini ( 8 )"
        Me.BT_addMINI.UseVisualStyleBackColor = True
        '
        'BT_addCafe
        '
        Me.BT_addCafe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addCafe.Location = New System.Drawing.Point(249, 3)
        Me.BT_addCafe.Name = "BT_addCafe"
        Me.BT_addCafe.Size = New System.Drawing.Size(119, 55)
        Me.BT_addCafe.TabIndex = 2
        Me.BT_addCafe.Text = "Café ( 9 )"
        Me.BT_addCafe.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.BT_addKS, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.BT_addSalgado, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.BT_addTubaina, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 56)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(369, 61)
        Me.TableLayoutPanel5.TabIndex = 10
        '
        'BT_addKS
        '
        Me.BT_addKS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addKS.Location = New System.Drawing.Point(249, 3)
        Me.BT_addKS.Name = "BT_addKS"
        Me.BT_addKS.Size = New System.Drawing.Size(117, 55)
        Me.BT_addKS.TabIndex = 8
        Me.BT_addKS.Text = "KS ( 3 )"
        Me.BT_addKS.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.BT_addlata, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.BT_addSUCOCOPO, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.BT_addSUCOJARRA, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(378, 56)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(369, 61)
        Me.TableLayoutPanel6.TabIndex = 11
        '
        'BT_addlata
        '
        Me.BT_addlata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addlata.Location = New System.Drawing.Point(3, 3)
        Me.BT_addlata.Name = "BT_addlata"
        Me.BT_addlata.Size = New System.Drawing.Size(117, 55)
        Me.BT_addlata.TabIndex = 0
        Me.BT_addlata.Text = "LATA ( 4 )"
        Me.BT_addlata.UseVisualStyleBackColor = True
        '
        'BT_addSUCOCOPO
        '
        Me.BT_addSUCOCOPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addSUCOCOPO.Location = New System.Drawing.Point(126, 3)
        Me.BT_addSUCOCOPO.Name = "BT_addSUCOCOPO"
        Me.BT_addSUCOCOPO.Size = New System.Drawing.Size(117, 55)
        Me.BT_addSUCOCOPO.TabIndex = 1
        Me.BT_addSUCOCOPO.Text = "SUCO COPO ( 5 )"
        Me.BT_addSUCOCOPO.UseVisualStyleBackColor = True
        '
        'BT_addSUCOJARRA
        '
        Me.BT_addSUCOJARRA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_addSUCOJARRA.Location = New System.Drawing.Point(249, 3)
        Me.BT_addSUCOJARRA.Name = "BT_addSUCOJARRA"
        Me.BT_addSUCOJARRA.Size = New System.Drawing.Size(117, 55)
        Me.BT_addSUCOJARRA.TabIndex = 2
        Me.BT_addSUCOJARRA.Text = "SUCO JARRA ( 6 )"
        Me.BT_addSUCOJARRA.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.94205!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.11591!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.94205!))
        Me.TableLayoutPanel2.Controls.Add(Me.BT_voltar, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BT_fechaconta, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.labeltotal, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 616)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1127, 63)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Dados, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.00747!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.37553!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.617!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1137, 684)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'Comanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 684)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.textoteste)
        Me.KeyPreview = True
        Me.Name = "Comanda"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMANDA"
        CType(Me.Dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_addSalgado As Button
    Friend WithEvents BT_addTubaina As Button
    Friend WithEvents BT_fechaconta As Button
    Friend WithEvents BT_voltar As Button
    Friend WithEvents Dados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents textoteste As Label
    Friend WithEvents labeltotal As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BT_addKS As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents BT_addAgua As Button
    Friend WithEvents BT_addMINI As Button
    Friend WithEvents BT_addCafe As Button
    Friend WithEvents BT_addlata As Button
    Friend WithEvents BT_addSUCOCOPO As Button
    Friend WithEvents BT_addSUCOJARRA As Button
End Class
