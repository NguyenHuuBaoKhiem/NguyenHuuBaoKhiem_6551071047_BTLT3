namespace Demo3
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
            label2 = new Label();
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            btnHoLot = new Button();
            btnTen = new Button();
            button3 = new Button();
            button4 = new Button();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(148, 161);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 1;
            label1.Text = "Họ lót";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(148, 217);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(238, 160);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(348, 27);
            txtHoLot.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 192, 192);
            txtTen.Location = new Point(238, 216);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(348, 27);
            txtTen.TabIndex = 4;
            // 
            // btnHoLot
            // 
            btnHoLot.Location = new Point(148, 326);
            btnHoLot.Name = "btnHoLot";
            btnHoLot.Size = new Size(94, 29);
            btnHoLot.TabIndex = 5;
            btnHoLot.Text = "Họ Lót";
            btnHoLot.UseVisualStyleBackColor = true;
            btnHoLot.Click += btnHoLot_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(339, 326);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 6;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // button3
            // 
            button3.Location = new Point(533, 326);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Họ và tên";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(308, 409);
            button4.Name = "button4";
            button4.Size = new Size(158, 29);
            button4.TabIndex = 8;
            button4.Text = "Thoát chương trình";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.Highlight;
            lblHoTen.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.Yellow;
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(801, 142);
            lblHoTen.TabIndex = 9;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoTen);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnTen);
            Controls.Add(btnHoLot);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtHoLot;
        private TextBox txtTen;
        private Button btnHoLot;
        private Button btnTen;
        private Button button3;
        private Button button4;
        private Label lblHoTen;
    }
}
