namespace Interface_Segregate_Principle.Services
{
    internal class Dropbox : ICloudStorageProvider
    {
        public void GetFile(string name)
        {
            Console.WriteLine("GetFile: Dropbox => " + name);
        }

        public void StoreFile(string name)
        {
            Console.WriteLine("StoreFile: Dropbox => " + name);
        }
    }
}