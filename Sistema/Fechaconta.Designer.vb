<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fechaconta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.textomesa = New System.Windows.Forms.Label()
        Me.BT_fechar = New System.Windows.Forms.Button()
        Me.BT_voltar = New System.Windows.Forms.Button()
        Me.Dados = New System.Windows.Forms.DataGridView()
        Me.mensagem = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labeltotal = New System.Windows.Forms.Label()
        CType(Me.Dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'textomesa
        '
        Me.textomesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textomesa.AutoSize = True
        Me.textomesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textomesa.Location = New System.Drawing.Point(3, 1)
        Me.textomesa.Name = "textomesa"
        Me.textomesa.Size = New System.Drawing.Size(930, 39)
        Me.textomesa.TabIndex = 0
        Me.textomesa.Text = "Erro"
        Me.textomesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BT_fechar
        '
        Me.BT_fechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_fechar.Location = New System.Drawing.Point(50, 34)
        Me.BT_fechar.Margin = New System.Windows.Forms.Padding(50, 5, 50, 5)
        Me.BT_fechar.Name = "BT_fechar"
        Me.BT_fechar.Size = New System.Drawing.Size(210, 51)
        Me.BT_fechar.TabIndex = 1
        Me.BT_fechar.Text = "FECHAR ( F )"
        Me.BT_fechar.UseVisualStyleBackColor = True
        '
        'BT_voltar
        '
        Me.BT_voltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_voltar.Location = New System.Drawing.Point(670, 34)
        Me.BT_voltar.Margin = New System.Windows.Forms.Padding(50, 5, 50, 5)
        Me.BT_voltar.Name = "BT_voltar"
        Me.BT_voltar.Size = New System.Drawing.Size(210, 51)
        Me.BT_voltar.TabIndex = 2
        Me.BT_voltar.Text = "Voltar ( Esc )"
        Me.BT_voltar.UseVisualStyleBackColor = True
        '
        'Dados
        '
        Me.Dados.AllowUserToAddRows = False
        Me.Dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dados.Location = New System.Drawing.Point(20, 62)
        Me.Dados.Margin = New System.Windows.Forms.Padding(20)
        Me.Dados.Name = "Dados"
        Me.Dados.ReadOnly = True
        Me.Dados.Size = New System.Drawing.Size(896, 334)
        Me.Dados.TabIndex = 7
        '
        'mensagem
        '
        Me.mensagem.AutoSize = True
        Me.mensagem.Location = New System.Drawing.Point(335, 419)
        Me.mensagem.Name = "mensagem"
        Me.mensagem.Size = New System.Drawing.Size(10, 13)
        Me.mensagem.TabIndex = 8
        Me.mensagem.Text = "."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.textomesa, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Dados, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.labeltotal, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.089179!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.45462!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.710448!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.74575!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(936, 600)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.BT_voltar, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BT_fechar, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 477)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(930, 120)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(360, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(50, 5, 50, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "IMPRIMIR ( ENTER )"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labeltotal
        '
        Me.labeltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labeltotal.AutoSize = True
        Me.labeltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotal.Location = New System.Drawing.Point(3, 429)
        Me.labeltotal.Name = "labeltotal"
        Me.labeltotal.Size = New System.Drawing.Size(930, 31)
        Me.labeltotal.TabIndex = 10
        Me.labeltotal.Text = "Soma"
        Me.labeltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fechaconta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 600)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.mensagem)
        Me.KeyPreview = True
        Me.Name = "Fechaconta"
        Me.Text = "Fechaconta"
        CType(Me.Dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textomesa As Label
    Friend WithEvents BT_fechar As Button
    Friend WithEvents BT_voltar As Button
    Friend WithEvents Dados As DataGridView
    Friend WithEvents mensagem As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents labeltotal As Label
End Class
