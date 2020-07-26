using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemStudent;

namespace FormApp
{
    public partial class InputForm : Form
    {
        public double a;
        public double b;
        public double c;
        public string figure;
        public bool IsClosed { get; set; }
        public InputForm(string figure)
        {
            this.figure = figure;
            switch (figure)
            {
                case "Прямоугольник":
                    InitializeRecComponent();
                    break;
                case "Круг":
                    InitializeCirComponent();
                    break;
                case "Треугольник":
                    InitializeTriComponent();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (figure == "Прямоугольник")
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                Program.mainForm.figure = new SystemStudent.Rectangle(a, b);
            }
            else if (figure == "Треугольник")
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                Program.mainForm.figure = new Triangle(a, b, c);
            }
            else
            {
                a = double.Parse(textBox1.Text);
                Program.mainForm.figure = new Circle(a);
            }


            if(Program.mainForm.flag=="p")
                MessageBox.Show(Program.mainForm.figure.GetP());
            else
                MessageBox.Show(Program.mainForm.figure.GetS());
        }
    }
}
