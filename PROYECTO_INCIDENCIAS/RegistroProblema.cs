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
        public int riesgo { get; set; }
        public bool Estado_Reporte { get; set; }
        public string Comentarios { get; set; }
        public string Comentario_espera { get; set; }
        public string Comentario_enproceso { get; set; }
        public string Comentario_finalizado { get; set; }
        public string Comentario_Eliminado { get; set; }

        public RegistroProblema(string usuario, string tipo, string descripcion, string ubicacion, DateTime fechaHora, string comentarios)
        {
            Usuario = usuario;
            Tipo = tipo;
            //ALTO = 1
            //MEDIANO = 2 
            //BAJO = 3
            switch (tipo.ToUpper())
            {
                case "ACCIDENTES DE TRÁFICO (PEATONALES, VEHICULARES)":
                case "INCENDIOS (ESTRUCTURALES, NATURALES)":
                case "DELITOS (ROBOS, HURTOS, VANDALISMO, ASALTOS)":
                case "ACTIVIDADES DE MANIFESTACIÓN O DISTURBIOS":
                    riesgo = 1; break;
                case "DEFICIENCIAS EN LA VÍA PÚBLICA (BACHES, ACERAS ROTAS, MOBILIARIO URBANO DAÑADO)":
                case "AVERÍAS EN LA RED DE AGUA O ALCANTARILLADO":
                case "INCIDENTES DE BIENESTAR ANIMAL":
                    riesgo = 2; break;
                case "PROBLEMAS CON SERVICIOS URBANOS (ALUMBRADO PÚBLICO, LIMPIEZA Y GESTIÓN DE RESIDUOS)":
                case "PLAGAS SANITARIAS":
                case "PROBLEMAS CON EL ARBOLADO Y JARDINERÍA (RAMAS CAÍDAS, RIEGO, PODA)":
                    riesgo = 3; break;
                default:
                    riesgo = 4; break;
            }
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            FechaHora = fechaHora;
            Comentarios = comentarios;
        }
    }
}
