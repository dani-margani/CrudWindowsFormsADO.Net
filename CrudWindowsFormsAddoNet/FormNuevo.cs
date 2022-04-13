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
    public partial class FrmNuevo : Form
    {
        public FrmNuevo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ItemsCentralesDB oItemsCentralesDB = new ItemsCentralesDB();
            try
            {
                oItemsCentralesDB.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecioCaja.Text, txtPrecioUnitario.Text);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar: "+ex.Message);
            }
        }
    }
}
