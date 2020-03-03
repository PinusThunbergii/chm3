using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace chm3
{
    public partial class Form1 : Form
    {
        private int n;
        private double a;
        private double b;
        public Form1()
        {
            InitializeComponent();
        }
        delegate double Function(double x);
        double function(double x)
        {
            return Math.Cos(x) / (1.0d + Math.Pow(x, 2.0d));
            //return Math.Cos(x);
        }

        double genRandDoubleInRange(double min, double max, ref Random rand)
        {
            double inMin = 0.0d, inMax = 1.0d;
            return (rand.NextDouble() - inMin) * (max - min) / (inMax - inMin) + min ;
        }

        bool isInside(Function function, double a, double b, double x, double y)
        {
            if (y <= function(x) && y >= 0.0d && x >= a && x <= b)
                return true;
            return false;
        }

        //Лучше использовать метод золотого сечения, это тупой алгоритм в лоб))
        //https://en.wikipedia.org/wiki/Golden-section_search
        double findMax(Function function, double a, double b, int n = 10000)
        {
            double dx = (b - a) / (double)n;
            double max = Double.MinValue;
            double y = 0.0d;
            double x = 0.0d;
            for (int i = 0; i < n; i++)
            {
                x = a + dx * (double)i;
                y = function(x);
                if (y > max)
                    max = y;
            }
            return max;
        }

        void calculateButtonOnClickHandler(object sender, EventArgs eventArgs)
        {
            try
            {
                Random rand = new Random();
                double rnum_x = 0.0d;
                double rnum_y = 0.0d;
                mainChart.Series[0].Points.Clear();
                mainChart.Series[1].Points.Clear();
                resultTextBox.Text = "";
                if (!int.TryParse(nTextBox.Text, out n) ||
                   !Double.TryParse(aTextBox.Text, out a) ||
                   !Double.TryParse(bTextBox.Text, out b))
                {
                    throw new Exception("Input error");
                }
                double dx = (b - a) /(double)n;
                double x = 0.0d;
                double y = 0.0d;
                double max_y = findMax(function, a, b);
                double min_y = 0.0d;
                int hitCount = 0;
                Console.WriteLine($"Max y {max_y}");
                for (int i = 0; i < n; i++)
                {
                    rnum_x = genRandDoubleInRange(a, b, ref rand);
                    rnum_y = genRandDoubleInRange(min_y, max_y, ref rand);
                    
                    x = a + dx * (double)i;
                    y = function(x);
                    if (displayChartCheckBox.Checked) 
                    { 
                        mainChart.Series[0].Points.AddXY(rnum_x, rnum_y);
                        mainChart.Series[1].Points.AddXY(x, y);
                    }

                    //Console.WriteLine($"{rnum_x} {rnum_y} :: {x} {y}");

                    if (isInside(function, a, b, rnum_x, rnum_y))
                        hitCount++;
                }
                double area = (double)hitCount / (double)n ;
                resultTextBox.Text = area.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
