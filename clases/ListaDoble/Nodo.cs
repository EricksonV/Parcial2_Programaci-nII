using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor.clases
{
    class Nodo
    {
        string cancion;
        string direccion;
        public Nodo adelante;
        public Nodo atras;

        public Nodo(string nombreCancion, string direccionCancion) {
            cancion = nombreCancion;
            direccion = direccionCancion;
            adelante = atras = null;
        }

        public string Cancion { get => cancion;  }
        public string Direccion { get => direccion; }
    }
}
