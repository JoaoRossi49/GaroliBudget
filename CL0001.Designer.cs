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
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            excluir = new DataGridViewImageColumn();
            tbNomeCliente = new TextBox();
            label1 = new Label();
            btnIncluir = new Button();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, telefone, editar, excluir });
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(597, 150);
            dataGridView1.TabIndex = 1;
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
            nome.Width = 250;
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            // 
            // editar
            // 
            editar.HeaderText = "Editar";
            editar.Name = "editar";
            // 
            // excluir
            // 
            excluir.HeaderText = "Excluir";
            excluir.Name = "excluir";
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
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.White;
            btnIncluir.Font = new Font("Segoe UI", 8F);
            btnIncluir.Location = new Point(476, 53);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(133, 25);
            btnIncluir.TabIndex = 4;
            btnIncluir.Text = "Incluir cliente";
            btnIncluir.TextAlign = ContentAlignment.TopCenter;
            btnIncluir.UseVisualStyleBackColor = false;
            // 
            // CL0001
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 276);
            Controls.Add(btnIncluir);
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn excluir;
        private TextBox tbNomeCliente;
        private Label label1;
        private Button btnIncluir;
    }
}
