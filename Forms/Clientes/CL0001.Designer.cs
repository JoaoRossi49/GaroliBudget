namespace GaroliBudget
{
    partial class CL0001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CL0001));
            btnPesquisar = new Button();
            dgvClientes = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            RazoSocial = new DataGridViewTextBoxColumn();
            Nomeantasia = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            tbRazaoSocial = new TextBox();
            label1 = new Label();
            btnExcluir = new Button();
            btnIncluir = new Button();
            btnEditar = new Button();
            label2 = new Label();
            tbNomeCliente = new TextBox();
            gbFiltros = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = SystemColors.Control;
            dgvClientes.BorderStyle = BorderStyle.Fixed3D;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { IdCliente, RazoSocial, Nomeantasia, telefone, email, cnpj });
            dgvClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvClientes.GridColor = SystemColors.ScrollBar;
            dgvClientes.Location = new Point(12, 84);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(702, 315);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // IdCliente
            // 
            IdCliente.DataPropertyName = "IdCliente";
            IdCliente.HeaderText = "IdCliente";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            IdCliente.Visible = false;
            // 
            // RazoSocial
            // 
            RazoSocial.DataPropertyName = "RazaoSocial";
            RazoSocial.FillWeight = 250F;
            RazoSocial.HeaderText = "Razão Social";
            RazoSocial.Name = "RazoSocial";
            RazoSocial.ReadOnly = true;
            RazoSocial.Width = 250;
            // 
            // Nomeantasia
            // 
            Nomeantasia.DataPropertyName = "NomeFantasia";
            Nomeantasia.HeaderText = "Nome Fantasia";
            Nomeantasia.Name = "Nomeantasia";
            Nomeantasia.ReadOnly = true;
            Nomeantasia.Width = 200;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "Telefone";
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // cnpj
            // 
            cnpj.DataPropertyName = "Cnpj";
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            cnpj.Width = 200;
            // 
            // tbRazaoSocial
            // 
            tbRazaoSocial.Location = new Point(5, 41);
            tbRazaoSocial.Name = "tbRazaoSocial";
            tbRazaoSocial.Size = new Size(256, 23);
            tbRazaoSocial.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 23);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Razão social";
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
            label2.Size = new Size(84, 15);
            label2.TabIndex = 16;
            label2.Text = "Nome fantasia";
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Location = new Point(280, 41);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(236, 23);
            tbNomeCliente.TabIndex = 1;
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltros.Controls.Add(tbRazaoSocial);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Controls.Add(tbNomeCliente);
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
            // CL0001
            // 
            AcceptButton = btnPesquisar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 403);
            Controls.Add(gbFiltros);
            Controls.Add(dgvClientes);
            Name = "CL0001";
            Text = "CL0001 - Listagem de clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dgvClientes;
        private TextBox tbRazaoSocial;
        private Label label1;
        private Button btnExcluir;
        private Button btnIncluir;
        private Button btnEditar;
        private Label label2;
        private TextBox tbNomeCliente;
        private GroupBox gbFiltros;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn RazoSocial;
        private DataGridViewTextBoxColumn Nomeantasia;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn cnpj;
    }
}
