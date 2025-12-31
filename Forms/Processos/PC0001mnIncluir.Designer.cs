namespace GaroliBudget
{
    partial class PC0001mnIncluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC0001mnIncluir));
            nmCustoHora = new NumericUpDown();
            label3 = new Label();
            tbDescricao = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmCustoHora).BeginInit();
            SuspendLayout();
            // 
            // nmCustoHora
            // 
            nmCustoHora.DecimalPlaces = 2;
            nmCustoHora.Font = new Font("Segoe UI", 9F);
            nmCustoHora.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmCustoHora.InterceptArrowKeys = false;
            nmCustoHora.Location = new Point(12, 81);
            nmCustoHora.Name = "nmCustoHora";
            nmCustoHora.Size = new Size(120, 23);
            nmCustoHora.TabIndex = 34;
            nmCustoHora.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 8);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 33;
            label3.Text = "Descrição";
            // 
            // tbDescricao
            // 
            tbDescricao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbDescricao.Location = new Point(12, 26);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(328, 23);
            tbDescricao.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 31;
            label2.Text = "Custo por hora (R$)";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(265, 132);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGravar.Location = new Point(178, 132);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 29;
            btnGravar.Text = "Gravar";
            btnGravar.TextAlign = ContentAlignment.MiddleRight;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // PC0001mnIncluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 162);
            Controls.Add(nmCustoHora);
            Controls.Add(label3);
            Controls.Add(tbDescricao);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "PC0001mnIncluir";
            Text = "PC0001 - Cadastrar processo";
            Load += PC0001mnIncluir_Load;
            ((System.ComponentModel.ISupportInitialize)nmCustoHora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmCustoHora;
        private Label label3;
        private TextBox tbDescricao;
        private Label label2;
        private Button btnCancelar;
        private Button btnGravar;
    }
}
