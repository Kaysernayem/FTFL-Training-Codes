using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WFA_DBPracticeDisconnected
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=KAYSER;Initial Catalog=FTFLPractice;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT EMPNO FROM Employee",con);
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string eno = dr.GetValue(0).ToString();
                comboBox1.Items.Add(eno);
            }
            dr.Close();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(comboBox1.SelectedItem.ToString());
            cmd = new SqlCommand("SELECT ENAME,SALARY,JOB,DEPTNO FROM Employee WHERE EMPNO=@E", con);
            cmd.Parameters.AddWithValue("@E", eno);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txtEName.Text = dr.GetValue(0).ToString();
                txtESalary.Text = dr.GetValue(1).ToString();
                txtEDesignation.Text = dr.GetValue(2).ToString();
                txtEDepartment.Text = dr.GetValue(3).ToString();
            }
            dr.Close();
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEName.Text = txtESalary.Text = txtEDesignation.Text = txtEDepartment.Text=null;
            comboBox1.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            int maxEmpNo = 1001;
            cmd = new SqlCommand("SELECT MAX(EMPNO) FROM EMPLOYEE", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                maxEmpNo = int.Parse(dr.GetValue(0).ToString());
                maxEmpNo++;
            }
            dr.Close();
            con.Close();
            comboBox1.Text = maxEmpNo.ToString();
            txtEName.Text = txtESalary.Text = txtEDesignation.Text = txtEDepartment.Text = null;
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(comboBox1.Text);
            string nm = txtEName.Text;
            float sl = float.Parse(txtESalary.Text);
            string desig = txtEDesignation.Text;
            int dn = int.Parse(txtEDepartment.Text);
            cmd = new SqlCommand("INSERT INTO Employee(EMPNO,ENAME,JOB,SALARY,DEPTNO)values(@EMPNO,@NAME,@DESIG,@SAL,@DEPTNO)", con);
            cmd.Parameters.AddWithValue("@EMPNO", eno);
            cmd.Parameters.AddWithValue("@NAME", nm);
            cmd.Parameters.AddWithValue("@DESIG", desig);
            cmd.Parameters.AddWithValue("@SAL", sl);
            cmd.Parameters.AddWithValue("@DEPTNO", dn);
            if (txtEName.Text == string.Empty)
            {
                Console.Write("Empty");
            }
            else
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Successfully");
                comboBox1.Items.Add(eno.ToString());
                comboBox1.Text = "";
                txtEName.Text = txtESalary.Text = txtEDesignation.Text = txtEDepartment.Text = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(comboBox1.SelectedItem.ToString());
            cmd = new SqlCommand("DELETE FROM Employee WHERE EMPNO=@ENO",con);
            cmd.Parameters.AddWithValue("@ENO", eno);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox1.Items.Remove(eno.ToString());
            MessageBox.Show("Removed Successfully");
            comboBox1.Text = "";
            txtEName.Text = txtESalary.Text = txtEDesignation.Text = txtEDepartment.Text = null;
        }

        private void txtEName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
