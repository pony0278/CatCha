using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CatCaha.List
{
    public class TeacherListData : ListData<Teacher>
    {
        public override List<Teacher> GetPeople()
        {
            return new List<Teacher>
        {
            new Teacher { ID = 1, Name = "JohnT", Age = 20 , Image = LoadImage("123.jpg")},
            new Teacher { ID = 1, Name = "JoT", Age = 20 , Image = LoadImage("123.jpg")},
            new Teacher { ID = 2, Name = "JaeT", Age = 22 , Image = LoadImage("123.jpg")},
        };
        }
        public List<Teacher> GetTeachersOlderThan20()
        {
            return GetPeople().Where(t => t.Age > 20).ToList();
        }

    }
}
