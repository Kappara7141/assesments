<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Crudoperationwebform._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
        <p><a href="InsertRec.aspx" class="btn btn-primary btn-lg">insert student data &raquo;</a></p>
        <p><a href="Courseinsert.aspx" class="btn btn-primary btn-lg">insert course data &raquo;</a></p>
        <p><a href="facultyinsert.aspx" class="btn btn-primary btn-lg">insert faculty data &raquo;</a></p>
        <p><a href="SelectRec.aspx" class="btn btn-primary btn-lg">display student data &raquo;</a></p>
        <p><a href="Displaycoursedetails.aspx" class="btn btn-primary btn-lg">display course data &raquo;</a></p>
        <p><a href="displayfaculty.aspx" class="btn btn-primary btn-lg">display faculty data &raquo;</a></p>
         <p><a href="Updatestudent.aspx" class="btn btn-primary btn-lg">update student data &raquo;</a></p>
        <p><a href="updatecoursedetails.aspx" class="btn btn-primary btn-lg">update course data &raquo;</a></p>
         <p><a href="Updatefaculty.aspx" class="btn btn-primary btn-lg">update faculty data &raquo;</a></p>
        <p><a href="DeleteStudent.aspx" class="btn btn-primary btn-lg">Delete student data &raquo;</a></p>
        <p><a href="DeleteCourse.aspx" class="btn btn-primary btn-lg">Delete course data &raquo;</a></p>
         <p><a href="DeleteFaculty.aspx" class="btn btn-primary btn-lg">Delete faculty data &raquo;</a></p>
       
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
