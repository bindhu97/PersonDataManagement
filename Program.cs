using System;
using System.Buffers;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { SSN = 1, Name = "Bindhu", Address = "Bangalore", Age = 30 });
            people.Add(new Person() { SSN = 2, Name = "Sunil", Address = "Bangalore", Age = 75});
            people.Add(new Person() { SSN = 3, Name = "Rekha", Address = "Bangalore", Age = 40 });
            people.Add(new Person() { SSN = 4, Name = "Parnika", Address = "Bangalore", Age = 3});
            people.Add(new Person() { SSN = 5, Name = "Meena", Address = "Bangalore", Age = 19});
            foreach (Person person in people)
            {
                Console.WriteLine("SSN={0}\tName={1}\tAddress={2}\tAge={3})", person.SSN, person.Name, person.Address, person.Age);
            }

            Operations operations = new Operations();
            //operations.RetreiveTopRecordsOfAge(people);
            //operations.RetreiveAllRecordsOfAge(people);
            operations.AverageAge(people);
        }
    }
}