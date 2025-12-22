namespace GaroliBudget
{
    partial class OR0001mnIncluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OR0001mnIncluir));
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            tbRazaoSocial = new TextBox();
            cbClientes = new ComboBox();
            panel1 = new Panel();
            tbTelefoneCliente = new TextBox();
            tbNomeCliente = new TextBox();
            tcOrcamento = new TabControl();
            tpMateriais = new TabPage();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnExcluir = new Button();
            btnIncluir = new Button();
            btnEditar = new Button();
            dgvMateriais = new DataGridView();
            descricao = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            valorUnitario = new DataGridViewTextBoxColumn();
            valorTotal = new DataGridViewTextBoxColumn();
            tbComponentes = new TabPage();
            tpProcessos = new TabPage();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            lblValorFinal = new Label();
            panel1.SuspendLayout();
            tcOrcamento.SuspendLayout();
            tpMateriais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 11;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 10;
            label1.Text = "Código";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(570, 518);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGravar.Location = new Point(483, 518);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.TextAlign = ContentAlignment.MiddleRight;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // tbRazaoSocial
            // 
            tbRazaoSocial.Location = new Point(12, 23);
            tbRazaoSocial.Name = "tbRazaoSocial";
            tbRazaoSocial.ReadOnly = true;
            tbRazaoSocial.Size = new Size(103, 23);
            tbRazaoSocial.TabIndex = 6;
            tbRazaoSocial.Text = "9999";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(12, 69);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(278, 23);
            cbClientes.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(tbTelefoneCliente);
            panel1.Controls.Add(tbNomeCliente);
            panel1.Controls.Add(tbRazaoSocial);
            panel1.Controls.Add(cbClientes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 106);
            panel1.TabIndex = 20;
            // 
            // tbTelefoneCliente
            // 
            tbTelefoneCliente.Location = new Point(449, 69);
            tbTelefoneCliente.Name = "tbTelefoneCliente";
            tbTelefoneCliente.ReadOnly = true;
            tbTelefoneCliente.Size = new Size(138, 23);
            tbTelefoneCliente.TabIndex = 21;
            tbTelefoneCliente.Text = "<Telefone>";
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Location = new Point(305, 69);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.ReadOnly = true;
            tbNomeCliente.Size = new Size(138, 23);
            tbNomeCliente.TabIndex = 20;
            tbNomeCliente.Text = "<Nome>";
            // 
            // tcOrcamento
            // 
            tcOrcamento.Controls.Add(tpMateriais);
            tcOrcamento.Controls.Add(tbComponentes);
            tcOrcamento.Controls.Add(tpProcessos);
            tcOrcamento.Location = new Point(8, 122);
            tcOrcamento.Name = "tcOrcamento";
            tcOrcamento.SelectedIndex = 0;
            tcOrcamento.Size = new Size(641, 357);
            tcOrcamento.TabIndex = 21;
            // 
            // tpMateriais
            // 
            tpMateriais.Controls.Add(label4);
            tpMateriais.Controls.Add(textBox1);
            tpMateriais.Controls.Add(label3);
            tpMateriais.Controls.Add(comboBox1);
            tpMateriais.Controls.Add(btnExcluir);
            tpMateriais.Controls.Add(btnIncluir);
            tpMateriais.Controls.Add(btnEditar);
            tpMateriais.Controls.Add(dgvMateriais);
            tpMateriais.Location = new Point(4, 24);
            tpMateriais.Name = "tpMateriais";
            tpMateriais.Padding = new Padding(3);
            tpMateriais.Size = new Size(633, 329);
            tpMateriais.TabIndex = 0;
            tpMateriais.Text = "Materiais";
            tpMateriais.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 16);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 23;
            label4.Text = "Quantidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 21;
            label3.Text = "Item";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(328, 23);
            comboBox1.TabIndex = 20;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.White;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Font = new Font("Segoe UI", 8F);
            btnExcluir.Location = new Point(579, 31);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 9;
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIncluir.BackColor = Color.White;
            btnIncluir.BackgroundImage = (Image)resources.GetObject("btnIncluir.BackgroundImage");
            btnIncluir.BackgroundImageLayout = ImageLayout.Center;
            btnIncluir.Font = new Font("Segoe UI", 8F);
            btnIncluir.Location = new Point(471, 31);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(47, 25);
            btnIncluir.TabIndex = 7;
            btnIncluir.TextAlign = ContentAlignment.TopCenter;
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.White;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Font = new Font("Segoe UI", 8F);
            btnEditar.Location = new Point(524, 31);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(47, 25);
            btnEditar.TabIndex = 8;
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvMateriais
            // 
            dgvMateriais.AllowUserToAddRows = false;
            dgvMateriais.AllowUserToDeleteRows = false;
            dgvMateriais.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriais.Columns.AddRange(new DataGridViewColumn[] { descricao, quantidade, valorUnitario, valorTotal });
            dgvMateriais.Location = new Point(0, 65);
            dgvMateriais.Name = "dgvMateriais";
            dgvMateriais.ReadOnly = true;
            dgvMateriais.Size = new Size(633, 268);
            dgvMateriais.TabIndex = 0;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            descricao.Width = 280;
            // 
            // quantidade
            // 
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // valorUnitario
            // 
            valorUnitario.HeaderText = "Valor unitário";
            valorUnitario.Name = "valorUnitario";
            valorUnitario.ReadOnly = true;
            // 
            // valorTotal
            // 
            valorTotal.HeaderText = "Valor total";
            valorTotal.Name = "valorTotal";
            valorTotal.ReadOnly = true;
            // 
            // tbComponentes
            // 
            tbComponentes.Location = new Point(4, 24);
            tbComponentes.Name = "tbComponentes";
            tbComponentes.Padding = new Padding(3);
            tbComponentes.Size = new Size(633, 329);
            tbComponentes.TabIndex = 1;
            tbComponentes.Text = "Componentes";
            tbComponentes.UseVisualStyleBackColor = true;
            // 
            // tpProcessos
            // 
            tpProcessos.Location = new Point(4, 24);
            tpProcessos.Name = "tpProcessos";
            tpProcessos.Padding = new Padding(3);
            tpProcessos.Size = new Size(633, 329);
            tpProcessos.TabIndex = 2;
            tpProcessos.Text = "Mão de Obra";
            tpProcessos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 537);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 22;
            label5.Text = "TOTAL: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 484);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 25;
            label6.Text = "Margem de contribuição";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 502);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 24;
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValorFinal.Location = new Point(62, 537);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(31, 15);
            lblValorFinal.TabIndex = 26;
            lblValorFinal.Text = "0.00";
            // 
            // OR0001mnIncluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 574);
            Controls.Add(lblValorFinal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(tcOrcamento);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "OR0001mnIncluir";
            Text = "Menu principal";
            Load += OR0001mnIncluir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcOrcamento.ResumeLayout(false);
            tpMateriais.ResumeLayout(false);
            tpMateriais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox tbRazaoSocial;
        private ComboBox cbClientes;
        private Panel panel1;
        private TextBox tbTelefoneCliente;
        private TextBox tbNomeCliente;
        private TabControl tcOrcamento;
        private TabPage tpMateriais;
        private TabPage tbComponentes;
        private DataGridView dgvMateriais;
        private TabPage tpProcessos;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn valorUnitario;
        private DataGridViewTextBoxColumn valorTotal;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnExcluir;
        private Button btnIncluir;
        private Button btnEditar;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label lblValorFinal;
    }
}
