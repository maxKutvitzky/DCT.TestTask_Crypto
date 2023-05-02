﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DCT.UI.Commands
{
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