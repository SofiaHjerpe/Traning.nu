using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Contact
    {
        public ObjectId Id { get; set; }

        public string Email { get; set; }

        public string Namn { get; set; }

        public Contact() {
        
        }

        public Contact(string email, string namn) {
            Email= email;
            Namn = namn;
            
        
        }
        public override string ToString()
        {
            return $"{Email}{Namn}";
        }

    }
}
