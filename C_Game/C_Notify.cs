using System;
using CatCaha.NewFolder1;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormResize
{
    
    public class C_Notify
    {
        
 
        class Notify
        {
            public string Title;
            public string Message;

            public Notify(string title, string message)
            {
                Title = title;
                Message = message;
            }
        }

        List<Notify> notify = new List<Notify>();
        private Frm_Notify frm_Notify;

        public C_Notify(Frm_Notify form)
        {
            frm_Notify = form;
        }

        public void addTtile()
        {
            notify.Add(new Notify("測試訊息1", "在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，在您的程式碼中，我們可以看到幾個問題：\r\n\r\n在 C_Notify 類別中，addTtile 方法的名稱應該是 addTitle，修正成正確的拼字。\r\n在 C_Notify 類別中，您在 Frm_Notify 的建構函式中，設定了 textBox_Message.Text 為 notify.leftBTN，但 C_Notify 類別中沒有定義 leftBTN 的值。您可能需要修改該值或確定使用正確的屬性。\r\n在 C_Notify 類別中的 _addBTN 方法中，您傳遞了一個 String title 參數，但是在方法內並沒有使用該參數來設定 Label 的文字。您可以將 l.Text 設定為 title。\r\n在 C_Notify 類別中的 _loadAll 方法中，您迴圈中的 foreach 声明的迴圈變數名稱和類別名稱相同，會造成衝突。您可以將其中一個名稱修改為不同的變數名稱，例如：foreach (Notify item in notify)。\r\n在 Frm_Notify 類別中，我們看不到 txtBack_Click 事件的實作，可能需要確認是否遺漏了該事件的程式碼。\r\n請注意進行這些修正後重新測試您的程式碼，並確保其他相關的邏輯和設定都是正確的。"));
            notify.Add(new Notify("測試訊息2", "222"));
            notify.Add(new Notify("測試訊息3", "333"));
            notify.Add(new Notify("測試訊息4", "444"));
            notify.Add(new Notify("測試訊息5", "555"));
        }



        public void _addBTN(FlowLayoutPanel f, String title)
        {
            Label l = new Label();
              
                l.AutoSize = true;
                l.BackColor = System.Drawing.Color.Transparent;
                l.Font = new System.Drawing.Font("微軟正黑體", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                l.ForeColor = System.Drawing.Color.White;
                l.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
                l.Size = new Size(265, 95);
                l.Text = title;
                l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                f.Controls.Add(l);
                l.Click += L_Click;
            
        }

        //TODO 解決呼叫相對應訊息問題
        public void L_Click(object sender, EventArgs e)
        {
            
        }

    



        public void _loadBTN(FlowLayoutPanel f) 
        {
            addTtile();
            foreach (Notify notify in notify) 
            {
                _addBTN(f,notify.Title);
                //在這個迴圈裏面把MESS家道TAG
            }
        }
    }
}
