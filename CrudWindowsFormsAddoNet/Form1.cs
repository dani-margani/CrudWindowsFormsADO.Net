using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrudWindowsFormsAddoNet
{
    public partial class FrmMiCrud : Form
    {
        public FrmMiCrud()
        {
            InitializeComponent();
        }

       
        private void Refresh()
        {
            ItemsCentralesDB oItemsCentralesDB = new ItemsCentralesDB();
            dataGridView1.DataSource = oItemsCentralesDB.Get();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevo frm = new FrmNuevo();
            frm.ShowDialog();

        }
    }
}


