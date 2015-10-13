using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

         

        public Calculator()
        {
            InitializeComponent();
            this.CommaClicked = false;
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }


 


        //This method is invoked when (0-9) numbers are clicked

        private delegate void InputSetter(string msg);

        private static void SetInput(string msg, Action<string> func )
        {
            func(msg);
        }

        private void AddStringToInput(string msg)
        {
            this.Input.Text = this.Input.Text + msg;
        }

        private void NumberClicked(object sender, EventArgs e)
        {
            var number = sender.ToString().ElementAt(35) + "";
            SetInput(number, AddStringToInput);

        }

       
        private void Comma_Click(object sender, EventArgs e)
        {
            if (this.CommaClicked == false)
            {
                SetInput(",", AddStringToInput);
                this.CommaClicked = true;
            }

        } 

        private void Clear_Click(object sender, EventArgs e)
        {
            SetInput(null, x => this.Input.Text = null);
            this.CommaClicked = false;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Szymon Sutek is an Author of this Calculator!", "Author",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }

       
        
    }

