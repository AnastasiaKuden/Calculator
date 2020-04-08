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
            numberBox.Text = "0";
            numberBox2.Text = "";            
        }

        private void delete_Click(object sender, EventArgs e)  //удаляем последнее значение
        {
            numberBox.Text = "";
        }

        private void AddToTextBox(string a)  //выводим число в окошке
        {            
            if (numberBox.Text != "0" && numberBox.Text != "Game over!")
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
            if (numberBox.Text != "")
            {
                if (numberBox.Text.IndexOf(",") == -1)
                {
                    if (numberBox.Text == null)
                    {
                        numberBox.Text = "0,";
                    }
                    else
                    {
                        numberBox.Text = numberBox.Text + ",";
                    }
                }
            }            
        }

        private void changeSymbol_Click(object sender, EventArgs e)  //меняем знак
        {            
            if (numberBox.Text != "0")
            {
                numberBox.Text = (Convert.ToDouble(numberBox.Text) * (-1)) + "";
            }            
        }

        private void minus_Click(object sender, EventArgs e)  //минус
        {
            if (numberBox.Text != "" && numberBox.Text != "Game over!")
            {                
                if (Calculate != null)
                {
                    double a = Convert.ToDouble(numberBox.Text);                    
                    tmp1 = Calculate.DoMath(tmp1, Convert.ToDouble(numberBox.Text));
                    if (Convert.ToString(tmp1) == "∞" || Convert.ToString(tmp1) == "-∞")
                    {
                        numberBox.Text = "Game over!";
                        numberBox2.Text = "";
                        tmp1 = 0;
                        tmp2 = 0;
                        Calculate = null;
                    }
                    else
                    {
                        numberBox.Text = "";
                        Calculate = new DoMinus();
                        numberBox2.AppendText($" {a} -");
                    }                                    
                }
                else
                {
                    tmp1 = Convert.ToDouble(numberBox.Text);
                    numberBox2.AppendText($"{numberBox.Text} -");
                    numberBox.Text = "";
                    Calculate = new DoMinus();
                }                                  
            }            
        }
        
        private void plus_Click(object sender, EventArgs e)  //плюс
        {
            if (numberBox.Text != "" && numberBox.Text != "Game over!")
            {
                if (Calculate != null)
                {
                    double a = Convert.ToDouble(numberBox.Text);
                    tmp1 = Calculate.DoMath(tmp1, Convert.ToDouble(numberBox.Text));
                    if (Convert.ToString(tmp1) == "∞" || Convert.ToString(tmp1) == "-∞")
                    {
                        numberBox.Text = "Game over!";
                        numberBox2.Text = "";
                        tmp1 = 0;
                        tmp2 = 0;
                        Calculate = null;
                    }
                    else
                    {
                        numberBox.Text = "";
                        Calculate = new DoMinus();
                        numberBox2.AppendText($" {a} +");
                    }
                }
                else
                {
                    tmp1 = Convert.ToDouble(numberBox.Text);
                    numberBox2.AppendText($"{numberBox.Text} +");
                    numberBox.Text = "";
                    Calculate = new DoPlus();
                }
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

        private void divide_Click(object sender, EventArgs e)  //деление
        {
            if (numberBox.Text != "" && numberBox.Text != "Game over!")
            {
                if (Calculate != null)
                {
                    double a = Convert.ToDouble(numberBox.Text);
                    tmp1 = Calculate.DoMath(tmp1, Convert.ToDouble(numberBox.Text));
                    if (Convert.ToString(tmp1) == "∞" || Convert.ToString(tmp1) == "-∞")
                    {
                        numberBox.Text = "Game over!";
                        numberBox2.Text = "";
                        tmp1 = 0;
                        tmp2 = 0;
                        Calculate = null;
                    }
                    else
                    {
                        numberBox.Text = "";
                        Calculate = new DoMinus();
                        numberBox2.AppendText($" {a} /");
                    }
                }
                else
                {
                    tmp1 = Convert.ToDouble(numberBox.Text);
                    numberBox2.AppendText($"{numberBox.Text} /");
                    numberBox.Text = "";
                    Calculate = new DoDivide();
                }
            }
        }

        private void multiply_Click(object sender, EventArgs e)  //умножение
        {
            if (numberBox.Text != "" && numberBox.Text != "Game over!")
            {
                if (Calculate != null)
                {
                    double a = Convert.ToDouble(numberBox.Text);
                    tmp1 = Calculate.DoMath(tmp1, Convert.ToDouble(numberBox.Text));
                    if (Convert.ToString(tmp1) == "∞" || Convert.ToString(tmp1) == "-∞")
                    {
                        numberBox.Text = "Game over!";
                        numberBox2.Text = "";
                        tmp1 = 0;
                        tmp2 = 0;
                        Calculate = null;
                    }
                    else
                    {
                        numberBox.Text = "";
                        Calculate = new DoMinus();
                        numberBox2.AppendText($" {a} *");
                    }
                }
                else
                {
                    tmp1 = Convert.ToDouble(numberBox.Text);
                    numberBox2.AppendText($"{numberBox.Text} *");
                    numberBox.Text = "";
                    Calculate = new DoMultiply();
                }
            }
        }

        private void solution_Click(object sender, EventArgs e)  //равно
        {
            if (numberBox.Text != "" && Calculate != null)
            {                
                tmp2 = Convert.ToDouble(numberBox.Text);  
                string a = Calculate.DoMath(tmp1, tmp2) + "";                
                if (a != "∞" && a != "-∞")
                {
                    numberBox.Text = a;
                }      
                else
                {
                    numberBox.Text = "Game over!";
                }
                tmp1 = 0;
                tmp2 = 0;
                Calculate = null;
                numberBox2.Text = "";
            }            
        }
    }
}
