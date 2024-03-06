using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysprog_29._02_2_
{
    public class Contact
    {
        public int id;
        public string name;
        public string number;

        public Contact(int id, string name, string number)
        {
            this.id = id;
            this.name = name;
            this.number = number;
        }
    }
}