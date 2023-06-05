using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pry_BD_Clientes_Franco
{
    internal class Class1
    {
        public OleDbCommand comandoBD = new OleDbCommand();
        public OleDbDataReader LectorBD;
        public OleDbConnection ConectBD = new OleDbConnection();

        public void ListarClientes(DataGridView dgv, string BD, string Tabla)
        {
            ConectBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BD + ".accdb;Persist Security Info=False;");
            dgv.Rows.Clear();
            try
            {
                comandoBD.Connection = ConectBD;
                comandoBD.CommandText = Tabla;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.Connection.Open();

                LectorBD = comandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    dgv.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9], LectorBD[10]);
                }

                comandoBD.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void CargarPaisCiudad(ComboBox cmbCiudad, ComboBox cmbPais, string BD, string Tabla)
        {
            ConectBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BD + ".accdb;Persist Security Info=False;");
            bool encontradoCiudad = false;
            bool encontradoPais = false;
            try
            {
                comandoBD.Connection = ConectBD;
                comandoBD.CommandText = Tabla;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.Connection.Open();

                LectorBD = comandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    for (int i = 0; i < cmbCiudad.Items.Count; i++)
                    {
                        if (LectorBD[5].ToString() == cmbCiudad.Items[i].ToString())
                        {
                            encontradoCiudad = true;
                        }
                    }
                    if (encontradoCiudad == false)
                    {
                        cmbCiudad.Items.Add(LectorBD[5]);
                    }
                    encontradoCiudad = false;

                    for (int i = 0; i < cmbPais.Items.Count; i++)
                    {
                        if (LectorBD[8].ToString() == cmbPais.Items[i].ToString())
                        {
                            encontradoPais = true;
                        }
                    }
                    if (encontradoPais == false)
                    {
                        cmbPais.Items.Add(LectorBD[8]);
                    }
                    encontradoPais = false;
                }
                comandoBD.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ListarCiudad(DataGridView dgv, string BD, string Tabla, ComboBox cmbCiudad, ComboBox cmbPais)
        {
            if (cmbCiudad.SelectedIndex != -1)
            {
                ConectBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BD + ".accdb;Persist Security Info=False;");
                dgv.Rows.Clear();
                cmbPais.SelectedIndex = -1;
                try
                {
                    comandoBD.Connection = ConectBD;
                    comandoBD.CommandText = Tabla;
                    comandoBD.CommandType = CommandType.TableDirect;
                    comandoBD.Connection.Open();

                    LectorBD = comandoBD.ExecuteReader();

                    while (LectorBD.Read())
                    {
                        if (LectorBD[5].ToString() == cmbCiudad.Text)
                        {
                            dgv.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9], LectorBD[10]);
                        }
                    }
                    comandoBD.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public void ListarPais(DataGridView dgv, string BD, string Tabla, ComboBox cmbPais, ComboBox cmbCiudad)
        {
            if (cmbPais.SelectedIndex != -1)
            {
                ConectBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BD + ".accdb;Persist Security Info=False;");
                dgv.Rows.Clear();
                cmbCiudad.SelectedIndex = -1;
                try
                {
                    comandoBD.Connection = ConectBD;
                    comandoBD.CommandText = Tabla;
                    comandoBD.CommandType = CommandType.TableDirect;
                    comandoBD.Connection.Open();

                    LectorBD = comandoBD.ExecuteReader();

                    while (LectorBD.Read())
                    {
                        if (LectorBD[8].ToString() == cmbPais.Text)
                        {
                            dgv.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9], LectorBD[10]);
                        }
                    }
                    comandoBD.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
