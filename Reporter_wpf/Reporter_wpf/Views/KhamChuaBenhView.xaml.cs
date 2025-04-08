using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Views
{
    public partial class KhamChuaBenhView : UserControl
    {
        public KhamChuaBenhView()
        {
            InitializeComponent();
            
            // Lưu tham chiếu đến DataGrid trong ViewModel
            this.Loaded += (s, e) => 
            {
                if (DataContext is KhamChuaBenhViewModel viewModel)
                {
                    viewModel.DataGrid = KhamChuaBenhDataGrid;
                    System.Console.WriteLine($"KhamChuaBenhView: DataGrid set to {KhamChuaBenhDataGrid != null}");
                }
                else
                {
                    System.Console.WriteLine($"KhamChuaBenhView: DataContext is not KhamChuaBenhViewModel, it's {DataContext?.GetType().Name}");
                }
            };
        }
    }
} 