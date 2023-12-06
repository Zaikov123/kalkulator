namespace praktika
{
    public partial class Form1 : Form
    {
        byte focusOnOperand = 0;
        double valueOfCalcul = 0;
        double valueOfCalculExpand = 0;
        char opExSign = '\0';
        string expandPrev;
 
        double currentValue = 0;
        double valuePrev = 0;
        char opExPrevSign = '\0';
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            secondOperand.Focus();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            firstOperand.Text= firstOperand.Text + "0";
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            firstOperand.Text= "";
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            secondOperand.Text = "";
        }

        private void backspace1_Click(object sender, EventArgs e)
        {
            int firstOperLen = firstOperand.TextLength;
            if(firstOperLen> 0)
            {
                firstOperand.Text = firstOperand.Text.Substring(0, firstOperLen - 1);
            }
            else
            {
                firstOperand.Text = "";
            }
            
        }

        private void backspace2_Click(object sender, EventArgs e)
        {
            int secondOperLen = secondOperand.TextLength;
            if(secondOperLen> 0)
            {
                secondOperand.Text = secondOperand.Text.Substring(0, secondOperLen - 1);
            }
            else
            {
                secondOperand.Text = "";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }

        }

        private void two_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }
        private void eight_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
            }
        }
        private void firstOperand_Enter(object sender, EventArgs e)
        {
            focusOnOperand = 1;
        }

        private void secondOperand_Enter(object sender, EventArgs e)
        {
            focusOnOperand= 2;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                firstOperand.Text = firstOperand.Text + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }
            else if (focusOnOperand == 2)
            {
                secondOperand.Text = secondOperand.Text + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (focusOnOperand == 1)
            {
                int firstOperLen = firstOperand.TextLength;
                if((firstOperLen > 0) && (firstOperand.Text[0] == '-'))
                {
                    firstOperand.Text = firstOperand.Text + ((Button)sender).Text;
                }
                    
            }
            else if (focusOnOperand == 2)
            {
                int secondOperLen = secondOperand.TextLength;
                if((secondOperLen > 0) && (secondOperand.Text[0] == '-'))
                {
                    secondOperand.Text = secondOperand.Text + ((Button)sender).Text;
                }
               
            }
        }

        private void doPlus_Click(object sender, EventArgs e)
        {
            if(double.TryParse(firstOperand.Text, out double firstNum) && double.TryParse(secondOperand.Text, out double secNum))
            {
                valueOfCalcul = firstNum + secNum;
            }
            
        }

        private void doMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(firstOperand.Text, out double firstNum) && double.TryParse(secondOperand.Text, out double secNum))
            {
                valueOfCalcul = firstNum - secNum;
            }
        }

        private void doMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(firstOperand.Text, out double firstNum) && double.TryParse(secondOperand.Text, out double secNum))
            {
                valueOfCalcul = firstNum * secNum;
            }
        }

        private void doDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(firstOperand.Text, out double firstNum) && double.TryParse(secondOperand.Text, out double secNum))
            {
                valueOfCalcul = firstNum / secNum;
            }
        }

        private void doEquals_Click(object sender, EventArgs e)
        {
            if(firstOperand.Text != null && secondOperand.Text !=null) 
                result.Text = valueOfCalcul.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Yellow; break;
                case 1:
                    this.BackColor = Color.Red; break;
                case 2:
                    this.BackColor = Color.Blue; break;
                case 3:
                    this.BackColor = Color.Black; break;
                case 4:
                    this.BackColor = Color.White; break;
            }
        }

        private void zeroExpand_Click(object sender, EventArgs e)
        {
            resultExpand.Text = resultExpand.Text + ((Button)sender).Text;
        }

        private void zeroExpand_Click_1(object sender, EventArgs e)
        {
            resultExpand.Text = resultExpand.Text + ((Button)sender).Text;
        }

        private void minusButtonExpand_Click(object sender, EventArgs e)
        {
            int resultExpandLen = resultExpand.TextLength;
            if ((resultExpandLen > 0) && (resultExpand.Text[0] == '-'))
            {
                resultExpand.Text = resultExpand.Text + ((Button)sender).Text;
            }
        }

        private void dotExpand_Click(object sender, EventArgs e)
        {
            firstOperand.Text = firstOperand.Text + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }

        private void backExpand_Click(object sender, EventArgs e)
        {
            int resultExpandLen = resultExpand.TextLength;
            if (resultExpandLen > 0)
            {
                resultExpand.Text = resultExpand.Text.Substring(0, resultExpandLen - 1);
            }
            else
            {
                resultExpand.Text = "";
            }
        }

        private void clearExpand_Click(object sender, EventArgs e)
        {
            resultExpand.Text = "";
        }

        private void plusExpand_Click(object sender, EventArgs e)
        {

            string btn_txt = ((Button)sender).Text;

            if (double.TryParse(resultExpand.Text, out double currentResult))
            {
                currentValue = currentResult;
            }

            expandPrev += $"{currentValue} {btn_txt} ";
            label5.Text = expandPrev;

            if (opExPrevSign != '\0')
            {
                switch (opExPrevSign)
                {
                    case '+': valuePrev += currentValue; break;
                    case '-': valuePrev -= currentValue; break;
                    case '*': valuePrev *= currentValue; break;
                    case '/': valuePrev /= currentValue; break;
                    case '\0': valuePrev = currentValue; break;
                }
            }
            else
            {
                valuePrev = currentValue;
            }

            // Обновляем label8 с текущим промежуточным результатом
            label8.Text = valuePrev.ToString();

            resultExpand.Text = "";
            opExPrevSign = btn_txt[0];
        }

        private void resultExpand_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(resultExpand.Text, out double resultValue))
            {
                plusExpand.Enabled = true;
                minusExpand.Enabled = true;
                multiplyExpand.Enabled = true;
                divideExpand.Enabled = true;
                equalsExpand.Enabled = true;
            }
            else
            {
                plusExpand.Enabled = false;
                minusExpand.Enabled = false;
                multiplyExpand.Enabled = false;
                divideExpand.Enabled = false;
                equalsExpand.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void equalsExpand_Click(object sender, EventArgs e)
        {
            if (opExPrevSign != '\0')
            {
                if (double.TryParse(resultExpand.Text, out double currentResult))
                {
                    currentValue = currentResult;
                }

                switch (opExPrevSign)
                {
                    case '+': valuePrev += currentValue; break;
                    case '-': valuePrev -= currentValue; break;
                    case '*': valuePrev *= currentValue; break;
                    case '/': valuePrev /= currentValue; break;
                }

                // Добавляем последнее число и оператор в label5
                expandPrev += $"{currentValue} = {valuePrev}";
                label5.Text = expandPrev;

                // Добавляем выражение в ListBox1
                listBox1.Items.Add(expandPrev);

                expandPrev = null;
                resultExpand.Text = "";
                label5.Text = "";
                label8.Text = "";
                opExPrevSign = '\0';
            }
        }
    }
}