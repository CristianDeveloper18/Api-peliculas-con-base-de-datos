using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Zyxenmovies.Domain.entities;



namespace Zyxenmovies.Infraestructure.Repository
{
    public class PictureRepository
    {
        public static List<Picture> _picture = new List<Picture>();

        public IEnumerable<Picture> ObtenerPelis()
        {
            return _picture;
        }

        public Picture ForID (int id)
        {
            var pictures = _picture.Where(m => m.IdPicture == id);
            return pictures.FirstOrDefault();
        }

        public void CrearPelicula (Picture nuevapeli)
        {
            _picture.Add(nuevapeli);
        }

       /* public void ActualizarPeli (int id, Picture actualizarPeli)
        {
            if (id < 1 || actualizarPeli == null)
            {
               throw new ArgumentException("informacion Incompleta");
            }
           var entidad = ForID(id);
           entidad.titlePicture = actualizarPeli.titlePicture;
           entidad.directorPicture = actualizarPeli.directorPicture;
           entidad.generoPicture = actualizarPeli.generoPicture;
           entidad.puntuacionMovie = actualizarPeli.puntuacionMovie;
           entidad.ratingPicture = actualizarPeli.ratingPicture;
           entidad.publicacionPicture = actualizarPeli.publicacionPicture;
           _picture.Remove(entidad);
           _picture.Add(entidad);
        }*/

        public void BorrarPeli (int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Informacion incompleta");
            }
            var respuesta = ForID(id);
            _picture.Remove(respuesta);
        }

        
        /* public IEnumerable<Picture> ForDirector(string NombreProducer)

        {
            var respuesta = _picture.Where(m=> m.directorPicture == NombreProducer);

            return respuesta;
        }
        */

    }
}