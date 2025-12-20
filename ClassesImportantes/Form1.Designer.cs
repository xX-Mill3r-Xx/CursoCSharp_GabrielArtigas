namespace ClassesImportantes
{
    partial class FrmPrincipal
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRandon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.BackColor = System.Drawing.Color.Navy;
            this.btnMessageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessageBox.FlatAppearance.BorderSize = 0;
            this.btnMessageBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMessageBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMessageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageBox.ForeColor = System.Drawing.Color.White;
            this.btnMessageBox.Location = new System.Drawing.Point(12, 56);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(149, 41);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = false;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 12);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(592, 41);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRandon
            // 
            this.btnRandon.BackColor = System.Drawing.Color.Navy;
            this.btnRandon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandon.FlatAppearance.BorderSize = 0;
            this.btnRandon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnRandon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRandon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandon.ForeColor = System.Drawing.Color.White;
            this.btnRandon.Location = new System.Drawing.Point(12, 103);
            this.btnRandon.Name = "btnRandon";
            this.btnRandon.Size = new System.Drawing.Size(149, 41);
            this.btnRandon.TabIndex = 2;
            this.btnRandon.Text = "Classe Randon";
            this.btnRandon.UseVisualStyleBackColor = false;
            this.btnRandon.Click += new System.EventHandler(this.btnRandon_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 519);
            this.Controls.Add(this.btnRandon);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMessageBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes Importantes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRandon;
    }
}

