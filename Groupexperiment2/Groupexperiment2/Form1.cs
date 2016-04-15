using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupexperiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pattern = "1352";
        string entered = "";
        public static int[] buttonvalues;
        Random rnd = new Random();
        int btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0;
        private void Form1_Load(object sender, EventArgs e)
        {
            shuffler();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[0];
            shuffler();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[1];
            shuffler();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[2];
            shuffler();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[3];
            shuffler();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[4];
            shuffler();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[5];
            shuffler();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[6];
            shuffler();
            //make variable for each button and randomize the value
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[7];
            shuffler();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[8];
            shuffler();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            entered = entered + buttonvalues[9];
            shuffler();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (pattern == entered)
            {
                MessageBox.Show("You've logged in");
            }
            else
            {
                MessageBox.Show("You've entered wrong pin");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            entered = "";
        }

        public void shuffler()
        {
            Button[] ButtonArray = { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9, btn_0 };
            buttonvalues = new int[]
                {
                    btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0,
                };
            //int[] buttonvalues = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0, };
            int tempnum;
            List<int> possiblevalues = new List<int>();
            
            possiblevalues.Add(1);
            possiblevalues.Add(2);
            possiblevalues.Add(3);
            possiblevalues.Add(4);
            possiblevalues.Add(5);
            possiblevalues.Add(6);
            possiblevalues.Add(7);
            possiblevalues.Add(8);
            possiblevalues.Add(9);
            possiblevalues.Add(0);

            for (int i = 0; i < 10; i++)
            {
                tempnum = rnd.Next(0, possiblevalues.Count);
                ButtonArray[i].Text = Convert.ToString(possiblevalues[tempnum]);
                buttonvalues[i] = possiblevalues[tempnum];
                possiblevalues.Remove(buttonvalues[i]);
            }
            
            


            /*btn_1.Text = Convert.ToString(btn1);
            btn_2.Text = Convert.ToString(btn2);
            btn_3.Text = Convert.ToString(btn3);
            btn_4.Text = Convert.ToString(btn4);
            btn_5.Text = Convert.ToString(btn5);
            btn_6.Text = Convert.ToString(btn6);
            btn_7.Text = Convert.ToString(btn7);
            btn_8.Text = Convert.ToString(btn8);
            btn_9.Text = Convert.ToString(btn9);*/
        }
    }
}
