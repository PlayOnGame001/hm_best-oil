using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hm_best_oil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            benz.Items.Add("Diesel");
            benz.Items.Add("Benzin");
            benz.Items.Add("Gas");
            benz.SelectedItem = null;

            textBox6.Text = "2,00";
            textBox7.Text = "2,50";
            textBox8.Text = "1,50";
            textBox9.Text = "0,90";

        }
        public double sum_petrol = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Бензин_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(textBox5.Text);
            sum += hotdog + burger + potato + cola;
            textBox15.Text = sum.ToString();
        }

        private void benz_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = benz.SelectedItem;
            string op = obj.ToString();
            switch (op)
            {
                case "Diesel":
                    textBox2.Text = "1,59";
                    break;

                case "Benzin":
                    textBox2.Text = "1,49";
                    break;

                case "Gas":
                    textBox2.Text = "0,99";
                    break;
            }
            sum_petrol = Convert.ToDouble(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double result_petrol = 0;
                if (textBox3.Text.Length > 0)
                {
                    result_petrol = sum_petrol * Convert.ToDouble(textBox3.Text);
                }
                else
                {
                    result_petrol = 0;
                }
                textBox5.Text = result_petrol.ToString();
            }
            else if (!radioButton1.Checked)
            {
                textBox5.Text = null;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && textBox4.Text.Length > 0)
            {
                textBox5.Text = textBox4.Text;
            }
            else
            {
                textBox5.Text = Convert.ToString(0);
            }
        }

        double sum_cafe = 0;
        double hotdog = 0;
        double burger = 0;
        double potato = 0;
        double cola = 0;

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && textBox13.Text.Length > 0)
            {
                sum_cafe = Convert.ToDouble(textBox6.Text);
                hotdog = sum_cafe * Convert.ToDouble(textBox13.Text);
            }
            else
            {
                hotdog = 0;
            }
            textBox14.Text = hotdog.ToString();

            if (!checkBox1.Checked)
            {
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && textBox12.Text.Length > 0)
            {
                sum_cafe = Convert.ToDouble(textBox7.Text);
                burger = sum_cafe * Convert.ToDouble(textBox12.Text);
            }
            else
            {
                burger = 0;
            }
            textBox14.Text = burger.ToString();

            if (!checkBox2.Checked)
            {
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked && textBox10.Text.Length > 0)
            {
                sum_cafe = Convert.ToDouble(textBox8.Text);
                potato = sum_cafe * Convert.ToDouble(textBox10.Text);
            }
            else
            {
                potato = 0;
            }
            textBox14.Text = potato.ToString();

            if (!checkBox3.Checked)
            {
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked && textBox11.Text.Length > 0)
            {
                sum_cafe = Convert.ToDouble(textBox9.Text);
                cola = sum_cafe * Convert.ToDouble(textBox11.Text);
            }
            else
            {
                cola = 0;
            }
            textBox14.Text = cola.ToString();

            if (!checkBox4.Checked)
            {
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void exitCtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            benz.Text = "";

            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            textBox14.Text = null;
            textBox15.Text = null;
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "грн.";
            label4.Text = "грн.";
            label5.Text = "грн.";
            label8.Text = "грн.";
            label9.Text = "грн.";
        }
    }
}
