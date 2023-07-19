namespace List_Person_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            Console.WriteLine($"Size of the list is {list.Count}");
            list.Add(2);
            Console.WriteLine($"Size of the list is {list.Count}");
            list.Remove(1);
            Console.WriteLine($"Size of the list is {list.Count}");
            list.Insert(0, 5);
            Console.WriteLine($"Size of the list is {list.Count}");
            Console.WriteLine(list[0]);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("========================");

            List<Person> personList = new List<Person>();
            personList.Add(new Person(1122, "Mohammed", "Male", 32));
            personList.Add(new Person(1133, "Ahmed", "Male", 20));
            personList.Add(new Person(1144, "Anood", "Female", 25));
            foreach (Person person in personList)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Gander: {person.Gander}, Age:  {person.Age}");
                Console.WriteLine("--------------------------");
            }

            List<int> numberList = new List<int>();
            numberList.Add(2);
            numberList.Add(1);
            numberList.Add(5);
            numberList.Add(4);
            numberList.Add(6);
            numberList.Add(3);

            Console.WriteLine("========================");
            numberList.Sort(); // To Arrangement the number
            foreach (int i in numberList)
            {
                Console.WriteLine("Sort: " + i);
            }

            Console.WriteLine("========================");
            numberList.Sort(); // To Arrangement the number
            numberList.Reverse(); // To write reverse number (A large number to a small number)
            foreach (int i in numberList)
            {
                Console.WriteLine("Reverse: " + i);
            }

            Console.WriteLine("========================");
            personList.Sort();
            Console.WriteLine("The name of the youngest name to oldest name:");
            foreach (Person person in personList)
            {
                Console.WriteLine(person.Name);
            }

            //Console.WriteLine();
            //Console.WriteLine("========================");

        }
    }
}