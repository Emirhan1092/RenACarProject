using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper
{
    public  interface IFileHelperService
    {

        string Upload(IFormFile file, string root);
        void Delete(string filepath);
        string Update(IFormFile file, string filePath, string root);
    }
}
