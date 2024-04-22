namespace Sudoku
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
            this.bttn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.lbl_Errors = new System.Windows.Forms.Label();
            this.pnl_Table = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_Refresh
            // 
            this.bttn_Refresh.Location = new System.Drawing.Point(266, 489);
            this.bttn_Refresh.Name = "bttn_Refresh";
            this.bttn_Refresh.Size = new System.Drawing.Size(105, 32);
            this.bttn_Refresh.TabIndex = 9;
            this.bttn_Refresh.Text = "Reinicar Jogo";
            this.bttn_Refresh.UseVisualStyleBackColor = true;
            this.bttn_Refresh.Click += new System.EventHandler(this.bttn_Refresh_Click);
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Points.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Points.Location = new System.Drawing.Point(486, 22);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(61, 21);
            this.lbl_Points.TabIndex = 7;
            this.lbl_Points.Text = "Pontos:";
            // 
            // lbl_Errors
            // 
            this.lbl_Errors.AutoSize = true;
            this.lbl_Errors.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_Errors.Location = new System.Drawing.Point(45, 22);
            this.lbl_Errors.Name = "lbl_Errors";
            this.lbl_Errors.Size = new System.Drawing.Size(49, 21);
            this.lbl_Errors.TabIndex = 6;
            this.lbl_Errors.Text = "Erros:";
            // 
            // pnl_Table
            // 
            this.pnl_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Table.Location = new System.Drawing.Point(15, 49);
            this.pnl_Table.Name = "pnl_Table";
            this.pnl_Table.Size = new System.Drawing.Size(599, 434);
            this.pnl_Table.TabIndex = 8;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(259, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(112, 37);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Sudoku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 533);
            this.Controls.Add(this.bttn_Refresh);
            this.Controls.Add(this.lbl_Points);
            this.Controls.Add(this.lbl_Errors);
            this.Controls.Add(this.pnl_Table);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Refresh;
        private System.Windows.Forms.Label lbl_Points;
        private System.Windows.Forms.Label lbl_Errors;
        private System.Windows.Forms.Panel pnl_Table;
        private System.Windows.Forms.Label lbl_Title;
    }
}

