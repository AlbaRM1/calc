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
        int[] number = new int[2];
        string @operator;

        public MainPage()
        {
            InitializeComponent();
        }
        private void clear(object sender, EventArgs e)
        {
            textCalc.Text = null;
        }
        
        private void delen(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + "/";
        }
        
        private void umnoj(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text + "*";
        }
        
        private void delete(object sender, EventArgs e)
        {
            textCalc.Text = textCalc.Text.Substring(0, textCalc.Text.Length - 1);
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
            textCalc.Text = textCalc.Text + "-";
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
            textCalc.Text = textCalc.Text + "+";
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
            Console.WriteLine(textCalc.Text);
            object a = new DataTable().Compute(textCalc.Text, null);
            
            textCalc.Text = a.ToString();
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
