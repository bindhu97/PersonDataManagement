using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operations
    {
        public void RetreiveTopRecordsOfAge(List<Person> person)
        {
            var data = person.Where(x => x.Age < 60).ToList().Take(2);
            foreach (var result in data) 
            {
                Console.WriteLine(result.SSN);
            }
        }
        public void RetreiveAllRecordsOfAge(List<Person> person)
        {
            var data = person.Where(x => x.Age > 13 && x.Age < 18).ToList();
            foreach (var result in data)
            {
                Console.WriteLine(result.SSN);
            }
        }
    }
}
