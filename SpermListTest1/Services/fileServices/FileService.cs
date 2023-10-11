using Microsoft.Extensions.Caching.Memory;
using SpermListTest1.data;
using SpermListTest1.data.context;
using SpermListTest1.data.entites;

namespace SpermListTest1.Services.fileServices
{
    public class FileService : IFileService
    {
        private readonly IData _data;
        public FileService(IData data)
        {
            _data = data;
        }

        public void DownloadFileById(int FileId)
        {
            var fileList = _data.GetFileDetails();
            var filteredList = fileList.Where(x=> x.Id == FileId).FirstOrDefault();

            var Content = new System.IO.MemoryStream(filteredList.FileData);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles",
                filteredList.Name);
            
            using(var fileStream = new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                Content.CopyTo(fileStream);
            }
        }

        public void UploadFile(IFormFile FileData, string FileType)
        {
            var FileDetail = new fileDetails
            {
                Name = FileData.FileName,
                FileType = FileType,
            };

            using(var stream = new MemoryStream())
            {
                FileData.CopyTo(stream);
                FileDetail.FileData = stream.ToArray();
            }

            //return FileDetail;
            _data.AddfileData(FileDetail);
        }
    }
}
