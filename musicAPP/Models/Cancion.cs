using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicAPP.Models
{
    public class Cancion
    {
        public int CancionId { get; set; }
        public String Titulo { get; set; }
        public String Album { get; set; }
        public String Artista { get; set; }
        public String Genero { get; set; }
        public String Compositor { get; set; }
        public String Duracion { get; set; }
        public String Ubicacion { get; set; }

    }
}
