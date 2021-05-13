using MediaInfoLib;
using musicAPP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicAPP.Controllers
{
    public class CancionController
    {

        public static void SaveFile(string path)
        {
            Cancion model = new Cancion();

            try
            {
                var mediaInfo = new MediaInfo();
                model.Titulo = mediaInfo.Option("Title");
                model.Album = "";
                model.Ubicacion = path;
                using(ModelContext db = new ModelContext())
                {
                    db.Canciones.Add(model);
                    db.SaveChanges();
                }
            } catch (FileNotFoundException) { }
        }
    }
}
