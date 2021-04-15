using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.clases.Lista_Circular
{
    class LCiterador
    {
        private NodoC actual;

        public LCiterador(ListaCircular id)
        {
            actual = id.RetornaNodo;
        }

        public NodoC siguiente()
        {
            NodoC a;
            a = actual;
            if (actual != null)
            {
                actual = actual.Enlace;
            }
            return a;
        }

    }
}
