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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
