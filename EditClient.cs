using N21__YP__Task_1_25._04._2025.Data;
using N21__YP__Task_1_25._04._2025.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class EditClient : Form
    {
        private Clients _client;

        public EditClient(Clients client)
        {
            InitializeComponent();
            _client = client;
            LoadClientData();
        }

        private void LoadClientData()
        {
            textBox1.Text = _client.Фио;
            maskedTextBox1.Text = _client.Телефон;
            textBox2.Text = _client.Почта;
            comboBox1.Text = _client.Разряд;
            maskedTextBox2.Text = _client.Дата_Регистрации.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = DB.CreateContext())
            {
                _client.Фио = textBox1.Text;
                _client.Телефон = maskedTextBox1.Text;
                _client.Почта = textBox2.Text;
                _client.Разряд = comboBox1.Text;
                _client.Дата_Регистрации = DateTime.Parse(maskedTextBox2.Text);
                _client.Группа = GetGroup(_client.Возраст);

                db.Clients.Update(_client);
                db.SaveChanges();

                MessageBox.Show("Данные успешно обновлены!");
                this.Close();
            }
        }

        private string GetGroup(int age)
        {
            if (age <= 9) return "A1";
            if (age <= 16) return "A2";
            if (age <= 25) return "Б";
            return "В";
        }
    }
}