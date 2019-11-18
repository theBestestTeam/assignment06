<!--
	FILE			:	winnerPage.aspx
	PROJECT			:	PROG2001 - Assignment 6
	PROGRAMMER		:	Amy Dayasundara, Paul Smith
	FIRST VERSION	:	November 15, 2019
	DESCRIPTION		:	
		This file is created tells the user that they are a winner.
        It also offers the current user the option to play the game again.
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winnerPage.aspx.cs" Inherits="assignment06.winnerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Winners land</title>
    <style type="text/css">
        
        body
        {
            padding-top:150px;
            background-color:lime;
            animation-name: winner;
            animation-duration:3s;
            animation-iteration-count:infinite;
        }
        @keyframes winner
        {
            from{background-color:lime;}
            to{background-color:darkorange;}
        }
        form 
        {
            float: left;      
            text-align:center;
            width:auto;           
            align-items:center;
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
    <form class="column" id="form1" runat="server">
    <div class="column"></div>
        <h1 style="background-color: #000000; color: #00FF00; font-variant: normal; font-style: normal; font-weight: bold; font-size: xx-large">You're a WINNER!</h1>
        <div>
            <asp:Label ID="Name" runat="server" Text="Would you like to play again?" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="playAgain" runat="server" Text="Play Again?" Onclick="playAgain_Click" />
        </div>
    </form>
    <div class="column"></div>
</body>
</html>
