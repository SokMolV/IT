using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Получаем номер выделенной строки     
            int index = listBox1.SelectedIndex;
            // Считываем строку в перменную str     
            string str = (string)listBox1.Items[index];
            // Узнаем количество символов в строке     
            int len = str.Length;
            // Считаем, что количество пробелов равно 0     
            int count = 0;
            // Устанавливаем счетчик символов в 0     
            int i = 0;
            //Организуем цикл перебора всех символов в строке     
            while (i < len - 1)
            {
                // Если нашли пробел, то увеличиваем счетчик пробелов на 1         
                if (str[i] == 'а')
                    count++;
                i++;
            }
            label1.Text = "Количество букв а = " + count.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {    
            int index = listBox1.SelectedIndex;    
            string str = (string)listBox1.Items[index];  
            int len = str.Length;   
            int count = 0;   
            int i = 0; 
            while (i < len - 1)
            {      
                if (str[i] == 'а')
                    count++;
                i++;
            }
            str = str.Replace("а", "*");
            label1.Text = " " + str.ToString();
        }
    }
}
