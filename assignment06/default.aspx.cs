/*
*	FILE			:	default.aspx.ca
*   PROJECT         :	PROG2001 - Assignment 6
*	PROGRAMMER		:	Amy Dayasundara, Paul Smith
*   FIRST VERSION	:	November 15, 2019
*	DESCRIPTION		:	
*		This file is contain the checks to make sure the user inputs a name.
*		The name must be letters only.
*/

using System;
using System.Web.UI;
using System.Text.RegularExpressions;

namespace assignment06
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

            }
            else
            {
                errorLabel.Visible = false;
                //Check to see if only letters were entered
                //If appropriately entered, the next page is loaded and the user's
                //name is saved
                if (Regex.IsMatch(namePrompt.Text.Trim(), @"^[A-Za-z\s]+$"))
                {
                    Session["userName"] = namePrompt.Text;
                    Server.Transfer("maxNumber.aspx");

                }
                //Check to see if string is empty
                else if ((namePrompt.Text.Trim()) == "")
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Please enter a name in using letters.";
                    //RequiredFieldValidator1.ErrorMessage = "Please enter appropriate characters";
                    namePrompt.Text = "";
                }
                //If the conditions are not met an error message is displayed
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Please enter letters only";
                    //RequiredFieldValidator1.ErrorMessage = "Please enter letters only.";
                    namePrompt.Text = "";
                }
            }
        }

        protected void checkInput_Click(object sender, EventArgs e)
        {
            //if (namePrompt.Text.Trim() == "")
            //{
            //    RequiredFieldValidator1.ErrorMessage = "Please enter appropriate characters";
            //    namePrompt.Text = "";
            //}
            //else if (Regex.IsMatch(namePrompt.Text.Trim(), @"^[A-Za-z\s]+$"))
            //{
            //    Session["userName"] = namePrompt.Text;
            //    Server.Transfer("maxNumber.aspx");

            //}
            //else
            //{
            //    RequiredFieldValidator1.ErrorMessage = "Please enter letters only.";
            //    namePrompt.Text = "";
            //}

        }

        public StateBag ReturnViewState()
        {
            return ViewState;
        }
    }
}