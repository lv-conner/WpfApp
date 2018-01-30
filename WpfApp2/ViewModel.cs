using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class ViewModel
    {
        public UserModel Data
        {
            get;set;
        }
        public ShowCommand Command
        {
            get;set;
        }
        public ViewModel()
        {
            Data = new UserModel();
            Command = new ShowCommand();
            Command.command += Data.AddPrefix;
        }
    }
}
