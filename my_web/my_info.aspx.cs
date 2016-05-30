using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace my_web
{
    public partial class my_info : System.Web.UI.Page
    {
        public string id;
        public string name;
        public string xingbie;
        public string age;
        public DataTable dt;
        public DataTable da;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["id"];
            //HttpCookie cookie2 = Request.Cookies["name"];
            //HttpCookie cookie3 = Request.Cookies["xingbie"];
            //HttpCookie cookie4 = Request.Cookies["age"];
            id = cookie1.Value;
            dt = Sqlhelper1.ExecuteDataTable("select * from student where id=@id", new SqlParameter("@id", id));
            da = Sqlhelper1.ExecuteDataTable("select * from student ", new SqlParameter("@id", id));
            // (DataRow row in ds.Rows)
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                name = dt.Rows[i]["name"].ToString();
                xingbie = dt.Rows[i]["xingbie"].ToString();
                age = dt.Rows[i]["age"].ToString();
            }
            // id = cookie1.Value;
            //name = cookie2.Value;
            //xingbie = cookie3.Value;
            // age = cookie4.Value;
            
        }
    }
    //public class  : IHttpHandler
    //{
    //    public void ProcessRequest(HttpContext context)
    //    {          
    //             context.Response.ContentType = "text/html";
    //            Sqlhelper1.ExecuteNonQuery("delete from student where id =‘t’");
    //            context.Response.Write("<script>alert('用户名或密码错误');</script>"); 


    //    }
    //}
        // public  button1(HttpContext t)
        //{ 
        //    Sqlhelper1.ExecuteNonQuery("delete from student where id =‘t’");
        
        //}
}