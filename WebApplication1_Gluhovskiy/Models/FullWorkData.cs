using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_Gluhovskiy.Models
{
    public class FullWorkData
    {
        [Display(Name = "Название")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр")]
        [MaxLength(100)]
        public string GenreName { get; set; }

        [Display(Name = "Ссылка информацию о жанре")]
        [DataType(DataType.MultilineText)]
        public string GenreDescription { get; set; }

        [Display(Name = "Название книжной серии")]
        [MaxLength(100)]
        public string SeriesName { get; set; }

        [Display(Name = "Описание произведения")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
