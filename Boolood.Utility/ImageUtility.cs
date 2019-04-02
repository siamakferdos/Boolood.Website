using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.AspNetCore.Http;

namespace Boolood.Utility
{
    public class ImageUtility
    {
        public static int GetImageWidth(IFormFile file)
        {
            using (var image = Image.FromStream(file.OpenReadStream()))
            {
                return image.Width;
            }
        }
        public static int GetImageHeight(IFormFile file)
        {
            using (var image = Image.FromStream(file.OpenReadStream()))
            {
                return image.Width;
            }
        }
        public static float GetImageRaito(IFormFile file)
        {
            using (var image = Image.FromStream(file.OpenReadStream()))
            {
                return (image.Width * 1.0F) / (image.Height * 1.0F);
            }
        }
    }
}
