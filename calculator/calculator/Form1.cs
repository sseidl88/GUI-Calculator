using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private Button[] buttons;


        Double resultValue = 0;
        String opperationPerformed = "";
        bool isOperationPerformed = false;


        public Form1()
        {
            InitializeComponent();
            buttons = new Button[10];
            buttons[0] = button_0;
            buttons[1] = button_1;
            buttons[2] = button_2;
            buttons[3] = button_3;
            buttons[4] = button_4;
            buttons[5] = button_5;
            buttons[6] = button_6;
            buttons[7] = button_7;
            buttons[8] = button_8;
            buttons[9] = button_9;

            buttons[0].Click += new EventHandler(numberClick);
            buttons[1].Click += new EventHandler(numberClick);
            buttons[2].Click += new EventHandler(numberClick);
            buttons[3].Click += new EventHandler(numberClick);
            buttons[4].Click += new EventHandler(numberClick);
            buttons[5].Click += new EventHandler(numberClick);
            buttons[6].Click += new EventHandler(numberClick);
            buttons[7].Click += new EventHandler(numberClick);
            buttons[8].Click += new EventHandler(numberClick);
            buttons[9].Click += new EventHandler(numberClick);
        }

        private void numberClick(object sender, EventArgs e)
        {
            equals.Enabled = true;

            if (isOperationPerformed)
            {
                answerText.Clear();
            }
            
            if (answerText.Text.Length < 20)
            {
              
                Button b = (Button)sender;
                answerText.Text += b.Text;
            }
            else
            {
                answerText.Text = ("Number too large");
                for (int i = 0; i < 10; i++)
                {
                    buttons[i].Enabled = false;
                }
            }
            isOperationPerformed = false;
        }

        private void clearClick(object sender, EventArgs e)
        {
            answerText.Text = "";
            for (int i = 0; i < 10; i++)
            {
                buttons[i].Enabled = true;
            }
            resultValue = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //  equals.Enabled = true;
            if (resultValue != 0)
            {
                if (equals.Enabled == false)
                {
                  //  equals.PerformClick();
                    opperationPerformed = button.Text;
                    //resultValue = Double.Parse(answerText.Text);
                    //labelCurrentOperation.Text = resultValue + "" + operationPerformed;
                    isOperationPerformed = true;
                }
                else
                {
                    opperationPerformed = button.Text;
                    resultValue = Double.Parse(answerText.Text);
                    //labelCurrentOperation.Text = resultValue + "" + operationPerformed;
                    isOperationPerformed = true;
                }
            }else
            {
                equals.Enabled = true;
                opperationPerformed = button.Text;
                resultValue = Double.Parse(answerText.Text);
                isOperationPerformed = true;
            }
            /*
            opperationPerformed = button.Text;
            resultValue = Double.Parse(answerText.Text);
            //labelCurrentOperation.Text = resultValue + "" + operationPerformed;
            isOperationPerformed = true;
            */




/*
          //  resultValue = Double.Parse(answerText.Text);
            isOperationPerformed = true;

            if (resultValue != 0){
                if(equals.Enabled == false)
                {
                   // answerText.Text = "";
                    equals.Enabled = true;
                    //  opperationPerformed = true;
                    isOperationPerformed = true;
                }
                else {
                    String temp = button.Text;
                    //answerText.Text = temp;
                    
                    switch (opperationPerformed)
                    {
                        case "+":
                            answerText.Text = (resultValue + Double.Parse(answerText.Text)).ToString();
                            break;
                        case "-":
                            answerText.Text = (resultValue - Double.Parse(answerText.Text)).ToString();
                            break;
                        case "/":
                            answerText.Text = (resultValue / Double.Parse(answerText.Text)).ToString();
                            break;
                        case "*":
                            answerText.Text = (resultValue * Double.Parse(answerText.Text)).ToString();
                            break;
                        default:
                            break;
                    } // end of switch

                    resultValue = Double.Parse(answerText.Text);
                    opperationPerformed = button.Text;
                    isOperationPerformed = true;
                }
            }else {

                opperationPerformed = button.Text;
                resultValue = Double.Parse(answerText.Text);
                isOperationPerformed = true;
            }

*/
        }

        private void equals_Click(object sender, EventArgs e)
        {
           



            if (answerText.Text.Length > 20)
            {
                //Console.WriteLine("Number too large");
                answerText.Text = ("Number too large");
                for (int i = 0; i < 10; i++)
                {
                    buttons[i].Enabled = false;
                }
            }
            else
            {


                switch (opperationPerformed)
                {
                    case "+":
                        answerText.Text = (resultValue + Double.Parse(answerText.Text)).ToString();
                        break;
                    case "-":
                        answerText.Text = (resultValue - Double.Parse(answerText.Text)).ToString();
                        break;
                    case "*":
                        answerText.Text = (resultValue * Double.Parse(answerText.Text)).ToString();
                        break;
                    case "/":
                        answerText.Text = (resultValue / Double.Parse(answerText.Text)).ToString();
                        break;
                    default:
                        break;
                }
                resultValue = Double.Parse(answerText.Text);
                equals.Enabled = false;
            }
        }
        /*
private void add(object sender, EventArgs e)
{

}
*/
    }
}
