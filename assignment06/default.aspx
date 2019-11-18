<!--
	FILE			:	default.aspx
	PROJECT			:	PROG2001 - Assignment 6
	PROGRAMMER		:	Amy Dayasundara, Paul Smith
	FIRST VERSION	:	November 15, 2019
	DESCRIPTION		:	
		This file is created as the start page for the HiLo game.
        The user is required to enter their name only using alphabets.
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="assignment06._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 06</title>
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
    <form class="column" id="IntroForm" runat="server">
        <h1>Welcome to the HiLo game!</h1>
        <div>
            <br />
            <asp:Label ID="Name" runat="server" Text="What is your name?" />
            <br />
            <asp:TextBox runat="server" ID="namePrompt" Width="150px" />
            <br />
<%--        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="namePrompt" Display="None"></asp:CustomValidator>--%>
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="namePrompt" ValidateEmptyText="true" Display="Dynamic"></asp:RequiredFieldValidator>--%>
             <asp:Label ID="errorLabel" runat="server" ForeColor="Red" Visible="False"></asp:Label>

            <br />
            <asp:Button ID="checkInput" runat="server" Text="Submit" OnClick="checkInput_Click" />
        </div>
    </form>
    <div class="column"></div>
</body>
</html>
