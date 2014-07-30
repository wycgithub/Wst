<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Wst.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr><td>
          <a>用户名</a> <asp:TextBox runat="server" ID="UseName" ></asp:TextBox></td></tr>
        <tr><td><a>密码</a><asp:TextBox runat="server" ID="PassWord"></asp:TextBox></td></tr>
        <tr><td><asp:Button  runat="server" ID="Button1" Text="确认"  OnClick="Button1_Click"/></td></tr>
    </table>
</asp:Content>
