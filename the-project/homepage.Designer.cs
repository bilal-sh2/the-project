namespace the_project
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            accountingcontrol1 = new accountingcontrol();
            storg1 = new storg();
            panel1 = new Panel();
            sideparicon = new PictureBox();
            panelmune = new Panel();
            panel3 = new Panel();
            buttonSTORG = new Button();
            panel2 = new Panel();
            sidypanel = new Panel();
            buttonACAONTING = new Button();
            panelHOME = new Panel();
            buttonHOME = new Button();
            menetrn = new System.Windows.Forms.Timer(components);
            loginpage2 = new loginpage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sideparicon).BeginInit();
            panelmune.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelHOME.SuspendLayout();
            SuspendLayout();
            // 
            // accountingcontrol1
            // 
            accountingcontrol1.BackColor = Color.White;
            accountingcontrol1.Location = new Point(219, 28);
            accountingcontrol1.Name = "accountingcontrol1";
            accountingcontrol1.Size = new Size(795, 571);
            accountingcontrol1.TabIndex = 1;
            // 
            // storg1
            // 
            storg1.BackColor = Color.White;
            storg1.Location = new Point(218, 28);
            storg1.Name = "storg1";
            storg1.Size = new Size(796, 571);
            storg1.TabIndex = 2;
            storg1.Load += storg1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(sideparicon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 28);
            panel1.TabIndex = 8;
            // 
            // sideparicon
            // 
            sideparicon.Image = Properties.Resources.icons8W_menu_32;
            sideparicon.Location = new Point(0, 0);
            sideparicon.Margin = new Padding(3, 10, 3, 30);
            sideparicon.Name = "sideparicon";
            sideparicon.Size = new Size(49, 28);
            sideparicon.SizeMode = PictureBoxSizeMode.CenterImage;
            sideparicon.TabIndex = 3;
            sideparicon.TabStop = false;
            sideparicon.Click += sideparicon_Click;
            // 
            // panelmune
            // 
            panelmune.BackColor = Color.FromArgb(23, 24, 26);
            panelmune.Controls.Add(panel3);
            panelmune.Controls.Add(panel2);
            panelmune.Controls.Add(panelHOME);
            panelmune.Dock = DockStyle.Left;
            panelmune.ForeColor = SystemColors.Control;
            panelmune.Location = new Point(0, 28);
            panelmune.Name = "panelmune";
            panelmune.Size = new Size(220, 546);
            panelmune.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonSTORG);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 57);
            panel3.TabIndex = 12;
            // 
            // buttonSTORG
            // 
            buttonSTORG.BackColor = Color.FromArgb(23, 24, 26);
            buttonSTORG.ForeColor = SystemColors.ButtonFace;
            buttonSTORG.Image = (Image)resources.GetObject("buttonSTORG.Image");
            buttonSTORG.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSTORG.Location = new Point(-11, -13);
            buttonSTORG.Name = "buttonSTORG";
            buttonSTORG.Padding = new Padding(30, 0, 0, 0);
            buttonSTORG.Size = new Size(269, 81);
            buttonSTORG.TabIndex = 11;
            buttonSTORG.Text = "               STORG";
            buttonSTORG.TextAlign = ContentAlignment.MiddleLeft;
            buttonSTORG.UseVisualStyleBackColor = false;
            buttonSTORG.Click += buttonSTORG_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(sidypanel);
            panel2.Controls.Add(buttonACAONTING);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 57);
            panel2.TabIndex = 11;
            // 
            // sidypanel
            // 
            sidypanel.BackColor = SystemColors.ButtonHighlight;
            sidypanel.Location = new Point(3, 6);
            sidypanel.Name = "sidypanel";
            sidypanel.Size = new Size(25, 51);
            sidypanel.TabIndex = 5;
            // 
            // buttonACAONTING
            // 
            buttonACAONTING.BackColor = Color.FromArgb(23, 24, 26);
            buttonACAONTING.FlatStyle = FlatStyle.Flat;
            buttonACAONTING.ForeColor = SystemColors.ButtonFace;
            buttonACAONTING.Image = (Image)resources.GetObject("buttonACAONTING.Image");
            buttonACAONTING.ImageAlign = ContentAlignment.MiddleLeft;
            buttonACAONTING.Location = new Point(-11, -13);
            buttonACAONTING.Name = "buttonACAONTING";
            buttonACAONTING.Padding = new Padding(30, 0, 0, 0);
            buttonACAONTING.Size = new Size(269, 81);
            buttonACAONTING.TabIndex = 11;
            buttonACAONTING.Text = "               ACONTING";
            buttonACAONTING.TextAlign = ContentAlignment.MiddleLeft;
            buttonACAONTING.UseVisualStyleBackColor = false;
            buttonACAONTING.Click += buttonACAONTING_Click;
            // 
            // panelHOME
            // 
            panelHOME.Controls.Add(buttonHOME);
            panelHOME.Dock = DockStyle.Top;
            panelHOME.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelHOME.Location = new Point(0, 0);
            panelHOME.Name = "panelHOME";
            panelHOME.Size = new Size(220, 57);
            panelHOME.TabIndex = 10;
            // 
            // buttonHOME
            // 
            buttonHOME.BackColor = Color.FromArgb(23, 24, 26);
            buttonHOME.FlatStyle = FlatStyle.Flat;
            buttonHOME.ForeColor = SystemColors.ButtonFace;
            buttonHOME.Image = (Image)resources.GetObject("buttonHOME.Image");
            buttonHOME.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHOME.Location = new Point(-11, -13);
            buttonHOME.Name = "buttonHOME";
            buttonHOME.Padding = new Padding(30, 0, 0, 0);
            buttonHOME.Size = new Size(269, 81);
            buttonHOME.TabIndex = 11;
            buttonHOME.Text = "               HOME";
            buttonHOME.TextAlign = ContentAlignment.MiddleLeft;
            buttonHOME.UseVisualStyleBackColor = false;
            buttonHOME.Click += buttonHOME_Click;
            // 
            // menetrn
            // 
            menetrn.Interval = 8;
            menetrn.Tick += menetrn_Tick;
            // 
            // loginpage2
            // 
            loginpage2.BackColor = Color.White;
            loginpage2.Location = new Point(218, 28);
            loginpage2.Name = "loginpage2";
            loginpage2.Size = new Size(796, 571);
            loginpage2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 574);
            Controls.Add(loginpage2);
            Controls.Add(panelmune);
            Controls.Add(panel1);
            Controls.Add(storg1);
            Controls.Add(accountingcontrol1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sideparicon).EndInit();
            panelmune.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelHOME.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private accountingcontrol accountingcontrol1;
        private storg storg1;
        private Panel panel1;
        private PictureBox sideparicon;
        private Panel panelmune;
        private Panel sidypanel;
        private Panel panelHOME;
        private Button buttonHOME;
        private Panel panel3;
        private Button buttonSTORG;
        private Panel panel2;
        private Button buttonACAONTING;
        private System.Windows.Forms.Timer menetrn;
        private loginpage loginpage2;
    }
}