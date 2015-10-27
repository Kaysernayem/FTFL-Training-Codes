using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ThreeLayerArchi.App_code.DataAL
{
    public class EmployeeDataAL
    {
        SqlConnection conn = new SqlConnection("Data Source=KAYSER;Initial Catalog=FTFLPractice;Integrated Security=True");
    

     public DataTable Load()
     {
         DataSet ds=new DataSet();
         SqlDataAdapter da=new SqlDataAdapter("Select EMPNO,ENAME,JOB,DEPTNO Where Employee",conn);
         da.Fill(ds,"localTblEmployee");
         return ds.Tables[0];

     }

    }
}