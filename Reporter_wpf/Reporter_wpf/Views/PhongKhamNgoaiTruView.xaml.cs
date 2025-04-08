using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Views
{
    public partial class PhongKhamNgoaiTruView : UserControl
    {
        public PhongKhamNgoaiTruView()
        {
            InitializeComponent();
            
            // Lưu tham chiếu đến DataGrid trong ViewModel
            if (DataContext is PhongKhamNgoaiTruViewModel viewModel)
            {
                viewModel.DataGrid = PhongKhamNgoaiTruDataGrid;
            }
        }
    }
} 