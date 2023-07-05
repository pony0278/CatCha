using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha.ProductsList;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatCaha.IcaptureData
{
    public class CaptureDataManager<T> where T : ProductsProperties
    {
        private ICaptureImages<T> _imageCapture;

        public CaptureDataManager(ICaptureImages<T> imageCapture)
        {
            _imageCapture = imageCapture;
        }

        public void Capture(List<T> people, Form form, FlowLayoutPanel flowLayoutPanel,Button button)
        {
            _imageCapture.captureImages(people, form, flowLayoutPanel ,button);
        }
    }
}
