using musicAPP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicAPP
{
    public partial class MusicApp : Form
    {
        public MusicApp()
        {
            InitializeComponent();
        }

        /* Abrir buscador de archivos */
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de Audio|*.wav;*.mp3;*.alac;*.ALAC;*.WAV;*.AAC;*.MP3;"; // Valida tipo de archivo
            ofd.ShowDialog();
            CancionController.SaveFile(ofd.FileName);
        }
    }
}
