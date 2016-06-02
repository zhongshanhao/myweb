using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace my_web
{
    /// <summary>
    /// login 的摘要说明
    /// </summary>
    public class login : IHttpHandler
    {
        public void  ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string str = context.Request["use"];
            string str1 = context.Request["password3"];          
            DataTable ds = Sqlhelper1.ExecuteDataTable("select * from student where id=@id and  keys=@keys", new SqlParameter("@id", str), new SqlParameter("@keys", str1));
            if (ds.Rows.Count == 1)
            {
                context.Response.Write("ok");
                foreach (DataRow row in ds.Rows)
                {
                    int id = (int)row["id"];
                    string keys = (string)row["keys"];
                    string name = (string)row["name"];
                    string xingbie = row["xingbie"].ToString();
                    int age = (int)row["age"];                
                    context.Response.SetCookie(new HttpCookie("id", id.ToString()));
                    //context.Response.SetCookie(new HttpCookie("name", name.ToString()));
                    //context.Response.SetCookie(new HttpCookie("xingbie", xingbie.ToString()));
                    //context.Response.SetCookie(new HttpCookie("age", age.ToString()));
                    //context.Response.Redirect("my_info.aspx");
                    //context.Response.Write("姓名:" + name + "性别:" + xingbie + "年龄:" + age + "\n账号:" + id + "\n密码:" + keys);
                }
            }
            else
                context.Response.Write("error");
            
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}