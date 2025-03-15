using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String CatTotal;
        int num1;
        int num2;
        String option;
        int result;
        int Factorial;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7button
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //9button
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1button
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2button
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3button
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4button
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5button
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6button
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8button
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //0button
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //-button
            option = "-";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //+button
            option = "+";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //*button
            option = "*";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Dividebutton
            option = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //saquarerootbutton
            option = "root";
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //powerbutton
            option = "power";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //logoarthimbutton
            option = "logoathim";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //factorialbutton
            option = "factorial";
           
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //tanbutton
            option = "tan";
           
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //sinbutton
            option = "sin";
            
            textBox1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //cosbutton
            option = "cos";
           
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
{
    num2 = int.Parse(textBox1.Text);
    if (option.Equals("+"))
        result = num1 + num2;

    if (option.Equals("-"))
        result = num1 - num2; // Corrected subtraction logic

    if (option.Equals("*"))
        result = num1 * num2;

    if (option.Equals("/"))
        result = num1 / num2;

    if (option.Equals("root"))
        result = (int)Math.Sqrt(num2);

    if (option.Equals("power"))
        result = (int)Math.Pow(num1, num2);

    if (option.Equals("logarithm"))
        result = (int)Math.Log(num1);

    if (option.Equals("tan"))
        result = (int)Math.Tan(num1 * Math.PI / 180);

    if (option.Equals("sin"))
        result = (int)Math.Sin(num1 * Math.PI / 180);

    if (option.Equals("cos"))
        result = (int)Math.Cos(num1 * Math.PI / 180);

    if (option.Equals("factorial"))
    {
        result = factorial(num1);
    }

    textBox1.Text = result.ToString();
}

private int factorial(int n)
{
    if (n == 0 || n == 1)
        return 1;
    return n * factorial(n - 1);
}

    }
}
        
       
       
    
