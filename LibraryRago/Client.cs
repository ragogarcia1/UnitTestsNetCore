using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRago
{
    public interface IClient
    {
        int discount  { get; set; }
        string nameClient { get; set; }
        int orderTotal { get; set; }
        bool isPremium { get; set; }
        string NameComplete(string firstName, string lastName);


    }
    public class Client : IClient
    {
        public int discount { get; set; }
        public string nameClient { get; set; }
        public int orderTotal { get; set; }
        public bool isPremium { get; set; }
        public Client()
        {
            isPremium = false;
            discount = 10;
        }

        public string NameComplete(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("The firstName is empty");
            }

            discount = 30;
            nameClient = $"{firstName} {lastName}";
            return nameClient;
        }
    }
}
