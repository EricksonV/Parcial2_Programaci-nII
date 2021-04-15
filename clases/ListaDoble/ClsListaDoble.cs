using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.clases
{
    class ClsListaDoble
    {
        //definir 
        protected Nodo cabeza; //es el nodo que se llama primero
        public int cont;

        public ClsListaDoble()
        {
            cabeza = null;
        }
        public Nodo RetornaCabeza() {
            return cabeza;
        }
        public ClsListaDoble InsertarCabezaLista(string song, string url)
        {
            Nodo nuevo;
            nuevo = new Nodo(song,url);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;
            cont++;
            return this;
        }
        public ClsListaDoble insertaDespues(Nodo ant, string song, string url)
        {
            Nodo nuevo;
            nuevo = new Nodo(song, url);
            nuevo.adelante = ant.adelante;
            if (ant.adelante != null)
            {
                ant.adelante.atras = nuevo;
            }
            ant.adelante = nuevo;
            nuevo.atras = ant;
            return this;
        }
        public void eliminar(string entrada)
        {
            Nodo actual;
            actual = cabeza;
            bool encontrado = false;

            //bucle de busqueda
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.Cancion.Equals(entrada));
                if (!encontrado)
                {
                    actual = actual.adelante;
                }
            }

            //enlace de un nodo anterior con el siguiente 
            if (actual != null)
            {
                //distinguir entre nodo cabecera del resto de la lista
                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                }
                else if (actual.adelante != null)
                {//no es el último nodo
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else
                {//ultimo nodo
                    actual.atras.adelante = null;
                }
                actual = null;
            }
        }//fin eliminar
        public void visualizar()
        {
            Nodo n;
            n = cabeza;
            while (n != null)
            {
               // System.out.print(n.dato + "\n");
                n = n.adelante;
            }
        }// end visualizar
        public string[] devuelveCanciones()
        {
            Nodo n;
            n = cabeza;
            string[] devuelta;
            string datos = "";
            while (n != null)
            {
                datos += n.Cancion + ";";
                n = n.adelante;
            }
            datos = datos.TrimEnd(';');
            return devuelta = datos.Split(';');
        }// end devuelveCanciones
        public Nodo obtieneCancion(int posicion)
        {
            //Nodo indice;
            if (posicion < 0 || posicion >= cont) {
                return null;
            }
            int n = 0;
            Nodo Aux = cabeza;
            while (n != posicion) {
                Aux = Aux.adelante;
                n++;
            }
            return Aux;
        }
    }
}
