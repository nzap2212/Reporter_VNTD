using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Views
{
    public partial class DichVuYeuCauView : UserControl
    {
        public DichVuYeuCauView()
        {
            InitializeComponent();
            
            // Lưu tham chiếu đến DataGrid trong ViewModel
            if (DataContext is DichVuYeuCauViewModel viewModel)
            {
                viewModel.DataGrid = DichVuYeuCauDataGrid;
            }
        }
    }
} 