using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace Boolood.Tests
{
    public class MockFile
    {
        public static IFormFile MakeFormFile(string path, string fileName)
        {
            var sourceImg = File.OpenRead(Path.Combine(path, fileName));
            var file = new FormFile(sourceImg, 0, sourceImg.Length, null, fileName)
            {
                Headers = new HeaderDictionary(),
                ContentType = GetContentType(fileName)
            };
            return file;
        }

        public static string GetContentType(string fileName)
        {
            switch (Path.GetExtension(fileName))
            {
                case ".jpg": return "image/jpeg";
                case ".png": return "image/png";
                case ".gif": return "image/gif";
            }
            return "image/jpeg";
        }
    }
}
