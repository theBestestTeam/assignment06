/*
*	FILE			:	winnerPage.aspx.ca
*   PROJECT         :	PROG2001 - Assignment 6
*	PROGRAMMER		:	Amy Dayasundara, Paul Smith
*   FIRST VERSION	:	November 15, 2019
*	DESCRIPTION		:	
*		This file is contain the code that will resart the game from
*		the user inputting a max value.
*/

using System;

namespace assignment06
{
    public partial class winnerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Play again event
        protected void playAgain_Click(object sender, EventArgs e)
        {
            //Clear all session variables except name
            Session.Remove("minValue");
            Session.Remove("maxValue");
            Session.Remove("randomValue");
            Server.Transfer("maxNumber.aspx");
        }
    }
}