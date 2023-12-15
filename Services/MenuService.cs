using Adressbok.Interfaces;

namespace Adressbok.Services
{

    

    public class MenuService : IMenuService
    {
        public void QuitApplication()
        {
            throw new NotImplementedException();
        }

        public void ShowMainMenu()
        {
            ContactService contactService = new ContactService();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("## Min Adressbok ##");
                Console.WriteLine("1. Lägg till kontakt");
                Console.WriteLine("2. Visa alla kontakter");
                Console.WriteLine("3. Visa enskild kontakt");
                Console.WriteLine("4. Uppdatera kontakt");
                Console.WriteLine("5. Radera kontakt");
                Console.WriteLine("0. Avsluta programmet");
                Console.WriteLine();
                Console.Write("Ditt val: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        contactService.AddContact();
                        break;
                    case "2":
                        contactService.ShowAllContacts();
                        break;
                    case "3":
                        contactService.ShowContact();
                        break;
                    case "4":
                        contactService.UpdateContact();
                        break;
                    case "5":
                        contactService.DeleteContact();
                        break;
                    case "0":
                        QuitApplication();
                        break; 
                }



            }
        }
    }
}
