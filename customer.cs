using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace invoiceCmd
{
    public class customer
    {
        
        private int ID;
        public string Name { get; set; }
        public string Surname { get; set; }     
        public string Email { get; set; }
        public string Mobile { get; set; }
        private string Data;

          
            public void test()
            {
                Console.WriteLine("test2");
            }
            //public void AddCustomer(string _Name, string _Surname, string _Email, string _Mobile)
            //{
            //    this.Name = _Name; 
            //    this.Surname = _Surname; 
            //    this.Email = _Email; 
            //    this.Mobile = _Mobile; 
            //}

            //public void AddCustomer(string _Name, string _Surname, string _Email)
            //{
            //    this.Name = _Name; 
            //    this.Surname = _Surname; 
            //    this.Email = _Email; 
            //}
        

            //public int id
            //{
            //    set
            //    {
            //        DateTime data = DateTime.Now;
            //        Data = data.ToShortDateString();
            //        ID = value;
            //    }
            //    get
            //    {
            //        return ID;

            //    }

            //}
            

            public void SetID()
            {
                    int lastID;
                    string cs = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;
                    if (cs != string.Empty)
                    {
                        Console.WriteLine("Database connected");
                    }


                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM clientInfo;", con);

                        con.Open();
                        try
                        {
                            lastID = (int)cmd.ExecuteScalar();
                        }
                        catch
                        {
                            lastID = 0;
                        }
                      

                    
                        // TODO
                        // get last ID from DB. 
                        // set ID + 1 then last id from db

                        lastID++;
                    }
                   
                    
                    this.ID = lastID;

                    DateTime data = DateTime.Now;
                    Data = data.ToShortDateString();
            }

            public string Info()
            {
                string info = "";
                   
               try
               {
                  
                   info = " \nID:  " + this.ID +
                 "\n Name:  " + this.Name +
                 "\n Surname: " + this.Surname +
                 "\n Email: " + this.Email +
                 "\n Mobile: " + this.Mobile +
                 "\n Join Date: " + this.Data;

                  
               }
                catch(Exception e)
               {
                    Console.WriteLine(e);
               }


               return info;
             
            }

         
            
            public void Add()
            {
                string dbConnection = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;

                string cmd = String.Format("INSERT INTO clientInfo VALUES({0}, '{1}','{2}','{3}','{4}','{5}')", this.ID, this.Name, this.Surname, this.Email, this.Mobile, this.Data);
               // TODO
                //SQL Incjection protection
                using (SqlConnection sqlCon = new SqlConnection(dbConnection))
                {
                    sqlCon.Open();
                   
                   SqlCommand ja =  new SqlCommand(cmd, sqlCon);
                   int TotalRowsAffected = (int)ja.ExecuteNonQuery();
                 

                };


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
                        string myCmd = String.Format("DELETE FROM clientInfo WHERE ID = {0}", _id);
                        //TODO
                        // SQL INCJECTION PROTECTION
                        SqlCommand cmd = new SqlCommand(myCmd, con);
                        int cos = (int)cmd.ExecuteNonQuery();

                    }
                }
                catch
                {
                    Console.WriteLine("removing failed!!");

                }
                //string cs = ConfigurationManager.ConnectionStrings["DBCL"].ConnectionString;

                //using (SqlConnection con = new SqlConnection(cs))
                //{
                //    string myCmd = String.Format("DELETE FROM clientInfo WHERE ID = {0};", _id);
                //    SqlCommand cmd = new SqlCommand(myCmd, con);

                //    con.Open();
                //}
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


