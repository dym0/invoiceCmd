using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceCmd
{
    interface ICustomer
    {
        int ID { get; set; }

         string Name { get; set; }

        string Surname { get; set; }

        string Email { get; set; }

        string Mobile { get; set; }

        DateTime Date { get; set; }

        


        //void SetID();

        //string Info();

      
       
    }
}
