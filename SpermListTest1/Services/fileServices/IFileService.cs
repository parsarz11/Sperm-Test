using SpermListTest1.data.entites;

namespace SpermListTest1.Services.fileServices
{
    public interface IFileService
    {
        public void UploadFile(IFormFile FileData,string FileType);
        public void DownloadFileById(int FileId);
    }
}
