<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Updatestudent.aspx.cs" Inherits="Crudoperationwebform.Updatestudent" %>

<asp:Content ID="id73" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Label ID="label1" runat="server" Text="enter student id"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
     <asp:Label ID="label2" runat="server" Text="enter student name"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button_submit"  /><br />
</asp:Content>