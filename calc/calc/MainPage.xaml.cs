using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calc
{
    public partial class MainPage : ContentPage
    {
        double[] number = new double[2];
        double result;
        string @operator;

        public MainPage()
        {
            InitializeComponent();
        }
        private void clear(object sender, EventArgs e)
        {
            @operator = null;
            number[0] = 0;
            textCalc.Text = null;
        }
        
        private void delen(object sender, EventArgs e)
        {
            try
            {
                @operator = "/";
                number[0] = double.Parse(textCalc.Text);
                textCalc.Text = null;
            }
            catch (Exception)
            {}

        }
        
        private void umnoj(object sender, EventArgs e)
        {
            try
            {
                @operator = "*";
                number[0] = double.Parse(textCalc.Text);
                textCalc.Text = null;
            }
            catch (Exception)
            { }
        }
        
        private void delete(object sender, EventArgs e)
        {
            try
            {
                textCalc.Text = textCalc.Text.Substring(0, textCalc.Text.Length - 1);
            }
            catch (Exception) { }
        }

        private void seven(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 7;
        }

        private void eight(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 8;
        }

        private void nine(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 9;
        }

        private void minus(object sender, EventArgs e)
        {
            try
            {
                @operator = "-";
                number[0] = double.Parse(textCalc.Text);
                textCalc.Text = null;
            }
            catch (Exception)
            { }
        }

        private void four(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 4;
        }

        private void five(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 5;
        }

        private void six(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 6;
        }

        private void plus(object sender, EventArgs e)
        {
            try
            {
                @operator = "+";
                number[0] = double.Parse(textCalc.Text);
                textCalc.Text = null;
            }
            catch (Exception)
            { }
        }

        private void one(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 1;
        }

        private void two(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 2;
        }

        private void three(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 3;
        }

        private void ravno(object sender, EventArgs e)
        {
            switch (@operator)
            {
                case "+":
                    {
                        try
                        {
                            number[1] = double.Parse(textCalc.Text);
                            result = number[0] + number[1];

                            textCalc.Text = result.ToString();
                            break;
                        }
                        catch (Exception)
                        {
                            textCalc.Text = "ERROR";
                            break;
                        }

                    }

                case "-":
                    {
                        try
                        {
                            number[1] = double.Parse(textCalc.Text);
                            result = number[0] - number[1];

                            textCalc.Text = result.ToString();
                            break;
                        }
                        catch (Exception)
                        {
                            textCalc.Text = "ERROR";
                            break;
                        }
                    }

                case "*":
                    {
                        try
                        {
                            number[1] = double.Parse(textCalc.Text);
                            result = number[0] * number[1];

                            textCalc.Text = result.ToString();
                            break;
                        }
                        catch (Exception)
                        {
                            textCalc.Text = "ERROR";
                            break;
                        }
                    }

                case "/":
                    {
                        try
                        {
                            number[1] = double.Parse(textCalc.Text);
                            result = number[0] / number[1];

                            textCalc.Text = result.ToString();
                            break;
                        }
                        catch (Exception)
                        {
                            textCalc.Text = "ERROR";
                            break;
                        }
                    }
                default:
                    break;
            }
        }

        private void nol(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + 0;
        }


        private void zapyat(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + ",";
        }

    }
}
