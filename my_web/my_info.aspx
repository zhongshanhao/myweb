<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my_info.aspx.cs" Inherits="my_web.my_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <%--<form action="use_to_change_my_information.ashx?ID=<%=student_info.Rows[0]["ID"]%>" method="post">--%>

    <form action="my_info2.aspx" method="post">
    <div>
        <h1>用户名：<%=id %></h1>
<%--        <p>姓名：<%=dt.Rows[0]["name"].ToString() %></p>
        <p>性别：<%=xingbie %></p>
        <p>年龄：<%=age %></p>       
    </div>--%>
        </div>
        <table border="1">
            <tr>
                <th>用户名</th>
                <th>姓名</th>
                <th>性别</th>
                <th>年龄</th>
            </tr>
             
               <% for (int j = 0; j < da.Rows.Count; j++){%>
                 <tr>
                <td><%=da.Rows[j]["id"].ToString() %></td>
                <td><%=da.Rows[j]["name"].ToString() %></td>
                <td><%=da.Rows[j]["xingbie"].ToString() %></td>
                <td><%=da.Rows[j]["age"].ToString() %></td>              
              <%--  <td><button onclick="button1()">删除</button></td>  --%>
                <td> <th><a href="delete.ashx?id=<%=da.Rows[j]["id"] %>"><h4 align="center" style="color:"><%="删除"%></h4></a></th></td>
                     <td> <th><a href="change.aspx?id=<%=da.Rows[j]["id"] %>"><h4 align="center" style="color:"><%="编辑"%></h4></a></th></td>               
            </tr> <%} %>
            
        </table>
        <td style="width: 151px">
       <%-- <input onclick="button1()" id="Submit1" type="submit" value="删除数据" name="Submit1"/></td>
        <button onclick="button2()">修改数据</button>--%>
    </form>
</body>
</html>
<script type="text/javascript">
  


    //function button1()
    //{
    //    var t = prompt("请输入你要删除的用户名", "");
        
    //    Response.SetCookie(new HttpCookie("t", t.ToString()));
    //   // location.href = 'my_info2.aspx';
       
        
    //}

</script>