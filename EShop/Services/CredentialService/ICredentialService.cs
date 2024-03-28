//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Models;

namespace EShop.Services.CredentialService
{
    public interface ICredentialService
    {
        Credential AddCredentialAndLogin(Credential credential);
        bool CheckUserLogin(Credential credential);
    }
}