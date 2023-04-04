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
            gboxUI01 = new GroupBox();
            txtJarmuTipus = new TextBox();
            gboxUI02 = new GroupBox();
            txtVevoNev = new TextBox();
            dgvKereso = new DataGridView();
            colJarmuNeve = new DataGridViewTextBoxColumn();
            colVevoNeve = new DataGridViewTextBoxColumn();
            gboxUI01.SuspendLayout();
            gboxUI02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKereso).BeginInit();
            SuspendLayout();
            // 
            // gboxUI01
            // 
            gboxUI01.Controls.Add(txtJarmuTipus);
            gboxUI01.Location = new Point(12, 12);
            gboxUI01.Name = "gboxUI01";
            gboxUI01.Size = new Size(233, 69);
            gboxUI01.TabIndex = 0;
            gboxUI01.TabStop = false;
            gboxUI01.Text = "Keresés jármű típusa alapján";
            // 
            // txtJarmuTipus
            // 
            txtJarmuTipus.Location = new Point(6, 28);
            txtJarmuTipus.Name = "txtJarmuTipus";
            txtJarmuTipus.Size = new Size(221, 29);
            txtJarmuTipus.TabIndex = 0;
            // 
            // gboxUI02
            // 
            gboxUI02.Controls.Add(txtVevoNev);
            gboxUI02.Location = new Point(282, 12);
            gboxUI02.Name = "gboxUI02";
            gboxUI02.Size = new Size(233, 69);
            gboxUI02.TabIndex = 0;
            gboxUI02.TabStop = false;
            gboxUI02.Text = "Keresés vevő neve alapján";
            // 
            // txtVevoNev
            // 
            txtVevoNev.Location = new Point(6, 28);
            txtVevoNev.Name = "txtVevoNev";
            txtVevoNev.Size = new Size(221, 29);
            txtVevoNev.TabIndex = 0;
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
            dgvKereso.Size = new Size(503, 253);
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
            ClientSize = new Size(527, 361);
            Controls.Add(dgvKereso);
            Controls.Add(gboxUI02);
            Controls.Add(gboxUI01);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmKereso";
            Text = "kereső";
            gboxUI01.ResumeLayout(false);
            gboxUI01.PerformLayout();
            gboxUI02.ResumeLayout(false);
            gboxUI02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKereso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxUI01;
        private TextBox txtJarmuTipus;
        private GroupBox gboxUI02;
        private TextBox txtVevoNev;
        private DataGridView dgvKereso;
        private DataGridViewTextBoxColumn colJarmuNeve;
        private DataGridViewTextBoxColumn colVevoNeve;
    }
}