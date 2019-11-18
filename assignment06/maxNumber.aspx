<!--
	FILE			:	maxNumber.aspx
	PROJECT			:	PROG2001 - Assignment 6
	PROGRAMMER		:	Amy Dayasundara, Paul Smith
	FIRST VERSION	:	November 15, 2019
	DESCRIPTION		:	
		This file is created to make for the user to choose their max
        number for HiLo.
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maxNumber.aspx.cs" Inherits="assignment06.maxNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Choose max number</title>
    <style type="text/css">
    body
    {
        padding-top:150px;
        background-color:orange;

    }
    form 
    {
        float: left;      
        text-align:center;
        width:auto;           
        align-items:center;
        border: groove #FF00FF;
        background-color:aqua;
        display:inline;
        border-style:dashed;
    }
    h1
    {
        display:inline;
    }
    .column 
    {
        float: left;
        width: 33.33%;
        padding: 5px;
    }
</style>

</head>
<body>
    <div class="column"></div>
    <form class="column" id="maxNumb" runat="server">
        <h1 style="padding:5px;">Max Number Choice!</h1>
        <div>
            <br />
            <asp:Label ID="welcomeToGame" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="maxValue" Width="190px" />
            <br />
<%--            <asp:CustomValidator ID="CustomValidator1" Text="*" runat="server" ControlToValidate="maxValue" Display="Dynamic"></asp:CustomValidator>--%>
             <asp:Label ID="errorLabel" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="submitNumb" runat="server" Text="Submit" OnClick="submitNumb_Click" />
            <br />
        </div>
    </form>
    <div class="column"></div>
</body>
</html>
