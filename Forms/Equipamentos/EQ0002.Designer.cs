namespace GaroliBudget
{
    partial class EQ0002
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQ0002));
            label5 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            cbMaterial = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(17, 170);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 74;
            label5.Text = "Quantidade";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 23);
            comboBox1.TabIndex = 73;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(14, 117);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 72;
            label1.Text = "Módulo";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(209, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 71;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(14, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 70;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(14, 36);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(305, 23);
            cbMaterial.TabIndex = 69;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(14, 69);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 68;
            label4.Text = "Unidade de medida";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(14, 18);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 67;
            label3.Text = "Selecione o material";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(209, 69);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 66;
            label2.Text = "Custo unitário (R$)";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(245, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 65;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGravar.Location = new Point(158, 215);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 64;
            btnGravar.Text = "Gravar";
            btnGravar.TextAlign = ContentAlignment.MiddleRight;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(17, 188);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(107, 23);
            numericUpDown1.TabIndex = 75;
            // 
            // EQ0002
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 250);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cbMaterial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "EQ0002";
            Text = "EQ0002 - incluir material";
            Load += EQ0002_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cbMaterial;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private Button btnGravar;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nmCustoUnitario;
        private ComboBox cbUnidadeMedida;
        private TextBox tbDescricao;
    }
}
