<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="change.aspx.cs" Inherits="my_web.change" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="change.ashx" id="login" method="get">
    <div>
     <p>用户名："<%=dt.Rows[0]["id"]%>"</p>
           <%-- <input type="text" id="usr" name="id" value="<%=dt.Rows[0]["id"]%>"/>--%>
            <p>密码：</p>           
            <input type="text" id="Password1" name="password5" value="<%=dt.Rows[0]["keys"]%>"/>
             <p>姓名：</p>
            <input type="text" id="Password2" name="password6" value="<%=dt.Rows[0]["name"]%>"/>
             <p>性别：</p>
            <input type="text" id="Password3" name="password7" value="<%=dt.Rows[0]["xingbie"]%>"/>
             <p>年龄：</p>
            <input type="text" id="Password4" name="password8" value="<%=dt.Rows[0]["age"]%>"/>
            <br />
        <button >修改</button>
            <br />
    </div>
    </form>
</body>
</html>
