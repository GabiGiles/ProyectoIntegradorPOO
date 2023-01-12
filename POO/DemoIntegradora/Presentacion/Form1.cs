

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridAlumnos.DataSource = AdminAlumno.CargaAlumnos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Apellido=txtApellido.Text, Nombre=txtNombre.Text, NroLegajo= Convert.ToInt32(txtLegajo.Text) };

            AdminAlumno.Nuevo(alumno);
        }
    }
}
