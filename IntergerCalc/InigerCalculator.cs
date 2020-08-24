using System;
using System.Windows.Forms;

namespace IntergerCalc
{
    public partial class InigerCalculator : Form
    {
        public InigerCalculator()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string ButtonText = ((sender as Button).Text).ToString();
            if (textBox_Zahl1.Text == string.Empty | textBox_Zahl2.Text == string.Empty)
                MessageBox.Show("No imput");
            else
            {
                switch (ButtonText)
                {
                    case "+":
                        textBox_Ergebnis.Text = (ConvertStringtoInt(textBox_Zahl1.Text) + ConvertStringtoInt(textBox_Zahl2.Text)).ToString();
                        break;

                    case "-":
                        textBox_Ergebnis.Text = (ConvertStringtoInt(textBox_Zahl1.Text) - ConvertStringtoInt(textBox_Zahl2.Text)).ToString();
                        break;

                    case "*":
                        textBox_Ergebnis.Text = (ConvertStringtoInt(textBox_Zahl1.Text) * ConvertStringtoInt(textBox_Zahl2.Text)).ToString();
                        break;

                    case "/":
                        if (textBox_Zahl2.Text == "0")
                            MessageBox.Show("Division mit null nicht erforgreich");
                        else
                            textBox_Ergebnis.Text = (ConvertStringtoInt(textBox_Zahl1.Text) / ConvertStringtoInt(textBox_Zahl2.Text)).ToString();
                        break;

                    case "%":
                        textBox_Ergebnis.Text = (ConvertStringtoInt(textBox_Zahl1.Text) % ConvertStringtoInt(textBox_Zahl2.Text)).ToString();
                        break;
                }
            }
            
        }

        public int ConvertStringtoInt(string text) 
        {
            int Zahl = 0;
            try
            {
                Zahl = int.Parse(text);
            }
            catch (Exception)
            {
                MessageBox.Show("False Zahl");
            }

            return Zahl;
        }

    }
}
