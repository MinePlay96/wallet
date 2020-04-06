namespace wallet
{
    partial class AcountView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.test = new UserControl1();

            this.ChangeAmount = new System.Windows.Forms.NumericUpDown();
            this.Substract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeAmount
            // 
            this.ChangeAmount.DecimalPlaces = 2;
            this.ChangeAmount.Location = new System.Drawing.Point(18, 118);
            this.ChangeAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ChangeAmount.Name = "ChangeAmount";
            this.ChangeAmount.Size = new System.Drawing.Size(200, 31);
            this.ChangeAmount.TabIndex = 8;
            this.ChangeAmount.ThousandsSeparator = true;
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(262, 118);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(32, 31);
            this.Substract.TabIndex = 9;
            this.Substract.Text = "-";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(224, 118);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(32, 31);
            this.Add.TabIndex = 10;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AcountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.ChangeAmount);
            this.Name = "AcountView";
            this.Text = "AcountView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControl1 test;
        private System.Windows.Forms.NumericUpDown ChangeAmount;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

