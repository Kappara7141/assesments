<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateRec.aspx.cs" Inherits="Traineeeapp.UpdateRec" %>
<asp:Content ID="Updatedata" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="enter ID"></asp:Label><br />
    
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="enter domain"></asp:Label><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Update" onclick="UPDATE_ButtonSubmit"/>
</asp:Content>

