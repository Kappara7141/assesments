<%@ Page Language="C#" AutoEventWireup="true"MasterPageFile="~/Site.Master" CodeBehind="TraineeData.aspx.cs" Inherits="Trainee.TraineeData" %>

<asp:Content ID="traineeData" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">
		
		<asp:GridView ID="trainerDataGrid" runat="server"></asp:GridView>

	</div>
	 <p><a href="TraineeSearch.aspx" class="btn btn-primary">Trainee Search</a>
	 <p><a href="InsertTrainee.aspx" class="btn btn-primary">Add Trainee</a>

</asp:Content>
