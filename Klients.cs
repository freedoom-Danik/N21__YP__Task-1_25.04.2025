using N21__YP__Task_1_25._04._2025.Data;
using System;
using System.Net.Sockets;
using System.Windows.Forms;
using N21__YP__Task_1_25._04._2025.Models;
using System.Linq;

namespace N21__YP__Task_1_25._04._2025
{
    public partial class Klients : Form
    {
        public Klients()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var db = DB.CreateContext())
            {
                dataGridView1.DataSource = db.Clients.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e) // Добавить клиента
        {
            AddClient addForm = new AddClient();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Изменить клиента
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using (var db = DB.CreateContext())
                {
                    var client = db.Clients.Find(id);
                    if (client != null)
                    {
                        EditClient editForm = new EditClient(client);
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // Удалить клиента
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using (var db = DB.CreateContext())
                {
                    var client = db.Clients.Find(id);
                    if (client != null)
                    {
                        db.Clients.Remove(client);
                        db.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // Обновить данные
        {
            LoadData();
        }

        private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e) // Сортировка по ФИО
        {
            using (var db = DB.CreateContext())
            {
                dataGridView1.DataSource = db.Clients.OrderBy(x => x.Фио).ToList();
            }
        }

        private void поРазрядамToolStripMenuItem_Click(object sender, EventArgs e) // Сортировка по разряду
        {
            using (var db = DB.CreateContext())
            {
                dataGridView1.DataSource = db.Clients.OrderBy(x => x.Разряд).ToList();
            }
        }

        private void поГруппамToolStripMenuItem_Click(object sender, EventArgs e) // Сортировка по группе
        {
            using (var db = DB.CreateContext())
            {
                dataGridView1.DataSource = db.Clients.OrderBy(x => x.Группа).ToList();
            }
        }
    }
}