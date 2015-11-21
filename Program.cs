using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace invoiceCmd
{   
   
     class Program
    {

     
        static void Main(string[] args)
        {
                

            List<customer> customerList = new List<customer>();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
           
            int userChoice;

            do
            {
                userChoice = 0;
               
                Console.WriteLine("\n\n    1.Customers \n\n    2.Invoices \n\n    3.Exit");

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
                            Console.WriteLine("\n\n    1.Add New Customer \n\n    2.Display List of Customers \n\n    3.Remove customer \n\n    4.Back to menu");
                            try { userChoice = Convert.ToInt16(Console.ReadLine()); }
                            catch { break; }

                                                    switch (userChoice)
                                                    {
                                                        case 1:
                                                            {
                                                                Console.WriteLine("Adding New Customer");
                                                                Console.WriteLine("Name: ");

                                                                string inputName = Console.ReadLine();

                                                                Console.WriteLine("Surname: ");
                                                                string inputSurname = Console.ReadLine();

                                                                Console.WriteLine("Email: ");
                                                                string inputEmail = Console.ReadLine();

                                                                Console.WriteLine("Mobile: ");
                                                                string inputMobile = Console.ReadLine();

                                                                customerList.Add(new customer() { Name = inputName, Surname = inputSurname, Email = inputEmail, Mobile = inputMobile });
                                                                foreach(customer cost in customerList)
                                                                {
                                                                    cost.SetID();
                                                                    cost.Add();
                                                                }
                                                             
                                                                Console.Clear();
                                                                break;
                                                                

                                                            }
                                                    
                                                        case 2:
                                                            {                                                          

                                                                customer.List();

                                                                break;
                                                            }

                                                        case 3:
                                                            {
                                                                Console.WriteLine("\n    Remove customer, \n Please insert ID, this Customer will be delate permanently from data base.");
                                                                try
                                                                {
                                                                    int deleteChoice = Convert.ToInt16(Console.ReadLine());

                                                                  customer.RemoveCustomer(deleteChoice);
                                                                }
                                                                catch
                                                                {
                                                                    Console.WriteLine("Wrong! CUstomer isnt deleted, try again.");
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
