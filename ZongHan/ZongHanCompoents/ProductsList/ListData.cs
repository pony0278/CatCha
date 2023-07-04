using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CatCaha.List
{

    public class ListData
    {
        string imagePath = @"D:\1 Download";

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student { ID = 1, Name = "John", Age = 20 , Image = LoadImage("297306.jpg")},
                new Student { ID = 2, Name = "Jane", Age = 22 , Image = LoadImage("297306.jpg")},
                new Student { ID = 3, Name = "Mike", Age = 19 , Image = LoadImage("297306.jpg")},
                new Student { ID = 4, Name = "Emily", Age = 21, Image = LoadImage("123.jpg")}
            };

            return students;
        }


        public Image LoadImage(string imageName)
        {
            return Image.FromFile($"{imagePath}\\{imageName}");
        }


        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Image Image { get; set; }
        }
    }
}
