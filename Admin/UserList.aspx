<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Wst.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater runat="server" ID="Repeater1">
        <HeaderTemplate>
            <table>
            <tr><th>用户名</th><th>密码</th>
                <th>创建时间</th>
                <th>上一次登录时间</th>
            </tr>
        </HeaderTemplate>
       <ItemTemplate>
           <tr>
               <td><%#Eval("UserName")%></td>
               <td><%#Eval("UserPwd")%></td>
                <td><%#Eval("UserName")%></td>
               <td><%#Eval("UserPwd")%></td>
               <td><asp:Button ID="ModButton" runat="server" Text="修改" OnClick="ModButton_Click" /></td>
               <td><asp:Button ID="DelButton" runat="server" Text="删除" CommandArgument='<% #Eval("UserID") %>' OnClick="DelButton_Click"/></td>
           </tr>
       </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
