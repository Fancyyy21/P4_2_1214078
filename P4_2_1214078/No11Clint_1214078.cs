using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214078
{
    internal class No11Clint_1214078 : Product_1214078
    {
        protected string role;

        public No11Clint_1214078(string title, string role)
        {
            this.MyType = "Hero";
            this.MyTitle = title;
            this.role = role;
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
