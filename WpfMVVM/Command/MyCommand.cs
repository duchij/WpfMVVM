﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace WpfMVVM.Command
{
    class MyCommand : ICommand
    {

        private Action _action;
        private bool _canExecute;

        public event EventHandler CanExecuteChanged;
        
      
        public MyCommand(Action action,bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        

        public bool CanExecute(object parameter)
        {
            //return _canExecute;
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
            //Model.Customer cs = new Model.Customer("lwlo");
        }

        
    }
}
