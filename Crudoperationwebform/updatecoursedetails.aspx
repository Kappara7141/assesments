<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updatecoursedetails.aspx.cs" Inherits="Crudoperationwebform.updatecoursedetails" %>

<asp:Content ID="id73" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Label ID="label1" runat="server" Text="enter course id"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
     <asp:Label ID="label2" runat="server" Text="enter course name"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button_submit"  /><br />
</asp:Content>