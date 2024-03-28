namespace Interface_Segregate_Principle.Services
{
    internal interface ICloudStorageProvider
    {
        void GetFile(string region);
        void StoreFile(string region);
    }
}