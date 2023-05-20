namespace the_project
{
    public partial class Form1 : Form
    {
        bool sideparexpand = true;
        public Form1()
        {
            InitializeComponent();
            sidypanel.Height = buttonHOME.Height;
            accountingcontrol1.BringToFront();
            sidypanel.Top = buttonHOME.Top;

        }

        //sidepanalexpandto 70 width and 541 width 
        private void menetrn_Tick(object sender, EventArgs e)
        {
            if (sideparexpand == true)
            {
                panelmune.Width -= 10;
                if (panelmune.Width <= 70) { sideparexpand = false; menetrn.Stop(); }
            }
            else
                panelmune.Width += 10;
            if (panelmune.Width >= 541) { sideparexpand = true; menetrn.Stop(); }
        }

        private void sideparicon_Click(object sender, EventArgs e)
        {
            menetrn.Start();
        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            sidypanel.Height = buttonHOME.Height;
            loginpage2.BringToFront();
            sidypanel.Top = buttonHOME.Top;
        }

        private void buttonACAONTING_Click(object sender, EventArgs e)
        {
            sidypanel.Height = buttonACAONTING.Height;
            accountingcontrol1.BringToFront();
            sidypanel.Top = buttonACAONTING.Top;
        }

        private void storg1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSTORG_Click(object sender, EventArgs e)
        {
            sidypanel.Height = buttonSTORG.Height;
            storg1.BringToFront();
            sidypanel.Top = buttonACAONTING.Top;
        }
    }
}
