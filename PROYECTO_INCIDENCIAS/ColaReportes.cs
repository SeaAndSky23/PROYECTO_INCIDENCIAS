using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PROYECTO_INCIDENCIAS.ColaReportes;


namespace PROYECTO_INCIDENCIAS
{
    public class Nodo
    {
        public RegistroProblema dato;
        public Nodo siguiente;
    }

    public class ColaReportes
    {
        public Nodo Inicio;
        public Nodo Fin;

        public ColaReportes()
        {
            Inicio = null;
            Fin = null;
        }

        public void Encolar(RegistroProblema registroProblema)
        {
            Nodo NuevoNodo = new Nodo();
            NuevoNodo.dato = registroProblema;
            NuevoNodo.siguiente = null;

            if (Inicio == null)
            {
                Inicio = Fin = NuevoNodo;
            }
            else
            {
                Fin.siguiente = NuevoNodo;
            }
            Fin = NuevoNodo;
        }

        public RegistroProblema Desencolar()
        {
            if (Inicio == null)
            {
                return null;
            }
            Nodo aux = Inicio;
            RegistroProblema registroProblema = aux.dato;
            Inicio = aux.siguiente;
            if (Inicio == null)
            {
                Fin = null;
            }
            return registroProblema;
        }
        public RegistroProblema EliminarPorDatos(string usuario, string tipo, string descripcion, string ubicacion, string fecha, int riesgo)
        {
            if (Inicio == null) return null;

            Nodo actual = Inicio;
            Nodo anterior = null;

            // Normalizar la fecha del DataGridView
            DateTime fechaComparar;
            DateTime.TryParse(fecha, out fechaComparar);

            while (actual != null)
            {
                // Comparación robusta, ignorando mayúsculas, espacios y formato de fecha
                bool coincide =
                    string.Equals(actual.dato.Usuario?.Trim(), usuario?.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(actual.dato.Tipo?.Trim(), tipo?.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(actual.dato.Descripcion?.Trim(), descripcion?.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(actual.dato.Ubicacion?.Trim(), ubicacion?.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    actual.dato.riesgo == riesgo &&
                    Math.Abs((actual.dato.FechaHora - fechaComparar).TotalSeconds) < 2; // margen de 2 segundos

                if (coincide)
                {
                    // Eliminar el nodo
                    if (anterior == null)
                        Inicio = Inicio.siguiente;
                    else
                        anterior.siguiente = actual.siguiente;

                    if (actual == Fin)
                        Fin = anterior;

                    return actual.dato;
                }

                anterior = actual;
                actual = actual.siguiente;
            }

            return null;
        }

        //LISTA ENLAZADA PARA AGREGAR REPORTES A UNA LISTA DE "EN PROCESO"
        public class ListaEnlazadaReportesAtendidos
        {
            public Nodo Inicio;
            public Nodo Fin;
            public ListaEnlazadaReportesAtendidos()
            {
                Inicio = null;
                Fin = null;
            }
            public void AgregarReporteAtendidos(RegistroProblema atendido)
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.dato = atendido;
                nuevoNodo.siguiente = null;

                if (Inicio == null)
                {
                    Inicio = Fin = nuevoNodo;
                }
                else
                {
                    Fin.siguiente = nuevoNodo;
                    Fin = nuevoNodo;
                }
            }
            
            public void EliminarReporteFINALIZADO(RegistroProblema finalizar)
            {
                if (Inicio == null) return;

                if (Inicio.dato == finalizar)
                {
                    Inicio = Inicio.siguiente;
                    return;
                }
                else
                {
                    Nodo actual = Inicio, anterior = null;
                    while (actual != null && actual.dato != finalizar)
                    {
                        anterior = actual;
                        actual = actual.siguiente;
                    }
                    if (actual != null)
                    {
                        anterior.siguiente = actual.siguiente;
                    }
                }
            }
        }
        //CLASE PARA USAR LAS PILAS 
        public class PilaReportes
        {
            public Nodo Inicio;
            public PilaReportes()
            {
                Inicio = null;
            }
            public void Apilar(RegistroProblema registroProblema)
            {
                Nodo NuevoNodo = new Nodo();
                NuevoNodo.dato = registroProblema;
                NuevoNodo.siguiente = Inicio;
                Inicio = NuevoNodo;
            }
        }
    }
}