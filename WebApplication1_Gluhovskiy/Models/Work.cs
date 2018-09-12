using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_Gluhovskiy.Models
{
    public class Work
    {
        public int ID { get; set; }

        [Display(Name ="Название")]
        public string Title { get; set; }

        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "ID жанра")]
        public int GenreID { get; set; }

        [Display(Name = "ID серии")]
        public int SeriesID { get; set; }

        [Display(Name = "Описание")]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}
