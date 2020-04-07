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

        private void Form1_Load(object sender, EventArgs e)  //первое действие для калькулятора и удаление всего
        {
            tmp1 = 0;
            tmp2 = 0;
            Calculate = null;
            numberBox.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)  //удаляем последнее значение
        {
            numberBox.Text = "";
        }

        private void AddToTextBox(string a)  //выводим число в окошке
        {
            if (numberBox.Text != "0")
            {
                numberBox.Text += a;
            }
            else
            {
                numberBox.Text = a;
            }
        }        

        private void button1_Click(object sender, EventArgs e)  //добавляем 1 в калькулятор 
        {
            AddToTextBox("1");
        }

        private void button2_Click(object sender, EventArgs e)  //добавляем 2 в калькулятор
        {
            AddToTextBox("2");
        }

        private void button3_Click(object sender, EventArgs e)  //добавляем 3 в калькулятор
        {
            AddToTextBox("3");
        }

        private void button4_Click(object sender, EventArgs e)  //добавляем 4 в калькулятор
        {
            AddToTextBox("4");
        }

        private void button5_Click(object sender, EventArgs e)  //добавляем 5 в калькулятор
        {
            AddToTextBox("5");
        }

        private void button6_Click(object sender, EventArgs e)  //добавляем 6 в калькулятор
        {
            AddToTextBox("6");
        }

        private void button7_Click(object sender, EventArgs e)  //добавляем 7 в калькулятор
        {
            AddToTextBox("7");
        }

        private void button8_Click(object sender, EventArgs e)  //добавляем 8 в калькулятор
        {
            AddToTextBox("8");
        }        

        private void button9_Click(object sender, EventArgs e)  //добавляем 9 в калькулятор
        {
            AddToTextBox("9");
        }

        private void button0_Click(object sender, EventArgs e)  //добавляем 0 в калькулятор
        {
            AddToTextBox("0");
        }

        private void buttonDouble_Click(object sender, EventArgs e)  //делаем число дробным
        {
            if (numberBox.Text.IndexOf(",") == -1)
            {
                if (numberBox.Text != "")
                {
                    numberBox.Text = numberBox.Text + ",";
                }
                else
                {
                    numberBox.Text = numberBox.Text + "0,";
                }
            }            
        }

        private void changeSymbol_Click(object sender, EventArgs e)  //меняем знак
        {
            
            if (numberBox.Text != "")
            {
                if (Convert.ToDouble(numberBox.Text) > 0)
                {
                    numberBox.Text = "-" + numberBox.Text;
                }
                else
                {
                    numberBox.Text = numberBox.Text.Remove(0,1);
                }
                tmp1 *= -1;
            }            
        }

        private void minus_Click(object sender, EventArgs e)  //минус
        {
            if (numberBox.Text != "")
            {
                if (Calculate != null)
                {
                    tmp1 = Calculate.DoMath(tmp1, Convert.ToDouble(numberBox.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(numberBox.Text);
                }
                numberBox.Text = "";
                Calculate = new DoMinus();
            }            
        }
        
        private void plus_Click(object sender, EventArgs e)  //плюс
        {
            if (numberBox.Text != "")
            {
                if (Calculate != null)
                {
                    tmp1 = Calculate.DoMath(tmp1, Convert.ToDouble(numberBox.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(numberBox.Text);
                }                
                numberBox.Text = "";
                Calculate = new DoPlus();
            }            
        }

        private void squared_Click(object sender, EventArgs e) //возводим в квадрат
        {
            if (numberBox.Text != "")
            {
                tmp1 = Convert.ToDouble(numberBox.Text);
                Calculate = new DoSquare();
                numberBox.Text = Calculate.DoMath(tmp1, tmp2) + "";
            }
        }

        private void solution_Click(object sender, EventArgs e)  //равно
        {
            if (numberBox.Text != "" && Calculate != null)
            {
                tmp2 = Convert.ToDouble(numberBox.Text);
                numberBox.Text = Calculate.DoMath(tmp1, tmp2) + "";                
            }
            tmp1 = 0;
            tmp2 = 0;
        }
    }
}
