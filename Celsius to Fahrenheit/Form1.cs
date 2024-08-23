using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_to_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * (9/5) + 32;
            return fahrenheit;
        }

        public string CelsiusToFahrenheitWithStrings(string celsius)
        {
            double celsiusDouble = double.Parse(celsius);
            double fahrenheit = CelsiusToFahrenheit(celsiusDouble);
            return fahrenheit.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = CelsiusToFahrenheitWithStrings(textBox1.Text);
            textBox5.Text = CelsiusToFahrenheitWithStrings(textBox2.Text);
            textBox6.Text = CelsiusToFahrenheitWithStrings(textBox3.Text);
        }

        public double FahrenheitToCelsius(double fahrenheit) 
        { 
            double celsius = (fahrenheit-32) * (5/9);
            return celsius;
        }

        public string FahrenheitToCelsiusWithStrings(string fahrenheit) 
        {
            double fahrenheitDouble = double.Parse(fahrenheit);
            double celsius = FahrenheitToCelsius(fahrenheitDouble);
            return celsius.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = FahrenheitToCelsiusWithStrings(textBox4.Text);
            textBox2.Text = FahrenheitToCelsiusWithStrings(textBox5.Text);
            textBox3.Text = FahrenheitToCelsiusWithStrings(textBox6.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
