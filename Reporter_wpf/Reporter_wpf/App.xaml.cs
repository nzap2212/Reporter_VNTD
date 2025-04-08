using System;
using System.Windows;
using System.Windows.Threading;

namespace Reporter_wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        // Thêm handler cho sự kiện DispatcherUnhandledException
        this.DispatcherUnhandledException += App_DispatcherUnhandledException;
    }

    private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        // Log lỗi
        Console.WriteLine($"Unhandled exception: {e.Exception.Message}");
        Console.WriteLine(e.Exception.StackTrace);
        
        // Hiển thị thông báo lỗi
        MessageBox.Show($"Đã xảy ra lỗi: {e.Exception.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
        
        // Đánh dấu là đã xử lý để ứng dụng không bị crash
        e.Handled = true;
    }
}

