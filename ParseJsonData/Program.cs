using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace ParseJsonData
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student()
            {
                Id = 1,
                Name = "Balaji",
                Degree = "MCA",
                Hobbies = new List<string>
                {
                    "Reading",
                    "Playing Games"
                }
            };

            // Take the info from sth student classs above and write them to a Json string (Serilaization)
            string strResultJson = JsonConvert.SerializeObject(student);
            //Console.WriteLine(strResultJson);
            File.WriteAllText(@"student.json", strResultJson);
            //Console.WriteLine("storaged");

            // present the above json string to a format close to the above object student (deserialize)
            strResultJson = File.ReadAllText("student.json");
            Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            Console.WriteLine(resultStudent.ToString());

            Console.WriteLine("\n\n");
            // Second way to present the jason data to dictionary format ...

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);

            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }

            Console.WriteLine();
        }
    }
}
