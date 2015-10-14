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
            _info.SecondNumber = float.Parse(Input.Text, CultureInfo.InvariantCulture.NumberFormat);
            var doOperation = new Operation(CalculationManager.GetOperation(_info.Operation));
            SetInput(doOperation(_info.FirstNumber, _info.SecondNumber), x => Input.Text = x);
        }

        private void Operate(object sender, EventArgs e)
        {
            _info.Operation = Identify(sender);
            _info.FirstNumber = float.Parse(Input.Text, CultureInfo.InvariantCulture.NumberFormat);
            ResetVariables();
        }

        private Operations Identify(object sender)
        {
            if (sender == Plus)
                return Operations.Addition;
            else if (sender == Minus)
                return Operations.Substraction;
            else if (sender == Divide)
                return Operations.Division;
            else if (sender == Multiply)
                return Operations.Multiplication;
            else if (sender == Mod)
                return Operations.Mod;
            else if (sender == Sqrt)
                return Operations.Sqrt;
            else if (sender == Reciprocal)
                return Operations.Reciprocal;

            return Operations.Default;
        }
    }
}

