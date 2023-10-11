using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpermListTest1.Model;
using SpermListTest1.Services.fileServices;

namespace SpermListTest1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }


        
        [HttpPost]
        public IActionResult PostFile([FromForm] FileUploadModel filedetail)
        {
            _fileService.UploadFile(filedetail.FileDetails, "pdf");
            return Ok();
        }
        [HttpGet]
        public IActionResult DownloadFile(int Id)
        {
            _fileService.DownloadFileById(Id);
            return Ok();
        }
    }
}
