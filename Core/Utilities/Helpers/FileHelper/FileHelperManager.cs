﻿using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelperService
    {
        public void Delete(string filepath)
        {
            if(File.Exists(filepath))
            
            {

                File.Delete(filepath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            
            {
             File.Delete(filePath); 
            
            }
            return Upload(file,root);    
        }

        public string Upload(IFormFile file, string root)
        {
            if(file.Length > 0) 
            
            {
                if(!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                string extension = Path.GetExtension(file.FileName);

                string guid = GuidHelpers.GuidHelpers.CreatGuid();

                string filePath = guid + extension;

                using(FileStream fileStream = File.Create(root+filePath))
               {
                    file.CopyTo(fileStream);
                    fileStream.Flush();

                    return filePath;

                }
            
            
            }
            return null;

        }


           
    }
}


