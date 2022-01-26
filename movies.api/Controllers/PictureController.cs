using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zyxenmovies.Domain.entities;
using Zyxenmovies.Infraestructure.Repository;

namespace movies.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PictureController : ControllerBase
    {
        [HttpGet]
        [Route("Obtenertodos")]

        public IActionResult obtener()
        {
            PictureSqlRepository cine = new PictureSqlRepository();
            return Ok (cine.ObtenerPelis());
        }  

          [HttpGet]
          [Route("PorID")]

        public IActionResult buscarId(int id)
        {
            PictureSqlRepository cine2 = new PictureSqlRepository();
            var cine = cine2.ForID(id);
            if (cine == null)
            {
                return NotFound($"No existe");
            }
            return Ok (cine);
        }  

         [HttpPost]
          [Route("Crearpelicula")]

        public IActionResult CrearPelicula (Picture nuevapeli)
        {
            PictureSqlRepository cine3 = new PictureSqlRepository();
            cine3.CrearPicture(nuevapeli);
            return CreatedAtAction(nameof(CrearPelicula), nuevapeli);
           
        }  

         [HttpPut]
          [Route("ActualizarPelicula")]

        public IActionResult ActualizarPeli ( int id, Picture actualizarPeli )
        {
           PictureSqlRepository cine4 = new PictureSqlRepository();
           var excepcion = cine4.ForID(id);
           if (excepcion == null)
           {
               return NotFound($"No existe el id ingresado");
           }
           cine4.ActualizarPeli(id, actualizarPeli);
           return Ok ("Pelicula Actualizada Correctamente");
           
        }  

           [HttpDelete]
          [Route("BorrarPelicula")]

        public IActionResult BorrarPeli ( int id )
        {
           PictureSqlRepository cine5 = new PictureSqlRepository();
           var excepcion = cine5.ForID(id);
           if (excepcion == null)
           {
               return NotFound($"No existe el id ingresado");
           }
           cine5.BorrarPeli(id);
           return Ok ("La pelicula se ha borrado exitosamente");
           
        }  


         [HttpGet]


        [Route("ForDirector")]
        public IActionResult ForDirector (string NombreProducer)
        {
            PictureSqlRepository cine6 = new PictureSqlRepository();

            var respuesta = cine6.ForDirector(NombreProducer);

            if (respuesta.Count() == 0)

            {

                return NotFound($"El director no existe");

            }

            return Ok (respuesta);

        }






      
        

    }

    

  
}