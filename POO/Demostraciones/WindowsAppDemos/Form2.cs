using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using LibPOO.PruebaErrores;

namespace WindowsAppDemos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPruebaException_Click(object sender, EventArgs e)
        {
            int num1=10, num2=0, result=0;
            try
            {
                result = num1 / num2;

                MessageBox.Show(result.ToString());
            }
            catch (DivideByZeroException ex )
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void btnSqlException_Click(object sender, EventArgs e)
        {  string cadena = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";

                SqlConnection conection = new SqlConnection(cadena);
            try
            {
              

                SqlCommand cmd = new SqlCommand("Select count(*) from dbo.Customers", conection);

                conection.Open();
                cmd.ExecuteScalar();


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            finally
            {
                if (conection.State==ConnectionState.Open)
                {
                    conection.Close();
                }
                
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento(new DateTime(2023, 1, 20), new DateTime(2023, 1, 10));

                MessageBox.Show(evento.FechaInicio.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
