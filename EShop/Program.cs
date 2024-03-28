//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using EShop.Models;
using EShop.Services.CredentialService;
using EShop.Services.Order;
using EShop.Services.ShippingService;
using EShop.Services.Storage;

namespace EShop
{
    public class Program
    {

        static IList<IShippingService> shippings = new List<IShippingService> { new Sea(), new Air(), new Ground() };
        static IProductService productService = new ProductService();
        static ICredentialService credentialService = new CredentialService();
        static OrderService OrderService;

        public static void Main(string[] args)
        {

           Console.WriteLine("------ Welcome to Eshop shopping app------");
            Console.WriteLine("You are required login this platform");
            bool  isLogged = false;

            do
            {
                Console.WriteLine("Do you have any Account? Yes(y) / No(n)");
                char option= Console.ReadKey().KeyChar;
                if (option=='n')
                {
                    Console.WriteLine("Please Enter your credentials");
                    Console.Write("Login: ");
                    string newLogin = Console.ReadLine();
                    Console.Write("Password: ");
                    string newPassword = Console.ReadLine();
                    var credential = credentialService.AddCredentialAndLogin(new Credential { Username = newLogin, Password = newPassword });
                    if (credential is Credential)
                    {
                        isLogged = true;
                        break;
                    }
                }
                Console.WriteLine("Please Enter your credentials");
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                isLogged = credentialService.CheckUserLogin(new Credential{Username=login,Password=password});
                if (!isLogged)
                {
                    Console.WriteLine("Invalid login or password");
                }
            } while (!isLogged);

            Console.Clear();    
            Console.WriteLine("Successfully Logged In");
            productService.PrintAllProducts();
            Console.Write("Select product: ");
            int product=int.Parse(Console.ReadLine());
            Console.Clear();
            PrintShippingTypes();
            int shippingType = int.Parse(Console.ReadLine());
            OrderService= new OrderService(new List<Product>() { productService.GetProductByIndex(product) });
            OrderService.SetShippingType(shippings[shippingType]);

            PrintOrderDetails(OrderService);
            Console.WriteLine("-----------------end-of-program----------------------");

        }

        static void PrintProduct()
        {
            Console.WriteLine("0) Order create");
            Console.WriteLine("-------Start-of-product-------------");
            int index = 1;
            Console.WriteLine("-----------End-of-product-----------");

        }

        static void PrintShippingTypes()
        {
            Console.WriteLine("-------Start-of-shipping-------------");
            int index = 0;
            foreach (var item in shippings)
            {
                Console.WriteLine($"{index++}) {item.GetType().Name}");
            }
            Console.WriteLine("-----------End-of-shipping-----------");

        }

        static void PrintOrderDetails(OrderService order)
        {
            Console.WriteLine($"Shipping cost: ${order.GetShippingCost()}");
            Console.WriteLine($"Shipping weight: ${order.GetTotalWeight()}");
            Console.WriteLine($"Shipping date: ${order.GetShippingDate()}");
        }
    }
}
