<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enter.aspx.cs" Inherits="Wst.Admin.Enter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
            td,tr {
                margin:20px 10px;
                padding:0px;
                border:0px;
                display:block;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="border-style: solid; border-color: inherit; border-width: 1px; width:344px; height:210px; margin:150px 500px; ">
            <tr><td><asp:TextBox runat="server" Width="300px" ID="UseName" Height="30px">帐号：</asp:TextBox></td></tr>
            <tr><td><asp:TextBox runat="server" Width="300px" ID="PassWord" Height="30px">密码：</asp:TextBox></td></tr>
            <tr><td><asp:Button ID="Button1" Width="103px" runat="server" Text="登录" Height="43px" OnClick="Button1_Click" /></td></tr>
        </table>
    </form>
</body>
</html>
