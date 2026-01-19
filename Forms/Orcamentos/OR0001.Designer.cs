namespace GaroliBudget
{
    partial class OR0001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OR0001));
            btnPesquisar = new Button();
            dgvOrcamentos = new DataGridView();
            IdOrcamento = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            valorTotal = new DataGridViewTextBoxColumn();
            tbNumeroOrcamento = new TextBox();
            label1 = new Label();
            btnExcluir = new Button();
            btnIncluir = new Button();
            btnEditar = new Button();
            label2 = new Label();
            tbDescricao = new TextBox();
            gbFiltros = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).BeginInit();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(537, 23);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(158, 24);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvOrcamentos
            // 
            dgvOrcamentos.AllowUserToAddRows = false;
            dgvOrcamentos.AllowUserToDeleteRows = false;
            dgvOrcamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrcamentos.BackgroundColor = SystemColors.Control;
            dgvOrcamentos.BorderStyle = BorderStyle.Fixed3D;
            dgvOrcamentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvOrcamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrcamentos.Columns.AddRange(new DataGridViewColumn[] { IdOrcamento, Descricao, valorTotal });
            dgvOrcamentos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvOrcamentos.GridColor = SystemColors.ScrollBar;
            dgvOrcamentos.Location = new Point(12, 84);
            dgvOrcamentos.Name = "dgvOrcamentos";
            dgvOrcamentos.ReadOnly = true;
            dgvOrcamentos.Size = new Size(702, 315);
            dgvOrcamentos.TabIndex = 7;
            dgvOrcamentos.CellDoubleClick += dgvOrcamentos_CellDoubleClick;
            // 
            // IdOrcamento
            // 
            IdOrcamento.HeaderText = "IdOrcamento";
            IdOrcamento.Name = "IdOrcamento";
            IdOrcamento.ReadOnly = true;
            IdOrcamento.Visible = false;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 500;
            // 
            // valorTotal
            // 
            valorTotal.DataPropertyName = "ValorTotal";
            valorTotal.HeaderText = "Valor total";
            valorTotal.Name = "valorTotal";
            valorTotal.ReadOnly = true;
            valorTotal.Width = 180;
            // 
            // tbNumeroOrcamento
            // 
            tbNumeroOrcamento.Location = new Point(5, 41);
            tbNumeroOrcamento.Name = "tbNumeroOrcamento";
            tbNumeroOrcamento.Size = new Size(256, 23);
            tbNumeroOrcamento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Número";
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.White;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 8F);
            btnExcluir.Location = new Point(648, 53);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 6;
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
            btnIncluir.Location = new Point(537, 53);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(47, 25);
            btnIncluir.TabIndex = 4;
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
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 8F);
            btnEditar.Location = new Point(590, 53);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(47, 25);
            btnEditar.TabIndex = 5;
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 23);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 16;
            label2.Text = "Código";
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(280, 41);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(236, 23);
            tbDescricao.TabIndex = 1;
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltros.Controls.Add(tbNumeroOrcamento);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Controls.Add(tbDescricao);
            gbFiltros.Controls.Add(btnExcluir);
            gbFiltros.Controls.Add(btnIncluir);
            gbFiltros.Controls.Add(btnEditar);
            gbFiltros.Controls.Add(btnPesquisar);
            gbFiltros.Location = new Point(12, 0);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(702, 85);
            gbFiltros.TabIndex = 17;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // OR0001
            // 
            AcceptButton = btnPesquisar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 403);
            Controls.Add(gbFiltros);
            Controls.Add(dgvOrcamentos);
            Name = "OR0001";
            Text = "CL0001 - Listagem de clientes";
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dgvOrcamentos;
        private TextBox tbNumeroOrcamento;
        private Label label1;
        private Button btnExcluir;
        private Button btnIncluir;
        private Button btnEditar;
        private Label label2;
        private TextBox tbDescricao;
        private GroupBox gbFiltros;
        private DataGridViewTextBoxColumn IdOrcamento;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn valorTotal;
    }
}
