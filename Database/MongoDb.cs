using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class MongoDb
    {
        private IMongoDatabase GetDb()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("ContactDB");
            return db;  
        }


        public async Task SaveContact(Contact contact)
        {
            await GetDb().GetCollection<Contact>("Kontakter")
                .InsertOneAsync(contact);


        }

        public async Task<List<Contact>> GetContacts()
        {
            var contacts = await GetDb().GetCollection<Contact>("Kontakter")
                .Find(c => true).ToListAsync();

           
            return contacts;
        }

        public async Task SaveEmployee(Employee employee)
        {
            await GetDb().GetCollection<Employee>("Employees")
                .InsertOneAsync(employee);


        }

        public async Task<List<Employee>> GetEmployees()
        {
            
            var employees = await GetDb().GetCollection<Employee>("Employees")
                .Find(e => true).ToListAsync();
            return employees;
        }

        public async Task<Employee> GetWorkerById(string id)
        {
            ObjectId _id = new ObjectId(id);
            var employee = await GetDb().GetCollection<Employee>("employees")
                .Find(e => e.Id == _id)
                .SingleOrDefaultAsync();
            return employee;
        }




    }
}

