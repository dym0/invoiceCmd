using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using invoiceCmd.Model;

namespace invoiceCmd
{   
   
     class Program
    {

       /* DOne */
       /* Add entity framework NuGet package*/
       /* Test entity */

       /* TODO TODAY */
        
        /* ADD Entity framwork and adapt invoicecmd to it */


         

        static void Main(string[] args)
        {

            Tests.dbConnection();

            List<Customer> customerList = new List<Customer>();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

        
            
            

            int userChoice;



            do
            {

               

                userChoice = 0;
               
                Console.Write("\n\n    1.Customers \n\n    2.Invoices \n\n    3.Exit \n\n ");

                try 
                { 
                    userChoice = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("sorry, its wrong choice, try again");
                
                    continue;
                }
                finally
                {
                    Console.Clear();
                }

                switch (userChoice)
                {
                    case 1:
                        {
                            Console.Write("\n\n    1.Add New Customer \n\n    2.Display List of Customers \n\n    3.Remove customer \n\n    4.Back to menu \n\n  ");
                            try { userChoice = Convert.ToInt16(Console.ReadLine()); }
                            catch { break; }

                                                    switch (userChoice)
                                                    {
                                                        case 1:
                                                            {
                                                            //    Console.WriteLine("\n  Adding New Customer");
                                                            //    Console.Write("\n  Name: ");

                                                            //    string inputName = Console.ReadLine();

                                                            //    Console.Write("\n  Surname: ");
                                                            //    string inputSurname = Console.ReadLine();

                                                            //    Console.Write("\n  Email: ");
                                                            //    string inputEmail = Console.ReadLine();

                                                            //    Console.Write("\n  Mobile: ");
                                                            //    string inputMobile = Console.ReadLine();

                                                            //    customerList.Add(new Customer() { Name = inputName, Surname = inputSurname, Email = inputEmail, Mobile = inputMobile });
                                                            //    foreach(Customer cost in customerList)
                                                            //    {
                                                                    //cost.SetID();
                                                                    //cost.Add();
                                                                //}
                                                             
                                                                //Console.Clear();
                                                                //break;

                                                                Customer.Add();
                                                                break;
                                                                

                                                            }
                                                    
                                                        case 2:
                                                            {                                                          

                                                                Customer.List();

                                                                break;
                                                            }

                                                        case 3:
                                                            {
                                                                Console.WriteLine("\n    Remove customer, \n Please insert ID, this Customer will be delate permanently from database.");
                                                                try
                                                                {
                                                                    int deleteChoice = Convert.ToInt16(Console.ReadLine());

                                                                  Customer.RemoveCustomer(deleteChoice);
                                                                }
                                                                catch
                                                                {
                                                                    Console.WriteLine("Error while removing customer , try again.");
                                                                }

                                                                userChoice = 0;
                                                                break;
                                                            }

                                                        case 4:
                                                            {
                                                                Console.Clear();

                                                                break;
                                                            }
                                                        default:
                                                            break;
                                                    }

                            break;
                        }
                    case 2:
                        {
                            //TODO
                            // Invoices

                            Console.WriteLine("Invoices");
                            break;
                        }
                    case 3:
                        {
                            // EXIT
                            break;
                        }
                    default:
                        break;
                }




            } while (userChoice != 3);
                

        } // end main func.

  
     

       
    }

   
}
