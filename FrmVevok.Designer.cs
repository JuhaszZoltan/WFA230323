namespace WFA230323
{
    partial class FrmVevok
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
            cboxNevek = new ComboBox();
            lblUI1 = new Label();
            txtCim = new TextBox();
            gboxMegbizhato = new GroupBox();
            rbMegbizhatoNem = new RadioButton();
            rbMegbizhatoIgen = new RadioButton();
            rtbFoglalozott = new RichTextBox();
            lblUI2 = new Label();
            gboxMegbizhato.SuspendLayout();
            SuspendLayout();
            // 
            // cboxNevek
            // 
            cboxNevek.FormattingEnabled = true;
            cboxNevek.Location = new Point(12, 37);
            cboxNevek.Name = "cboxNevek";
            cboxNevek.Size = new Size(310, 29);
            cboxNevek.TabIndex = 0;
            // 
            // lblUI1
            // 
            lblUI1.AutoSize = true;
            lblUI1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUI1.Location = new Point(12, 89);
            lblUI1.Name = "lblUI1";
            lblUI1.Size = new Size(44, 21);
            lblUI1.TabIndex = 1;
            lblUI1.Text = "Cím:";
            // 
            // txtCim
            // 
            txtCim.Location = new Point(62, 86);
            txtCim.Name = "txtCim";
            txtCim.Size = new Size(260, 29);
            txtCim.TabIndex = 2;
            // 
            // gboxMegbizhato
            // 
            gboxMegbizhato.Controls.Add(rbMegbizhatoNem);
            gboxMegbizhato.Controls.Add(rbMegbizhatoIgen);
            gboxMegbizhato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gboxMegbizhato.Location = new Point(12, 145);
            gboxMegbizhato.Name = "gboxMegbizhato";
            gboxMegbizhato.Size = new Size(310, 97);
            gboxMegbizhato.TabIndex = 3;
            gboxMegbizhato.TabStop = false;
            gboxMegbizhato.Text = "Megbízható";
            // 
            // rbMegbizhatoNem
            // 
            rbMegbizhatoNem.AutoSize = true;
            rbMegbizhatoNem.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            rbMegbizhatoNem.Location = new Point(186, 40);
            rbMegbizhatoNem.Name = "rbMegbizhatoNem";
            rbMegbizhatoNem.Size = new Size(76, 34);
            rbMegbizhatoNem.TabIndex = 0;
            rbMegbizhatoNem.Text = "nem";
            rbMegbizhatoNem.UseVisualStyleBackColor = true;
            // 
            // rbMegbizhatoIgen
            // 
            rbMegbizhatoIgen.AutoSize = true;
            rbMegbizhatoIgen.Checked = true;
            rbMegbizhatoIgen.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            rbMegbizhatoIgen.Location = new Point(50, 40);
            rbMegbizhatoIgen.Name = "rbMegbizhatoIgen";
            rbMegbizhatoIgen.Size = new Size(76, 34);
            rbMegbizhatoIgen.TabIndex = 0;
            rbMegbizhatoIgen.TabStop = true;
            rbMegbizhatoIgen.Text = "igen";
            rbMegbizhatoIgen.UseVisualStyleBackColor = true;
            // 
            // rtbFoglalozott
            // 
            rtbFoglalozott.Location = new Point(12, 301);
            rtbFoglalozott.Name = "rtbFoglalozott";
            rtbFoglalozott.Size = new Size(310, 148);
            rtbFoglalozott.TabIndex = 4;
            rtbFoglalozott.Text = "";
            // 
            // lblUI2
            // 
            lblUI2.AutoSize = true;
            lblUI2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUI2.Location = new Point(12, 265);
            lblUI2.Name = "lblUI2";
            lblUI2.Size = new Size(193, 21);
            lblUI2.TabIndex = 1;
            lblUI2.Text = "Lefoglalózott járművek:";
            // 
            // FrmVevok
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(rtbFoglalozott);
            Controls.Add(gboxMegbizhato);
            Controls.Add(txtCim);
            Controls.Add(lblUI2);
            Controls.Add(lblUI1);
            Controls.Add(cboxNevek);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmVevok";
            Text = "Vevők";
            gboxMegbizhato.ResumeLayout(false);
            gboxMegbizhato.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxNevek;
        private Label lblUI1;
        private TextBox txtCim;
        private GroupBox gboxMegbizhato;
        private RadioButton rbMegbizhatoNem;
        private RadioButton rbMegbizhatoIgen;
        private RichTextBox rtbFoglalozott;
        private Label lblUI2;
    }
}