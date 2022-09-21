using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    public class GeneratedObject
    {
        public string pathfile { get; set; }
        
        
        public List<Person> list = new List<Person>();
        Random random = new Random();

        public void RunJson()
        {
            int i = 0;
            while (i< 10000)
            {
                var res = new Person()
                {
                    Id = i,
                    TransportId = Guid.NewGuid(),
                    FirstName = "Ad" + (char)(65 + i),
                    LastName = "Va" + (char)(65 + i),
                    IsMarred = true,
                    Age = 34,
                    BirthDate = 463785456L + i,
                    CreditCardNumbers = new string[] { "45", "65" },
                    SequenceId = 1,
                    Children = new Child[] { new Child() { Id = i, FirstName = "Str" + (char)(65 + i), LastName = "Petrov" + (char)(65 + i), BirthDate = i + 63785456L, Gender = Gender.Male } },
                    Gender = Gender.Male,
                    Phones = new string[] { "+7" + (char)50 + (char)51 + (char)52 + (char)53 + (char)(54 + i) + (char)55 + (char)56 + (char)57 },
                    Salary = 50000.0 + i
                


                };
                list.Add(res);
                i++;
            }


            string jsonString = JsonSerializer.Serialize<List<Person>>(list);
            System.IO.File.WriteAllText(@pathfile, jsonString);


        }
        public string ReadJsonFile()
        {
            using(FileStream fs = new FileStream(pathfile,FileMode.Open))
            {
                list = JsonSerializer.Deserialize<List<Person>>(fs);
            }
            return "";
        }



    }
}
