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
                mediaInfo.Open(path);
                model.Titulo = mediaInfo.Option("Title");
                model.Album = "";
                model.Artista = "Los Prisioneros";
                model.Genero = "Rock";
                model.Compositor = "Jorge Gonzalez";
                model.Duracion = "";
                model.Ubicacion = path;
                using(ModelContext db = new ModelContext())
                {
                    db.Canciones.Add(model);
                    db.SaveChanges();
                }
            } catch (FileNotFoundException) { }
        }

        public static List<Cancion> GetList()
        {
            ModelContext db = new ModelContext();
            return db.Canciones.ToList();
        }
    }
}
