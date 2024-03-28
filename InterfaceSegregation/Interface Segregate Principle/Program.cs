using Interface_Segregate_Principle.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Amazon amazon = new Amazon();

        amazon.GetFile("AmazonFile.txt");
        amazon.StoreFile("s-AmazonFile.txt");
        amazon.CreateServer("Tashkent");
        amazon.ListServers("Bukhara");
        amazon.GetDCNAddress();

        Console.WriteLine("------------------------");

        Dropbox dropbox = new Dropbox();

        dropbox.GetFile("DropFile.txt");
        dropbox.StoreFile("s-DropFile.txt");
    }
}