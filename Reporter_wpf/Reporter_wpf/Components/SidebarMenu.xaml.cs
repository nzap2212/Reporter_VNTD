using System;
using System.Windows;
using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Components
{
    public partial class SidebarMenu : UserControl
    {
        public SidebarMenu()
        {
            InitializeComponent();
            
            // Không cần đặt DataContext ở đây nữa, vì đã đặt trong MainWindow.xaml.cs
        }
    }
} 