namespace GaroliBudget
{
    partial class EQ0001mnIncluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQ0001mnIncluir));
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            tbRazaoSocial = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tcOrcamento = new TabControl();
            tpMateriais = new TabPage();
            label4 = new Label();
            tbMateriaisQuantidade = new TextBox();
            label3 = new Label();
            cbMateriais = new ComboBox();
            btnExcluir = new Button();
            btnIncluirMaterial = new Button();
            btnEditar = new Button();
            dgvMateriais = new DataGridView();
            descricaoMaterial = new DataGridViewTextBoxColumn();
            quantidadeMaterial = new DataGridViewTextBoxColumn();
            valorUnitarioMaterial = new DataGridViewTextBoxColumn();
            valorTotalMaterial = new DataGridViewTextBoxColumn();
            tpComponentes = new TabPage();
            label7 = new Label();
            tbComponentesQuantidade = new TextBox();
            label8 = new Label();
            cbComponentes = new ComboBox();
            button1 = new Button();
            btnIncluirComponente = new Button();
            button3 = new Button();
            dgvComponentes = new DataGridView();
            descricaoComponente = new DataGridViewTextBoxColumn();
            quantidadeComponente = new DataGridViewTextBoxColumn();
            valorUnitarioComponente = new DataGridViewTextBoxColumn();
            valorTotalComponente = new DataGridViewTextBoxColumn();
            tpProcessos = new TabPage();
            label9 = new Label();
            tbProcessosQuantidade = new TextBox();
            label10 = new Label();
            cbProcessos = new ComboBox();
            button4 = new Button();
            btnIncluirProcesso = new Button();
            button6 = new Button();
            dgvProcessos = new DataGridView();
            descricaoProcesso = new DataGridViewTextBoxColumn();
            quantidadeProcesso = new DataGridViewTextBoxColumn();
            valorUnitarioProcesso = new DataGridViewTextBoxColumn();
            valorTotalProcesso = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            lblValorFinal = new Label();
            nmMargem = new NumericUpDown();
            treeViewModulos = new TreeView();
            btnIncluirModulo = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tcOrcamento.SuspendLayout();
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
            btnCancelar.Location = new Point(673, 539);
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
            btnGravar.Location = new Point(586, 539);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbRazaoSocial);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 106);
            panel1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(308, 29);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(402, 61);
            textBox2.TabIndex = 13;
            textBox2.Text = "9999";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(308, 11);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 14;
            label11.Text = "Observações";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 67);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 11;
            textBox1.Text = "9999";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Descrição";
            // 
            // tcOrcamento
            // 
            tcOrcamento.Controls.Add(tpMateriais);
            tcOrcamento.Controls.Add(tpComponentes);
            tcOrcamento.Controls.Add(tpProcessos);
            tcOrcamento.Location = new Point(223, 122);
            tcOrcamento.Name = "tcOrcamento";
            tcOrcamento.SelectedIndex = 0;
            tcOrcamento.Size = new Size(529, 357);
            tcOrcamento.TabIndex = 21;
            // 
            // tpMateriais
            // 
            tpMateriais.Controls.Add(label4);
            tpMateriais.Controls.Add(tbMateriaisQuantidade);
            tpMateriais.Controls.Add(label3);
            tpMateriais.Controls.Add(cbMateriais);
            tpMateriais.Controls.Add(btnExcluir);
            tpMateriais.Controls.Add(btnIncluirMaterial);
            tpMateriais.Controls.Add(btnEditar);
            tpMateriais.Controls.Add(dgvMateriais);
            tpMateriais.Location = new Point(4, 24);
            tpMateriais.Name = "tpMateriais";
            tpMateriais.Padding = new Padding(3);
            tpMateriais.Size = new Size(521, 329);
            tpMateriais.TabIndex = 0;
            tpMateriais.Text = "Materiais";
            tpMateriais.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 15);
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
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 21;
            label3.Text = "Material";
            // 
            // cbMateriais
            // 
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
            btnExcluir.Location = new Point(467, 31);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 9;
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncluirMaterial
            // 
            btnIncluirMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIncluirMaterial.BackColor = Color.White;
            btnIncluirMaterial.BackgroundImage = (Image)resources.GetObject("btnIncluirMaterial.BackgroundImage");
            btnIncluirMaterial.BackgroundImageLayout = ImageLayout.Center;
            btnIncluirMaterial.Font = new Font("Segoe UI", 8F);
            btnIncluirMaterial.Location = new Point(359, 31);
            btnIncluirMaterial.Name = "btnIncluirMaterial";
            btnIncluirMaterial.Size = new Size(47, 25);
            btnIncluirMaterial.TabIndex = 7;
            btnIncluirMaterial.TextAlign = ContentAlignment.TopCenter;
            btnIncluirMaterial.UseVisualStyleBackColor = false;
            btnIncluirMaterial.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.White;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Font = new Font("Segoe UI", 8F);
            btnEditar.Location = new Point(412, 31);
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
            dgvMateriais.Columns.AddRange(new DataGridViewColumn[] { descricaoMaterial, quantidadeMaterial, valorUnitarioMaterial, valorTotalMaterial });
            dgvMateriais.Location = new Point(0, 65);
            dgvMateriais.Name = "dgvMateriais";
            dgvMateriais.ReadOnly = true;
            dgvMateriais.Size = new Size(521, 268);
            dgvMateriais.TabIndex = 0;
            // 
            // descricaoMaterial
            // 
            descricaoMaterial.HeaderText = "Descrição";
            descricaoMaterial.Name = "descricaoMaterial";
            descricaoMaterial.ReadOnly = true;
            descricaoMaterial.Width = 280;
            // 
            // quantidadeMaterial
            // 
            quantidadeMaterial.HeaderText = "Quantidade";
            quantidadeMaterial.Name = "quantidadeMaterial";
            quantidadeMaterial.ReadOnly = true;
            // 
            // valorUnitarioMaterial
            // 
            valorUnitarioMaterial.HeaderText = "Valor unitário";
            valorUnitarioMaterial.Name = "valorUnitarioMaterial";
            valorUnitarioMaterial.ReadOnly = true;
            // 
            // valorTotalMaterial
            // 
            valorTotalMaterial.HeaderText = "Valor total";
            valorTotalMaterial.Name = "valorTotalMaterial";
            valorTotalMaterial.ReadOnly = true;
            // 
            // tpComponentes
            // 
            tpComponentes.Controls.Add(label7);
            tpComponentes.Controls.Add(tbComponentesQuantidade);
            tpComponentes.Controls.Add(label8);
            tpComponentes.Controls.Add(cbComponentes);
            tpComponentes.Controls.Add(button1);
            tpComponentes.Controls.Add(btnIncluirComponente);
            tpComponentes.Controls.Add(button3);
            tpComponentes.Controls.Add(dgvComponentes);
            tpComponentes.Location = new Point(4, 24);
            tpComponentes.Name = "tpComponentes";
            tpComponentes.Padding = new Padding(3);
            tpComponentes.Size = new Size(521, 329);
            tpComponentes.TabIndex = 1;
            tpComponentes.Text = "Componentes";
            tpComponentes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 15);
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
            label8.Location = new Point(6, 16);
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
            button1.Location = new Point(467, 31);
            button1.Name = "button1";
            button1.Size = new Size(47, 25);
            button1.TabIndex = 27;
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnIncluirComponente
            // 
            btnIncluirComponente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIncluirComponente.BackColor = Color.White;
            btnIncluirComponente.BackgroundImage = (Image)resources.GetObject("btnIncluirComponente.BackgroundImage");
            btnIncluirComponente.BackgroundImageLayout = ImageLayout.Center;
            btnIncluirComponente.Font = new Font("Segoe UI", 8F);
            btnIncluirComponente.Location = new Point(359, 31);
            btnIncluirComponente.Name = "btnIncluirComponente";
            btnIncluirComponente.Size = new Size(47, 25);
            btnIncluirComponente.TabIndex = 25;
            btnIncluirComponente.TextAlign = ContentAlignment.TopCenter;
            btnIncluirComponente.UseVisualStyleBackColor = false;
            btnIncluirComponente.Click += btnIncluir_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Segoe UI", 8F);
            button3.Location = new Point(412, 31);
            button3.Name = "button3";
            button3.Size = new Size(47, 25);
            button3.TabIndex = 26;
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // dgvComponentes
            // 
            dgvComponentes.AllowUserToAddRows = false;
            dgvComponentes.AllowUserToDeleteRows = false;
            dgvComponentes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvComponentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComponentes.Columns.AddRange(new DataGridViewColumn[] { descricaoComponente, quantidadeComponente, valorUnitarioComponente, valorTotalComponente });
            dgvComponentes.Location = new Point(0, 65);
            dgvComponentes.Name = "dgvComponentes";
            dgvComponentes.ReadOnly = true;
            dgvComponentes.Size = new Size(521, 268);
            dgvComponentes.TabIndex = 24;
            // 
            // descricaoComponente
            // 
            descricaoComponente.HeaderText = "Descrição";
            descricaoComponente.Name = "descricaoComponente";
            descricaoComponente.ReadOnly = true;
            descricaoComponente.Width = 280;
            // 
            // quantidadeComponente
            // 
            quantidadeComponente.HeaderText = "Quantidade";
            quantidadeComponente.Name = "quantidadeComponente";
            quantidadeComponente.ReadOnly = true;
            // 
            // valorUnitarioComponente
            // 
            valorUnitarioComponente.HeaderText = "Valor unitário";
            valorUnitarioComponente.Name = "valorUnitarioComponente";
            valorUnitarioComponente.ReadOnly = true;
            // 
            // valorTotalComponente
            // 
            valorTotalComponente.HeaderText = "Valor total";
            valorTotalComponente.Name = "valorTotalComponente";
            valorTotalComponente.ReadOnly = true;
            // 
            // tpProcessos
            // 
            tpProcessos.Controls.Add(label9);
            tpProcessos.Controls.Add(tbProcessosQuantidade);
            tpProcessos.Controls.Add(label10);
            tpProcessos.Controls.Add(cbProcessos);
            tpProcessos.Controls.Add(button4);
            tpProcessos.Controls.Add(btnIncluirProcesso);
            tpProcessos.Controls.Add(button6);
            tpProcessos.Controls.Add(dgvProcessos);
            tpProcessos.Location = new Point(4, 24);
            tpProcessos.Name = "tpProcessos";
            tpProcessos.Padding = new Padding(3);
            tpProcessos.Size = new Size(521, 329);
            tpProcessos.TabIndex = 2;
            tpProcessos.Text = "Mão de Obra";
            tpProcessos.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(163, 15);
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
            label10.Location = new Point(6, 16);
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
            button4.Location = new Point(467, 31);
            button4.Name = "button4";
            button4.Size = new Size(47, 25);
            button4.TabIndex = 27;
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // btnIncluirProcesso
            // 
            btnIncluirProcesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIncluirProcesso.BackColor = Color.White;
            btnIncluirProcesso.BackgroundImage = (Image)resources.GetObject("btnIncluirProcesso.BackgroundImage");
            btnIncluirProcesso.BackgroundImageLayout = ImageLayout.Center;
            btnIncluirProcesso.Font = new Font("Segoe UI", 8F);
            btnIncluirProcesso.Location = new Point(359, 31);
            btnIncluirProcesso.Name = "btnIncluirProcesso";
            btnIncluirProcesso.Size = new Size(47, 25);
            btnIncluirProcesso.TabIndex = 25;
            btnIncluirProcesso.TextAlign = ContentAlignment.TopCenter;
            btnIncluirProcesso.UseVisualStyleBackColor = false;
            btnIncluirProcesso.Click += btnIncluir_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.White;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Font = new Font("Segoe UI", 8F);
            button6.Location = new Point(412, 31);
            button6.Name = "button6";
            button6.Size = new Size(47, 25);
            button6.TabIndex = 26;
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            // 
            // dgvProcessos
            // 
            dgvProcessos.AllowUserToAddRows = false;
            dgvProcessos.AllowUserToDeleteRows = false;
            dgvProcessos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProcessos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessos.Columns.AddRange(new DataGridViewColumn[] { descricaoProcesso, quantidadeProcesso, valorUnitarioProcesso, valorTotalProcesso });
            dgvProcessos.Location = new Point(0, 65);
            dgvProcessos.Name = "dgvProcessos";
            dgvProcessos.ReadOnly = true;
            dgvProcessos.Size = new Size(521, 268);
            dgvProcessos.TabIndex = 24;
            // 
            // descricaoProcesso
            // 
            descricaoProcesso.HeaderText = "Descrição";
            descricaoProcesso.Name = "descricaoProcesso";
            descricaoProcesso.ReadOnly = true;
            descricaoProcesso.Width = 280;
            // 
            // quantidadeProcesso
            // 
            quantidadeProcesso.HeaderText = "Quantidade";
            quantidadeProcesso.Name = "quantidadeProcesso";
            quantidadeProcesso.ReadOnly = true;
            // 
            // valorUnitarioProcesso
            // 
            valorUnitarioProcesso.HeaderText = "Valor unitário";
            valorUnitarioProcesso.Name = "valorUnitarioProcesso";
            valorUnitarioProcesso.ReadOnly = true;
            // 
            // valorTotalProcesso
            // 
            valorTotalProcesso.HeaderText = "Valor total";
            valorTotalProcesso.Name = "valorTotalProcesso";
            valorTotalProcesso.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(317, 512);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 22;
            label5.Text = "TOTAL: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 488);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 25;
            label6.Text = "Margem de contribuição";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblValorFinal.Location = new Point(390, 512);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(53, 28);
            lblValorFinal.TabIndex = 26;
            lblValorFinal.Text = "0.00";
            // 
            // nmMargem
            // 
            nmMargem.DecimalPlaces = 2;
            nmMargem.Font = new Font("Segoe UI", 15F);
            nmMargem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmMargem.Location = new Point(12, 506);
            nmMargem.Name = "nmMargem";
            nmMargem.Size = new Size(120, 34);
            nmMargem.TabIndex = 27;
            nmMargem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmMargem.ValueChanged += nmMargem_ValueChanged;
            // 
            // treeViewModulos
            // 
            treeViewModulos.Location = new Point(8, 146);
            treeViewModulos.Name = "treeViewModulos";
            treeViewModulos.Size = new Size(213, 333);
            treeViewModulos.TabIndex = 28;
            treeViewModulos.AfterSelect += treeViewModulos_AfterSelect;
            // 
            // btnIncluirModulo
            // 
            btnIncluirModulo.IconChar = FontAwesome.Sharp.IconChar.AlignRight;
            btnIncluirModulo.IconColor = Color.Black;
            btnIncluirModulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIncluirModulo.IconSize = 18;
            btnIncluirModulo.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncluirModulo.Location = new Point(8, 117);
            btnIncluirModulo.Name = "btnIncluirModulo";
            btnIncluirModulo.Size = new Size(142, 23);
            btnIncluirModulo.TabIndex = 29;
            btnIncluirModulo.Text = "Adicionar módulo";
            btnIncluirModulo.UseVisualStyleBackColor = true;
            btnIncluirModulo.Click += btnIncluirModulo_Click;
            // 
            // EQ0001mnIncluir
            // 
            AcceptButton = btnGravar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 574);
            Controls.Add(btnIncluirModulo);
            Controls.Add(treeViewModulos);
            Controls.Add(nmMargem);
            Controls.Add(lblValorFinal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tcOrcamento);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "EQ0001mnIncluir";
            Text = "EQ0001 - Cadastro de equipamentos";
            Load += EQ0001mnIncluir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcOrcamento.ResumeLayout(false);
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
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox tbRazaoSocial;
        private Panel panel1;
        private TabControl tcOrcamento;
        private TabPage tpMateriais;
        private TabPage tpComponentes;
        private DataGridView dgvMateriais;
        private TabPage tpProcessos;
        private Label label3;
        private ComboBox cbMateriais;
        private Button btnExcluir;
        private Button btnIncluirMaterial;
        private Button btnEditar;
        private Label label4;
        private TextBox tbMateriaisQuantidade;
        private Label label5;
        private Label label6;
        private Label lblValorFinal;
        private Label label7;
        private TextBox tbComponentesQuantidade;
        private Label label8;
        private ComboBox cbComponentes;
        private Button button1;
        private Button btnIncluirComponente;
        private Button button3;
        private DataGridView dgvComponentes;
        private Label label9;
        private TextBox tbProcessosQuantidade;
        private Label label10;
        private ComboBox cbProcessos;
        private Button button4;
        private Button btnIncluirProcesso;
        private Button button6;
        private DataGridView dgvProcessos;
        private DataGridViewTextBoxColumn descricaoMaterial;
        private DataGridViewTextBoxColumn quantidadeMaterial;
        private DataGridViewTextBoxColumn valorUnitarioMaterial;
        private DataGridViewTextBoxColumn valorTotalMaterial;
        private DataGridViewTextBoxColumn descricaoComponente;
        private DataGridViewTextBoxColumn quantidadeComponente;
        private DataGridViewTextBoxColumn valorUnitarioComponente;
        private DataGridViewTextBoxColumn valorTotalComponente;
        private DataGridViewTextBoxColumn descricaoProcesso;
        private DataGridViewTextBoxColumn quantidadeProcesso;
        private DataGridViewTextBoxColumn valorUnitarioProcesso;
        private DataGridViewTextBoxColumn valorTotalProcesso;
        private NumericUpDown nmMargem;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label11;
        private TreeView treeViewModulos;
        private FontAwesome.Sharp.IconButton btnIncluirModulo;
    }
}
