using CarW.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarW.Window
{
    public partial class Order : Form
    {
        string id_c;
        SqlConnection con_p;
        DataGridViewSelectedCellCollection sel;
        public Order(string clientId, SqlConnection con, DataGridViewSelectedCellCollection sel)
        {
            this.id_c = clientId;
            this.con_p = con;
            this.sel = sel;
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB_AS.DB_CH_CARS(con_p, id_c);
            label1.Text = DB_AS.DB_NAME_CLIENT(con_p, sel);
            label4.Text = DB_AS.DB_ID_CLIENT(con_p, sel);
            dataGridView1.Columns["car_id"].Visible = false;
            final.Location = new Point(15, 199);

            // Загрузка данных в comboBox1
            LoadComboBoxFromDatabase();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var sel_car = dataGridView1.SelectedCells;
            try
            {
                marka.Text = sel_car[1].Value.ToString();
                models.Text = sel_car[2].Value.ToString();
                bodwork.Text = sel_car[3].Value.ToString();
            }
            catch 
            {
                MessageBox.Show("Выберите всю запись!","Подсказка");
            }

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if(marka.Text != "" && models.Text != "" && bodwork.Text != "")
            DB_AS.DB_ADDCAR(con_p, marka.Text,models.Text,bodwork.Text,id_c);
            dataGridView1.DataSource = DB_AS.DB_CH_CARS(con_p, id_c);

        }
        public void LoadComboBoxFromDatabase()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DP.mdf;Initial Catalog=DP;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT ID, ServiceName FROM Servic";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            // Проверка на пустую таблицу
                            if (dataTable.Rows.Count > 0)
                            {
                                comboBox1.DataSource = dataTable;
                                comboBox1.DisplayMember = "ServiceName";
                                comboBox1.ValueMember = "ID";
                            }
                            else
                            {
                                MessageBox.Show("Справочник услуг пуст!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int com = Convert.ToInt32(comboBox1.SelectedValue);
                dataGridView1.Location = new Point(121, 64);
                label5.Text = DB_AS.DB_COMB_SERV(con_p, com);
                label7.Text = DB_AS.DB_COMB_SERV_prise(con_p, com);
                calculate.Visible = true;
                marka.Visible = true;
                final.Location = new Point(15, 228);
                models.Visible = true;
                bodwork.Visible = true;
                label2.Visible = true;
                model.Visible = true;
                bodywork.Visible = true;
            }
            else
            {
                dataGridView1.Location = new Point(15, 64);
                final.Location = new Point(15, 199);
                marka.Visible = false;
                models.Visible = false;
                bodwork.Visible = false;
                label2.Visible = false;
                model.Visible = false;
                bodywork.Visible = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int com = comboBox1.SelectedIndex + 1;
            label5.Text = DB_AS.DB_COMB_SERV(con_p,com);
            label7.Text = DB_AS.DB_COMB_SERV_prise(con_p,com);
        }

        private void final_Click(object sender, EventArgs e)
        {
            // Проверяем выбор автомобиля
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите автомобиль!");
                return;
            }

            // Получаем car_id из выбранной строки
            string id_car = dataGridView1.SelectedRows[0].Cells["car_id"].Value?.ToString();

            // Проверяем выбор услуги
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Выберите услугу!");
                return;
            }

            int id_serv = Convert.ToInt32(comboBox1.SelectedValue);

            // Добавляем заказ только после проверок
            DB_AS.DB_ORDER_add(con_p, id_car, id_serv, label4.Text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"{comboBox2.Text} LIKE '%{textBox1.Text}%'";
        }
    }
}
