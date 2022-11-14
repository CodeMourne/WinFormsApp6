using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            for (int x = 1; x < 11; x++)
            {
                var fn = Outer();   // fn = Inner, так как метод Outer возвращает функцию Inner
                                    // вызываем внутреннюю функцию Inner
                fn();

                Action Outer()  // метод или внешняя функция
                {
                    int x = 1;  // лексическое окружение - локальная переменная
                    void Inner()    // локальная функция
                    {
                        x++;        // операции с лексическим окружением
                    }
                    return Inner;   // возвращаем локальную функцию
                }
                listBox1.Items.Add($"x = {x}");

            }
            listBox1.Items.Add($"Я хочу питсы");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
