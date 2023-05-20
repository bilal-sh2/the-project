namespace the_project
{
    partial class accountingcontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountingcontrol));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            priceD = new Button();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            addbutton = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(6, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(68, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 23);
            textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 26);
            panel1.Controls.Add(priceD);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(666, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 118);
            panel1.TabIndex = 2;
            // 
            // priceD
            // 
            priceD.FlatStyle = FlatStyle.Flat;
            priceD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            priceD.ForeColor = SystemColors.ControlLightLight;
            priceD.Location = new Point(25, 63);
            priceD.Name = "priceD";
            priceD.Size = new Size(75, 32);
            priceD.TabIndex = 11;
            priceD.Text = "click";
            priceD.UseVisualStyleBackColor = true;
            priceD.Click += priceD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(42, 98);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "price";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(6, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 10;
            label3.Text = "Currency Exchange";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonFace;
            textBox3.Location = new Point(492, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 23);
            textBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(23, 24, 26);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(193, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(598, 383);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.FromArgb(23, 24, 26);
            addbutton.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            addbutton.ForeColor = SystemColors.ButtonFace;
            addbutton.Image = Properties.Resources.icons8_Plus_321;
            addbutton.Location = new Point(-10, -10);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(232, 96);
            addbutton.TabIndex = 6;
            addbutton.Text = " ADD";
            addbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addbutton.UseCompatibleTextRendering = true;
            addbutton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(243, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 8;
            label2.Text = "select product";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 26);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 115);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(595, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 11;
            label5.Text = "Quantity";
            // 
            // panel3
            // 
            panel3.Controls.Add(addbutton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 71);
            panel3.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(23, 24, 26);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(panel3);
            panel7.Location = new Point(3, 170);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 210);
            panel7.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 133);
            panel5.Name = "panel5";
            panel5.Size = new Size(184, 62);
            panel5.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 26);
            button2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(-33, -4);
            button2.Name = "button2";
            button2.Size = new Size(324, 74);
            button2.TabIndex = 6;
            button2.Text = " DELET";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 62);
            panel4.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 26);
            button1.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-33, -4);
            button1.Name = "button1";
            button1.Size = new Size(324, 74);
            button1.TabIndex = 6;
            button1.Text = " EDIT";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            // 
            // accountingcontrol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "accountingcontrol";
            Size = new Size(794, 571);
            Load += accountingcontrol_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Label label3;
        private Button addbutton;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Panel panel7;
        private Panel panel4;
        private Button button1;
        private Panel panel5;
        private Button button2;
        private Button priceD;
    }
}
