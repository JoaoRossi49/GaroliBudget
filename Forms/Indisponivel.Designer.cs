namespace GaroliBudget
{
    partial class Indisponivel
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
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            label1 = new Label();
            SuspendLayout();
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 25F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(112, 152);
            label1.Name = "label1";
            label1.Size = new Size(355, 46);
            label1.TabIndex = 1;
            label1.Text = "NÃO IMPLEMENTADO";
            // 
            // Indisponivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 350);
            Controls.Add(label1);
            Name = "Indisponivel";
            Opacity = 0.7D;
            Text = "Indisponível";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label label1;
    }
}
