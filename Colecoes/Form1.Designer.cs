namespace Colecoes
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
            this.lista = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnSortedDictionary = new System.Windows.Forms.Button();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 15;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(301, 229);
            this.lista.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Navy;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(319, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(151, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List<>";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.BackColor = System.Drawing.Color.Navy;
            this.btnHashSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHashSet.FlatAppearance.BorderSize = 0;
            this.btnHashSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnHashSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHashSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHashSet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashSet.ForeColor = System.Drawing.Color.White;
            this.btnHashSet.Location = new System.Drawing.Point(319, 41);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(151, 23);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = false;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.BackColor = System.Drawing.Color.Navy;
            this.btnDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDictionary.FlatAppearance.BorderSize = 0;
            this.btnDictionary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDictionary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDictionary.ForeColor = System.Drawing.Color.White;
            this.btnDictionary.Location = new System.Drawing.Point(319, 70);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(151, 23);
            this.btnDictionary.TabIndex = 3;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = false;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.BackColor = System.Drawing.Color.Navy;
            this.btnSortedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortedList.FlatAppearance.BorderSize = 0;
            this.btnSortedList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSortedList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSortedList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortedList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedList.ForeColor = System.Drawing.Color.White;
            this.btnSortedList.Location = new System.Drawing.Point(319, 99);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(151, 23);
            this.btnSortedList.TabIndex = 4;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.UseVisualStyleBackColor = false;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnSortedDictionary
            // 
            this.btnSortedDictionary.BackColor = System.Drawing.Color.Navy;
            this.btnSortedDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortedDictionary.FlatAppearance.BorderSize = 0;
            this.btnSortedDictionary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSortedDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSortedDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortedDictionary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedDictionary.ForeColor = System.Drawing.Color.White;
            this.btnSortedDictionary.Location = new System.Drawing.Point(319, 131);
            this.btnSortedDictionary.Name = "btnSortedDictionary";
            this.btnSortedDictionary.Size = new System.Drawing.Size(151, 23);
            this.btnSortedDictionary.TabIndex = 5;
            this.btnSortedDictionary.Text = "SortedDictionary";
            this.btnSortedDictionary.UseVisualStyleBackColor = false;
            this.btnSortedDictionary.Click += new System.EventHandler(this.btnSortedDictionary_Click);
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.BackColor = System.Drawing.Color.Navy;
            this.btnSortedSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortedSet.FlatAppearance.BorderSize = 0;
            this.btnSortedSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSortedSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSortedSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortedSet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedSet.ForeColor = System.Drawing.Color.White;
            this.btnSortedSet.Location = new System.Drawing.Point(319, 160);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(151, 23);
            this.btnSortedSet.TabIndex = 6;
            this.btnSortedSet.Text = "SortedSet";
            this.btnSortedSet.UseVisualStyleBackColor = false;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.BackColor = System.Drawing.Color.Navy;
            this.btnQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueue.FlatAppearance.BorderSize = 0;
            this.btnQueue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.ForeColor = System.Drawing.Color.White;
            this.btnQueue.Location = new System.Drawing.Point(319, 189);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(151, 23);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = false;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.BackColor = System.Drawing.Color.Navy;
            this.btnStack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStack.FlatAppearance.BorderSize = 0;
            this.btnStack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnStack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack.ForeColor = System.Drawing.Color.White;
            this.btnStack.Location = new System.Drawing.Point(319, 218);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(151, 23);
            this.btnStack.TabIndex = 8;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = false;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 249);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSortedSet);
            this.Controls.Add(this.btnSortedDictionary);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lista);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coleções Avançadas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btnSortedDictionary;
        private System.Windows.Forms.Button btnSortedSet;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
    }
}

