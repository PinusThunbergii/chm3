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
        public Form1()
        {
            InitializeComponent();
        }
        delegate double Function(double x);
        double function(double x)
        {
            return Math.Cos(x) / (1.0d + Math.Pow(x, 2.0d));
        }

        double genRandDoubleInRange(double min, double max, ref Random rand)
        {
            double inMin = 0.0d, inMax = 1.0d;
            return (rand.NextDouble() - inMin) * (max - min) / (inMax - inMin) + min ;
        }

        bool isInside(Function function, double a, double b, double n)
        {

            return false;
        }

        void calculateButtonOnClickHandler(object sender, EventArgs eventArgs)
        {
            Random rand = new Random();
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(genRandDoubleInRange(20.0d, 40.0d, ref rand));
            }
        }
    }
}
