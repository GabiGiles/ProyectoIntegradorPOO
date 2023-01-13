using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Clinica
{
    public class Medico:Persona
    {
        public int Matricula { get; set; }

        //Propiedad de navegación
        //un medico tiene muchos pacientes
        public List<Paciente> Pacientes { get; set; }
    }
}
