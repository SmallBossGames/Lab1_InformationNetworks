using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_Gluhovskiy.Models
{
    public class Series
    {
        public int SeriesID { get; set; }

        [Display(Name = "Название книжной серии")]
        [MaxLength(100)]
        public string SeriesName { get; set; }

        [Display(Name = "Описание серии")]
        [DataType(DataType.MultilineText)]
        public string SeriesDescription { get; set; }
    }
}
