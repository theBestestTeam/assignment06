<!--
	FILE			:	gameTime.aspx
	PROJECT			:	PROG2001 - Assignment 6
	PROGRAMMER		:	Amy Dayasundara, Paul Smith
	FIRST VERSION	:	November 15, 2019
	DESCRIPTION		:	
		This file is created this page is for the actual game 
        where the user guesses the number. 
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gameTime.aspx.cs" Inherits="assignment06.gameTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Time!!!</title>
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
            padding:5px;
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
    <form class="column" id="form1" runat="server">
        <h1>Game Time!</h1>
        <div>
            <br />
            <asp:Label ID="guessTime" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="guessNumber" runat="server" />
            <br />
            <asp:Label ID="errorLabel" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="submitGuess" runat="server" Text="Guess Number" Onclick="submitGuess_Click" />
        </div>
    </form>
    <div class="column"></div>

</body>
</html>
