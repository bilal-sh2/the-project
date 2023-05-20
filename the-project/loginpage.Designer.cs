namespace the_project
{
    partial class loginpage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 258);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 23);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(23, 24, 26);
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 134);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 10;
            label3.Text = "username";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(23, 24, 26);
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(68, 217);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 11;
            label1.Text = "password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 23);
            textBox3.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 26);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(189, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 577);
            panel1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 26);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(68, 352);
            button1.Name = "button1";
            button1.Size = new Size(268, 45);
            button1.TabIndex = 15;
            button1.Text = "log in ";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 26);
            panel2.Location = new Point(0, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 391);
            panel2.TabIndex = 16;
            // 
            // loginpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Name = "loginpage";
            Size = new Size(796, 571);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private TextBox textBox3;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
    }
}
