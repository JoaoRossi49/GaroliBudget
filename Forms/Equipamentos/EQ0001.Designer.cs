namespace GaroliBudget
{
    partial class EQ0001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQ0001));
            btnPesquisar = new Button();
            dgvEquipamentos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            IdEquipamento = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            tbDescricao = new TextBox();
            label1 = new Label();
            btnExcluir = new Button();
            btnIncluir = new Button();
            btnEditar = new Button();
            label2 = new Label();
            tbCodigo = new TextBox();
            gbFiltros = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).BeginInit();
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
            // dgvEquipamentos
            // 
            dgvEquipamentos.AllowUserToAddRows = false;
            dgvEquipamentos.AllowUserToDeleteRows = false;
            dgvEquipamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEquipamentos.BackgroundColor = SystemColors.Control;
            dgvEquipamentos.BorderStyle = BorderStyle.Fixed3D;
            dgvEquipamentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamentos.Columns.AddRange(new DataGridViewColumn[] { Codigo, IdEquipamento, Descricao });
            dgvEquipamentos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEquipamentos.GridColor = SystemColors.ScrollBar;
            dgvEquipamentos.Location = new Point(12, 84);
            dgvEquipamentos.Name = "dgvEquipamentos";
            dgvEquipamentos.ReadOnly = true;
            dgvEquipamentos.Size = new Size(702, 315);
            dgvEquipamentos.TabIndex = 7;
            dgvEquipamentos.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 200;
            // 
            // IdEquipamento
            // 
            IdEquipamento.DataPropertyName = "IdEquipamento";
            IdEquipamento.HeaderText = "IdEquipamento";
            IdEquipamento.Name = "IdEquipamento";
            IdEquipamento.ReadOnly = true;
            IdEquipamento.Visible = false;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 450;
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(5, 41);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(256, 23);
            tbDescricao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Descrição";
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.White;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Font = new Font("Segoe UI", 8F);
            btnExcluir.Location = new Point(648, 53);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 6;
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Visible = false;
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
            // tbCodigo
            // 
            tbCodigo.Location = new Point(280, 41);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(236, 23);
            tbCodigo.TabIndex = 1;
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltros.Controls.Add(tbDescricao);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Controls.Add(tbCodigo);
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
            // EQ0001
            // 
            AcceptButton = btnPesquisar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 403);
            Controls.Add(gbFiltros);
            Controls.Add(dgvEquipamentos);
            Name = "EQ0001";
            Text = "EQ0001 - Listagem de equipamentos";
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dgvEquipamentos;
        private TextBox tbDescricao;
        private Label label1;
        private Button btnExcluir;
        private Button btnIncluir;
        private Button btnEditar;
        private Label label2;
        private TextBox tbCodigo;
        private GroupBox gbFiltros;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn IdEquipamento;
        private DataGridViewTextBoxColumn Descricao;
    }
}
