﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteStudent.aspx.cs" Inherits="Crudoperationwebform.DeleteStudent" %>
<asp:Content ID="Crudoperationwebform" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jambotran">
       
    <asp:Label ID="label1" runat="server" Text="enter student id"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button_submit"  /><br />
        </div>
    </asp:Content>
