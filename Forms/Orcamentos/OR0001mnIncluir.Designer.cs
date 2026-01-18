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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            tbNumeroOrcamento = new TextBox();
            panel1 = new Panel();
            tbObservacoes = new TextBox();
            label12 = new Label();
            label11 = new Label();
            cbCliente = new ComboBox();
            label2 = new Label();
            cbEquipamento = new ComboBox();
            gbOrcamento = new GroupBox();
            tcItens = new TabControl();
            tpMateriais = new TabPage();
            btnExcluirMaterial = new Button();
            btnIncluirMaterial = new Button();
            label4 = new Label();
            tbMateriaisQuantidade = new TextBox();
            label3 = new Label();
            cbMateriais = new ComboBox();
            btnExcluir = new Button();
            dgvMateriais = new DataGridView();
            Descricao = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            CustoUnitario = new DataGridViewTextBoxColumn();
            valorTotalMaterial = new DataGridViewTextBoxColumn();
            tpComponentes = new TabPage();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            tbComponentesQuantidade = new TextBox();
            label8 = new Label();
            cbComponentes = new ComboBox();
            button1 = new Button();
            dgvComponentes = new DataGridView();
            descricaoComponente = new DataGridViewTextBoxColumn();
            quantidadeComponente = new DataGridViewTextBoxColumn();
            valorUnitarioComponente = new DataGridViewTextBoxColumn();
            valorTotalComponente = new DataGridViewTextBoxColumn();
            tpProcessos = new TabPage();
            button5 = new Button();
            button6 = new Button();
            label9 = new Label();
            tbProcessosQuantidade = new TextBox();
            label10 = new Label();
            cbProcessos = new ComboBox();
            button4 = new Button();
            dgvProcessos = new DataGridView();
            descricaoProcesso = new DataGridViewTextBoxColumn();
            quantidadeProcesso = new DataGridViewTextBoxColumn();
            valorUnitarioProcesso = new DataGridViewTextBoxColumn();
            valorTotalProcesso = new DataGridViewTextBoxColumn();
            btnExcluirModulo = new FontAwesome.Sharp.IconButton();
            btnIncluirModulo = new FontAwesome.Sharp.IconButton();
            treeViewModulos = new TreeView();
            nmMargem = new NumericUpDown();
            lblValorFinal = new Label();
            label6 = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            panel1.SuspendLayout();
            gbOrcamento.SuspendLayout();
            tcItens.SuspendLayout();
            tpMateriais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).BeginInit();
            tpComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComponentes).BeginInit();
            tpProcessos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcessos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmMargem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 6);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Número";
            // 
            // tbNumeroOrcamento
            // 
            tbNumeroOrcamento.Location = new Point(16, 23);
            tbNumeroOrcamento.Name = "tbNumeroOrcamento";
            tbNumeroOrcamento.Size = new Size(78, 23);
            tbNumeroOrcamento.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(tbObservacoes);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(cbCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbEquipamento);
            panel1.Controls.Add(tbNumeroOrcamento);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 106);
            panel1.TabIndex = 20;
            // 
            // tbObservacoes
            // 
            tbObservacoes.Location = new Point(437, 24);
            tbObservacoes.Multiline = true;
            tbObservacoes.Name = "tbObservacoes";
            tbObservacoes.Size = new Size(314, 68);
            tbObservacoes.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(437, 5);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 26;
            label12.Text = "Observações";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(110, 5);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 24;
            label11.Text = "Cliente";
            // 
            // cbCliente
            // 
            cbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(106, 23);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(310, 23);
            cbCliente.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 49);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 22;
            label2.Text = "Equipamento";
            // 
            // cbEquipamento
            // 
            cbEquipamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEquipamento.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbEquipamento.FormattingEnabled = true;
            cbEquipamento.Location = new Point(16, 68);
            cbEquipamento.Name = "cbEquipamento";
            cbEquipamento.Size = new Size(400, 23);
            cbEquipamento.TabIndex = 21;
            cbEquipamento.SelectedIndexChanged += cbEquipamento_SelectedIndexChanged;
            // 
            // gbOrcamento
            // 
            gbOrcamento.Controls.Add(tcItens);
            gbOrcamento.Controls.Add(btnExcluirModulo);
            gbOrcamento.Controls.Add(btnIncluirModulo);
            gbOrcamento.Controls.Add(treeViewModulos);
            gbOrcamento.Controls.Add(nmMargem);
            gbOrcamento.Controls.Add(lblValorFinal);
            gbOrcamento.Controls.Add(label6);
            gbOrcamento.Controls.Add(label5);
            gbOrcamento.Controls.Add(btnCancelar);
            gbOrcamento.Controls.Add(btnGravar);
            gbOrcamento.Enabled = false;
            gbOrcamento.Location = new Point(4, 107);
            gbOrcamento.Name = "gbOrcamento";
            gbOrcamento.Size = new Size(751, 467);
            gbOrcamento.TabIndex = 21;
            gbOrcamento.TabStop = false;
            // 
            // tcItens
            // 
            tcItens.Controls.Add(tpMateriais);
            tcItens.Controls.Add(tpComponentes);
            tcItens.Controls.Add(tpProcessos);
            tcItens.Enabled = false;
            tcItens.Location = new Point(216, 19);
            tcItens.Name = "tcItens";
            tcItens.SelectedIndex = 0;
            tcItens.Size = new Size(529, 357);
            tcItens.TabIndex = 41;
            // 
            // tpMateriais
            // 
            tpMateriais.Controls.Add(btnExcluirMaterial);
            tpMateriais.Controls.Add(btnIncluirMaterial);
            tpMateriais.Controls.Add(label4);
            tpMateriais.Controls.Add(tbMateriaisQuantidade);
            tpMateriais.Controls.Add(label3);
            tpMateriais.Controls.Add(cbMateriais);
            tpMateriais.Controls.Add(btnExcluir);
            tpMateriais.Controls.Add(dgvMateriais);
            tpMateriais.Location = new Point(4, 24);
            tpMateriais.Name = "tpMateriais";
            tpMateriais.Padding = new Padding(3);
            tpMateriais.Size = new Size(521, 329);
            tpMateriais.TabIndex = 0;
            tpMateriais.Text = "Materiais";
            tpMateriais.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMaterial
            // 
            btnExcluirMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirMaterial.BackColor = Color.White;
            btnExcluirMaterial.BackgroundImage = (Image)resources.GetObject("btnExcluirMaterial.BackgroundImage");
            btnExcluirMaterial.BackgroundImageLayout = ImageLayout.Center;
            btnExcluirMaterial.Font = new Font("Segoe UI", 8F);
            btnExcluirMaterial.Location = new Point(468, 31);
            btnExcluirMaterial.Name = "btnExcluirMaterial";
            btnExcluirMaterial.Size = new Size(47, 25);
            btnExcluirMaterial.TabIndex = 25;
            btnExcluirMaterial.TextAlign = ContentAlignment.TopCenter;
            btnExcluirMaterial.UseVisualStyleBackColor = false;
            btnExcluirMaterial.Click += btnExcluir_Click;
            // 
            // btnIncluirMaterial
            // 
            btnIncluirMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIncluirMaterial.BackColor = Color.White;
            btnIncluirMaterial.BackgroundImage = (Image)resources.GetObject("btnIncluirMaterial.BackgroundImage");
            btnIncluirMaterial.BackgroundImageLayout = ImageLayout.Center;
            btnIncluirMaterial.Font = new Font("Segoe UI", 8F);
            btnIncluirMaterial.Location = new Point(415, 31);
            btnIncluirMaterial.Name = "btnIncluirMaterial";
            btnIncluirMaterial.Size = new Size(47, 25);
            btnIncluirMaterial.TabIndex = 24;
            btnIncluirMaterial.TextAlign = ContentAlignment.TopCenter;
            btnIncluirMaterial.UseVisualStyleBackColor = false;
            btnIncluirMaterial.Click += btnIncluir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 18);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 23;
            label4.Text = "Quantidade";
            // 
            // tbMateriaisQuantidade
            // 
            tbMateriaisQuantidade.Location = new Point(163, 33);
            tbMateriaisQuantidade.Name = "tbMateriaisQuantidade";
            tbMateriaisQuantidade.Size = new Size(100, 23);
            tbMateriaisQuantidade.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 19);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 21;
            label3.Text = "Material";
            // 
            // cbMateriais
            // 
            cbMateriais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMateriais.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbMateriais.FormattingEnabled = true;
            cbMateriais.Location = new Point(6, 34);
            cbMateriais.Name = "cbMateriais";
            cbMateriais.Size = new Size(150, 23);
            cbMateriais.TabIndex = 20;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.White;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Font = new Font("Segoe UI", 8F);
            btnExcluir.Location = new Point(785, 34);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 9;
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // dgvMateriais
            // 
            dgvMateriais.AllowUserToAddRows = false;
            dgvMateriais.AllowUserToDeleteRows = false;
            dgvMateriais.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriais.Columns.AddRange(new DataGridViewColumn[] { Descricao, Quantidade, CustoUnitario, valorTotalMaterial });
            dgvMateriais.Location = new Point(2, 62);
            dgvMateriais.Name = "dgvMateriais";
            dgvMateriais.ReadOnly = true;
            dgvMateriais.Size = new Size(519, 267);
            dgvMateriais.TabIndex = 0;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 180;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // CustoUnitario
            // 
            CustoUnitario.DataPropertyName = "CustoUnitario";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            CustoUnitario.DefaultCellStyle = dataGridViewCellStyle7;
            CustoUnitario.HeaderText = "Valor unitário";
            CustoUnitario.Name = "CustoUnitario";
            CustoUnitario.ReadOnly = true;
            // 
            // valorTotalMaterial
            // 
            valorTotalMaterial.DataPropertyName = "Total";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            valorTotalMaterial.DefaultCellStyle = dataGridViewCellStyle8;
            valorTotalMaterial.HeaderText = "Valor total";
            valorTotalMaterial.Name = "valorTotalMaterial";
            valorTotalMaterial.ReadOnly = true;
            // 
            // tpComponentes
            // 
            tpComponentes.Controls.Add(button2);
            tpComponentes.Controls.Add(button3);
            tpComponentes.Controls.Add(label7);
            tpComponentes.Controls.Add(tbComponentesQuantidade);
            tpComponentes.Controls.Add(label8);
            tpComponentes.Controls.Add(cbComponentes);
            tpComponentes.Controls.Add(button1);
            tpComponentes.Controls.Add(dgvComponentes);
            tpComponentes.Location = new Point(4, 24);
            tpComponentes.Name = "tpComponentes";
            tpComponentes.Padding = new Padding(3);
            tpComponentes.Size = new Size(521, 329);
            tpComponentes.TabIndex = 1;
            tpComponentes.Text = "Componentes";
            tpComponentes.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI", 8F);
            button2.Location = new Point(468, 31);
            button2.Name = "button2";
            button2.Size = new Size(47, 25);
            button2.TabIndex = 33;
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnExcluir_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Segoe UI", 8F);
            button3.Location = new Point(415, 31);
            button3.Name = "button3";
            button3.Size = new Size(47, 25);
            button3.TabIndex = 32;
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnIncluir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 18);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 31;
            label7.Text = "Quantidade";
            // 
            // tbComponentesQuantidade
            // 
            tbComponentesQuantidade.Location = new Point(163, 33);
            tbComponentesQuantidade.Name = "tbComponentesQuantidade";
            tbComponentesQuantidade.Size = new Size(100, 23);
            tbComponentesQuantidade.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 19);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 29;
            label8.Text = "Componente";
            // 
            // cbComponentes
            // 
            cbComponentes.FormattingEnabled = true;
            cbComponentes.Location = new Point(6, 34);
            cbComponentes.Name = "cbComponentes";
            cbComponentes.Size = new Size(150, 23);
            cbComponentes.TabIndex = 28;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(785, 34);
            button1.Name = "button1";
            button1.Size = new Size(47, 25);
            button1.TabIndex = 27;
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvComponentes
            // 
            dgvComponentes.AllowUserToAddRows = false;
            dgvComponentes.AllowUserToDeleteRows = false;
            dgvComponentes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvComponentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComponentes.Columns.AddRange(new DataGridViewColumn[] { descricaoComponente, quantidadeComponente, valorUnitarioComponente, valorTotalComponente });
            dgvComponentes.Location = new Point(2, 62);
            dgvComponentes.Name = "dgvComponentes";
            dgvComponentes.ReadOnly = true;
            dgvComponentes.Size = new Size(519, 268);
            dgvComponentes.TabIndex = 24;
            // 
            // descricaoComponente
            // 
            descricaoComponente.DataPropertyName = "Descricao";
            descricaoComponente.HeaderText = "Descrição";
            descricaoComponente.Name = "descricaoComponente";
            descricaoComponente.ReadOnly = true;
            descricaoComponente.Width = 180;
            // 
            // quantidadeComponente
            // 
            quantidadeComponente.DataPropertyName = "Quantidade";
            quantidadeComponente.HeaderText = "Quantidade";
            quantidadeComponente.Name = "quantidadeComponente";
            quantidadeComponente.ReadOnly = true;
            // 
            // valorUnitarioComponente
            // 
            valorUnitarioComponente.DataPropertyName = "CustoUnitario";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            valorUnitarioComponente.DefaultCellStyle = dataGridViewCellStyle9;
            valorUnitarioComponente.HeaderText = "Valor unitário";
            valorUnitarioComponente.Name = "valorUnitarioComponente";
            valorUnitarioComponente.ReadOnly = true;
            // 
            // valorTotalComponente
            // 
            valorTotalComponente.DataPropertyName = "Total";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            valorTotalComponente.DefaultCellStyle = dataGridViewCellStyle10;
            valorTotalComponente.HeaderText = "Valor total";
            valorTotalComponente.Name = "valorTotalComponente";
            valorTotalComponente.ReadOnly = true;
            // 
            // tpProcessos
            // 
            tpProcessos.Controls.Add(button5);
            tpProcessos.Controls.Add(button6);
            tpProcessos.Controls.Add(label9);
            tpProcessos.Controls.Add(tbProcessosQuantidade);
            tpProcessos.Controls.Add(label10);
            tpProcessos.Controls.Add(cbProcessos);
            tpProcessos.Controls.Add(button4);
            tpProcessos.Controls.Add(dgvProcessos);
            tpProcessos.Location = new Point(4, 24);
            tpProcessos.Name = "tpProcessos";
            tpProcessos.Padding = new Padding(3);
            tpProcessos.Size = new Size(521, 329);
            tpProcessos.TabIndex = 2;
            tpProcessos.Text = "Mão de Obra";
            tpProcessos.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.White;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Font = new Font("Segoe UI", 8F);
            button5.Location = new Point(468, 31);
            button5.Name = "button5";
            button5.Size = new Size(47, 25);
            button5.TabIndex = 35;
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnExcluir_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.White;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Font = new Font("Segoe UI", 8F);
            button6.Location = new Point(415, 31);
            button6.Name = "button6";
            button6.Size = new Size(47, 25);
            button6.TabIndex = 34;
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 18);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 31;
            label9.Text = "Quantidade";
            // 
            // tbProcessosQuantidade
            // 
            tbProcessosQuantidade.Location = new Point(163, 33);
            tbProcessosQuantidade.Name = "tbProcessosQuantidade";
            tbProcessosQuantidade.Size = new Size(100, 23);
            tbProcessosQuantidade.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 19);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 29;
            label10.Text = "Processo";
            // 
            // cbProcessos
            // 
            cbProcessos.FormattingEnabled = true;
            cbProcessos.Location = new Point(6, 34);
            cbProcessos.Name = "cbProcessos";
            cbProcessos.Size = new Size(150, 23);
            cbProcessos.TabIndex = 28;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.White;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Segoe UI", 8F);
            button4.Location = new Point(785, 34);
            button4.Name = "button4";
            button4.Size = new Size(47, 25);
            button4.TabIndex = 27;
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // dgvProcessos
            // 
            dgvProcessos.AllowUserToAddRows = false;
            dgvProcessos.AllowUserToDeleteRows = false;
            dgvProcessos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProcessos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessos.Columns.AddRange(new DataGridViewColumn[] { descricaoProcesso, quantidadeProcesso, valorUnitarioProcesso, valorTotalProcesso });
            dgvProcessos.Location = new Point(2, 62);
            dgvProcessos.Name = "dgvProcessos";
            dgvProcessos.ReadOnly = true;
            dgvProcessos.Size = new Size(519, 268);
            dgvProcessos.TabIndex = 24;
            // 
            // descricaoProcesso
            // 
            descricaoProcesso.DataPropertyName = "Descricao";
            descricaoProcesso.HeaderText = "Descrição";
            descricaoProcesso.Name = "descricaoProcesso";
            descricaoProcesso.ReadOnly = true;
            descricaoProcesso.Width = 180;
            // 
            // quantidadeProcesso
            // 
            quantidadeProcesso.DataPropertyName = "Quantidade";
            quantidadeProcesso.HeaderText = "Quantidade";
            quantidadeProcesso.Name = "quantidadeProcesso";
            quantidadeProcesso.ReadOnly = true;
            // 
            // valorUnitarioProcesso
            // 
            valorUnitarioProcesso.DataPropertyName = "CustoHora";
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            valorUnitarioProcesso.DefaultCellStyle = dataGridViewCellStyle11;
            valorUnitarioProcesso.HeaderText = "Valor unitário";
            valorUnitarioProcesso.Name = "valorUnitarioProcesso";
            valorUnitarioProcesso.ReadOnly = true;
            // 
            // valorTotalProcesso
            // 
            valorTotalProcesso.DataPropertyName = "Total";
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            valorTotalProcesso.DefaultCellStyle = dataGridViewCellStyle12;
            valorTotalProcesso.HeaderText = "Valor total";
            valorTotalProcesso.Name = "valorTotalProcesso";
            valorTotalProcesso.ReadOnly = true;
            // 
            // btnExcluirModulo
            // 
            btnExcluirModulo.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnExcluirModulo.IconColor = Color.Black;
            btnExcluirModulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcluirModulo.IconSize = 25;
            btnExcluirModulo.Location = new Point(151, 7);
            btnExcluirModulo.Name = "btnExcluirModulo";
            btnExcluirModulo.Size = new Size(44, 30);
            btnExcluirModulo.TabIndex = 40;
            btnExcluirModulo.UseVisualStyleBackColor = true;
            btnExcluirModulo.Visible = false;
            // 
            // btnIncluirModulo
            // 
            btnIncluirModulo.IconChar = FontAwesome.Sharp.IconChar.AlignRight;
            btnIncluirModulo.IconColor = Color.Black;
            btnIncluirModulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIncluirModulo.IconSize = 18;
            btnIncluirModulo.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncluirModulo.Location = new Point(3, 7);
            btnIncluirModulo.Name = "btnIncluirModulo";
            btnIncluirModulo.Size = new Size(142, 30);
            btnIncluirModulo.TabIndex = 39;
            btnIncluirModulo.Text = "Adicionar módulo";
            btnIncluirModulo.UseVisualStyleBackColor = true;
            btnIncluirModulo.Visible = false;
            // 
            // treeViewModulos
            // 
            treeViewModulos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            treeViewModulos.FullRowSelect = true;
            treeViewModulos.HideSelection = false;
            treeViewModulos.Location = new Point(3, 43);
            treeViewModulos.Name = "treeViewModulos";
            treeViewModulos.Size = new Size(213, 333);
            treeViewModulos.TabIndex = 38;
            treeViewModulos.AfterSelect += treeViewModulos_AfterSelect;
            // 
            // nmMargem
            // 
            nmMargem.DecimalPlaces = 2;
            nmMargem.Font = new Font("Segoe UI", 15F);
            nmMargem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmMargem.Location = new Point(7, 403);
            nmMargem.Name = "nmMargem";
            nmMargem.Size = new Size(120, 34);
            nmMargem.TabIndex = 37;
            nmMargem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblValorFinal.Location = new Point(385, 409);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(53, 28);
            lblValorFinal.TabIndex = 36;
            lblValorFinal.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 385);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 35;
            label6.Text = "Margem de contribuição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(312, 409);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 34;
            label5.Text = "TOTAL: ";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(668, 436);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGravar.Location = new Point(581, 436);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 31;
            btnGravar.Text = "Gravar";
            btnGravar.TextAlign = ContentAlignment.MiddleRight;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // OR0001mnIncluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 574);
            Controls.Add(gbOrcamento);
            Controls.Add(panel1);
            Name = "OR0001mnIncluir";
            Text = "OR0001 - Orçamentos";
            Load += OR0001mnIncluir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbOrcamento.ResumeLayout(false);
            gbOrcamento.PerformLayout();
            tcItens.ResumeLayout(false);
            tpMateriais.ResumeLayout(false);
            tpMateriais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).EndInit();
            tpComponentes.ResumeLayout(false);
            tpComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComponentes).EndInit();
            tpProcessos.ResumeLayout(false);
            tpProcessos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcessos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmMargem).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox tbNumeroOrcamento;
        private Panel panel1;
        private DataGridViewTextBoxColumn descricaoMaterial;
        private DataGridViewTextBoxColumn quantidadeMaterial;
        private DataGridViewTextBoxColumn valorUnitarioMaterial;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label11;
        private ComboBox cbCliente;
        private Label label2;
        private ComboBox cbEquipamento;
        private TextBox tbObservacoes;
        private Label label12;
        private GroupBox gbOrcamento;
        private FontAwesome.Sharp.IconButton btnExcluirModulo;
        private FontAwesome.Sharp.IconButton btnIncluirModulo;
        private TreeView treeViewModulos;
        private NumericUpDown nmMargem;
        private Label lblValorFinal;
        private Label label6;
        private Label label5;
        private Button btnCancelar;
        private Button btnGravar;
        private TabControl tcItens;
        private TabPage tpMateriais;
        private Label label4;
        private TextBox tbMateriaisQuantidade;
        private Label label3;
        private ComboBox cbMateriais;
        private Button btnExcluir;
        private DataGridView dgvMateriais;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn CustoUnitario;
        private DataGridViewTextBoxColumn valorTotalMaterial;
        private TabPage tpComponentes;
        private Label label7;
        private TextBox tbComponentesQuantidade;
        private Label label8;
        private ComboBox cbComponentes;
        private Button button1;
        private Button btnIncluirComponente;
        private DataGridView dgvComponentes;
        private DataGridViewTextBoxColumn descricaoComponente;
        private DataGridViewTextBoxColumn quantidadeComponente;
        private DataGridViewTextBoxColumn valorUnitarioComponente;
        private DataGridViewTextBoxColumn valorTotalComponente;
        private TabPage tpProcessos;
        private Label label9;
        private TextBox tbProcessosQuantidade;
        private Label label10;
        private ComboBox cbProcessos;
        private Button button4;
        private Button btnIncluirProcesso;
        private DataGridView dgvProcessos;
        private DataGridViewTextBoxColumn descricaoProcesso;
        private DataGridViewTextBoxColumn quantidadeProcesso;
        private DataGridViewTextBoxColumn valorUnitarioProcesso;
        private DataGridViewTextBoxColumn valorTotalProcesso;
        private Button btnExcluirMaterial;
        private Button btnIncluirMaterial;
        private Button button5;
        private Button button7;
        private Button button2;
        private Button button3;
        private Button button6;
    }
}
