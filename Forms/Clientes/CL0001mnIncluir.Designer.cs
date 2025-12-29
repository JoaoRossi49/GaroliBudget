namespace GaroliBudget
{
    partial class CL0001mnIncluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CL0001mnIncluir));
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            tbNomeFantasia = new TextBox();
            tbRazaoSocial = new TextBox();
            label3 = new Label();
            mtbCnpj = new MaskedTextBox();
            mtbTelefone = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            tbEmail = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome Fantasia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 10;
            label1.Text = "Razão Social";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(215, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGravar.Location = new Point(128, 237);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.TextAlign = ContentAlignment.MiddleRight;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // tbNomeFantasia
            // 
            tbNomeFantasia.Location = new Point(12, 84);
            tbNomeFantasia.Name = "tbNomeFantasia";
            tbNomeFantasia.Size = new Size(278, 23);
            tbNomeFantasia.TabIndex = 1;
            // 
            // tbRazaoSocial
            // 
            tbRazaoSocial.Location = new Point(12, 27);
            tbRazaoSocial.Name = "tbRazaoSocial";
            tbRazaoSocial.Size = new Size(278, 23);
            tbRazaoSocial.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 13;
            label3.Text = "CNPJ";
            // 
            // mtbCnpj
            // 
            mtbCnpj.Location = new Point(12, 143);
            mtbCnpj.Mask = "00.000.000/0000-00";
            mtbCnpj.Name = "mtbCnpj";
            mtbCnpj.Size = new Size(108, 23);
            mtbCnpj.TabIndex = 2;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(144, 143);
            mtbTelefone.Mask = "(00) 00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(97, 23);
            mtbTelefone.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 125);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 15;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 178);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 196);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(278, 23);
            tbEmail.TabIndex = 4;
            // 
            // CL0001mnIncluir
            // 
            AcceptButton = btnGravar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 268);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(mtbTelefone);
            Controls.Add(label4);
            Controls.Add(mtbCnpj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(tbNomeFantasia);
            Controls.Add(tbRazaoSocial);
            Name = "CL0001mnIncluir";
            Text = "Menu principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox tbNomeFantasia;
        private TextBox tbRazaoSocial;
        private Label label3;
        private MaskedTextBox mtbCnpj;
        private MaskedTextBox mtbTelefone;
        private Label label4;
        private Label label5;
        private TextBox tbEmail;
    }
}
