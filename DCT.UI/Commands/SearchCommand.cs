using System;
using System.Windows.Input;

namespace DCT.UI.Commands
{
    /// <summary>
    /// Custom command to handle search of a currency information
    /// </summary>
    public class SearchCommand : ICommand
    {
        private readonly Action _action;
        
        public event EventHandler? CanExecuteChanged;

        public SearchCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _action?.Invoke();
        }
    }
}
