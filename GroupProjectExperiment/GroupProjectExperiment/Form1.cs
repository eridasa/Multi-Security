using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroupProjectExperiment
{   //start of namespace
    public partial class Form1 : Form
    {   //start of class
        public static char[,] randomizer;
        string randomizedPassword = "";
        public Form1()
        {   //start of form1
            InitializeComponent();
        }   //end of form1

        public void Form1_Load(object sender, EventArgs e)
        {   //start of form1 load
           randomizer  = new char[,]
            {   //start of 2d array
                {'a', 'a'},{'b', 'a'},{'c', 'a'},{'d', 'a'},{'e', 'a'},{'f', 'a'},
                {'g', 'a'},{'h', 'a'},{'i', 'a'},{'j', 'a'},{'k', 'a'},{'l', 'a'},
                {'m', 'a'},{'n', 'a'},{'o', 'a'},{'p', 'a'},{'q', 'a'},{'r', 'a'},
                {'s', 'a'},{'t', 'a'},{'u', 'a'},{'v', 'a'},{'w', 'a'},{'x', 'a'},
                {'y', 'a'},{'z', 'a'},{'0', 'a'},{'1', 'a'},{'2', 'a'},{'3', 'a'},
                {'4', 'a'},{'5', 'a'},{'6', 'a'},{'7', 'a'},{'8', 'a'},{'9', 'a'},
            };  //end of 2d array
            string password = "eridas";
        int tempnum;
            #region list
            List<char> setofchars = new List<char>();
            setofchars.Add('a');
            setofchars.Add('b');
            setofchars.Add('c');
            setofchars.Add('d');
            setofchars.Add('e');
            setofchars.Add('f');
            setofchars.Add('g');
            setofchars.Add('h');
            setofchars.Add('i');
            setofchars.Add('j');
            setofchars.Add('k');
            setofchars.Add('l');
            setofchars.Add('m');
            setofchars.Add('n');
            setofchars.Add('o');
            setofchars.Add('p');
            setofchars.Add('q');
            setofchars.Add('r');
            setofchars.Add('s');
            setofchars.Add('t');
            setofchars.Add('u');
            setofchars.Add('v');
            setofchars.Add('w');
            setofchars.Add('x');
            setofchars.Add('y');
            setofchars.Add('z');
            setofchars.Add('0');
            setofchars.Add('1');
            setofchars.Add('2');
            setofchars.Add('3');
            setofchars.Add('4');
            setofchars.Add('5');
            setofchars.Add('6');
            setofchars.Add('7');
            setofchars.Add('8');
            setofchars.Add('9');
            #endregion
            Label[] labelsArray = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12,
                                    label13, label14, label15, label16, label17, label18, label19, label20 ,label21 ,label22, label23, label24,
                                    label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, };
            Random rnd = new Random();
            for (int i = 0; i< 35; i++)
            {   //start of loop
                
                tempnum = rnd.Next(1, setofchars.Count);
                randomizer[i, 1] = setofchars[tempnum];
                setofchars.Remove(randomizer[i, 1]);

                //populate the labels
                for (int j = 0; j < labelsArray.Count(); j++)
                {
                    labelsArray[j].Text = Convert.ToString(randomizer[j, 1]);
                }
            }   //end of loop

            foreach (char a in password)
            {
                for (int i = 0; i < 36; i++)
                {
                    if (a == randomizer[i,0])
                    {
                        randomizedPassword = randomizedPassword + randomizer[i,1];
                    }
                }
            }



        }   //end of form1 load

       public void button1_Click(object sender, EventArgs e)
        {   //start of button click
            string input;
            string output ="";

            input = txt_input.Text;
           /* foreach( char inp in input)
            {   //start of loop
                for (int i = 0; i < 36; i++)
                {   //start of loop
                    if (inp == randomizer[i,0] )
                    {   //start of if
                        output = output + randomizer[i,1];
                    }   //end of if
                }   //end of loop

            }   //end of loop */
            if (txt_input.Text == randomizedPassword)
            {
                MessageBox.Show("You're logged in");
            }
            else
            {
                MessageBox.Show("the password is incorrect");
            }

            //lbl_output.Text = output;
        }   //end of button click
    } //end of class
} //end of namespace
