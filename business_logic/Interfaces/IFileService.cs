using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    internal interface IFileService
    {
        Task<string> SaveVideo(IFormFile file);
        Task<string> SaveImage(IFormFile file);
        Task DeleteVideo(string path);
    }
}
