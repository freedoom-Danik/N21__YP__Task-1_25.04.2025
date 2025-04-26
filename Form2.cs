using N21__YP__Task_1_25._04._2025.Data;
using N21__YP__Task_1_25._04._2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Обработчик кнопки "Расписание"
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"""D:\Documents\Desktop\расп.docx"""; // Укажите путь к документу
            Process.Start(path);
        }

        // Обработчик кнопки "Сотрудники"
        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = DB.CreateContext())
            {
                Sotr sotr = new Sotr();
                sotr.Show();
            }
        }

        // Обработчик кнопки "Клиенты"
        private void button3_Click(object sender, EventArgs e)
        {
            Klients cl = new Klients();
            cl.Show();
        }
    }
}
