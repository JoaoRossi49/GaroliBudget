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
            btnOrcamentos = new Button();
            btnClientes = new Button();
            btnMateriais = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 0;
            label1.Text = "Garoli Equipamentos";
            // 
            // btnOrcamentos
            // 
            btnOrcamentos.BackColor = SystemColors.Info;
            btnOrcamentos.Font = new Font("Segoe UI", 9F);
            btnOrcamentos.Location = new Point(402, 147);
            btnOrcamentos.Name = "btnOrcamentos";
            btnOrcamentos.Size = new Size(149, 41);
            btnOrcamentos.TabIndex = 3;
            btnOrcamentos.Text = "Orçamentos";
            btnOrcamentos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.Info;
            btnClientes.Font = new Font("Segoe UI", 9F);
            btnClientes.Location = new Point(60, 147);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(149, 41);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnMateriais
            // 
            btnMateriais.BackColor = SystemColors.Info;
            btnMateriais.Font = new Font("Segoe UI", 9F);
            btnMateriais.Location = new Point(228, 147);
            btnMateriais.Name = "btnMateriais";
            btnMateriais.Size = new Size(149, 41);
            btnMateriais.TabIndex = 1;
            btnMateriais.Text = "Cadastro de Materiais";
            btnMateriais.UseVisualStyleBackColor = false;
            btnMateriais.Click += btnMateriais_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 209);
            Controls.Add(btnOrcamentos);
            Controls.Add(btnClientes);
            Controls.Add(btnMateriais);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOrcamentos;
        private Button btnClientes;
        private Button btnMateriais;
    }
}
