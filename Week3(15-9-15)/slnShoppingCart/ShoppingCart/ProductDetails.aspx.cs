using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShoppingCart
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=KAYSER;Initial Catalog=FTFLPractice;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cmd = new SqlCommand("SELECT DISTINCT ProductCatagory FROM TableProduct", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                DropDownListProductCatagory.Items.Add("Select");
                DropDownListProductType.Items.Add("Select");
                while (dr.Read())
                {
                    DropDownListProductCatagory.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                conn.Close();

                DataTable dt = new DataTable();
                dt.Columns.Add("ProductID", typeof(int));
                dt.Columns.Add("ProductDetails", typeof(string));
                dt.Columns.Add("ProductPrice", typeof(float));
                dt.Columns.Add("noOfItems", typeof(int));
                dt.Columns.Add("TotalPrice", typeof(float));
                Session["cart"] = dt;
            }
            
        }

        protected void GridViewProductDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewProductDetails.PageIndex = e.NewPageIndex;
        }

        protected void DropDownListProductCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownListProductCatagory.SelectedIndex > 0)
            {
                string catagory = DropDownListProductCatagory.SelectedItem.ToString();
                cmd = new SqlCommand("select distinct ProductType from TableProduct where ProductCatagory = '" + catagory + "'", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (DropDownListProductType.Items.Count > 0)
            {
                DropDownListProductType.Items.Clear();
                DropDownListProductType.Items.Add("Select");
            }
                while (dr.Read())
                {
                    string nam = dr["ProductType"].ToString();
                    DropDownListProductType.Items.Add(nam);
                  //  DropDownListProductType.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                conn.Close();
                
            }
            
        }

        protected void GetData()
        {
            string productCatagory = (DropDownListProductCatagory.SelectedItem.ToString());
            string productType = (DropDownListProductType.SelectedItem.ToString());
            da = new SqlDataAdapter("SELECT ProductID,BrandName,ProductDetails,ProductPrice,ProductStock FROM TableProduct WHERE ProductCatagory='" + productCatagory + "' AND ProductType='" + productType + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "localTblProduct");
            Session["ds"] = ds;
            //SqlCommandBuilder scb = new SqlCommandBuilder(da);
            Session["da"] = da;

         
          
            
        }


        protected void BindData()
        {
            DataTable dt = ((DataSet)Session["ds"]).Tables[0];
            //DataSet ds = ((DataSet)Session["ds"]);
            //DataTable dt.Tables[0];
            GridViewProductDetails.DataSource = ds.Tables[0];
            GridViewProductDetails.DataBind();
            for (int i = 0; i < GridViewProductDetails.Rows.Count; i++)
            {
               // GridViewProductDetails.Rows[i].Cells[4].FindControl("DropDownListNoOfItems").visible = false;
                DropDownList noOfItems = (DropDownList)GridViewProductDetails.Rows[i].FindControl("DropDownListNoOfItems");

                noOfItems.Visible = false;
            }
        
        }

        protected void ButtonShowProductDetails_Click(object sender, EventArgs e)
        {
            GridViewProductDetails.Visible = true;
            GetData();
            BindData();
           

        }

        protected void DropDownListProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonShowProductDetails.Visible = true;
        }

        protected void CheckBoxSelectProduct_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < GridViewProductDetails.Rows.Count; i++)
            {
                CheckBox ch = (CheckBox)GridViewProductDetails.Rows[i].FindControl("CheckBoxSelectProduct");

                bool flag = false;
                if (ch.Checked == true)
                {
                    flag = true;
                   // noOfAdd++;

                }
                if (flag)
                {
                    DropDownList btnEdit = (DropDownList)GridViewProductDetails.Rows[i].FindControl("DropDownListNoOfItems");

                    btnEdit.Visible = true;
                    int length = int.Parse(GridViewProductDetails.Rows[i].Cells[4].Text);

                    for (int j = 1; j <= length; j++)
                    {
                        DropDownList lblUserID = (DropDownList)GridViewProductDetails.Rows[i].FindControl("DropDownListNoOfItems");
                        lblUserID.Items.Add(j.ToString());
                    }
                }
                else
                {
                   // noOfAdd--;
                    DropDownList btnEdit = (DropDownList)GridViewProductDetails.Rows[i].FindControl("DropDownListNoOfItems");

                    btnEdit.Visible = false; 
                   
                }
                
            }
        }

        protected void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["cart"];
            for (int i = 0; i < GridViewProductDetails.Rows.Count; i++)
            {
                CheckBox ch=(CheckBox)GridViewProductDetails.Rows[i].FindControl("CheckBoxSelectProduct");
                if(ch.Checked==true)
                    {
                        Label lpid = (Label)GridViewProductDetails.Rows[i].FindControl("Label1");
                        Label lpdet = (Label)GridViewProductDetails.Rows[i].FindControl("Label2");
                        Label lppri = (Label)GridViewProductDetails.Rows[i].FindControl("Label3");
                        DropDownList lpnoi = (DropDownList)GridViewProductDetails.Rows[i].FindControl("DropDownListNoOfItems");
                        int tp = int.Parse(lppri.Text) * int.Parse(lpnoi.SelectedItem.ToString());
                        DataRow dr = dt.NewRow();
                        dr[0] = int.Parse(lpid.Text);
                        dr[1] = lpdet.Text;
                        dr[2] = int.Parse(lppri.Text);
                        dr[3] = int.Parse(lpnoi.Text);
                        dr[4] = tp;                      
                        dt.Rows.Add(dr);
                        
                    }
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();

            //for (int j = 0; j < GridView1.Rows.Count; j++)
            //{
            //    Label ltp = (Label)GridView1.Rows[j].FindControl("tp");
            //    int ltpri = ltpri + ltp(j);
            //}

            //float totSal = 0;
            //bool flag = false;
            //for (int i = 0; i < GridViewProductDetails1.Rows.Count; i++)
            //{
            //    CheckBox ch = (CheckBox)GridViewProductDetails1.Rows[i].FindControl("CheckBoxSelectProduct");
            //    if (ch.Checked == true)
            //    {
            //        Label l = (Label)GridViewProductDetails1.Rows[i].FindControl("Label1");
            //        int sl = int.Parse(l.Text);
            //        //Alternative
            //        //int sl = int.Parse(GridView1.Rows[i].Cells[3].Text);
            //        totSal = totSal + sl;
            //        flag = true;
            //    }
            //}
            //if (flag == true)
            //    Label1.Text = totSal.ToString();
            //else
            //    Label1.Text = "Please Select any rows for calculating total salary";
        }
    }
}