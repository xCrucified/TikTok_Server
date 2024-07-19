using business_logic.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace business_logic.Services;

public class FileService: IFileService
{
    private const string imageFolder = "images";
    private const string videoFolder = "videos";
    private readonly IWebHostEnvironment environment;
    public FileService(IWebHostEnvironment environment)
    {
        this.environment = environment;
    }

    public async Task<string> SaveImage(IFormFile file)
    {
        string root = environment.WebRootPath;
        string name = Guid.NewGuid().ToString();
        string extension = Path.GetExtension(file.FileName);
        string fullName = name + extension;

        string imagePath = Path.Combine(imageFolder, fullName);
        string imageFullPath = Path.Combine(root, imagePath);

        using (FileStream fs = new FileStream(imageFullPath, FileMode.Create))
        {
            await file.CopyToAsync(fs);
        }

        return Path.DirectorySeparatorChar + imagePath;
    }

    public async Task<string> SaveVideo(IFormFile file)
    {
        string root = environment.WebRootPath;
        string name = Guid.NewGuid().ToString();
        string extension = Path.GetExtension(file.FileName);
        string fullName = name + extension;

        string videoPath = Path.Combine(videoFolder, fullName);
        string videoFullPath = Path.Combine(root, videoPath);

        using (FileStream fs = new FileStream(videoFullPath, FileMode.Create))
        {
            await file.CopyToAsync(fs);
        }
        return Path.DirectorySeparatorChar + videoPath;
    }

    public Task DeleteVideo(string path)
    {
        //TODO: delete
        throw new NotImplementedException();
    }
}