using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceCmd
{
    interface Iinvoice
    {

        int clientID { get; set; }

        int invoiceID { get; set; }

        Article[] articles { get; set; }

        double nettoSum { get; set; }

        double bruttoSum { get; set; }



        
    }
}
