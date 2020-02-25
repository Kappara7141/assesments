<%@ Page Language="C#" MasterPagefile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courseinsert.aspx.cs" Inherits="Crudoperationwebform.Courseinsert" %>

<asp:Content ID="Crudoperationwebform" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jambotran">
       
       <asp:Label ID="label1" runat="server" Text="enter course id"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
           
            <asp:Label ID="label2" runat="server" Text="enter course name"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Label ID="label3" runat="server" Text="enter fees"></asp:Label><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button_submit"  /><br />
    </div>
</asp:Content>

