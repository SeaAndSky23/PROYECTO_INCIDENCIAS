using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INCIDENCIAS
{
    public class RegistroProblema
    {
        public string Usuario { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaHora { get; set; }

        public RegistroProblema() { }
        public RegistroProblema(string usuario, string tipo, string descripcion, string ubicacion, DateTime fechaHora)
        {
            Usuario = usuario;
            Tipo = tipo;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            FechaHora = fechaHora;
        }
    }
}
