using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class UserModel:NotificationObject
    {
        private string name;
        private string password;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                PropertyChange(nameof(Name));
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                PropertyChange(nameof(Password));
            }
        }

        public override string ToString()
        {
            return string.Format($"{name} + {Password}");
        }

        public void AddPrefix(object o)
        {
            this.Name += "*";
            this.Password += "**";
        }

    }
}
