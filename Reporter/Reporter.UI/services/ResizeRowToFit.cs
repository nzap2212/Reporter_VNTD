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

        // 🚀 Hàm giúp các dòng mở rộng để lấp đầy DataGridView
        public void AutoResizeRow(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0) return;

            // Tính tổng chiều cao DataGridView trừ phần tiêu đề cột
            int totalHeight = dgv.Height - dgv.ColumnHeadersHeight;
            int rowCount = dgv.Rows.Count;

            if (rowCount > 0)
            {
                int rowHeight = totalHeight / rowCount; // Chia đều chiều cao cho mỗi dòng
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = rowHeight;
                }
            }
        }
    }
}
