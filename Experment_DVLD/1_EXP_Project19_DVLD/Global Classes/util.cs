using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXP_Project19_DVLD.Global_Classes
{
    internal class util
    {
        public static string GenerateGUID()
        {
            Guid newGuid = Guid.NewGuid();
            return newGuid.ToString();
        }

        public static bool GreateFolderIfDoesNotExist(string folderPath)
        {
            if(!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + folderPath, ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static string ReplaceFileNameWithGUID(string originalFilePath)
        {
            string fileName = originalFilePath;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;
        }

        public static bool CopyImageToProjectImageFolder( ref string originalFilePath)
        {
            string folderPath = @"C:\DVLD-People-Image\";
            if(!GreateFolderIfDoesNotExist(folderPath))
            {
                return false;
            }

            string fileExtension = folderPath + ReplaceFileNameWithGUID(originalFilePath);
            try
            {
                File.Copy(originalFilePath, folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying image to project folder: " + folderPath, ex.Message);
                return false;
            }
            originalFilePath = folderPath;
            return true;
        }
    }
}
