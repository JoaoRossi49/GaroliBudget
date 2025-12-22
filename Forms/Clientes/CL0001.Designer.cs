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
            clienasdasdteId = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(616, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(89, 43);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = SystemColors.Control;
            dgvClientes.BorderStyle = BorderStyle.Fixed3D;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clienasdasdteId, RazoSocial, Nomeantasia, telefone, email, cnpj });
            dgvClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvClientes.GridColor = SystemColors.ScrollBar;
            dgvClientes.Location = new Point(12, 84);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(693, 295);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // clienasdasdteId
            // 
            clienasdasdteId.DataPropertyName = "IdCliente";
            clienasdasdteId.HeaderText = "IdCliente";
            clienasdasdteId.Name = "clienasdasdteId";
            clienasdasdteId.Visible = false;
            // 
            // RazoSocial
            // 
            RazoSocial.DataPropertyName = "RazaoSocial";
            RazoSocial.FillWeight = 250F;
            RazoSocial.HeaderText = "Razão Social";
            RazoSocial.Name = "RazoSocial";
            RazoSocial.Width = 250;
            // 
            // Nomeantasia
            // 
            Nomeantasia.DataPropertyName = "NomeFantasia";
            Nomeantasia.HeaderText = "Nome Fantasia";
            Nomeantasia.Name = "Nomeantasia";
            Nomeantasia.Width = 200;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "Telefone";
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            // 
            // email
            // 
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // cnpj
            // 
            cnpj.DataPropertyName = "Cnpj";
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.Width = 200;
            // 
            // tbRazaoSocial
            // 
            tbRazaoSocial.Location = new Point(13, 53);
            tbRazaoSocial.Name = "tbRazaoSocial";
            tbRazaoSocial.Size = new Size(256, 23);
            tbRazaoSocial.TabIndex = 2;
            tbRazaoSocial.TextChanged += tbNomeCliente_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Razão social";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Font = new Font("Segoe UI", 8F);
            btnExcluir.Location = new Point(658, 53);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 14;
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.White;
            btnIncluir.BackgroundImage = (Image)resources.GetObject("btnIncluir.BackgroundImage");
            btnIncluir.BackgroundImageLayout = ImageLayout.Center;
            btnIncluir.Font = new Font("Segoe UI", 8F);
            btnIncluir.Location = new Point(547, 53);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(47, 25);
            btnIncluir.TabIndex = 13;
            btnIncluir.TextAlign = ContentAlignment.TopCenter;
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Font = new Font("Segoe UI", 8F);
            btnEditar.Location = new Point(600, 53);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(47, 25);
            btnEditar.TabIndex = 12;
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 35);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 16;
            label2.Text = "Nome fantasia";
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Location = new Point(288, 53);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(236, 23);
            tbNomeCliente.TabIndex = 15;
            // 
            // CL0001
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 391);
            Controls.Add(label2);
            Controls.Add(tbNomeCliente);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(tbRazaoSocial);
            Controls.Add(dgvClientes);
            Controls.Add(btnPesquisar);
            Name = "CL0001";
            Text = "CL0001 - Listagem de clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dgvClientes;
        private TextBox tbRazaoSocial;
        private Label label1;
        private Button btnExcluir;
        private Button btnIncluir;
        private Button btnEditar;
        private DataGridViewTextBoxColumn clienasdasdteId;
        private DataGridViewTextBoxColumn RazoSocial;
        private DataGridViewTextBoxColumn Nomeantasia;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn cnpj;
        private Label label2;
        private TextBox tbNomeCliente;
    }
}
