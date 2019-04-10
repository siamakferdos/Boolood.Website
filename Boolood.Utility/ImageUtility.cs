using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace Boolood.Utility
{
    public class ImageUtility
    {
        public static int GetImageWidth(IFormFile file)
        {
            using (Image image = Image.FromStream(file.OpenReadStream()))
            {
                return image.Width;
            }
        }
        public static int GetImageHeight(IFormFile file)
        {
            using (Image image = Image.FromStream(file.OpenReadStream()))
            {
                return image.Width;
            }
        }
        private static Object _imageRaitoLock = new Object();
        public static float GetImageRaito(IFormFile file)
        {
            lock (_imageRaitoLock)
            {
                using (Image image = Image.FromStream(file.OpenReadStream()))
                {
                    return (image.Width * 1.0F) / (image.Height * 1.0F);
                }
            }
        }
       
        public static List<string> GetBase64Images(string htmlBody)
        {
            List<string> images = new List<string>();
            string pattern = "(\"|\')data:image/([a-zA-Z]*);base64,([^\']*)(\"|\')";
            var headPattern = "(\"|\')data:image/([a-zA-Z]*);base64,|(\"|\')";
            Match match = Regex.Match(htmlBody, pattern, RegexOptions.IgnoreCase);
            while (match.Success)
            {
                var pureImage = match.Value.Replace(
                    Regex.Match(
                        match.Value,
                        headPattern,
                        RegexOptions.IgnoreCase).Value, "");
                pureImage = pureImage.Remove(pureImage.Length - 1);
                images.Add(pureImage);
                match = match.NextMatch();
            }
            return images;
        }

        public static int GetBase64ImageSize(string base64Image)
        {
            return Convert.FromBase64String(base64Image).Length;
        }

        public static string GetExtention(IFormFile img)
        {
            return Path.GetExtension(img.FileName);
        }

        
    }
}
