<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertRec.aspx.cs" Inherits="Traineeeapp.InsertRec" %>
<asp:Content ID="traineeData" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jambotran">
        <asp:Label ID="label1" runat="server" Text="enter trainee id"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
       
           
            <asp:Label ID="label2" runat="server" Text="enter trainee name"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Label ID="label3" runat="server" Text="enter trainee location"></asp:Label><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:Label ID="label4" runat="server" Text="enter trainee techdomain"></asp:Label><br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Label ID="label5" runat="server" Text="enter trainee StartDate"></asp:Label><br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button_submit"  /><br />
    </div>
</asp:Content>


