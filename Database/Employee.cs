using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Employee
    {
        public ObjectId Id { get; set; }

        public string Name { get; private set; }

        public string Title { get;private set; }

        public string Image { get; private set; }

        public string Description { get; private set; } 

        public Employee(string name, string title ,string image, string description) {
            Name = name;
            Title = title;
            Image = image;
            Description = description;
        
        } 
    }
}
