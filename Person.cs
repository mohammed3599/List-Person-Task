using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Person_Task
{
    internal class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gander { get; set; }
        public int Age { get; set; }


        public Person(int Id, string Name, string Gander, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gander = Gander;
            this.Age = Age;
        }

        public int CompareTo(Person? other)
        {
            if (other == null)
            {
                return 1;
            }
            if (other.Age == this.Age)
            {
                return 0;
            }
            if (other.Age > this.Age)
            {
                return -1;
            }
            return 1;

        }
    }
}
