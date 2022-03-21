namespace Mirehub.api.Services
{
    public class StorageService : IStorageService
    {
        private readonly IConfiguration _configuration;

        public StorageService(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Upload(IFormFile formFile, string idEvent)
        {
            string uploadsFolder = Path.Combine("Uploads", idEvent);
            Directory.CreateDirectory(uploadsFolder);

            if (formFile.Length > 0)
            {
                string filePath = Path.Combine(uploadsFolder, formFile.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    formFile.CopyTo(fileStream);
                }
            }
        }
    }
}
