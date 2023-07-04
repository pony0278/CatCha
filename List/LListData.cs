using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.List
{
    public abstract class ListData<T> where T : Person
    {
        string imagePath = @"D:\1 Download";

        public Image LoadImage(string imageName)
        {
            return Image.FromFile($"{imagePath}\\{imageName}");
        }

        public abstract List<T> GetPeople();
    }
}
