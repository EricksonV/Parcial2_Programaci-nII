using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.clases.Lista_Circular
{
    class NodoC
    {
        private string cancion;
        private string direccionC;
        private NodoC enlace;

        public NodoC(string NombreCancion, string direccionCancion) {
            cancion = NombreCancion;
            direccionC = direccionCancion;
            enlace = this;
        }

        public string Cancion { get => cancion; }
        public string DireccionC { get => direccionC; }
        public NodoC Enlace { get => enlace; set => enlace = value; }
    }
}
