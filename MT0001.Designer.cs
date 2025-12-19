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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MT0001));
            btnEditar = new Button();
            label1 = new Label();
            tbNomeCliente = new TextBox();
            dataGridView1 = new DataGridView();
            btnPesquisar = new Button();
            btnIncluir = new Button();
            btnExcluir = new Button();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Font = new Font("Segoe UI", 8F);
            btnEditar.Location = new Point(447, 45);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(47, 25);
            btnEditar.TabIndex = 9;
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 8;
            label1.Text = "Descrição material";
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Location = new Point(9, 29);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(269, 23);
            tbNomeCliente.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, preco });
            dataGridView1.Location = new Point(9, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(553, 150);
            dataGridView1.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(284, 18);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(89, 43);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.White;
            btnIncluir.BackgroundImage = (Image)resources.GetObject("btnIncluir.BackgroundImage");
            btnIncluir.BackgroundImageLayout = ImageLayout.Center;
            btnIncluir.Font = new Font("Segoe UI", 8F);
            btnIncluir.Location = new Point(394, 45);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(47, 25);
            btnIncluir.TabIndex = 10;
            btnIncluir.TextAlign = ContentAlignment.TopCenter;
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.Font = new Font("Segoe UI", 8F);
            btnExcluir.Location = new Point(505, 45);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(47, 25);
            btnExcluir.TabIndex = 11;
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // nome
            // 
            nome.FillWeight = 250F;
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.Width = 410;
            // 
            // preco
            // 
            preco.HeaderText = "Preço por KG";
            preco.Name = "preco";
            // 
            // MT0001
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 253);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(tbNomeCliente);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Name = "MT0001";
            Text = "MT0001 - Listagem de materiais";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private Label label1;
        private TextBox tbNomeCliente;
        private DataGridView dataGridView1;
        private Button btnPesquisar;
        private Button btnIncluir;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn preco;
    }
}
