namespace Banco_De_Dados_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstVw1 = new ListView();
            clmnHdrIDPedido = new ColumnHeader();
            clmnHdrPedidos = new ColumnHeader();
            clmnHdrQuantidadePedido = new ColumnHeader();
            clmnHdrCliente = new ColumnHeader();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblValorPedido = new Label();
            label5 = new Label();
            btnBuscarCliente = new Button();
            btnRemover = new Button();
            btnAdicionarPedido = new Button();
            txtBxIdentificadorCliente = new TextBox();
            lstBxVendiveis = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBxQuantidadeDePedido = new TextBox();
            txtBxPedido = new TextBox();
            tabPage2 = new TabPage();
            btnAtualizar = new Button();
            btnAdicionarVendivel = new Button();
            lstVw2 = new ListView();
            clmnHdrIDVendivel = new ColumnHeader();
            clmnHdrNomeVendivel = new ColumnHeader();
            clmnHdrQuantidadeVendivel = new ColumnHeader();
            clmnHdrValorVendivel = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lstVw1
            // 
            lstVw1.AllowColumnReorder = true;
            lstVw1.Columns.AddRange(new ColumnHeader[] { clmnHdrIDPedido, clmnHdrPedidos, clmnHdrQuantidadePedido, clmnHdrCliente });
            lstVw1.FullRowSelect = true;
            lstVw1.GridLines = true;
            lstVw1.LabelEdit = true;
            lstVw1.Location = new Point(9, 6);
            lstVw1.Name = "lstVw1";
            lstVw1.Size = new Size(568, 182);
            lstVw1.TabIndex = 4;
            lstVw1.UseCompatibleStateImageBehavior = false;
            lstVw1.View = View.Details;
            // 
            // clmnHdrIDPedido
            // 
            clmnHdrIDPedido.Text = "ID";
            clmnHdrIDPedido.Width = 40;
            // 
            // clmnHdrPedidos
            // 
            clmnHdrPedidos.Text = "Pedidos";
            clmnHdrPedidos.Width = 200;
            // 
            // clmnHdrQuantidadePedido
            // 
            clmnHdrQuantidadePedido.Text = "Quantidade";
            // 
            // clmnHdrCliente
            // 
            clmnHdrCliente.Text = "Cliente";
            clmnHdrCliente.Width = 200;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(598, 396);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblValorPedido);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnBuscarCliente);
            tabPage1.Controls.Add(btnRemover);
            tabPage1.Controls.Add(btnAdicionarPedido);
            tabPage1.Controls.Add(txtBxIdentificadorCliente);
            tabPage1.Controls.Add(lstBxVendiveis);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtBxQuantidadeDePedido);
            tabPage1.Controls.Add(txtBxPedido);
            tabPage1.Controls.Add(lstVw1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(590, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblValorPedido
            // 
            lblValorPedido.AutoSize = true;
            lblValorPedido.Location = new Point(58, 295);
            lblValorPedido.Name = "lblValorPedido";
            lblValorPedido.Size = new Size(13, 15);
            lblValorPedido.TabIndex = 18;
            lblValorPedido.Text = "  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 295);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 17;
            label5.Text = "Valor: R$";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(237, 255);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(100, 38);
            btnBuscarCliente.TabIndex = 15;
            btnBuscarCliente.Text = "Buscar pedidos pelo cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(124, 255);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 23);
            btnRemover.TabIndex = 14;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionarPedido
            // 
            btnAdicionarPedido.Location = new Point(9, 255);
            btnAdicionarPedido.Name = "btnAdicionarPedido";
            btnAdicionarPedido.Size = new Size(100, 23);
            btnAdicionarPedido.TabIndex = 13;
            btnAdicionarPedido.Text = "Adicionar";
            btnAdicionarPedido.UseVisualStyleBackColor = true;
            btnAdicionarPedido.Click += btnAdicionarPedido_Click;
            // 
            // txtBxIdentificadorCliente
            // 
            txtBxIdentificadorCliente.Location = new Point(237, 218);
            txtBxIdentificadorCliente.Name = "txtBxIdentificadorCliente";
            txtBxIdentificadorCliente.Size = new Size(100, 23);
            txtBxIdentificadorCliente.TabIndex = 12;
            // 
            // lstBxVendiveis
            // 
            lstBxVendiveis.FormattingEnabled = true;
            lstBxVendiveis.ItemHeight = 15;
            lstBxVendiveis.Location = new Point(343, 194);
            lstBxVendiveis.Name = "lstBxVendiveis";
            lstBxVendiveis.Size = new Size(104, 139);
            lstBxVendiveis.TabIndex = 11;
            lstBxVendiveis.Click += lstBxVendiveis_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 200);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 200);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 200);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 8;
            label1.Text = "Pedido";
            // 
            // txtBxQuantidadeDePedido
            // 
            txtBxQuantidadeDePedido.Location = new Point(124, 218);
            txtBxQuantidadeDePedido.Name = "txtBxQuantidadeDePedido";
            txtBxQuantidadeDePedido.Size = new Size(100, 23);
            txtBxQuantidadeDePedido.TabIndex = 7;
            // 
            // txtBxPedido
            // 
            txtBxPedido.Location = new Point(9, 218);
            txtBxPedido.Name = "txtBxPedido";
            txtBxPedido.Size = new Size(100, 23);
            txtBxPedido.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAtualizar);
            tabPage2.Controls.Add(btnAdicionarVendivel);
            tabPage2.Controls.Add(lstVw2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(590, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(90, 214);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionarVendivel
            // 
            btnAdicionarVendivel.Location = new Point(9, 214);
            btnAdicionarVendivel.Name = "btnAdicionarVendivel";
            btnAdicionarVendivel.Size = new Size(75, 23);
            btnAdicionarVendivel.TabIndex = 1;
            btnAdicionarVendivel.Text = "Adicionar";
            btnAdicionarVendivel.UseVisualStyleBackColor = true;
            btnAdicionarVendivel.Click += btnAdicionarVendivel_Click;
            // 
            // lstVw2
            // 
            lstVw2.AllowColumnReorder = true;
            lstVw2.Columns.AddRange(new ColumnHeader[] { clmnHdrIDVendivel, clmnHdrNomeVendivel, clmnHdrQuantidadeVendivel, clmnHdrValorVendivel });
            lstVw2.FullRowSelect = true;
            lstVw2.GridLines = true;
            lstVw2.LabelEdit = true;
            lstVw2.Location = new Point(3, 6);
            lstVw2.Name = "lstVw2";
            lstVw2.Size = new Size(574, 188);
            lstVw2.TabIndex = 0;
            lstVw2.UseCompatibleStateImageBehavior = false;
            lstVw2.View = View.Details;
            // 
            // clmnHdrIDVendivel
            // 
            clmnHdrIDVendivel.Text = "ID";
            // 
            // clmnHdrNomeVendivel
            // 
            clmnHdrNomeVendivel.Text = "Nome";
            clmnHdrNomeVendivel.Width = 200;
            // 
            // clmnHdrQuantidadeVendivel
            // 
            clmnHdrQuantidadeVendivel.Text = "Quantidade";
            // 
            // clmnHdrValorVendivel
            // 
            clmnHdrValorVendivel.Text = "Valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 387);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtBxTeste1;
        private ListView lstVw1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtBxQuantidadeDePedido;
        private TextBox txtBxPedido;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lstBxVendiveis;
        private Button btnRemover;
        private Button btnAdicionarPedido;
        private TextBox txtBxIdentificadorCliente;
        private Button btnBuscarCliente;
        private ListView lstVw2;
        private Button btnAdicionarVendivel;
        private Button btnAtualizar;
        private ColumnHeader clmnHdrIDPedido;
        private ColumnHeader clmnHdrPedidos;
        private ColumnHeader clmnHdrCliente;
        private ColumnHeader clmnHdrQuantidadePedido;
        private ColumnHeader clmnHdrIDVendivel;
        private ColumnHeader clmnHdrQuantidadeVendivel;
        private ColumnHeader clmnHdrNomeVendivel;
        private ColumnHeader clmnHdrValorVendivel;
        private Label lblValorPedido;
        private Label label5;
    }
}
