namespace Calculator_Form
{
    public partial class Form1 : Form
    {
        //
        double FirstNumber;
        string Operator;
        //
        public Form1()
        {
            InitializeComponent();
            GenerateButotns();
        }
        void GenerateButotns()
        {
            string[] ButtonLabels = {   "7", "8", "9", "+",
                                        "4", "5", "6", "-",
                                        "1", "2", "3", "*",
                                        "C", "0", "=", "/",
                                        "X"};
            int width = (flowLayoutPanel1.Width - 8 * DefaultMargin.Left) / 4;
            int height = (flowLayoutPanel1.Height - 8 * DefaultMargin.Top) / 5;
            for (int i = 0; i < ButtonLabels.Length; i++)
            {
                Button b = new Button();
                b.Text = ButtonLabels[i];
                b.Width = width;
                b.Height = height;
                flowLayoutPanel1.Controls.Add(b);
                if (i == 3)
                {
                    b.Click += AddButton_Click;

                }
                else if (i == 7)
                {
                    b.Click += SubButton_Click;

                }
                else if (i == 11)
                {
                    b.Click += MuitiplyButton_Click;

                }
                else if (i == 12)
                {
                    b.Click += ClearButton_Click;

                }
                else if (i == 14)
                {
                    b.Click += ResultButton_Click;

                }
                else if (i == 15)
                {
                    b.Click += DivideButton_Click;

                }
                else if (i == 16)
                {
                    b.Click += ClearAllButton_Click;
                }
                else
                {
                    //string numberHandle = b.Text;
                    b.Click += NumberButton_Click;

                }
            }
        }


        private void AddButton_Click(object? sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbInput.Text);
            tbInput.Text = "0";
            Operator = "+";
        }

        private void SubButton_Click(object? sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbInput.Text);
            tbInput.Text = "0";
            Operator = "-";
        }

        private void MuitiplyButton_Click(object? sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbInput.Text);
            tbInput.Text = "0";
            Operator = "*";
        }
        private void DivideButton_Click(object? sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(tbInput.Text);
            tbInput.Text = "0";
            Operator = "/";
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            if (tbInput.Text != String.Empty)
            {
                tbInput.Text = tbInput.Text.Substring(0, tbInput.Text.Length - 1);
            }
        }
        private void ClearAllButton_Click(object? sender, EventArgs e)
        {
            if (tbInput.Text != String.Empty)
            {
                tbInput.Text = String.Empty;
            }
        }

        private void NumberButton_Click(object? sender, EventArgs e)
        {

            tbInput.Text += ((Button)sender).Text;
        }

        private void ResultButton_Click(object? sender, EventArgs e)
        {
            double Result;
            double SecondNumber = Convert.ToDouble(tbInput.Text);

            if (Operator == "+")
            {
                Result = FirstNumber + SecondNumber;
                tbInput.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operator == "-")
            {
                Result = FirstNumber - SecondNumber;
                tbInput.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operator == "*")
            {
                Result = FirstNumber * SecondNumber;
                tbInput.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operator == "/")
            {
                if (SecondNumber == 0)
                {
                    MessageBox.Show("Hoc lai toan cap 1 di nhe :) ");
                }
                else
                {
                    Result = FirstNumber / SecondNumber;
                    tbInput.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }


}