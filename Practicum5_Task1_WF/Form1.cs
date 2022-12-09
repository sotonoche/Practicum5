using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum5_Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            double y = Math.Sqrt(5 - Math.Pow(x, 3));
            if ((5 - Math.Pow(x, 3)) < 0) throw new Exception();
            return y;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            double a, b, h;
            
            try
            {
                a = (double)numericUpDownA.Value;
                b = (double)numericUpDownB.Value;
                h = (double)numericUpDownH.Value;

                if (h == 0.0) throw new Exception("Шаг не может быть равен нулю!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            richTextBox.Clear();
            richTextBox.Text += $"Значения фунции на промежутке от {a} до {b} с шагом {h}\n";
            richTextBox.Text += "x\ty\n";
            for (double i = a; i <= b; i += h)
            {
                try
                {
                    richTextBox.Text += $"{i}\t{Math.Round(f(i), 3)}\n";
                }
                catch (Exception)
                {
                    richTextBox.Text += $"{i}\tПри данном значении х, значение под корнем будет отрицательным!\n";
                }
            }
        }
    }
}
