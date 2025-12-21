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
            dataGridView1 = new DataGridView();
            tbNomeCliente = new TextBox();
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            razaoSocial = new DataGridViewTextBoxColumn();
            nomeFantasia = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            btnIncluir = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(287, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(89, 43);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, razaoSocial, nomeFantasia, cnpj });
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(693, 150);
            dataGridView1.TabIndex = 1;
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Location = new Point(12, 30);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(269, 23);
            tbNomeCliente.TabIndex = 2;
            tbNomeCliente.TextChanged += tbNomeCliente_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome cliente";
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // razaoSocial
            // 
            razaoSocial.FillWeight = 250F;
            razaoSocial.HeaderText = "Razão Social";
            razaoSocial.Name = "razaoSocial";
            razaoSocial.Width = 250;
            // 
            // nomeFantasia
            // 
            nomeFantasia.HeaderText = "Nome Fantasia";
            nomeFantasia.Name = "nomeFantasia";
            nomeFantasia.Width = 200;
            // 
            // cnpj
            // 
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.Width = 200;
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
            // 
            // CL0001
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 391);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(tbNomeCliente);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Name = "CL0001";
            Text = "CL0001 - Listagem de clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private TextBox tbNomeCliente;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn razaoSocial;
        private DataGridViewTextBoxColumn nomeFantasia;
        private DataGridViewTextBoxColumn cnpj;
        private Button btnExcluir;
        private Button btnIncluir;
        private Button btnEditar;
    }
}
