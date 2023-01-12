using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Estaticos
{
    public class Cliente
    {
        private static int instancias;
        public static int Instancias
        {
            get { return instancias; }
        }

        public Cliente(string nombre)
        { 
            Nombre = nombre;
            instancias++;
        }
        public string Nombre { get; set; }

    }
}
