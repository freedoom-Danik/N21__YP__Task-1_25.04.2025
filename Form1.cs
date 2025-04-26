using N21__YP__Task_1_25._04._2025;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработка нажатия кнопки "Вход"
        private void button1_Click(object sender, EventArgs e)
        {
            string password = "1234"; // Пароль администратора
            if (comboBox1.Text == "Администратор" && textBox1.Text == password)
            {
                MessageBox.Show("Вы успешно авторизировались!");
                Form2 f2 = new Form2(); // Открываем главную форму
                this.Hide(); // Скрываем форму авторизации
                f2.Show();
            }
            else
            {
                MessageBox.Show("Неверно введен пароль!");
            }
        }

        // Обработка закрытия окна через Label
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму авторизации
        }

        // Перемещение окна при зажатии ЛКМ
        Point LastPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y); // Сохраняем начальные координаты
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Если зажата левая кнопка мыши
            {
                this.Left += e.X - LastPoint.X; // Изменяем положение формы по горизонтали
                this.Top += e.Y - LastPoint.Y; // Изменяем положение формы по вертикали
            }
        }
    }
}