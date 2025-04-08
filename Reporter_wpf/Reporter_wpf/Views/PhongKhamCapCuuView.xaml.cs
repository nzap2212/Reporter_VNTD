using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Views
{
    public partial class PhongKhamCapCuuView : UserControl
    {
        public PhongKhamCapCuuView()
        {
            InitializeComponent();
            
            // Lưu tham chiếu đến DataGrid trong ViewModel
            if (DataContext is PhongKhamCapCuuViewModel viewModel)
            {
                viewModel.DataGrid = PhongKhamCapCuuDataGrid;
            }
        }
    }
} 