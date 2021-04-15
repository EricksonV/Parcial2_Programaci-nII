using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.clases
{
    class ClsIterator
    {
        private Nodo actual;

        public ClsIterator(ClsListaDoble id) {
            actual = id.RetornaCabeza(); 
        }

        public Nodo siguiente() {
            Nodo a;
            a = actual;
            if (actual != null) {
                if (actual.adelante == null){ irAlinicion(); } //Se analiza si está en la ultima cancion
                else { actual = actual.adelante; }                
            }
            return a;
        }
        public Nodo atras() //Para ir atras de las canciones
        {
            Nodo a;
            a = actual;
            if (actual != null)
            {
                if (actual.atras == null) { irAlFin(); }
                else { actual = actual.atras; }                
            }
            return a;
        }
        private void irAlinicion() {
            while (actual.adelante != null) { actual = actual.adelante; }
        }
        private void irAlFin() {
            while (actual.atras != null) { actual = actual.atras; }
        }

    }
}
