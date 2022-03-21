namespace Mirehub.api.Services
{
    public interface IStorageService
    {
        void Upload(IFormFile formFile, string idEvent);
    }
}