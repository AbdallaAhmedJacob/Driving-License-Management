using System;
using System.IO;

namespace DVLD_Business.Helpers
{
    internal class clsImageHelper
    {
        private static string _PeoleImagesPathFolder = @"D:\DVLD.Images\Peolple";

        public static string SavePersonImage(string sourceFilePath)
        {
            // Validation

            string extension = Path.GetExtension(sourceFilePath);

            if(!Directory.Exists(_PeoleImagesPathFolder)) 
                Directory.CreateDirectory(_PeoleImagesPathFolder);

            string newFileName = Guid.NewGuid().ToString() + extension;
            string destinationPath = Path.Combine(_PeoleImagesPathFolder, newFileName);

            File.Copy(sourceFilePath, destinationPath);

            return destinationPath;
        }
    }
}
