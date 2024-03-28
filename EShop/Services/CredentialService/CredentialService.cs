//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Brokers.Loggings;
using EShop.Brokers.StorageBrokers.FileBroker;
using EShop.Models;

namespace EShop.Services.CredentialService
{
    public class CredentialService : ICredentialService
    {
        private readonly IFileStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public CredentialService()
        {
            storageBroker = new FileStorageBroker();
            loggingBroker = new LoggingBroker();
        }

        public Credential AddCredentialAndLogin(Credential credential)
        {
            return credential is null
                ? CreateAndLogInvalidCredential()
                : ValidateAndAddCredential(credential);
        }
        public bool CheckUserLogin(Credential credential)
        {
            foreach (Credential credentialItem in storageBroker.GetAll())
            {
                if (credential.Username == credentialItem.Username &&
                    credential.Password == credentialItem.Password)
                {
                    return true;
                }
            }

            return false;
        }

        public List<Credential> GetAllCredentials()
        {
            if (storageBroker.GetAll().Count == 0)
            {
                return new List<Credential>();
            }

            return storageBroker.GetAll();
        }

        private Credential CreateAndLogInvalidCredential()
        {
            loggingBroker.LogError("Contact is invalid");

            return new Credential();
        }

        private Credential ValidateAndAddCredential(Credential credential)
        {
            if (string.IsNullOrWhiteSpace(credential.Username)
                || string.IsNullOrWhiteSpace(credential.Password))
            {
                loggingBroker.LogError("Contact details missing.");

                return new Credential();
            }
            else
            {
                return storageBroker.Add(credential);
            }
        }
    }
}