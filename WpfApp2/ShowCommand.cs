using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2
{
    public class ShowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event Action<object> command;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(command != null)
            {
                command(parameter);
            }
        }
    }
}
