namespace Interface_Segregate_Principle.Services
{
    internal class Amazon : ICloudHostingProvider, ICDNProvider, ICloudStorageProvider
    {
        public void StoreFile(string name) =>
            Console.WriteLine("StoreFile: Amazon => " + name);

        public void GetFile(string name) =>
            Console.WriteLine("GetFile: Amazon => " + name);

        public void CreateServer(string region) =>
            Console.WriteLine("CreateServer: Amazon => " + region);

        public void ListServers(string region) =>
            Console.WriteLine("ListServers: Amazon => " + region);

        public void GetDCNAddress() =>
            Console.WriteLine("GetCDNA: Amazon");
    }
}