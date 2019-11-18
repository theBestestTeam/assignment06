/*
*	FILE			:	gameTime.aspx.ca
*   PROJECT         :	PROG2001 - Assignment 6
*	PROGRAMMER		:	Amy Dayasundara, Paul Smith
*   FIRST VERSION	:	November 15, 2019
*	DESCRIPTION		:	
*		This file is contain the code behind for the game logic.
*		It checks and updates the value according to if the user
*		guesses a number below the random value or above the random 
*		value to +/- the guessed number.
*/

using System;

namespace assignment06
{
    public partial class gameTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Session["userName"].ToString();
            string maxNumber = Session["maxValue"].ToString();
            int maxIntNumber = 0;

            //Setup initial page load
            if (IsPostBack == false)
            {
                int randNumb = 0;
                guessTime.Text = userName + ", guess a number between 1 and " +maxNumber+ ".";
                
                //Convert to int to generate a random number between 1 and max
                Int32.TryParse(maxNumber, out maxIntNumber);
                
                Random rnd = new Random();
                randNumb = rnd.Next(1, maxIntNumber);

                //Convert to string for comparisons
                string randStr = randNumb.ToString();
                string minNumber = "1";

                //Store values
                Session["randomValue"] = randStr;
                Session["minValue"] = minNumber;
            }

        }

        protected void submitGuess_Click(object sender, EventArgs e)
        {
            int guessNumb = 0;
            int minNumber = 0;
            int maxNumber = 0;
            int randomValue = 0;
            errorLabel.Visible = false;
            
            //Change values to int
            Int32.TryParse(Session["minValue"].ToString(), out minNumber);
            Int32.TryParse(Session["maxValue"].ToString(),out maxNumber);
            Int32.TryParse(Session["randomValue"].ToString(), out randomValue);
            Int32.TryParse((guessNumber.Text.Trim()).ToString(), out guessNumb);

            if(randomValue == guessNumb)
            {
                //Win
                Server.Transfer("winnerPage.aspx");

            }
            else if(guessNumb < minNumber || guessNumb > maxNumber)
            {
                //Enter number within range -- do error check
                errorLabel.Text = "Please enter a value within the " + minNumber + " and " + maxNumber;
                errorLabel.Visible = true;
            }
            else if(guessNumb < randomValue && guessNumb >= minNumber)
            {
                //Shift min number to current number +1
                minNumber = ++guessNumb;
                Session["minValue"] = minNumber.ToString();
                guessAgain();
            }
            else if(guessNumb > randomValue && guessNumb <= maxNumber)
            {
                //Shift max to current number -1
                maxNumber = --guessNumb;
                Session["maxValue"] = maxNumber.ToString();
                guessAgain();

            }
        }

        public void guessAgain()
        {
            string maxValue = Session["maxValue"].ToString();
            string minValue = Session["minValue"].ToString();

            //Show new guessing numbers
            guessTime.Text = "Please try again. Choose a number between " +minValue+ " and " +maxValue+".";
            //Clear text box
            guessNumber.Text = "";
        }
    }
}