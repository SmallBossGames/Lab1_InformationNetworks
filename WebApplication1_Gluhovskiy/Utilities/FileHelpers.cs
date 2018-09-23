using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using WebApplication1_Gluhovskiy.Models;

namespace WebApplication1_Gluhovskiy.Utilities
{
    public class FileHelpers
    {
        public static async Task<string> TryProcessFormFile (IFormFile formFile, ModelStateDictionary modelStete, string directorty)
        {

            var fileName = WebUtility.HtmlEncode(Path.GetFileName(formFile.FileName));

            if (formFile.ContentType.ToLower() != "image/jpeg")
            {
                modelStete.AddModelError(
                    formFile.Name,
                    $"The file {fileName} must be a image!");
            }

            if (formFile.Length == 0)
            {
                modelStete.AddModelError(
                    formFile.Name,
                    $"The file {fileName} is empty!");
            }
            else if (formFile.Length > 2097152)
            {
                modelStete.AddModelError(
                    formFile.Name,
                    $"The file {fileName} exceeds 2 MiB!");
            }
            else
            {
                var filepath = Path.Combine(directorty, formFile.FileName);
                using (var filestream = new FileStream(filepath, FileMode.CreateNew))
                {
                    await formFile.CopyToAsync(filestream);
                }
                return filepath;
            }

            return string.Empty;
        }
    }
}
