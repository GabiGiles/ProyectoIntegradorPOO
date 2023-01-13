using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.PruebaErrores
{
    public class Evento
    {

        public Evento(DateTime fechaInicio, DateTime fechaFin ) 
        {
            if (fechaInicio>fechaFin)
            {
                throw new Exception("La fecha de inicio no puede ser mayor a la de finalización");
            }

            //if (fechaFin<fechaInicio)
            //{
            //    throw new Exception("La fecha de finalización no puede ser anterior a la de inicio");

            //}
            FechaInicio = fechaInicio;

            FechaFin = fechaFin;
        }



        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        private DateTime fechaFin;
        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
