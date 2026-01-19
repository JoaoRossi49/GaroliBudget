namespace GaroliBudget
{
    partial class MT0001
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MT0001));
            dgvMateriais = new DataGridView();
            IdMaterial = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            UnidadeMedida = new DataGridViewTextBoxColumn();
            CustoUnitario = new DataGridViewTextBoxColumn();
            ativo = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            btnIncluir = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            tbDescricao = new TextBox();
            label1 = new Label();
            gbFiltros = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).BeginInit();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMateriais
            // 
            dgvMateriais.AllowUserToAddRows = false;
            dgvMateriais.AllowUserToDeleteRows = false;
            dgvMateriais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMateriais.BackgroundColor = SystemColors.Control;
            dgvMateriais.BorderStyle = BorderStyle.Fixed3D;
            dgvMateriais.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriais.Columns.AddRange(new DataGridViewColumn[] { IdMaterial, Codigo, Descricao, UnidadeMedida, CustoUnitario, ativo });
            dgvMateriais.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMateriais.GridColor = SystemColors.ScrollBar;
            dgvMateriais.Location = new Point(12, 93);
            dgvMateriais.Name = "dgvMateriais";
            dgvMateriais.ReadOnly = true;
            dgvMateriais.Size = new Size(693, 298);
            dgvMateriais.TabIndex = 18;
            dgvMateriais.CellDoubleClick += dgvMateriais_CellDoubleClick;
            // 
            // IdMaterial
            // 
            IdMaterial.DataPropertyName = "IdMaterial";
            IdMaterial.HeaderText = "IdMaterial";
            IdMaterial.Name = "IdMaterial";
            IdMaterial.ReadOnly = true;
            IdMaterial.Visible = false;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 400;
            // 
            // UnidadeMedida
            // 
            UnidadeMedida.DataPropertyName = "Unidade";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UnidadeMedida.DefaultCellStyle = dataGridViewCellStyle1;
            UnidadeMedida.HeaderText = "Unidade de medida";
            UnidadeMedida.Name = "UnidadeMedida";
            UnidadeMedida.ReadOnly = true;
            // 
            // CustoUnitario
            // 
            CustoUnitario.DataPropertyName = "CustoUnitario";
            dataGridViewCellStyle2.Format = "C2";
            CustoUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            CustoUnitario.HeaderText = "Custo unitário";
            CustoUnitario.Name = "CustoUnitario";
            CustoUnitario.ReadOnly = true;
            // 
            // ativo
            // 
            ativo.DataPropertyName = "Ativo";
            ativo.HeaderText = "Ativo";
            ativo.Name = "ativo";
            ativo.ReadOnly = true;
            ativo.Visible = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.White;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 8F);
            btnExcluir.Location = new Point(640, 52);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 22;
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
            btnIncluir.Location = new Point(529, 52);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(47, 25);
            btnIncluir.TabIndex = 20;
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
            btnEditar.Location = new Point(582, 52);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(47, 25);
            btnEditar.TabIndex = 21;
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(529, 22);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(158, 24);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(6, 40);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(342, 23);
            tbDescricao.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 24;
            label1.Text = "Descrição";
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltros.Controls.Add(btnPesquisar);
            gbFiltros.Controls.Add(tbDescricao);
            gbFiltros.Controls.Add(btnEditar);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Controls.Add(btnIncluir);
            gbFiltros.Controls.Add(btnExcluir);
            gbFiltros.Location = new Point(12, 3);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(693, 84);
            gbFiltros.TabIndex = 25;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // MT0001
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 403);
            Controls.Add(gbFiltros);
            Controls.Add(dgvMateriais);
            Name = "MT0001";
            Text = "MT0001 - Listagem de materiais";
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvMateriais;
        private Button btnExcluir;
        private Button btnIncluir;
        private Button btnEditar;
        private Button btnPesquisar;
        private TextBox tbDescricao;
        private Label label1;
        private GroupBox gbFiltros;
        private DataGridViewTextBoxColumn IdMaterial;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn UnidadeMedida;
        private DataGridViewTextBoxColumn CustoUnitario;
        private DataGridViewTextBoxColumn ativo;
    }
}
