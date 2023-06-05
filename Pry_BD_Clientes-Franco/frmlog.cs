using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_BD_Clientes_Franco
{
    public partial class frmlog : Form
    {
        public frmlog()
        {
            InitializeComponent();
        }

        private void btnInicar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" )
            {
                if (txtContra.Text == "admin")
                {
                    MessageBox.Show("acceso permitido");
                    var frmClientes = new frmClientes();                   
                    frmClientes.Show();
                    this.Hide();
                    

                }
                else
                {
                    MessageBox.Show("Error de datos");     
                }
            }
        }

        private void frmlog_Load(object sender, EventArgs e)
        {

        }

        private void btnInicar_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "")
            {                
                
               btnInicar.Location = new Point(36, 153);
                
                
            }
            

            
        }
    }
}
