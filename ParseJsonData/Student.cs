using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ParseJsonData
{
    class Student
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Hobbies { get; set; }

        // methods (override)
        public override string ToString()
        {
            return string.Format("Student Information:\nId: {0}, \nName: {1}, \nDegree {2}" + "\nHobbies: \n{3}", Id, Name, Degree,string.Join(",\n", Hobbies.ToArray()));
        }

    }
}
