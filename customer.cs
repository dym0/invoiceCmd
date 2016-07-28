using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using invoiceCmd.Model;




namespace invoiceCmd
{
    public class Customer : ICustomer
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }    
 
        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime Date { get; set; }

 

            public void SetID()
            {
                    int lastID;
                    string cs = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;
              


                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("SELECT MAX(Client_ID) FROM clientInfo;", con);

                        con.Open();
                        try
                        {
                            lastID = (int)cmd.ExecuteScalar();
                        }
                        catch
                        {
                            lastID = 0;
                        }  
                 

                        lastID++;
                    }
                   
                    
                    this.ID = lastID;

                     Date = DateTime.Today;
                     Date = Date.Date;
                
            }

            public string Info()
            {
                string info = "";
                   
             
                  
                   info = " \n ID:  " + this.ID +
                 "\n Name:  " + this.Name +
                 "\n Surname: " + this.Surname +
                 "\n Email: " + this.Email +
                 "\n Mobile: " + this.Mobile +
                 "\n Join Date: " + this.Date;

            return info;
             
            }

         
            
            public static void Add()  // add static for entity framework test
            {
               // string dbConnection = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;

               // string cmd = String.Format("INSERT INTO clientInfo VALUES({0}, '{1}','{2}','{3}','{4}','{5}')", this.ID, this.Name, this.Surname, this.Date, this.Email, this.Mobile );
               //// TODO

               // //SQL Incjection protection
               // using (SqlConnection sqlCon = new SqlConnection(dbConnection))
               // {
               //     sqlCon.Open();
                   
               //    SqlCommand ja =  new SqlCommand(cmd, sqlCon);
               //    int TotalRowsAffected = (int)ja.ExecuteNonQuery();
                 

               // };

                using (var db = new CustomerDBContext())
                {

                    var customer = new DbCustomer
                    {
                        ID = 1,
                        Date = DateTime.Now,
                        Email =

                            "damiankuzmicki1989@gmail.com",
                        Mobile = "0738961968",
                        Name = "Damian",
                        Surname = "Kuzmicki"
                    };




                    try
                    {
                        db.Customers.Add(customer);
                        db.SaveChanges();
                    }
                    catch
                    {
                        Console.WriteLine("Sorry, Cant add Customer, try again later!");
                    }

                }

            }
               // ## STATIC METHODS ## //

            public static void RemoveCustomer(int _id)
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string myCmd = String.Format("DELETE FROM clientInfo WHERE client_ID = {0}", _id);
                        //TODO
                        // Removing confirmation
                        // SQL INCJECTION PROTECTION
                        SqlCommand cmd = new SqlCommand(myCmd, con);
                        int cos = (int)cmd.ExecuteNonQuery();

                    }
                }
                catch
                {
                    Console.WriteLine("removing failed!!");

                }
          
            }

            public static void List()
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;
                if (cs != string.Empty)
                {
                    Console.WriteLine("Database connected");
                }


                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM clientInfo", con);

                    con.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        Console.Clear();
                        //Console.WriteLine("ID | Name | Surname | Add Date | Email | Mobile |");
                        while (rdr.Read())
                        {
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                Console.WriteLine("\n    " + rdr.GetValue(i));

                            }
                            Console.WriteLine(" \n");
                        }

                    }
                }
                //return null;
            }

    
       
       
        }
      
 
        
    }


