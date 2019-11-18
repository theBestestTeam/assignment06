/*
*	FILE			:	maxNumber.aspx.ca
*   PROJECT         :	PROG2001 - Assignment 6
*	PROGRAMMER		:	Amy Dayasundara, Paul Smith
*   FIRST VERSION	:	November 15, 2019
*	DESCRIPTION		:	
*		This file is contain the logic for the users input for 
*		max value. If the value is not greater than one, the 
*		logic will request the user to input an appropriate value.
*/

using System;
using System.Text.RegularExpressions;

namespace assignment06
{
    public partial class maxNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This logic will display the users name and ask them to enter an appropriate value
            string userName = Session["userName"].ToString();
            welcomeToGame.Text = "Hi " +userName+". Please choose a number greater than 1!";
        }

        protected void submitNumb_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            //check to see if the value is empty
            if(maxValue.Text.Trim() == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Please enter a number";
                //CustomValidator1.ErrorMessage = "Please enter a number";
            }
            //Check to see if the value is one
            else if(maxValue.Text.Trim() == "1")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Please enter a number greater than 1.";

                //CustomValidator1.ErrorMessage = "Please enter a value greater than 1";
                //CustomValidator1.Text = CustomValidator1.ErrorMessage;
            }
            else
            {
                //Make sure the value is a numeric value
                if (Regex.IsMatch(maxValue.Text, @"^[0-9]+$"))
                {
                    int convertToInt = 0;

                    if(Int32.TryParse(maxValue.Text, out convertToInt))
                    {
                        //Make sure value is greater than 1
                        if(convertToInt < 1)
                        {
                            errorLabel.Visible = true;
                            errorLabel.Text = "Please enter a number greater than 1.";

                            //CustomValidator1.ErrorMessage = "Please enter a value greater than 1.";
                        }
                        //Is all requirements met, the value is saved in session and moved to next page
                        else
                        {
                            Session["maxValue"] = maxValue.Text;
                            Server.Transfer("gameTime.aspx");
                        }

                    }
                }
                //If not, display error value
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Please enter a number";

                    //CustomValidator1.ErrorMessage = "Please enter a number.";
                }

            }
        }
    }
}