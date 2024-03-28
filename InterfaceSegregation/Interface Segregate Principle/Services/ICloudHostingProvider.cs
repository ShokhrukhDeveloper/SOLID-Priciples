namespace Interface_Segregate_Principle.Services
{
    internal interface ICloudHostingProvider
    {
        void CreateServer(string region);
        void ListServers(string region);
    }
}