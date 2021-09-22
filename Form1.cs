using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Конвертер : Form
    {
        public static int f, h, c, dlyaif1, dlyaif2;
        public static string d;
        public static double[] array = new double[] { 1, 0.1, 0.01, 0.1, 0.01, 0.001, 0.000001, 0.000000001, 0.003785, 0.000946353, 0.0005, 0.158987, 0.00024, 0.000015, 0.000005 };
        public static double vvodperviy, obrabotka, number, x;

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число")
            {
                textBox1.Text = null;
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Podskazka();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Конвертер_Load(object sender, EventArgs e)
        {

        }

        public Конвертер()
        {

            InitializeComponent();
            textBox1.Text = "Введите число";
            textBox1.ForeColor = System.Drawing.Color.Gray;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dlyaif1 = 0;
            dlyaif2 = 0;
            button1.Enabled = false;
            

        }


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                dlyaif1 = 1;

            if (dlyaif1 == 1 & dlyaif2 == 1)
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stroka1 = textBox1.Text;
           
            //Задаём логическую переменную uspeh для проверки вхождения текста в строку
            bool uspeh = Double.TryParse(stroka1, out number);

            //Если переменная успеха приняла значение true, тогда выолняем вычисление
            if (uspeh == true)
            {
                x = Convert.ToDouble(stroka1);
                c = this.comboBox1.SelectedIndex;
                h = this.comboBox2.SelectedIndex;
                vvodperviy = Convert.ToDouble(textBox1.Text);
                obrabotka = ((vvodperviy * array[c]) / array[h]);
                string rezf = Convert.ToString(obrabotka);
                this.textBox2.Text = rezf;
            }
            //Иначе обнуляем текстбокс1
            else
            {
                textBox1.Text = "0";
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex != -1)
            { dlyaif2 = 1; };
            if (dlyaif1 == 1 & dlyaif2 == 1)
            { button1.Enabled = true; };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.Hide();
            Калькулятор calculator = new Калькулятор();
            calculator.Show();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Podskazka()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите число";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }

}
