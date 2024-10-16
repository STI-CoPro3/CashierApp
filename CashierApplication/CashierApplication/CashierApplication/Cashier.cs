using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string Department;

        public Cashier(String name, string Department, string uName, string pass)
            :base(name, uName, pass)
        {
            this.Department = Department;
        }

        public override bool ValidateLogin(string uName, string password)
        {
            return uName.Equals(this.user_name) && password.Equals(this.user_password);
        }

        public string getDepartment()
        {
            return this.Department;
        }
    }
}
