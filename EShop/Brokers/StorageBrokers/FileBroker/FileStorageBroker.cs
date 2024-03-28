//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Brokers.Storages;
using EShop.Models;

namespace EShop.Brokers.StorageBrokers.FileBroker
{
    public class FileStorageBroker : IFileStorageBroker
    {
        private const string FilePath = "../../../Assets/Credentials.txt";

        public FileStorageBroker()
        {
            EnsureFileExists();
        }

        public List<Credential> GetAll()
        {
            List<Credential> credentials = new List<Credential>();
            string[] credentialLines = File.ReadAllLines(FilePath);

            foreach (string credentialLine in credentialLines)
            {
                string[] credentialProperties = credentialLine.Split('*');

                credentials.Add(new Credential()
                {
                    Username = credentialProperties[0],
                    Password = credentialProperties[1]
                });
            }

            return credentials;
        }

        public Credential Add(Credential credential)
        {
            string credentialLine = $"{credential.Username}*{credential.Password}\n";
            File.AppendAllText(FilePath, credentialLine);

            return credential;
        }

        private void EnsureFileExists()
        {
            bool fileExists = File.Exists(FilePath);

            if (fileExists is false)
            {
                File.Create(FilePath).Close();
            }
        }
    }
}