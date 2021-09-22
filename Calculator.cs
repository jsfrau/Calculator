using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Калькулятор : Form
    {

        public Калькулятор()
        {
            InitializeComponent();
            Podskazka();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        public static int a, b, c, dlyaif1, dlyaif2, dlyaif3;
        public static double d, f, g, h, i, j, number;


        public static double[] array = new double[] { 1, 0.1, 0.01, 0.1, 0.01, 0.001, 0.000001, 0.000000001, 0.00378541, 0.000946353, 0.0005, 0.158987, 0.00024, 0.000015, 0.000005 };

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Podskazka();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            Podskazka();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Podskazka_Delete_1();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Podskazka_Delete_2();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Конвертер form1 = new Конвертер();
            form1.Show();
        }

        public static string k,stroka1,stroka2;

        private void button2_Click_1(object sender, EventArgs e)
        {
            stroka1 = textBox1.Text;
            stroka2 = textBox2.Text;
            string textbox_1 = textBox1.Text;
            int index_1 = comboBox1.SelectedIndex;
            bool uspeh1 = Double.TryParse(stroka1, out number);
            bool uspeh2 = Double.TryParse(stroka2, out number);
            if (uspeh1 & uspeh2 == true)
            {
                d = Convert.ToDouble(textBox1.Text);
                f = Convert.ToDouble(textBox2.Text);
                g = d * array[this.comboBox1.SelectedIndex];
                h = f * array[this.comboBox2.SelectedIndex];
                i = g - h;
                j = i / array[this.comboBox3.SelectedIndex];
                k = Convert.ToString(j);
                if (checkBox1.Checked == false)
                {
                    if (g < h)
                    {
                        textBox1.Text = textbox_1;
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = textbox_1;
                        comboBox1.SelectedIndex = comboBox2.SelectedIndex;
                        comboBox2.SelectedIndex = index_1;
                        textBox3.Text = Convert.ToString(Math.Abs(j));
                    }
                }
                else
                {
                    textBox3.Text = k;
                }
            }

            else
            {
                if (uspeh1 == false)
                {
                    textBox1.Text = "Введите число";
                }
                if (uspeh2 == false)
                {
                    textBox2.Text = "Введите число";
                }
            }

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            stroka1 = textBox1.Text;
            stroka2 = textBox2.Text;
            bool uspeh1 = Double.TryParse(stroka1, out number);
            bool uspeh2 = Double.TryParse(stroka2, out number);
            if (uspeh1 & uspeh2 == true)
            {
                d = Convert.ToDouble(textBox1.Text);
                f = Convert.ToDouble(textBox2.Text);
                g = d * array[comboBox1.SelectedIndex];
                h = f * array[comboBox2.SelectedIndex];
                i = g + h;
                j = i / array[comboBox3.SelectedIndex];
                k = Convert.ToString(j);
                textBox3.Text = k;
            }

            else
            {
                if (uspeh1 == false)
                    textBox1.Text = "Введите число";
                if (uspeh2 == false)
                    textBox2.Text = "Введите число";
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                dlyaif1 = 1;
            if (dlyaif1 == 1 & dlyaif2 == 1 & dlyaif3 == 1)
            { 
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
                dlyaif3 = 1;
            if (dlyaif1 == 1 & dlyaif2 == 1 & dlyaif3 == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
                dlyaif2 = 1;
            if (dlyaif1 == 1 & dlyaif2 == 1 & dlyaif3 == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
        public void Podskazka()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите число";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите число";
                textBox2.ForeColor = System.Drawing.Color.Gray;
            }
            
        }
        
        public void Podskazka_Delete_1()
        {
            textBox1.Text = null;
            textBox1.ForeColor = System.Drawing.Color.Black;
        }
        public void Podskazka_Delete_2()
        {
            textBox2.Text = null;
            textBox2.ForeColor = System.Drawing.Color.Black;
        }
    }
}