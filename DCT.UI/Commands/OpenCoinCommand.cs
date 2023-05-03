using System;
using System.Windows.Input;

namespace DCT.UI.Commands
{
    /// <summary>
    /// Custom command to handle opening a window with currency information
    /// </summary>
    public class OpenCoinCommand : ICommand
    {
        private readonly Action<string> _action;

        public event EventHandler? CanExecuteChanged;

        public OpenCoinCommand(Action<string> action)
        {
            _action = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _action.Invoke(parameter.ToString());
        }
    }
}
