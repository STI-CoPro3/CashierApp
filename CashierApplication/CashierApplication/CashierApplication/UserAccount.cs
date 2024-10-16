using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public abstract class UserAccount
    {
        private String full_name;
        protected String user_name;
        protected String user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password; 
        }
        public abstract bool ValidateLogin(string uName, string password);
        
        public string getFullName()
        {
            return this.full_name;
        }
    }

}
