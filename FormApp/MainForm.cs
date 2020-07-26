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
    
    public partial class MainForm : Form
    {
        public Figure figure;
        public InputForm form;
        public string flag;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form = new InputForm(comboBox1.SelectedItem.ToString());
            form.Show();
            flag = "p";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form = new InputForm(comboBox1.SelectedItem.ToString());
            form.Show();
            flag = "s";
        }
    }
}
