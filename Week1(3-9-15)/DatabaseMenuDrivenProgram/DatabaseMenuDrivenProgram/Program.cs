using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseMenuDrivenProgram
{
    class Program
    {
        static SqlConnection con = new SqlConnection("Data Source=KAYSER;Initial Catalog=FTFLPractice;Integrated Security=True");
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Show All Employee Details");
                Console.WriteLine("3. Show Employee Details by Emp No");
                Console.WriteLine("4. Remove Employee details by Emp no");
                Console.WriteLine("5. Update Salary by Emp No");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ShowAllEmployee();
                        break;
                    case 3:
                        DisplayByEmployee();
                        break;
                    case 4:
                        DeleteEmpByEmpNo();
                        break;
                    case 5:
                        UpdateSalByEmpNo();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Wrong Input. Try again");
                        break;
                }
            }
        }
        static void AddEmployee()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee(ENAME,JOB,SALARY,DEPTNO)values(@NAME,@DESIG,@SAL,@DEPTNO)", con);
            Console.Write("Enter Name:");
            string n = Console.ReadLine();
            cmd.Parameters.AddWithValue("@Name", n);
            Console.Write("Enter Designation:");
            string d = Console.ReadLine();
            cmd.Parameters.AddWithValue("@DESIG", d);
            Console.Write("Enter Salary:");
            int s = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@SAL", s);
            Console.Write("Enter Dept no:");
            int dn = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@DEPTNO", dn);
            con.Open();
            int no = cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine(no + " record added successfully");
        }
        static void ShowAllEmployee()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    //for (int i = 0; i < dr.FieldCount; i++)
                    //{
                        Console.WriteLine(dr.GetValue(1));
                    //}
                }
            }
            else
                Console.WriteLine("No Data found");
            con.Close();
        }

        static void DisplayByEmployee()
        {
            Console.Write("Enter Employee No:");
            int eno = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("SELECT EMPNO,ENAME,JOB,SALARY,DOJ,DEPTNO FROM Employee WHERE EMPNO=@ENO",con);
            cmd.Parameters.AddWithValue("@ENO", eno);
            con.Open();
            SqlDataReader dr;
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                Console.WriteLine("Employee No:" + dr.GetValue(0).ToString());
                Console.WriteLine("Employee Name:" + dr.GetValue(1).ToString());
                Console.WriteLine("Employee Department No:" + dr.GetValue(5).ToString());
                Console.WriteLine("Employee Designation:" + dr.GetValue(2).ToString());
                Console.WriteLine("Employee Salary:" + dr.GetValue(3).ToString());
                Console.WriteLine("Employee Date Of Joining:" + dr.GetValue(4).ToString());
            }
            else
                Console.WriteLine("Not Found, please enter correct Employee ID");
            con.Close();
        }

        static void DeleteEmpByEmpNo()
        {
            Console.Write("Enter Employee No:");
            int eno = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE EMPNO=@ENO", con);
            cmd.Parameters.AddWithValue("@ENO", eno);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            bool flag = false;
            if (dr.Read())
                flag = true;
            dr.Close();
            if (flag == true)
            {
                cmd = new SqlCommand("DELETE FROM Employee WHERE EMPNO=@E", con);
                cmd.Parameters.AddWithValue("@E", eno);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee has been deleted successfully");
            }
        }
        static void UpdateSalByEmpNo()
        {
            Console.Write("Enter Employee No:");
            int eno = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE EMPNO=@ENO", con);
            cmd.Parameters.AddWithValue("@ENO", eno);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            bool flag = false;
            if (dr.Read())
                flag = true;
            dr.Close();
            if (flag == true)
            {
                Console.Write("Enter New Salary:");
                float sl = float.Parse(Console.ReadLine());
                cmd = new SqlCommand("UPDATE Employee SET SALARY=@S WHERE EMPNO=@E AND @S>Salary",con);
                cmd.Parameters.AddWithValue("@S", sl);
                cmd.Parameters.AddWithValue("@E", eno);
                int n=cmd.ExecuteNonQuery();
                if (n == 0)
                    Console.WriteLine("Please Enter Greater Salary");
                else
                    Console.WriteLine("Updated Successfully");
            }
            else
                Console.WriteLine("Not found");
            con.Close();
        }
    }
}
