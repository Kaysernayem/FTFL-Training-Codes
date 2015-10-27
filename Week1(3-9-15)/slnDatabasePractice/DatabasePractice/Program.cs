using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabasePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=KAYSER;Initial Catalog=FTFLPractice;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update Employee set SALARY=SALARY+50", con);
            con.Open();
            int n = cmd.ExecuteNonQuery(); 
            con.Close();
            Console.Write(n + " are Records Updated");
            Console.Read();
        }
    }
}
