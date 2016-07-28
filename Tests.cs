using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace invoiceCmd
{
    class Tests
    {

        //check database connection \\


        private static bool IsServerConnected()
        {

            string dbConnection = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;

            using (var l_oconnection = new SqlConnection(dbConnection))
            {
                try
                {
                    l_oconnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;

                }
                finally
                {

                }
            }

        }


        public static void dbConnection()
        {

            bool dbConnected = IsServerConnected();

            if (dbConnected)
            {   
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                
                Console.WriteLine("\n   Database connected successful!");

            }
            else if (!dbConnected)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n    Database connecion error!!");
                
            }
            else
            {
                Console.WriteLine("Unknown error!");
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }


        //test add, remove, edit and delate client from DB \\

        public static bool addTestCustomer()
        {

            return true;
            
        }
    }
}
