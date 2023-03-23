namespace WFA230323
{
    partial class FrmMain
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
            mnuMain = new MenuStrip();
            msiVevok = new ToolStripMenuItem();
            msiKereso = new ToolStripMenuItem();
            dgvMain = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { msiVevok, msiKereso });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(742, 59);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // msiVevok
            // 
            msiVevok.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            msiVevok.ForeColor = Color.Red;
            msiVevok.Name = "msiVevok";
            msiVevok.Size = new Size(158, 55);
            msiVevok.Text = "VEVŐK";
            // 
            // msiKereso
            // 
            msiKereso.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            msiKereso.ForeColor = Color.Green;
            msiKereso.Name = "msiKereso";
            msiKereso.Size = new Size(174, 55);
            msiKereso.Text = "KERESŐ";
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvMain.Location = new Point(12, 72);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersVisible = false;
            dgvMain.RowTemplate.Height = 25;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(718, 305);
            dgvMain.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "típus";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ár";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "állapot";
            Column3.Name = "Column3";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 389);
            Controls.Add(dgvMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "usedUFO.glx kínálata";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem msiVevok;
        private ToolStripMenuItem msiKereso;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}