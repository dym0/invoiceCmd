using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceCmd.Model
{
    class DbCustomer : ICustomer
    {
        public int ID { get;  set;  }

        public string Name {  get; set;}

        public string Surname { get; set;  }

        public string Email { get;  set;}

        public string Mobile {  get; set; }

        public DateTime Date { get; set;  }
        
    }
}
