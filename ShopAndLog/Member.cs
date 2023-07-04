using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatChaForms
{
    //    若您希望保護 LoggedInUser.ID 不被其他人直接修改，您可以使用封裝 (Encapsulation) 的概念來達到這個目的。封裝可以透過設置變數的存取範圍以及提供公開的方法來控制對該變數的訪問。
    //在這種情況下，您可以將 LoggedInUser.ID 設置為私有的，並提供一個公開的只讀屬性或方法來獲取該值。這樣，其他程式碼只能讀取該值，而無法直接修改它。
    public static class LoggedInUser
    {
        private static int id;
        public static int ID
        {
            get { return id; }
            private set { id = value; }
        }
        public static string Username { get; set; }

        public static void SetID(int newID)
        {
            // 在這裡您可以增加額外的驗證邏輯，以確保只有特定條件下才能修改 ID
            id = newID;
        }

        public static void Logout()
        {
            id = 0;
        }
    }
}
