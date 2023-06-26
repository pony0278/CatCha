using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatCaha.List;
using CatCaha;
using System.Windows.Forms;

namespace CatCaha.IcaptureData
{
    public interface ICaptureImages<T> where T : Person
    {
        void captureImages(List<T> items, Form form, FlowLayoutPanel flowLayoutPanel, Button button);
    }
}

