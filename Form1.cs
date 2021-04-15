using Reproductor.clases;
using Reproductor.clases.Lista_Circular;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Form1 : Form
    {
        private ClsListaDoble listaCanciones = new ClsListaDoble();
        private ListaCircular circular = new ListaCircular();
        private LCiterador iteradorCircular;
        private ClsIterator iterador;
        private Nodo actual;
        private NodoC actualCircular, circularRepetir;
        private OpenFileDialog busqueda;
        private string[] rutas, archivos;
        private int cont, cont2 = 0, contCircular=0;
        private bool Flagplay = false, flagAdd = false, flagCircular = false;
        string dato;
        public Form1()
        {
            InitializeComponent();
        }

        private void Reproductor_Enter(object sender, EventArgs e)
        {

        }

        private void PBAgregar_Click(object sender, EventArgs e)
        {
            busqueda = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "flac files (*.flac)|*.flac|mp3 files (*.mp3)|*.mp3|" +
                "mp4 files (*.mp4)|*.mp4| All files (*.*)|*.*",
                Title = "Seleccione canciones"

            };

            if (busqueda.ShowDialog() == DialogResult.OK) {
                archivos = busqueda.SafeFileNames;
                rutas = busqueda.FileNames;
                while ((cont < archivos.Length ) && (cont < rutas.Length )) {
                    listaCanciones.InsertarCabezaLista(archivos[cont], rutas[cont]);
                    circular.insertar(archivos[cont], rutas[cont]);
                    cont++;
                }
                llenaIteradores();
                llenaLista();
            }
            cont = 0;
            flagAdd = true;
        }//end Agregar cancion

        private void PBPlay_Click(object sender, EventArgs e)
        {
            if (flagAdd == true) {
                if (cont2 != 0)
                {
                    switch (Flagplay)
                    {
                        case true:
                            playCancion();
                            break;
                        case false:
                            pausaCancion();
                            break;
                    }
                }
                else {
                    Sigue();
                    pausaCancion(); 
                    
                }
                
            }
            

        }//end btPlay

        private void PBanterior_Click(object sender, EventArgs e)
        {
            if (flagAdd == true) {
                actual = iterador.atras();
                if (actual != null)
                {
                    Reproductor.URL = actual.Direccion;
                    LbCancion.Text = actual.Cancion;
                    pausaCancion();
                }
            }
        }

        private void PBDelete_Click(object sender, EventArgs e)
        {
            if (flagAdd == true) {
                playCancion();
                listaCanciones.eliminar(actual.Cancion);
                circular.eliminar(actual.Cancion);
                llenaIteradores();
                llenaLista();
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (flagAdd == true) {
                if (flagCircular == true) {
                    if (contCircular != 2)
                    {
                        actualCircular = iteradorCircular.siguiente();
                        circularRepetir = actualCircular;
                    }
                    else {
                        actualCircular = circularRepetir;
                    }
                    Reproductor.URL = actualCircular.DireccionC;
                    LbCancion.Text = actualCircular.Cancion;


                }
                else
                {
                    Sigue();
                }
                pausaCancion();

            }
            
        }//end siguiente

        //METODOS QUE SE REPITEN VARIAS VECES 
        public void llenaLista() {
            lstCanciones.Items.Clear();
            string[] cancion = listaCanciones.devuelveCanciones();
            foreach (string songs in cancion)
            {
                lstCanciones.Items.Add(songs);
            }
        }
        public void Sigue()
        {
            actual = iterador.siguiente();
            if (actual != null)
            {
                cont2++;
                Reproductor.URL = actual.Direccion;
                LbCancion.Text = actual.Cancion;
            }

        }//end Ant

        private void Reproductor_StatusChange(object sender, EventArgs e)
        {

        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            actualizarDatosTrack();
        }

        private void MtBduracion_ValueChanged(object sender, decimal value)
        {
            Reproductor.Ctlcontrols.currentPosition = MtBduracion.Value;
        }

        private void MtBVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = MtBVolumen.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizarDatosTrack();
            MtBduracion.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            MtBVolumen.Value = (int)Reproductor.settings.volume;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flagCircular == false)
            {
                    lbCircular.Text = "Activado";
                    flagCircular = true;
                    contCircular = 1;
            }
            else {
                if (contCircular == 1) { lbCircular.Text = "Rep. canción"; contCircular = 2; }
                else { lbCircular.Text = "Desactivado"; flagCircular = false; } 
            }
        }//end Repetición

        private void lbCircular_Click(object sender, EventArgs e)
        {

        }

        public void ReproduceYcambiaNombre(string direcc, string canc) { 

        }
        private void playCancion()
        {
            PBPlay.Image = Properties.Resources.play;
            Reproductor.Ctlcontrols.pause();
            Flagplay = false;
        }//end PlayCancion
        private void pausaCancion()
        {
            PBPlay.Image = Properties.Resources.pause;
            Reproductor.Ctlcontrols.play();
            Flagplay = true;
        }//end pausaCancion
        public void llenaIteradores() {
            iterador = new ClsIterator(listaCanciones);
            iteradorCircular = new LCiterador(circular);
        }
        public void actualizarDatosTrack()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MtBduracion.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                MtBduracion.Value = 0;
            }
        }//end actualizaDatosTrack

    }
}
