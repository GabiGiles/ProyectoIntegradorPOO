using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public static class AdminAlumno
    {
        public static List<Alumno> CargaAlumnos() {

            List<Alumno> lista = new List<Alumno>();
            lista.Add(new Alumno() { Apellido="Rosa" , Nombre="Maria", NroLegajo=100  });
            lista.Add(new Alumno() { Apellido = "Pinta", Nombre = "Andres", NroLegajo = 110 });

            return lista;
        }

        public static int Nuevo(Alumno alumno)
        {
 
            return DacAlumno.Insertar(alumno);
        }

    }
}
