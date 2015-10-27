using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ThreeLayerArchi.App_code.BussAL
{
    public class EmployeeBussAL
    {
        public DataTable LoadData()
        {
            EmployeeDataAL EDataAL = new EmployeeDataAL();
            return EDataAL.Load();
            Datatable dt = EDataAL.Load();
            return dt;
        }
    }
}