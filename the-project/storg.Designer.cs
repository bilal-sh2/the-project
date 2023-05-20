namespace the_project
{
    partial class storg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storg));
            prodactname = new TextBox();
            price = new TextBox();
            quantity = new TextBox();
            kind = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            addbutton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // prodactname
            // 
            prodactname.Location = new Point(117, 16);
            prodactname.Name = "prodactname";
            prodactname.Size = new Size(162, 23);
            prodactname.TabIndex = 2;
            // 
            // price
            // 
            price.Location = new Point(699, 17);
            price.Name = "price";
            price.Size = new Size(74, 23);
            price.TabIndex = 4;
            // 
            // quantity
            // 
            quantity.Location = new Point(357, 17);
            quantity.Name = "quantity";
            quantity.Size = new Size(74, 23);
            quantity.TabIndex = 5;
            // 
            // kind
            // 
            kind.Location = new Point(482, 17);
            kind.Name = "kind";
            kind.Size = new Size(162, 23);
            kind.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 7;
            label1.Text = "prodact name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 26);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(addbutton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(price);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(prodactname);
            panel1.Controls.Add(kind);
            panel1.Controls.Add(quantity);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 116);
            panel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 26);
            button2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(132, 56);
            button2.Name = "button2";
            button2.Size = new Size(121, 43);
            button2.TabIndex = 10;
            button2.Text = " EDIT";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.FromArgb(23, 24, 26);
            addbutton.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            addbutton.ForeColor = SystemColors.ButtonFace;
            addbutton.Image = Properties.Resources.icons8_Plus_321;
            addbutton.Location = new Point(5, 56);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(121, 43);
            addbutton.TabIndex = 9;
            addbutton.Text = " ADD";
            addbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addbutton.UseCompatibleTextRendering = true;
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(437, 23);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 10;
            label4.Text = "kind";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(285, 21);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 9;
            label3.Text = "quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(650, 20);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 8;
            label2.Text = "price";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(795, 427);
            dataGridView1.TabIndex = 1;
            // 
            // storg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "storg";
            Size = new Size(795, 571);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox prodactname;
        private TextBox price;
        private TextBox quantity;
        private TextBox kind;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button addbutton;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
