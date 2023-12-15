using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbok.Services
{
    public interface IContactService
    {
        public void AddContact();
        public void DeleteContact();
        public void UpdateContact();
        public void ShowAllContacts();
        public void ShowContact();
        
    }
    internal class ContactService : IContactService
    {
        public void AddContact()
        {
            throw new NotImplementedException();
        }

        public void DeleteContact()
        {
            throw new NotImplementedException();
        }

        public void ShowAllContacts()
        {
            throw new NotImplementedException();
        }

        public void ShowContact()
        {
            throw new NotImplementedException();
        }

        public void UpdateContact()
        {
            throw new NotImplementedException();
        }
    }
}
