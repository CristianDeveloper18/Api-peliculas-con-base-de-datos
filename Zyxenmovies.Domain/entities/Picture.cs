using System;
using System.Collections.Generic;

#nullable disable

namespace Zyxenmovies.Domain.entities
{
    public partial class Picture
    {
        
        public int IdPicture { get; set; }
        public string TitlePicture { get; set; }
        public string DirectorPicture { get; set; }
        public string GenrePicture { get; set; }
        public int? RatingPicture { get; set; }
        public string PublicationPicture { get; set; }
        public int? PuntuationPicture { get; set; }
    }
}
