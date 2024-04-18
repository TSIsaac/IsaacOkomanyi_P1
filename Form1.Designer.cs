namespace IsaacOkomanyi_P1
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            exitLabel = new Label();
            txtUsername = new TextBox();
            txtpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 124);
            label1.Location = new Point(138, 152);
            label1.Name = "label1";
            label1.Size = new Size(188, 65);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(20, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 124);
            panel1.Location = new Point(20, 362);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 124);
            panel2.Location = new Point(21, 491);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 1);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(21, 435);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 124);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 573);
            button1.Name = "button1";
            button1.Size = new Size(411, 59);
            button1.TabIndex = 5;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 124);
            label2.Location = new Point(304, 533);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 6;
            label2.Text = "Clear Fields";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 117, 124);
            label3.Location = new Point(21, 533);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 7;
            label3.Text = "Create Account";
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.FromArgb(0, 117, 124);
            exitLabel.Location = new Point(199, 663);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(48, 25);
            exitLabel.TabIndex = 8;
            exitLabel.Text = "Exit";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(0, 117, 124);
            txtUsername.Location = new Point(68, 323);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 24);
            txtUsername.TabIndex = 9;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(0, 117, 124);
            txtpassword.Location = new Point(69, 452);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(300, 24);
            txtpassword.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 719);
            Controls.Add(txtpassword);
            Controls.Add(txtUsername);
            Controls.Add(exitLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label exitLabel;
        private TextBox txtUsername;
        private TextBox txtpassword;
    }
}
