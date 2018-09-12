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
        public string GenreName { get; set; }

        [Display(Name = "Ссылка информацию о жанре")]
        [DataType(DataType.Text)]
        public string GenreDescription { get; set; }
    }
}
