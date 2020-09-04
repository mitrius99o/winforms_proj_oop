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
        public bool flagTri=false;
        public IInputForm inputForm { get; set; }
        public InputForm(string figure)
        {
            this.figure = figure;
            switch (figure)
            {
                case "Прямоугольник":
                    inputForm = new RecComponent();
                    break;
                case "Круг":
                    inputForm = new CirComponent();
                    break;
                case "Треугольник":
                    inputForm = new TriComponent();
                    break;
            }
            inputForm.InitializeComponent(this);
        }

        private void GetResult()
        {
            if (Program.mainForm.flag == "p")
                MessageBox.Show(Program.mainForm.figure.GetP());
            else
                MessageBox.Show(Program.mainForm.figure.GetS());
        }
        public void button1_Click(object sender, EventArgs e)
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
                flagTri = c > a ? true: false;
                Program.mainForm.figure = new Triangle(a, b, c);
            }
            else
            {
                a = double.Parse(textBox1.Text);
                Program.mainForm.figure = new Circle(a);
            }

            if (flagTri)
                MessageBox.Show("Данные катета не должны быть больше самой стороны а");
            else
                GetResult();

        }
    }
}
