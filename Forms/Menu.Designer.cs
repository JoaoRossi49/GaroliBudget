namespace GaroliBudget
{
    partial class Menu
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
            label1 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnOracamentos = new FontAwesome.Sharp.IconButton();
            pnlConteudo = new Panel();
            btnMateriais = new FontAwesome.Sharp.IconButton();
            btnComponentes = new FontAwesome.Sharp.IconButton();
            btnProcessos = new FontAwesome.Sharp.IconButton();
            btnEquipamentos = new FontAwesome.Sharp.IconButton();
            pnlMenu = new Panel();
            pnlTitulo = new Panel();
            tbNomeForm = new Label();
            pnlMenu.SuspendLayout();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 35);
            label1.TabIndex = 0;
            label1.Text = "Garoli Equipamentos - ";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // btnClientes
            // 
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            btnClientes.IconColor = Color.Black;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnClientes.IconSize = 36;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(4, 56);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(138, 47);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnOracamentos
            // 
            btnOracamentos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnOracamentos.IconColor = Color.Black;
            btnOracamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOracamentos.IconSize = 36;
            btnOracamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnOracamentos.Location = new Point(4, 106);
            btnOracamentos.Name = "btnOracamentos";
            btnOracamentos.Size = new Size(138, 47);
            btnOracamentos.TabIndex = 2;
            btnOracamentos.Text = "Orçamentos";
            btnOracamentos.TextAlign = ContentAlignment.MiddleRight;
            btnOracamentos.UseVisualStyleBackColor = true;
            btnOracamentos.Click += btnOracamentos_Click;
            // 
            // pnlConteudo
            // 
            pnlConteudo.AutoSize = true;
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(145, 56);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(939, 455);
            pnlConteudo.TabIndex = 3;
            // 
            // btnMateriais
            // 
            btnMateriais.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            btnMateriais.IconColor = Color.Black;
            btnMateriais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMateriais.IconSize = 36;
            btnMateriais.ImageAlign = ContentAlignment.MiddleLeft;
            btnMateriais.Location = new Point(4, 206);
            btnMateriais.Name = "btnMateriais";
            btnMateriais.Size = new Size(138, 47);
            btnMateriais.TabIndex = 4;
            btnMateriais.Text = "Materiais";
            btnMateriais.TextAlign = ContentAlignment.MiddleRight;
            btnMateriais.UseVisualStyleBackColor = true;
            btnMateriais.Click += btnMateriais_Click;
            // 
            // btnComponentes
            // 
            btnComponentes.IconChar = FontAwesome.Sharp.IconChar.Dumpster;
            btnComponentes.IconColor = Color.Black;
            btnComponentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComponentes.IconSize = 36;
            btnComponentes.ImageAlign = ContentAlignment.MiddleLeft;
            btnComponentes.Location = new Point(4, 256);
            btnComponentes.Name = "btnComponentes";
            btnComponentes.Size = new Size(138, 47);
            btnComponentes.TabIndex = 5;
            btnComponentes.Text = "Componentes";
            btnComponentes.TextAlign = ContentAlignment.MiddleRight;
            btnComponentes.UseVisualStyleBackColor = true;
            // 
            // btnProcessos
            // 
            btnProcessos.IconChar = FontAwesome.Sharp.IconChar.FistRaised;
            btnProcessos.IconColor = Color.Black;
            btnProcessos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcessos.IconSize = 36;
            btnProcessos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProcessos.Location = new Point(4, 306);
            btnProcessos.Name = "btnProcessos";
            btnProcessos.Size = new Size(138, 47);
            btnProcessos.TabIndex = 6;
            btnProcessos.Text = "Processos";
            btnProcessos.TextAlign = ContentAlignment.MiddleRight;
            btnProcessos.UseVisualStyleBackColor = true;
            // 
            // btnEquipamentos
            // 
            btnEquipamentos.IconChar = FontAwesome.Sharp.IconChar.Leanpub;
            btnEquipamentos.IconColor = Color.Black;
            btnEquipamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEquipamentos.IconSize = 36;
            btnEquipamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEquipamentos.Location = new Point(4, 156);
            btnEquipamentos.Name = "btnEquipamentos";
            btnEquipamentos.Size = new Size(138, 47);
            btnEquipamentos.TabIndex = 7;
            btnEquipamentos.Text = "Equipamentos";
            btnEquipamentos.TextAlign = ContentAlignment.MiddleRight;
            btnEquipamentos.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnComponentes);
            pnlMenu.Controls.Add(btnEquipamentos);
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(btnProcessos);
            pnlMenu.Controls.Add(btnOracamentos);
            pnlMenu.Controls.Add(btnMateriais);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(145, 511);
            pnlMenu.TabIndex = 8;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(tbNomeForm);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(145, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(939, 56);
            pnlTitulo.TabIndex = 9;
            // 
            // tbNomeForm
            // 
            tbNomeForm.AutoSize = true;
            tbNomeForm.Font = new Font("Impact", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNomeForm.ForeColor = Color.DarkGoldenrod;
            tbNomeForm.Location = new Point(257, 9);
            tbNomeForm.Name = "tbNomeForm";
            tbNomeForm.Size = new Size(79, 35);
            tbNomeForm.TabIndex = 1;
            tbNomeForm.Text = "Menu";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 511);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlMenu);
            Name = "Menu";
            Text = "Menu principal";
            Load += Menu_Load;
            pnlMenu.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnOracamentos;
        private Panel pnlConteudo;
        private FontAwesome.Sharp.IconButton btnMateriais;
        private FontAwesome.Sharp.IconButton btnComponentes;
        private FontAwesome.Sharp.IconButton btnProcessos;
        private FontAwesome.Sharp.IconButton btnEquipamentos;
        private Panel pnlMenu;
        private Panel pnlTitulo;
        private Label tbNomeForm;
    }
}
