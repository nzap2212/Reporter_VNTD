using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter.UI.services
{
    public class ResizeRowsToFit
    {
        private static ResizeRowsToFit instance;
        public static ResizeRowsToFit Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ResizeRowsToFit();
                }
                return instance;
            }
        }
        private ResizeRowsToFit() { }

        // Hàm giúp các dòng mở rộng để lấp đầy DataGridView
        public void AutoResizeRow(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0) return;

            // Tính tổng chiều cao DataGridView trừ phần tiêu đề cột
            int totalHeight = dgv.Height - dgv.ColumnHeadersHeight;
            int rowCount = dgv.Rows.Count;

            if (rowCount > 0)
            {
                int rowHeight = Math.Max(35, totalHeight / rowCount); // Đảm bảo chiều cao tối thiểu là 35px
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = rowHeight;
                }
            }
            
            // Tự động điều chỉnh chiều rộng cột để lấp đầy DataGridView
            int totalColumnWidth = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                {
                    totalColumnWidth += col.Width;
                }
            }
            
            // Nếu tổng chiều rộng cột nhỏ hơn chiều rộng DataGridView, điều chỉnh cột cuối cùng
            if (totalColumnWidth < dgv.Width - 20) // Trừ đi 20px cho thanh cuộn
            {
                DataGridViewColumn lastVisibleColumn = null;
                for (int i = dgv.Columns.Count - 1; i >= 0; i--)
                {
                    if (dgv.Columns[i].Visible)
                    {
                        lastVisibleColumn = dgv.Columns[i];
                        break;
                    }
                }
                
                if (lastVisibleColumn != null)
                {
                    lastVisibleColumn.Width += (dgv.Width - 20 - totalColumnWidth);
                }
            }
        }
    }
}
