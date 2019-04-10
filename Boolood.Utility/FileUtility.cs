using Microsoft.AspNetCore.Http;
using System.IO;
using System.Reflection;

namespace Boolood.Utility
{
    public class FileUtility
    {
        public static void SaveFileForm(IFormFile file, string fileFullPath)
        {
            if (file.Length > 0)
            {
                using (FileStream stream = new FileStream(fileFullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
        }

        public static bool IsFileExist(string fileFullPath)
        {
            return File.Exists(fileFullPath);
        }

        public static void DeleteFile(string fileFullPath)
        {
            if (!File.Exists(fileFullPath))
            {
                return;
            }

            File.Delete(fileFullPath);
        }

        public static bool IsDirectoryExist(string path)
        {
            return Directory.Exists(path);
        }

        public static void CreateDirectory(string path)
        {
            if (IsDirectoryExist(path))
            {
                return;
            }

            Directory.CreateDirectory(path);
        }

        //public static string GetWebRootPath()
        //{
        //    return 
        //        Path.GetDirectoryName(
        //            Assembly.GetExecutingAssembly().Location
        //            ) + "/wwwroot";
        //}
    }
}


