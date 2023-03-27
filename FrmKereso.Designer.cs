namespace WFA230323
{
    partial class FrmKereso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gboxJarmuTipusa = new GroupBox();
            textBox1 = new TextBox();
            gbVevoNeve = new GroupBox();
            textBox2 = new TextBox();
            dgvKereso = new DataGridView();
            colJarmuNeve = new DataGridViewTextBoxColumn();
            colVevoNeve = new DataGridViewTextBoxColumn();
            gboxJarmuTipusa.SuspendLayout();
            gbVevoNeve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKereso).BeginInit();
            SuspendLayout();
            // 
            // gboxJarmuTipusa
            // 
            gboxJarmuTipusa.Controls.Add(textBox1);
            gboxJarmuTipusa.Location = new Point(12, 12);
            gboxJarmuTipusa.Name = "gboxJarmuTipusa";
            gboxJarmuTipusa.Size = new Size(218, 69);
            gboxJarmuTipusa.TabIndex = 0;
            gboxJarmuTipusa.TabStop = false;
            gboxJarmuTipusa.Text = "Keresés jármű neve alapján";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 29);
            textBox1.TabIndex = 0;
            // 
            // gbVevoNeve
            // 
            gbVevoNeve.Controls.Add(textBox2);
            gbVevoNeve.Location = new Point(254, 12);
            gbVevoNeve.Name = "gbVevoNeve";
            gbVevoNeve.Size = new Size(218, 69);
            gbVevoNeve.TabIndex = 0;
            gbVevoNeve.TabStop = false;
            gbVevoNeve.Text = "Keresés vevő neve alapján";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 29);
            textBox2.TabIndex = 0;
            // 
            // dgvKereso
            // 
            dgvKereso.AllowUserToAddRows = false;
            dgvKereso.AllowUserToDeleteRows = false;
            dgvKereso.AllowUserToResizeColumns = false;
            dgvKereso.AllowUserToResizeRows = false;
            dgvKereso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKereso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKereso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKereso.Columns.AddRange(new DataGridViewColumn[] { colJarmuNeve, colVevoNeve });
            dgvKereso.Location = new Point(12, 96);
            dgvKereso.Name = "dgvKereso";
            dgvKereso.RowHeadersVisible = false;
            dgvKereso.RowTemplate.Height = 25;
            dgvKereso.Size = new Size(460, 253);
            dgvKereso.TabIndex = 1;
            // 
            // colJarmuNeve
            // 
            colJarmuNeve.HeaderText = "jármű típusa";
            colJarmuNeve.Name = "colJarmuNeve";
            // 
            // colVevoNeve
            // 
            colVevoNeve.HeaderText = "vevő neve";
            colVevoNeve.Name = "colVevoNeve";
            // 
            // FrmKereso
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(dgvKereso);
            Controls.Add(gbVevoNeve);
            Controls.Add(gboxJarmuTipusa);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmKereso";
            Text = "kereső";
            gboxJarmuTipusa.ResumeLayout(false);
            gboxJarmuTipusa.PerformLayout();
            gbVevoNeve.ResumeLayout(false);
            gbVevoNeve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKereso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxJarmuTipusa;
        private TextBox textBox1;
        private GroupBox gbVevoNeve;
        private TextBox textBox2;
        private DataGridView dgvKereso;
        private DataGridViewTextBoxColumn colJarmuNeve;
        private DataGridViewTextBoxColumn colVevoNeve;
    }
}