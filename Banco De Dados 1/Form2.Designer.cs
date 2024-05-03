namespace Banco_De_Dados_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAdicionarConsumivel = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBxValorConsumivel = new TextBox();
            txtBxQuantidadeConsumivel = new TextBox();
            txtBxDescricaoConsumivel = new TextBox();
            tabPage2 = new TabPage();
            button1 = new Button();
            btnAdicionarIngredienteALista = new Button();
            lstVwIngredientes = new ListView();
            clmnHdrIngrediente = new ColumnHeader();
            clmnHdrQuantidade = new ColumnHeader();
            txtBxQuantidade = new TextBox();
            label9 = new Label();
            btnAdicionarReceita = new Button();
            txtBxIngredientesReceita = new TextBox();
            txtBxValorReceita = new TextBox();
            txtBxNomeReceita = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            btnAdicionarIngrediente = new Button();
            label8 = new Label();
            label7 = new Label();
            txtBxQuantidadeIngrediente = new TextBox();
            txtBxNomeIngrediente = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(394, 256);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAdicionarConsumivel);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtBxValorConsumivel);
            tabPage1.Controls.Add(txtBxQuantidadeConsumivel);
            tabPage1.Controls.Add(txtBxDescricaoConsumivel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(386, 228);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consumiveis";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarConsumivel
            // 
            btnAdicionarConsumivel.Location = new Point(8, 148);
            btnAdicionarConsumivel.Name = "btnAdicionarConsumivel";
            btnAdicionarConsumivel.Size = new Size(75, 23);
            btnAdicionarConsumivel.TabIndex = 6;
            btnAdicionarConsumivel.Text = "Adicionar";
            btnAdicionarConsumivel.UseVisualStyleBackColor = true;
            btnAdicionarConsumivel.Click += btnAdicionarConsumivel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 91);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 47);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantidade em estoque";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Descrição";
            // 
            // txtBxValorConsumivel
            // 
            txtBxValorConsumivel.Location = new Point(8, 109);
            txtBxValorConsumivel.Name = "txtBxValorConsumivel";
            txtBxValorConsumivel.Size = new Size(100, 23);
            txtBxValorConsumivel.TabIndex = 2;
            // 
            // txtBxQuantidadeConsumivel
            // 
            txtBxQuantidadeConsumivel.Location = new Point(8, 65);
            txtBxQuantidadeConsumivel.Name = "txtBxQuantidadeConsumivel";
            txtBxQuantidadeConsumivel.Size = new Size(100, 23);
            txtBxQuantidadeConsumivel.TabIndex = 1;
            // 
            // txtBxDescricaoConsumivel
            // 
            txtBxDescricaoConsumivel.Location = new Point(8, 21);
            txtBxDescricaoConsumivel.Name = "txtBxDescricaoConsumivel";
            txtBxDescricaoConsumivel.Size = new Size(100, 23);
            txtBxDescricaoConsumivel.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(btnAdicionarIngredienteALista);
            tabPage2.Controls.Add(lstVwIngredientes);
            tabPage2.Controls.Add(txtBxQuantidade);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(btnAdicionarReceita);
            tabPage2.Controls.Add(txtBxIngredientesReceita);
            tabPage2.Controls.Add(txtBxValorReceita);
            tabPage2.Controls.Add(txtBxNomeReceita);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(386, 228);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Receitas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(201, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarIngredienteALista
            // 
            btnAdicionarIngredienteALista.Location = new Point(174, 138);
            btnAdicionarIngredienteALista.Name = "btnAdicionarIngredienteALista";
            btnAdicionarIngredienteALista.Size = new Size(163, 23);
            btnAdicionarIngredienteALista.TabIndex = 10;
            btnAdicionarIngredienteALista.Text = "Adicionar Ingrediente a lista";
            btnAdicionarIngredienteALista.UseVisualStyleBackColor = true;
            btnAdicionarIngredienteALista.Click += btnAdicionarIngredienteALista_Click;
            // 
            // lstVwIngredientes
            // 
            lstVwIngredientes.AllowColumnReorder = true;
            lstVwIngredientes.Columns.AddRange(new ColumnHeader[] { clmnHdrIngrediente, clmnHdrQuantidade });
            lstVwIngredientes.FullRowSelect = true;
            lstVwIngredientes.GridLines = true;
            lstVwIngredientes.LabelEdit = true;
            lstVwIngredientes.Location = new Point(173, 3);
            lstVwIngredientes.Name = "lstVwIngredientes";
            lstVwIngredientes.Size = new Size(207, 129);
            lstVwIngredientes.TabIndex = 9;
            lstVwIngredientes.UseCompatibleStateImageBehavior = false;
            lstVwIngredientes.View = View.Details;
            // 
            // clmnHdrIngrediente
            // 
            clmnHdrIngrediente.Text = "Ingrediente";
            clmnHdrIngrediente.Width = 100;
            // 
            // clmnHdrQuantidade
            // 
            clmnHdrQuantidade.Text = "Quantidade";
            clmnHdrQuantidade.Width = 100;
            // 
            // txtBxQuantidade
            // 
            txtBxQuantidade.Location = new Point(8, 109);
            txtBxQuantidade.Name = "txtBxQuantidade";
            txtBxQuantidade.Size = new Size(100, 23);
            txtBxQuantidade.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(-4, 91);
            label9.Name = "label9";
            label9.Size = new Size(159, 15);
            label9.TabIndex = 7;
            label9.Text = "Quantidade dos ingredinetes";
            // 
            // btnAdicionarReceita
            // 
            btnAdicionarReceita.Location = new Point(8, 182);
            btnAdicionarReceita.Name = "btnAdicionarReceita";
            btnAdicionarReceita.Size = new Size(75, 23);
            btnAdicionarReceita.TabIndex = 6;
            btnAdicionarReceita.Text = "Adicionar";
            btnAdicionarReceita.UseVisualStyleBackColor = true;
            btnAdicionarReceita.Click += btnAdicionarReceita_Click;
            // 
            // txtBxIngredientesReceita
            // 
            txtBxIngredientesReceita.Location = new Point(8, 65);
            txtBxIngredientesReceita.Name = "txtBxIngredientesReceita";
            txtBxIngredientesReceita.Size = new Size(100, 23);
            txtBxIngredientesReceita.TabIndex = 5;
            // 
            // txtBxValorReceita
            // 
            txtBxValorReceita.Location = new Point(8, 153);
            txtBxValorReceita.Name = "txtBxValorReceita";
            txtBxValorReceita.Size = new Size(100, 23);
            txtBxValorReceita.TabIndex = 4;
            // 
            // txtBxNomeReceita
            // 
            txtBxNomeReceita.Location = new Point(8, 21);
            txtBxNomeReceita.Name = "txtBxNomeReceita";
            txtBxNomeReceita.Size = new Size(100, 23);
            txtBxNomeReceita.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 135);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 2;
            label6.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 47);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 1;
            label5.Text = "Ingredientes necessários";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 3);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAdicionarIngrediente);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtBxQuantidadeIngrediente);
            tabPage3.Controls.Add(txtBxNomeIngrediente);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(386, 228);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ingredientes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarIngrediente
            // 
            btnAdicionarIngrediente.Location = new Point(8, 94);
            btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            btnAdicionarIngrediente.Size = new Size(75, 23);
            btnAdicionarIngrediente.TabIndex = 4;
            btnAdicionarIngrediente.Text = "Adicionar";
            btnAdicionarIngrediente.UseVisualStyleBackColor = true;
            btnAdicionarIngrediente.Click += btnAdicionarIngrediente_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 47);
            label8.Name = "label8";
            label8.Size = new Size(134, 15);
            label8.TabIndex = 3;
            label8.Text = "Quantidade em Estoque";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 3);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 2;
            label7.Text = "Nome";
            // 
            // txtBxQuantidadeIngrediente
            // 
            txtBxQuantidadeIngrediente.Location = new Point(8, 65);
            txtBxQuantidadeIngrediente.Name = "txtBxQuantidadeIngrediente";
            txtBxQuantidadeIngrediente.Size = new Size(100, 23);
            txtBxQuantidadeIngrediente.TabIndex = 1;
            // 
            // txtBxNomeIngrediente
            // 
            txtBxNomeIngrediente.Location = new Point(8, 21);
            txtBxNomeIngrediente.Name = "txtBxNomeIngrediente";
            txtBxNomeIngrediente.Size = new Size(100, 23);
            txtBxNomeIngrediente.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 241);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Adicionar estoque";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtBxValorConsumivel;
        private TextBox txtBxQuantidadeConsumivel;
        private TextBox txtBxDescricaoConsumivel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox txtBxIngredientesReceita;
        private TextBox txtBxValorReceita;
        private TextBox txtBxNomeReceita;
        private Label label6;
        private Label label8;
        private Label label7;
        private TextBox txtBxQuantidadeIngrediente;
        private TextBox txtBxNomeIngrediente;
        private Button btnAdicionarConsumivel;
        private Button btnAdicionarReceita;
        private Button btnAdicionarIngrediente;
        private TextBox txtBxQuantidade;
        private Label label9;
        private ListView lstVwIngredientes;
        private ColumnHeader clmnHdrIngrediente;
        private ColumnHeader clmnHdrQuantidade;
        private Button btnAdicionarIngredienteALista;
        private Button button1;
    }
}