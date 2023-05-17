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
        OleDbConnection miConexionBD;
        OleDbCommand miComandoBD;
        OleDbDataReader miLectorBD;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                miConexionBD = new OleDbConnection();
                miConexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";
                miConexionBD.Open();

                btnConect.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                btnConect.Text = "Error";
                btnConect.Text = ex.Message;
                btnConect.BackColor = Color.Red;
                
               

               
            }
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            try
            {
                miComandoBD = new OleDbCommand();

                miComandoBD.Connection = miConexionBD;
                miComandoBD.CommandType = CommandType.TableDirect;
                miComandoBD.CommandText = "Clientes";

                btnMostrar.BackColor = Color.Green;

                miLectorBD = miComandoBD.ExecuteReader();

                while (miLectorBD.Read())
                {
                                       
                  dgv.Rows.Add(miLectorBD[0], miLectorBD[1], miLectorBD[2], miLectorBD[3], miLectorBD[4], miLectorBD[5], miLectorBD[6], miLectorBD[7], miLectorBD[8], miLectorBD[9], miLectorBD[10]);
                    
                }

            }
            catch (Exception ex)
            {
                btnMostrar.Text = "Error";
                btnMostrar.BackColor = Color.Red;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
