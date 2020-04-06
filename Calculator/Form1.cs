using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.MyCalculator;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double tmp1, tmp2;
        ICalculate Calculate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)  //первое действие для калькулятора
        {
            tmp1 = 0;
            tmp2 = 0;
        }

        private void AddToTextBox(string a)  //выводим число в окошке
        {
            numberBox.Text += a;
        }        

        private void button1_Click(object sender, EventArgs e)  //добавляем 1 в калькулятор 
        {
            AddToTextBox("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToTextBox("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToTextBox("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToTextBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToTextBox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToTextBox("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToTextBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToTextBox("8");
        }        

        private void button9_Click(object sender, EventArgs e)
        {
            AddToTextBox("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddToTextBox("0");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            tmp1 = Convert.ToDouble(numberBox.Text);
            numberBox.Text = "";
            Calculate = new DoMinus();
        }
        
        private void plus_Click(object sender, EventArgs e)
        {
            tmp1 = Convert.ToDouble(numberBox.Text);
            numberBox.Text = "";
            Calculate = new DoPlus();
        }        

        private void solution_Click(object sender, EventArgs e)
        {
            tmp2 = Convert.ToDouble(numberBox.Text);
            numberBox.Text = Calculate.DoMath(tmp1, tmp2) + "";
        }

    }
}
