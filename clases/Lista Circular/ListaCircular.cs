using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.clases.Lista_Circular
{
    class ListaCircular
    {
        private NodoC lc;

        public ListaCircular() { lc = null; }
        public NodoC RetornaNodo { get => lc; }
        public ListaCircular insertar(string nombreCancion, string direccionCancion) {
            NodoC temp;
            temp = new NodoC(nombreCancion, direccionCancion);
            if (lc != null) {
                temp.Enlace = lc.Enlace;
                lc.Enlace = temp;
            }
            lc = temp;
            return this;
        }//end insertar
        public void eliminar(string entrada) {
            NodoC actual;
            actual = lc;
            while ((actual.Enlace != lc) && !(actual.Enlace.Cancion.Equals(entrada))) {
                if (!actual.Enlace.Cancion.Equals(entrada)) {
                    actual = actual.Enlace;
                }
            }

            if (actual.Enlace.Cancion.Equals(entrada)) {
                NodoC p;
                p = actual.Enlace;
                if (lc == lc.Enlace) { lc = null; }
                else
                {
                    if (p == lc) { lc = actual; }
                    actual.Enlace = p.Enlace;
                }
                p = null;
            }
        }//end eliminar
        public void borrarLista() {
            NodoC p;
            if (lc != null) {
                p = lc;
                do
                {
                    NodoC t;
                    t = p;
                    p = p.Enlace;
                } while (p != lc);
            }
            lc = null;
        }//end borrarLista
        public void recorrer() {
            NodoC p;
            if (lc != null)
            {
                p = lc.Enlace;
                do
                {
                    Console.WriteLine("\t" + p.Cancion);
                    p = p.Enlace;
                } while (p != lc.Enlace);
            }
            else { Console.WriteLine("Lista Vacia"); }
        }//end recorrer
    }
}
