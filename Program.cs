using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net
{
    class Program
    {
        static void Main()
        {
            new Program().CreateTable();
        }
        
        //create 1 method
        public void CreateTable()
        {
            SqlConnection con = null;
     
            //apply try catch
            try
            {
                //create connection
                con = new SqlConnection("data source=.; database=Employee; integrated security=SSPI");


                //write sql query to create table

   //                  SqlCommand cm = new SqlCommand("create table Employee(id int not null,name varchar(100), email varchar(50), join_date date)", con);  

                //query to insert data
  //               SqlCommand cm = new SqlCommand("insert into Employee(id, name, email,join_date)values('100','roshi','roshi@gmail.com','1/06/2021')", con);

                //query to retrive record
    //            SqlCommand cm = new SqlCommand("Select * from Employee", con);


                //query to delete record
                SqlCommand cm = new SqlCommand("delete from Employee where id=100", con);


               //opening connection
               con.Open();
                //executing sql query
                cm.ExecuteNonQuery();

                //executing sql query to retrive record
                //-----------------------------------------------------------
                /*
                // for this, comment - cm.ExecuteNonQuery();

                SqlDataReader sd = cm.ExecuteReader();
                while (sd.Read())
                {
                    //display record
                    Console.WriteLine(sd["id"] + "" + sd["name"] + "" + sd["email"]);    //"" in between because + cannot be applied to the object instance used
                
                }
                */
                //------------------------------------------------------
                //display message
                Console.WriteLine("table created");
                Console.WriteLine("table record inserted");
                Console.WriteLine("table record retrived");
                Console.WriteLine("table record deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine("not working"+e);
            }
            //closing connection
            finally
            {
                con.Close();
            }
       
        //-----------------------------------------------
       

        }  
    }
}