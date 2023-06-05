using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pry_BD_Clientes_Franco
{
    public partial class frmClientes : Form
    {
        
        public frmClientes()
        {
            InitializeComponent();
        }

       
        private void frmClientes_Load(object sender, EventArgs e)
        {
            Class1 Datos = new Class1();
            Datos.CargarPaisCiudad(cmbCiudad, cmbPais, "NEPTUNO", "Clientes");

        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Class1 Datos = new Class1();
            Datos.ListarClientes(dgv, "NEPTUNO", "Clientes");
            mrcFiltro.Enabled = true;
                               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class1 Datos = new Class1();
            Datos.ListarPais(dgv, "NEPTUNO", "Clientes", cmbPais, cmbCiudad);
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class1 Datos = new Class1();
            Datos.ListarCiudad(dgv, "NEPTUNO", "Clientes", cmbCiudad, cmbPais);
        }
    }
}
