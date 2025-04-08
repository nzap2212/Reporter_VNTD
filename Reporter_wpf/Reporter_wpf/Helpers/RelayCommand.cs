using System;
using System.Diagnostics;
using System.Windows.Input;

namespace Reporter_wpf.Helpers
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Predicate<T> _canExecute;

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            try
            {
                if (_canExecute == null)
                    return true;
                    
                if (parameter == null)
                {
                    if (typeof(T).IsValueType && Nullable.GetUnderlyingType(typeof(T)) == null)
                        return false;
                        
                    return _canExecute(default);
                }
                
                return _canExecute((T)parameter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CanExecute: {ex.Message}");
                return false;
            }
        }

        public void Execute(object parameter)
        {
            try
            {
                Console.WriteLine($"RelayCommand<T>.Execute called with parameter: {parameter}");
                
                if (parameter == null)
                {
                    _execute(default);
                    return;
                }
                
                _execute((T)parameter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Execute: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("RelayCommand.Execute called");
            _execute();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
