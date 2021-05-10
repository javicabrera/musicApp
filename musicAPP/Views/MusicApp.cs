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
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;

        }
    }
}
