namespace Demo5
{
    partial class Form1
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
            label1 = new Label();
            txtNhapTen = new TextBox();
            gbColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox1 = new GroupBox();
            chkUnderLine = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            gbColor.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(104, 5);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(341, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += textBox1_TextChanged;
            // 
            // gbColor
            // 
            gbColor.BackColor = SystemColors.ActiveCaption;
            gbColor.Controls.Add(radBlack);
            gbColor.Controls.Add(radBlue);
            gbColor.Controls.Add(radGreen);
            gbColor.Controls.Add(radRed);
            gbColor.Font = new Font("Segoe UI", 10F);
            gbColor.Location = new Point(12, 48);
            gbColor.Name = "gbColor";
            gbColor.Size = new Size(186, 160);
            gbColor.TabIndex = 2;
            gbColor.TabStop = false;
            gbColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radBlack.Location = new Point(25, 119);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(74, 27);
            radBlack.TabIndex = 3;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radBlue.ForeColor = Color.FromArgb(0, 0, 192);
            radBlue.Location = new Point(25, 86);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(66, 27);
            radBlue.TabIndex = 2;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radGreen.ForeColor = Color.Lime;
            radGreen.Location = new Point(25, 53);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(78, 27);
            radGreen.TabIndex = 1;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.BackColor = Color.Transparent;
            radRed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(25, 20);
            radRed.Name = "radRed";
            radRed.Size = new Size(62, 27);
            radRed.TabIndex = 0;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = false;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(chkUnderLine);
            groupBox1.Controls.Add(chkItalic);
            groupBox1.Controls.Add(chkBold);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(249, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 160);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font";
            // 
            // chkUnderLine
            // 
            chkUnderLine.AutoSize = true;
            chkUnderLine.FlatStyle = FlatStyle.Flat;
            chkUnderLine.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
            chkUnderLine.ForeColor = Color.Blue;
            chkUnderLine.Location = new Point(23, 104);
            chkUnderLine.Name = "chkUnderLine";
            chkUnderLine.Size = new Size(112, 27);
            chkUnderLine.TabIndex = 2;
            chkUnderLine.Text = "Gạch Chân";
            chkUnderLine.UseVisualStyleBackColor = true;
            chkUnderLine.CheckedChanged += chkUnderLine_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.FlatStyle = FlatStyle.Flat;
            chkItalic.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(23, 71);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(140, 27);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.FlatStyle = FlatStyle.Flat;
            chkBold.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(23, 38);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(108, 27);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(35, 258);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 4;
            label2.Text = "Lập trình bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.FlatStyle = FlatStyle.Flat;
            lblLapTrinh.Location = new Point(168, 258);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(158, 27);
            lblLapTrinh.TabIndex = 5;
            lblLapTrinh.Click += lblLapTrinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(344, 258);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 397);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(gbColor);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            gbColor.ResumeLayout(false);
            gbColor.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private GroupBox gbColor;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox groupBox1;
        private CheckBox chkUnderLine;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label label2;
        private Label lblLapTrinh;
        private Button btnThoat;
    }
}
