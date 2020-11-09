using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
       

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //use try -catch to avoid input errors
            try
            {

                double length = double.Parse(textBox3.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox1.Text);
                //calculate Fx and Fy using equations Fx = Fcos and Fy = Fsin
                double volume = length * width * height;
                double surfacearea = 2.0 * (length * height + length * width + width * height);
                //Output solutions to label1 and label2
                label4.Text = "volume =" + volume;
                label5.Text = "surface area =" + surfacearea;

            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }
    }
}
