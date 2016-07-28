using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceCmd
{
    interface IArticle
    {

        int articleID { get; } 

        string name { get; set; }

        double bruttoSum { get; set; }

        double nettoSum { get; set; }


      
    }
}
