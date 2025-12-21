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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(170, 31);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 0;
            label1.Text = "Garoli Equipamentos";
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
            btnClientes.Location = new Point(12, 80);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(138, 44);
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
            btnOracamentos.Location = new Point(12, 130);
            btnOracamentos.Name = "btnOracamentos";
            btnOracamentos.Size = new Size(138, 44);
            btnOracamentos.TabIndex = 2;
            btnOracamentos.Text = "Orçamentos";
            btnOracamentos.TextAlign = ContentAlignment.MiddleRight;
            btnOracamentos.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Location = new Point(156, 80);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(732, 384);
            pnlConteudo.TabIndex = 3;
            // 
            // btnMateriais
            // 
            btnMateriais.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            btnMateriais.IconColor = Color.Black;
            btnMateriais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMateriais.IconSize = 36;
            btnMateriais.ImageAlign = ContentAlignment.MiddleLeft;
            btnMateriais.Location = new Point(12, 230);
            btnMateriais.Name = "btnMateriais";
            btnMateriais.Size = new Size(138, 44);
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
            btnComponentes.Location = new Point(12, 280);
            btnComponentes.Name = "btnComponentes";
            btnComponentes.Size = new Size(138, 44);
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
            btnProcessos.Location = new Point(12, 330);
            btnProcessos.Name = "btnProcessos";
            btnProcessos.Size = new Size(138, 44);
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
            btnEquipamentos.Location = new Point(12, 180);
            btnEquipamentos.Name = "btnEquipamentos";
            btnEquipamentos.Size = new Size(138, 44);
            btnEquipamentos.TabIndex = 7;
            btnEquipamentos.Text = "Equipamentos";
            btnEquipamentos.TextAlign = ContentAlignment.MiddleRight;
            btnEquipamentos.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 490);
            Controls.Add(btnEquipamentos);
            Controls.Add(btnProcessos);
            Controls.Add(btnComponentes);
            Controls.Add(btnMateriais);
            Controls.Add(pnlConteudo);
            Controls.Add(btnOracamentos);
            Controls.Add(btnClientes);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu principal";
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
    }
}
