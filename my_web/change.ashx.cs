using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace my_web
{
    /// <summary>
    /// change1 的摘要说明
    /// </summary>
    public class change1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentType = "text/html";
            string id = context.Request["id"];          
            string keys = context.Request["password5"];
            string name = context.Request["password6"];
            string xingbie = context.Request["password7"];
            string age = context.Request["password8"];
            Sqlhelper1.ExecuteScalar("delete from student where id=@id", new SqlParameter("@id", id));           
            Sqlhelper1.ExecuteScalar("insert into student (id,keys,name,xingbie,age)values (@id,@keys,@name,@xingbie,@age)", new SqlParameter("@id", id), new SqlParameter("@keys", keys), new SqlParameter("@name", name), new SqlParameter("@xingbie", xingbie ), new SqlParameter("@age", age));              
            context.Response.Write("<script>confirm('修改成功');</script>");
           
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