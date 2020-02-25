<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertRec.aspx.cs" Inherits="Crudoperationwebform.InsertRec" %>

<asp:Content ID="Crudoperationwebform" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jambotran">
       
       <asp:Label ID="label1" runat="server" Text="enter student id"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
           
            <asp:Label ID="label2" runat="server" Text="enter student name"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Label ID="label3" runat="server" Text="enter student address"></asp:Label><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:Label ID="label4" runat="server" Text="enter course id"></asp:Label><br />
            
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button_submit"  /><br />
    </div>
</asp:Content>


