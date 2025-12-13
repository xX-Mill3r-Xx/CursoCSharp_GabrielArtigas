namespace SistemaCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnFundoTitulo = new System.Windows.Forms.Panel();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            this.ckbVeiculo = new System.Windows.Forms.CheckBox();
            this.ckbCasaPropia = new System.Windows.Forms.CheckBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.listResult = new System.Windows.Forms.ListBox();
            this.tlpOpcoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnFundoTitulo.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbSituacao.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            this.tlpOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.pnFundoTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tcPrincipal, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpOpcoes, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.Size = new System.Drawing.Size(294, 407);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnFundoTitulo
            // 
            this.pnFundoTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlpPrincipal.SetColumnSpan(this.pnFundoTitulo, 2);
            this.pnFundoTitulo.Controls.Add(this.tlpTitulo);
            this.pnFundoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundoTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnFundoTitulo.Name = "pnFundoTitulo";
            this.pnFundoTitulo.Size = new System.Drawing.Size(288, 34);
            this.pnFundoTitulo.TabIndex = 0;
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 5;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.Controls.Add(this.btnFechar, 3, 0);
            this.tlpTitulo.Controls.Add(this.lbTitulo, 1, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(288, 34);
            this.tlpTitulo.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(261, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 28);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(18, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(179, 34);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Sistema Cadastro";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcPrincipal
            // 
            this.tlpPrincipal.SetColumnSpan(this.tcPrincipal, 2);
            this.tcPrincipal.Controls.Add(this.tpCadastro);
            this.tcPrincipal.Controls.Add(this.tpConsulta);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(3, 43);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(288, 321);
            this.tcPrincipal.TabIndex = 1;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.gbSexo);
            this.tpCadastro.Controls.Add(this.gbSituacao);
            this.tpCadastro.Controls.Add(this.cbEstadoCivil);
            this.tpCadastro.Controls.Add(this.mktTelefone);
            this.tpCadastro.Controls.Add(this.dtDataNascimento);
            this.tpCadastro.Controls.Add(this.txtNome);
            this.tpCadastro.Controls.Add(this.lbTelefone);
            this.tpCadastro.Controls.Add(this.lbEstadoCivil);
            this.tpCadastro.Controls.Add(this.lbDataNascimento);
            this.tpCadastro.Controls.Add(this.lbNome);
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(280, 295);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Location = new System.Drawing.Point(9, 142);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(265, 69);
            this.gbSexo.TabIndex = 9;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(7, 42);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbSituacao
            // 
            this.gbSituacao.Controls.Add(this.ckbVeiculo);
            this.gbSituacao.Controls.Add(this.ckbCasaPropia);
            this.gbSituacao.Location = new System.Drawing.Point(9, 217);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(265, 71);
            this.gbSituacao.TabIndex = 8;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação Financeira";
            // 
            // ckbVeiculo
            // 
            this.ckbVeiculo.AutoSize = true;
            this.ckbVeiculo.Location = new System.Drawing.Point(6, 42);
            this.ckbVeiculo.Name = "ckbVeiculo";
            this.ckbVeiculo.Size = new System.Drawing.Size(101, 17);
            this.ckbVeiculo.TabIndex = 1;
            this.ckbVeiculo.Text = "Possui Veiculo?";
            this.ckbVeiculo.UseVisualStyleBackColor = true;
            // 
            // ckbCasaPropia
            // 
            this.ckbCasaPropia.AutoSize = true;
            this.ckbCasaPropia.Location = new System.Drawing.Point(6, 19);
            this.ckbCasaPropia.Name = "ckbCasaPropia";
            this.ckbCasaPropia.Size = new System.Drawing.Size(123, 17);
            this.ckbCasaPropia.TabIndex = 0;
            this.ckbCasaPropia.Text = "Possui Casa Própia?";
            this.ckbCasaPropia.UseVisualStyleBackColor = true;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Location = new System.Drawing.Point(9, 115);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(265, 21);
            this.cbEstadoCivil.TabIndex = 7;
            // 
            // mktTelefone
            // 
            this.mktTelefone.Location = new System.Drawing.Point(9, 76);
            this.mktTelefone.Mask = "(##) ##### - ####";
            this.mktTelefone.Name = "mktTelefone";
            this.mktTelefone.Size = new System.Drawing.Size(100, 20);
            this.mktTelefone.TabIndex = 6;
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Location = new System.Drawing.Point(115, 76);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(159, 20);
            this.dtDataNascimento.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(6, 60);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 3;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(6, 99);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lbEstadoCivil.TabIndex = 2;
            this.lbEstadoCivil.Text = "Estado Civil:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(112, 60);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(92, 13);
            this.lbDataNascimento.TabIndex = 1;
            this.lbDataNascimento.Text = "Data Nascimento:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 20);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.listResult);
            this.tpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(280, 295);
            this.tpConsulta.TabIndex = 1;
            this.tpConsulta.Text = "Consulta";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // listResult
            // 
            this.listResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(3, 3);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(274, 289);
            this.listResult.TabIndex = 0;
            this.listResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listResult_MouseDoubleClick);
            // 
            // tlpOpcoes
            // 
            this.tlpOpcoes.ColumnCount = 5;
            this.tlpPrincipal.SetColumnSpan(this.tlpOpcoes, 2);
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpOpcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOpcoes.Controls.Add(this.btnCadastrar, 0, 0);
            this.tlpOpcoes.Controls.Add(this.btnLimpar, 4, 0);
            this.tlpOpcoes.Controls.Add(this.btnExcluir, 2, 0);
            this.tlpOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOpcoes.Location = new System.Drawing.Point(3, 370);
            this.tlpOpcoes.Name = "tlpOpcoes";
            this.tlpOpcoes.RowCount = 1;
            this.tlpOpcoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOpcoes.Size = new System.Drawing.Size(288, 34);
            this.tlpOpcoes.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(86, 28);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.Location = new System.Drawing.Point(199, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 28);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Location = new System.Drawing.Point(101, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 28);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 407);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnFundoTitulo.ResumeLayout(false);
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.tcPrincipal.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.tpConsulta.ResumeLayout(false);
            this.tlpOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnFundoTitulo;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.MaskedTextBox mktTelefone;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.GroupBox gbSituacao;
        private System.Windows.Forms.CheckBox ckbVeiculo;
        private System.Windows.Forms.CheckBox ckbCasaPropia;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.TableLayoutPanel tlpOpcoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

