using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicAPP.Models
{
    public class PlayList
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<Cancion> Lista { get; set; }
    }
}
