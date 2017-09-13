using System;
using System.Diagnostics;
using System.Windows.Input;

namespace DemoCommand.ViewModel
{
    internal class DemoCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return  !string.IsNullOrWhiteSpace(parameter?.ToString());
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine("Executing >>>>>> " + parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
