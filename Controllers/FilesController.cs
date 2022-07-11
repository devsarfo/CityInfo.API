using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers;

[Route("api/files")]
[ApiController]
public class FilesController : Controller
{
    private readonly  FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;
    
    public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
    {
        _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider ?? 
            throw new ArgumentNullException(nameof(fileExtensionContentTypeProvider));
    }

    [HttpGet("{fileId}")]
    public IActionResult GetFile()
    {
        const string fileName = "resume.pdf";
        if (!System.IO.File.Exists(fileName))
        {
            return NotFound();
        }
        
        if(!_fileExtensionContentTypeProvider.TryGetContentType(fileName, out var contentType))
        {
            contentType = "application/octet-stream";
        }

        var bytes = System.IO.File.ReadAllBytes(fileName);
        var file = File(bytes, contentType, Path.GetFileName(fileName));

        return file;
    }
}