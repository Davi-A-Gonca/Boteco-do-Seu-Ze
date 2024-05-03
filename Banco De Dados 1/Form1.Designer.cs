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
            rdBtnRemover = new RadioButton();
            rdBtnAdicionar = new RadioButton();
            nmrcUpDwnAtualizar = new NumericUpDown();
            label8 = new Label();
            ConsumivelAtualizar = new Label();
            QuantNova = new Label();
            QuantAntiga = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnAtualizar = new Button();
            btnAdicionarVendivel = new Button();
            lstVw2 = new ListView();
            clmnHdrIDVendivel = new ColumnHeader();
            clmnHdrNomeVendivel = new ColumnHeader();
            clmnHdrQuantidadeVendivel = new ColumnHeader();
            clmnHdrValorVendivel = new ColumnHeader();
            btnRemoverEstoque = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDwnAtualizar).BeginInit();
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
            tabPage1.Text = "Pedidos";
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
            tabPage2.Controls.Add(btnRemoverEstoque);
            tabPage2.Controls.Add(rdBtnRemover);
            tabPage2.Controls.Add(rdBtnAdicionar);
            tabPage2.Controls.Add(nmrcUpDwnAtualizar);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(ConsumivelAtualizar);
            tabPage2.Controls.Add(QuantNova);
            tabPage2.Controls.Add(QuantAntiga);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnAtualizar);
            tabPage2.Controls.Add(btnAdicionarVendivel);
            tabPage2.Controls.Add(lstVw2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(590, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estoque/Cardápio";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdBtnRemover
            // 
            rdBtnRemover.AutoSize = true;
            rdBtnRemover.Location = new Point(420, 285);
            rdBtnRemover.Name = "rdBtnRemover";
            rdBtnRemover.Size = new Size(138, 19);
            rdBtnRemover.TabIndex = 16;
            rdBtnRemover.TabStop = true;
            rdBtnRemover.Text = "Remover Consumível";
            rdBtnRemover.UseVisualStyleBackColor = true;
            rdBtnRemover.CheckedChanged += rdBtnRemover_CheckedChanged;
            // 
            // rdBtnAdicionar
            // 
            rdBtnAdicionar.AutoSize = true;
            rdBtnAdicionar.Location = new Point(420, 260);
            rdBtnAdicionar.Name = "rdBtnAdicionar";
            rdBtnAdicionar.Size = new Size(142, 19);
            rdBtnAdicionar.TabIndex = 15;
            rdBtnAdicionar.TabStop = true;
            rdBtnAdicionar.Text = "Adicionar Consumível";
            rdBtnAdicionar.UseVisualStyleBackColor = true;
            rdBtnAdicionar.CheckedChanged += rdBtnAdicionar_CheckedChanged;
            // 
            // nmrcUpDwnAtualizar
            // 
            nmrcUpDwnAtualizar.Location = new Point(340, 268);
            nmrcUpDwnAtualizar.Name = "nmrcUpDwnAtualizar";
            nmrcUpDwnAtualizar.Size = new Size(74, 23);
            nmrcUpDwnAtualizar.TabIndex = 11;
            nmrcUpDwnAtualizar.ValueChanged += nmrcUpDwnAtualizar_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(201, 270);
            label8.Name = "label8";
            label8.Size = new Size(128, 15);
            label8.TabIndex = 10;
            label8.Text = "Quantidade a atualizar:";
            // 
            // ConsumivelAtualizar
            // 
            ConsumivelAtualizar.AutoSize = true;
            ConsumivelAtualizar.Location = new Point(308, 218);
            ConsumivelAtualizar.Name = "ConsumivelAtualizar";
            ConsumivelAtualizar.Size = new Size(0, 15);
            ConsumivelAtualizar.TabIndex = 8;
            // 
            // QuantNova
            // 
            QuantNova.AutoSize = true;
            QuantNova.Location = new Point(308, 299);
            QuantNova.Name = "QuantNova";
            QuantNova.Size = new Size(0, 15);
            QuantNova.TabIndex = 7;
            // 
            // QuantAntiga
            // 
            QuantAntiga.AutoSize = true;
            QuantAntiga.Location = new Point(308, 247);
            QuantAntiga.Name = "QuantAntiga";
            QuantAntiga.Size = new Size(0, 15);
            QuantAntiga.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 299);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 5;
            label7.Text = "Quantidade nova:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 247);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 4;
            label6.Text = "Quantidade atual:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 218);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Consumível:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(9, 243);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(156, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar o Estoque";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionarVendivel
            // 
            btnAdicionarVendivel.Location = new Point(9, 214);
            btnAdicionarVendivel.Name = "btnAdicionarVendivel";
            btnAdicionarVendivel.Size = new Size(156, 23);
            btnAdicionarVendivel.TabIndex = 1;
            btnAdicionarVendivel.Text = "Adicionar novo produto";
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
            lstVw2.Click += lstVw2_Click;
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
            // btnRemoverEstoque
            // 
            btnRemoverEstoque.Location = new Point(9, 272);
            btnRemoverEstoque.Name = "btnRemoverEstoque";
            btnRemoverEstoque.Size = new Size(156, 23);
            btnRemoverEstoque.TabIndex = 17;
            btnRemoverEstoque.Text = "Remover do Estoque";
            btnRemoverEstoque.UseVisualStyleBackColor = true;
            btnRemoverEstoque.Click += btnRemoverEstoque_Click;
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
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDwnAtualizar).EndInit();
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
        private Label ConsumivelAtualizar;
        private Label QuantNova;
        private Label QuantAntiga;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label8;
        private NumericUpDown nmrcUpDwnAtualizar;
        private RadioButton rdBtnRemover;
        private RadioButton rdBtnAdicionar;
        private Button btnRemoverEstoque;
    }
}
