using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Person
    {
        private string name;//field

        public string Name//property
        {
            get{return name;} //read
            set{ //write
                if(string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be null or empty");
                name  = value;
            }
        }

        public string NameAge{get;set;}

        public int Age { get; set;}
    }

    
}

// Person john = new();
// john.Name = "John";
// Console.WriteLine(john.Name);

// Person p = new Person
// {
//     NameAge = "Gaius",
//     Age = 80,
// };
// Console.WriteLine(p.NameAge);
// Console.WriteLine(p.Age);
