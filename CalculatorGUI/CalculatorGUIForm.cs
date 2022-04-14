using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// author: Sarah Eubank
/// creation date: 4/13/2022
/// last modified: 4/14/2022
/// program for a GUI calculator that can add, subtract, multiply, divide, square root, log base 10, log variable base, 
/// variable exponent, find the min and max of two numbers, reverse a string, remove whitespace from a string, find the quadratic roots,
/// and find the quotient and the remainder of two numbers.
/// </summary>

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
        string userInput = "";
        string first = "";
        string second = "";
        string third = "";
        char operation;
        double result = 0;

      public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "0" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zeroButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "0";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "1" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oneButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "1";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "2" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void twoButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "2";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "3" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void threeButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "3";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "4" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fourButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "4";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "5" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fiveButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "5";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "6" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sixButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "6";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "7" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sevenButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "7";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "8" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eightButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "8";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "9" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nineButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "9";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "." button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decimalButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += ".";
            display.Text += userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "/" (the divide) button is pressed.
        /// assigns first and resets userInput for second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divideButton_Click(object sender, EventArgs e)
        {
            operation = '/';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "x" (the mulitplication) button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void muliplicationButton_Click(object sender, EventArgs e)
        {
            operation = '*';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "-" (the subtract) button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minusButton_Click(object sender, EventArgs e)
        {
            operation = '-';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "+" (the add) button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plusButton_Click(object sender, EventArgs e)
        {
            operation = '+';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/14/2022
        /// if the "=" (the equal) button is pressed. program preforms the operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;

            //addition
            if (operation == '+')
            {
                if (result != 0)
                {
                    firstNum = result;
                    secondNum = Convert.ToDouble(second);
                    result = firstNum + secondNum;
                    display.Text = result.ToString();
                }
                else
                {
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum + secondNum;
                    display.Text = result.ToString();
                }
            }
            //subtraction
            else if (operation == '-')
            {
                if (result != 0)
                {
                    firstNum = result;
                    secondNum = Convert.ToDouble(second);
                    result = firstNum - secondNum;
                    display.Text = result.ToString();
                }
                else
                {
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum - secondNum;
                    display.Text = result.ToString();
                }
            }
            //multiplication
            else if (operation == '*')
            {
                if (result != 0)
                {
                    firstNum = result;
                    secondNum = Convert.ToDouble(second);
                    result = firstNum * secondNum;
                    display.Text = result.ToString();
                }
                else
                {
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = firstNum * secondNum;
                    display.Text = result.ToString();
                }
            }
            //division
            else if (operation == '/')
            {
                if (result != 0)
                {
                    firstNum = result;
                    secondNum = Convert.ToDouble(second);
                    result = firstNum / secondNum;
                    display.Text = result.ToString();
                }
                else
                {
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);

                    //can't divide by 0
                    if (secondNum == 0)
                    {
                        display.Text = "Divide by 0 error.";
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        display.Text = result.ToString();
                    }
                }
            }
            //logx
            else if (operation == '$')
            {
                if (result != 0)
                {
                    firstNum = result;
                    secondNum = Convert.ToDouble(second);
                    result = Math.Log(firstNum, secondNum);
                    display.Text = result.ToString();
                }
                else
                {
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = Math.Log(firstNum, secondNum);
                    display.Text = result.ToString();
                }
            }

            //power
            else if (operation == '^')
            {
                if (result != 0)
                {
                    firstNum = result;
                    secondNum = Convert.ToDouble(second);
                    result = Math.Pow(firstNum, secondNum);
                    display.Text = result.ToString();
                }
                else
                {
                    firstNum = Convert.ToDouble(first);
                    secondNum = Convert.ToDouble(second);
                    result = Math.Pow(firstNum, secondNum);
                    display.Text = result.ToString();
                }
            }

            //quotient and remainder
            else if (operation == '&')
            {
                int dividend, divisor, quotient, remainder;
                if (result != 0)
                {
                    dividend = Convert.ToInt32(result);
                    divisor = Convert.ToInt32(second);
                    quotient = Math.DivRem(dividend, divisor, out remainder);
                    display.Text = quotient.ToString() + "  Remainder:" + remainder.ToString();
                }
                else
                {
                    dividend = Convert.ToInt32(first);
                    divisor = Convert.ToInt32(second);
                    quotient = Math.DivRem(dividend, divisor, out remainder);
                    display.Text = quotient.ToString() + "  Remainder:" + remainder.ToString();
                }
            }

            //min max
            //user must press "C" button (clear) after this operation
            else if (operation == '!')
            {
                double min, max;

                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);
                min = Math.Min(firstNum, secondNum);
                max = Math.Max(firstNum, secondNum);
                display.Text = "Min: " + min.ToString() + "  Max: " + max.ToString();
            }
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/14/2022
        /// if the "sqr" (the square root) button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void squareRootButton_Click(object sender, EventArgs e)
        {
            double firstNum;
            first = userInput;
            userInput = "";

            if (result != 0)
            {
                firstNum = result;
                result = Math.Sqrt(firstNum);
                display.Text = result.ToString();
            }
            else
            {
                firstNum = Convert.ToDouble(first);
                result = Math.Sqrt(firstNum);
                display.Text = result.ToString();
            }
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/14/2022
        /// if the "log10" (the log base 10) button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void log10Button_Click(object sender, EventArgs e)
        {
            double firstNum;
            first = userInput;
            userInput = "";

            if (result != 0)
            {
                firstNum = result;
                result = Math.Log10(firstNum);
                display.Text = result.ToString();
            }
            else
            {
                firstNum = Convert.ToDouble(first);
                result = Math.Log10(firstNum);
                display.Text = result.ToString();
            }
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "logx" (the log of any base) button is pressed.
        /// the second number entered is the base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logxButton_Click(object sender, EventArgs e)
        {
            operation = '$';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/14/2022
        /// if the "quad. roots" (the quadratic roots) button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/14/2022
        /// if the "reverse" (the reverse a string) button is pressed.
        /// can only take one string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reverseButton_Click(object sender, EventArgs e)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            userInput = "";

            foreach (char ch in charArray)
            {
                userInput += ch;
            }

            display.Text = userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/14/2022
        /// last modified: 4/14/2022
        /// a button that inserts spaces into the userInput.
        /// allows functionality to removed spaces and quadratic roots.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spaceButton_Click(object sender, EventArgs e)
        {
            userInput += ' ';
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/14/2022
        /// if the "remove spaces" (the remove whitespace) button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeSpaceButton_Click(object sender, EventArgs e)
        {
            char[] charArray = userInput.ToCharArray();
            userInput = "";

            foreach (char ch in charArray)
            {
                if (ch != ' ')
                {
                    userInput += ch;
                }
            }

            display.Text = userInput;
        }

        /// <summary>
        /// author: Sarah Eubank
        /// creation date: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "quotient remainder" button is pressed
        /// function finds the quotient and the remainder of two numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            operation = '&';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// creation date: 4/13/2022
        /// last modified: 4/13/2022
        /// if the min max button is pressed
        /// finds the minimum and the maximum of two numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minmaxButton_Click(object sender, EventArgs e)
        {
            operation = '!';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// creation date: 4/13/2022
        /// last modified: 4/13/2022
        /// what happens if the "pwr" (the power) button is pressed.
        /// allows user to raise any number to any power.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void powerButton_Click(object sender, EventArgs e)
        {
            operation = '^';
            first = userInput;
            userInput = "";
        }

        /// <summary>
        /// author: Sarah Eubank
        /// date created: 4/13/2022
        /// last modified: 4/13/2022
        /// if the "C" (the clear) button is pressed.
        /// erases the display and all stored info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            result = 0;
            userInput = "";
            display.Text = "";
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/