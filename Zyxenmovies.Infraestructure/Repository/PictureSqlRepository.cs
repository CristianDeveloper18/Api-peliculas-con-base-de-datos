using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Zyxenmovies.Domain.entities;
using Zyxenmovies.Infraestructure.Data;

namespace Zyxenmovies.Infraestructure.Repository
{
    public class PictureSqlRepository
    {
        private readonly ApiPeliculasContext _context;
        public PictureSqlRepository()
        {
            _context = new ApiPeliculasContext();

            
        }

         public IEnumerable<Picture> ObtenerPelis()
        {
            return _context.Pictures;
        }

        public Picture ForID (int id)
        {
            var pictures = _context.Pictures.Where(m => m.IdPicture == id);
            return pictures.FirstOrDefault();
        }

        public void CrearPicture (Picture nuevaPicture)
        {
            var identidad = nuevaPicture;
            _context.Pictures.Add(identidad);
            var row = _context.SaveChanges();
            if(row <= 0)
            throw new Exception("Pelicula sin registrar");
            return;
        }

            public void ActualizarPeli (int id, Picture actualizarPeli)
        {
            if (id < 1 || actualizarPeli == null)
            {
               throw new ArgumentException("informacion Incompleta");
            }
           var entidad = ForID(id);
           entidad.TitlePicture = actualizarPeli.TitlePicture;
           entidad.DirectorPicture = actualizarPeli.DirectorPicture;
           entidad.GenrePicture = actualizarPeli.GenrePicture;
           entidad.PuntuationPicture = actualizarPeli.PuntuationPicture;
           entidad.RatingPicture = actualizarPeli.RatingPicture;
           entidad.PuntuationPicture = actualizarPeli.PuntuationPicture;
           _context.Update(entidad);
           var row =_context.SaveChanges();
           return;
        }

        public void BorrarPeli(int id)
        {
          if(id <= 0)
          {
              throw  new ArgumentException("No existe la pelicula en la base de datos");
          }
          var entidad = ForID(id);
          _context.Remove(entidad);
          var row = _context.SaveChanges();
          return; 
          

        }

          public IEnumerable<Picture> ForDirector(string NombreProducer)

        {
            var respuesta = _context.Pictures.Where(m=> m.DirectorPicture == NombreProducer);
            return respuesta;
        }
        

        
    }
}