using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEF.Models;
using WindowsEF.Dac;
namespace WindowsEF
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text}; 

            int filasAfectadas= AbmCategoria.Insert(categoria);

            if (filasAfectadas>0)
            {
                MessageBox.Show("Insert ok");
                MostrarTodasCategorias();

            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTodasCategorias();
        }

        private void MostrarTodasCategorias()
        {
            GridCategoria.DataSource = AbmCategoria.SelectAll();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text, Id = Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmCategoria.Update(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarTodasCategorias();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text , Id=Convert.ToInt32(txtId.Text)};

            int filasAfectadas = AbmCategoria.Delete(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarTodasCategorias();

            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(txtId.Text);

            Categoria categoria = AbmCategoria.SelectWhereById(id);
            MessageBox.Show(categoria.Nombre);
        }
    }
}
