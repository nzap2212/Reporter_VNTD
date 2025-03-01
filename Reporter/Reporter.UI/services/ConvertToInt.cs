using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter.UI.services
{
    public class ConvertToInt
    {
        private static ConvertToInt instance;
        public static ConvertToInt Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ConvertToInt();
                }
                return instance;
            }
        }
        private ConvertToInt() { }

        // Hàm kiểm tra và chuyển đổi số nguyên an toàn
        public int TryParseInt(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return 0; // Nếu giá trị trống, trả về 0

            int result;
            if (int.TryParse(value.ToString(), out result))
                return result; // Chuyển đổi thành công

            return 0; // Nếu lỗi, trả về 0 để tránh crash
        }
    }
}
