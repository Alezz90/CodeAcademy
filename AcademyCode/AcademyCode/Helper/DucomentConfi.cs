using Microsoft.AspNetCore.Routing.Constraints;
using System.Reflection;

namespace AcademyCode.Helper
{
    public static class DucomentConfi
    {
        public static string DocumentUplod(IFormFile formFile , string FileName)
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", FileName);
            //            string fileName =  $"{Guid.NewGuid()}{file.FileName}"; //unique

            string fileName =$"{Guid.NewGuid()}{formFile.FileName}";
            string path = Path.Combine(folderPath, fileName);
            var fs = new FileStream(path, FileMode.Create);
            formFile.CopyTo(fs);                                                
            return path;
        }
        public static void DocumentDelete(string filename,string Foldername) 
        {
          //  string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", FileName);
            if (filename != null)
            {

            }
        }
    }
}
