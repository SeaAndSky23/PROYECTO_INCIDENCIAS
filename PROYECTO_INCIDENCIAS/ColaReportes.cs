using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

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

        //CONVERTIR EN LISTA YA QUE NO USO LOS MÉTODOS PREESTABLECIDOS
        public List<RegistroProblema> Listar()
        {
            List<RegistroProblema> listaproblemas = new List<RegistroProblema>();
            Nodo actual = Inicio;
            while (actual != null)
            {
                listaproblemas.Add(actual.dato);
                actual = actual.siguiente;
            }
            return listaproblemas;
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
