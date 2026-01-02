namespace GaroliBudget
{
    partial class MT0001mnIncluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MT0001mnIncluir));
            btnGravar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            tbDescricao = new TextBox();
            label3 = new Label();
            cbUnidadeMedida = new ComboBox();
            label4 = new Label();
            nmCustoUnitario = new NumericUpDown();
            label1 = new Label();
            tbCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nmCustoUnitario).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.Image = (Image)resources.GetObject("btnGravar.Image");
            btnGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGravar.Location = new Point(178, 183);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.TextAlign = ContentAlignment.MiddleRight;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(265, 183);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(211, 110);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 13;
            label2.Text = "Custo unitário (R$)";
            // 
            // tbDescricao
            // 
            tbDescricao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbDescricao.Location = new Point(12, 77);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(328, 23);
            tbDescricao.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 15;
            label3.Text = "Descrição";
            // 
            // cbUnidadeMedida
            // 
            cbUnidadeMedida.Anchor = AnchorStyles.Left;
            cbUnidadeMedida.FormattingEnabled = true;
            cbUnidadeMedida.Location = new Point(12, 128);
            cbUnidadeMedida.Name = "cbUnidadeMedida";
            cbUnidadeMedida.Size = new Size(146, 23);
            cbUnidadeMedida.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 17;
            label4.Text = "Unidade de medida";
            // 
            // nmCustoUnitario
            // 
            nmCustoUnitario.DecimalPlaces = 2;
            nmCustoUnitario.Font = new Font("Segoe UI", 9F);
            nmCustoUnitario.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmCustoUnitario.InterceptArrowKeys = false;
            nmCustoUnitario.Location = new Point(211, 128);
            nmCustoUnitario.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nmCustoUnitario.Name = "nmCustoUnitario";
            nmCustoUnitario.Size = new Size(120, 23);
            nmCustoUnitario.TabIndex = 28;
            nmCustoUnitario.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 12;
            label1.Text = "Código";
            // 
            // tbCodigo
            // 
            tbCodigo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCodigo.Location = new Point(12, 33);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(328, 23);
            tbCodigo.TabIndex = 10;
            // 
            // MT0001mnIncluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 218);
            Controls.Add(nmCustoUnitario);
            Controls.Add(label4);
            Controls.Add(cbUnidadeMedida);
            Controls.Add(label3);
            Controls.Add(tbDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "MT0001mnIncluir";
            Text = "MT0001 - Cadastrar material";
            Load += MT0001mnIncluir_Load;
            ((System.ComponentModel.ISupportInitialize)nmCustoUnitario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label2;
        private TextBox tbDescricao;
        private Label label3;
        private ComboBox cbUnidadeMedida;
        private Label label4;
        private NumericUpDown nmCustoUnitario;
        private Label label1;
        private TextBox tbCodigo;
    }
}
