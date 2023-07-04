using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.List
{

    public class StudentListData : ListData<Student>
    {
        public override List<Student> GetPeople()
        {
            return new List<Student>
        {
            new Student { ID = 1, Name = "John", Age = 20 , Image = LoadImage("297306.jpg")},
            // ... add more students here
        };
        }
    }
}
