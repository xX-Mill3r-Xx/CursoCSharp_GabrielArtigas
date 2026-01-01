namespace ControleDeErros
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.Location = new System.Drawing.Point(113, 157);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(212, 73);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(12, 60);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(414, 94);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "...";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFor
            // 
            this.txtFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFor.Location = new System.Drawing.Point(309, 37);
            this.txtFor.Name = "txtFor";
            this.txtFor.Size = new System.Drawing.Size(117, 20);
            this.txtFor.TabIndex = 2;
            this.txtFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Defina o numero para passagem do Loop For sobre a Matriz";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(37, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(364, 25);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "Temos Uma Matriz de 5 Posições";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 243);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFor);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnExecutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamento de Erros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitulo;
    }
}

