using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_project
{
    public partial class storg : UserControl
    {
        DataTable tabel = new DataTable();
        public storg()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            tabel.Columns.Add("prodactname", Type.GetType("System.string"));
            tabel.Columns.Add("quantity", Type.GetType("System.string"));
            tabel.Columns.Add("kind", Type.GetType("System.string"));
            tabel.Columns.Add("price", Type.GetType("System.string"));
            dataGridView1.DataSource=tabel;
        }
    }
}
