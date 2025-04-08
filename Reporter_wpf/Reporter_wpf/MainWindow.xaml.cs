using System;
using System.Windows;
using System.Windows.Controls;
using Reporter_wpf.ViewModels;
using Reporter_wpf.Views;

namespace Reporter_wpf
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            
            // Tạo instance của MainViewModel
            _viewModel = new MainViewModel();
            
            // Thiết lập DataContext cho MainWindow
            DataContext = _viewModel;
            
            // Kiểm tra xem ContentArea có tồn tại không
            if (ContentArea == null)
            {
                MessageBox.Show("ContentArea is null", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            // Kiểm tra xem CurrentView có tồn tại không
            if (_viewModel.CurrentView == null)
            {
                MessageBox.Show("CurrentView is null", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            // Kiểm tra xem SidebarMenu có tồn tại không
            if (SidebarMenu == null)
            {
                MessageBox.Show("SidebarMenu is null", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            // Đặt DataContext cho SidebarMenu
            SidebarMenu.DataContext = _viewModel;
            
            // Thêm handler cho sự kiện Loaded
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Kiểm tra lại sau khi window đã loaded
            Console.WriteLine($"MainWindow Loaded, DataContext: {DataContext}");
            Console.WriteLine($"ContentArea Content: {ContentArea.Content}");
            Console.WriteLine($"SidebarMenu DataContext: {SidebarMenu.DataContext}");
            
            // Kiểm tra các command
            var viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                Console.WriteLine($"NavigateCommand: {viewModel.NavigateCommand != null}");
                Console.WriteLine($"LoadDataCommand: {viewModel.LoadDataCommand != null}");
                Console.WriteLine($"ExportToWordCommand: {viewModel.ExportToWordCommand != null}");
                Console.WriteLine($"ResetCommand: {viewModel.ResetCommand != null}");
                Console.WriteLine($"IsDataLoaded: {viewModel.IsDataLoaded}");
                
                // Thêm button click handler để kiểm tra
                var button = this.FindName("ExportWordButton") as Button;
                if (button != null)
                {
                    Console.WriteLine($"ExportWordButton found, Command: {button.Command}");
                    Console.WriteLine($"CanExecute: {button.Command?.CanExecute(null)}");
                }
            }
            
            // Thử chuyển trang thủ công
            _viewModel.Navigate("Dashboard");
        }

        private void ExportWordButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ExportWordButton clicked");
            
            var viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                Console.WriteLine($"IsDataLoaded: {viewModel.IsDataLoaded}");
                Console.WriteLine($"CanExportToWord: {viewModel.ExportToWordCommand.CanExecute(null)}");
                
                // Thử thực thi command trực tiếp
                if (viewModel.ExportToWordCommand.CanExecute(null))
                {
                    viewModel.ExportToWordCommand.Execute(null);
                }
                else
                {
                    MessageBox.Show("Vui lòng tải dữ liệu trước khi xuất báo cáo", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void ExportWordButtonDirect_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ExportWordButtonDirect clicked");
            
            var viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                if (viewModel.IsDataLoaded)
                {
                    try
                    {
                        // Gọi trực tiếp phương thức ExportToWord
                        viewModel.ExportToWordDirectly();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất báo cáo: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng tải dữ liệu trước khi xuất báo cáo", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
