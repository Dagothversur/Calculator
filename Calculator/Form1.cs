using System;
using System.Globalization;
using System.Linq;
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
            CommaClicked = false;
            Input.Text = null;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private static void SetInput(string msg, Action<string> func)
        {
            func(msg);
        }

        private void AddStringToInput(string msg)
        {
            Input.Text = Input.Text + msg;
        }


        private void NumberClicked(object sender, EventArgs e)
        {
            var number = sender.ToString().ElementAt(35) + "";
            SetInput(number, AddStringToInput);
        }


        private void Comma_Click(object sender, EventArgs e)
        {
            if (CommaClicked == false)
            {
                SetInput(",", AddStringToInput);
                CommaClicked = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SetInput(null, x => Input.Text = null);
            InitializeVariables();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Calculator_Info_Click_Szymon_Sutek_created_this_Calculator_, "Author",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if(_info.Operation != Operations.Sqrt && _info.Operation != Operations.Reciprocal)
                 _info.SecondNumber = float.Parse(Input.Text, CultureInfo.InvariantCulture.NumberFormat);
            var doOperation = new Operation(CalculationManager.GetOperation(_info.Operation));
            SetInput(doOperation(_info.FirstNumber, _info.SecondNumber), x => Input.Text = x);
        }

        private void Operate(object sender, EventArgs e)
        {
            if(GotInput())
             _info.FirstNumber = float.Parse(Input.Text, CultureInfo.InvariantCulture.NumberFormat);
            _info.Operation = Identify(sender);
            if(HandleException(_info.Operation) !=true)
             ResetVariables();
        }

        private Operations Identify(object sender)
        {
            if (sender == Plus)
                return Operations.Addition;
            if (sender == Minus)
                return Operations.Substraction;
            if (sender == Divide)
                return Operations.Division;
            if (sender == Multiply)
                return Operations.Multiplication;
            if (sender == Mod)
                return Operations.Mod;
            if (sender == Sqrt) 
                return Operations.Sqrt;
            if (sender == Reciprocal)
                return Operations.Reciprocal;

            return Operations.Default;
        }

        private bool HandleException(Operations op)
        {
            if (op.Equals(Operations.Sqrt) || op.Equals(Operations.Reciprocal))
            {
                Result_Click(this.Result, System.EventArgs.Empty);
                return true;
            }
           

            return false;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            string input = this.Input.Text;
            if (input.Length > 0)
                input = input.Substring(0, this.Input.Text.Length - 1);
            else
                input = "";
           this.Input.Text = input;

        }


        private bool GotInput()
        {
            return !this.Input.Text.Equals(string.Empty);
        }
    }
}

