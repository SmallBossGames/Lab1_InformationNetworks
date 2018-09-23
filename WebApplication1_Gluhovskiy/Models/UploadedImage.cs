using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_Gluhovskiy.Models
{
    public class UploadedImage
    {
        [Required]
        [Display(Name = "Заголовок")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Загружаемое изображение")]
        public IFormFile UploadedFile { get; set; }
    }
}
