using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_Gluhovskiy.Models
{
    public class Genre
    {
        public int GenreID { get; set; }

        [Display(Name = "Жанр")]
        [MaxLength(100)]
        public string GenreName { get; set; }

        [Display(Name = "Ссылка информацию о жанре")]
        [DataType(DataType.MultilineText)]
        public string GenreDescription { get; set; }
    }
}
