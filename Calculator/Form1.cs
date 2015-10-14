using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Properties;
using OperationInformation;


namespace Calculator
{

    public partial class Calculator : Form
    {
        private readonly Information _info;

        private delegate string Operation(float x, float y);

        public Calculator()
        {
            InitializeComponent();
            _info = new Information();
            InitializeVariables();

      
        }

        private void InitializeVariables()
        {
            ResetVariables();
            _info.FirstNumber = 0;
            _info.SecondNumber = 0;
            _info.Operation = 0;
        }

        private void ResetVariables()
        {
            this.CommaClicked = false;
            this.Input.Text = null;         
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

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
            InitializeVariables();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Calculator_Info_Click_Szymon_Sutek_created_this_Calculator_, "Author",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Result_Click(object sender, EventArgs e)
        {
            _info.SecondNumber = float.Parse(this.Input.Text, CultureInfo.InvariantCulture.NumberFormat);
            var doOperation = new Operation(CalculationManager.GetOperation(_info.Operation));
            SetInput(doOperation(_info.FirstNumber, _info.SecondNumber),(x) => this.Input.Text = x ); 
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            _info.Operation = Operations.Addition;
            _info.FirstNumber = float.Parse(this.Input.Text, CultureInfo.InvariantCulture.NumberFormat);
            ResetVariables();

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            _info.Operation = Operations.Division;
            _info.FirstNumber = float.Parse(this.Input.Text, CultureInfo.InvariantCulture.NumberFormat);
            ResetVariables();
        }
    }

       
        
    }

