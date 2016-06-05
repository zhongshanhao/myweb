using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace my_web
{
    /// <summary>
    /// zzzz 的摘要说明
    /// </summary>
    public class zzzz : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           // context.Response.Write("Hello World");
            context.Response.ContentType = "text/html";
            string str2 = context.Request["use1"];
            string str3 = context.Request["password4"];
            string str4 = context.Request["password5"];
            string str5 = context.Request["password6"];
            string str6 = context.Request["password7"];
            string str7 = context.Request["password8"];
          
            if (str3 != str4)
                context.Response.Write("<script>alert('两次输入密码不一致！！');location.href = 'register.ashx';</script>");
            else
            {
                Sqlhelper1.ExecuteScalar("insert into student (id,keys,name,xingbie,age)values (@id,@keys,@name,@xingbie,@age)", new SqlParameter("@id", str2), new SqlParameter("@keys", str3), new SqlParameter("@name", str5), new SqlParameter("@xingbie", str6), new SqlParameter("@age", str7));
                context.Response.Write("<script>alert('注册成功 ');location.href = '../html/login.html';</script>");
            }

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