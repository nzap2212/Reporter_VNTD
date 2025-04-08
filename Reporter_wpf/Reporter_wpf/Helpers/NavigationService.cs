using System;
using System.Windows.Controls;

namespace Reporter_wpf.Helpers
{
    public static class NavigationService
    {
        private static Action<UserControl> _navigateAction;

        public static void Configure(Action<UserControl> navigateAction)
        {
            _navigateAction = navigateAction;
        }

        public static void Navigate(UserControl page)
        {
            _navigateAction?.Invoke(page);
        }
    }
}
