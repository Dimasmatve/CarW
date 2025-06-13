using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CarW.Data
{
    public class DB_AS
    {
        public static SqlConnection DB_CON()// просто подключение к бд
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DP.mdf;Initial Catalog=DP;Integrated Security=True;Connect Timeout=30"); //сдесь строку ставить и резать до того как и тут
            return con;
        }
        public static string DB_AVT(SqlConnection con, string log, string pas)//авторизация с возварщением ID
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT employee_id FROM employ WHERE [logen] = '{log}' AND [passw] = '{pas}'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string tex;
            if (dt.Rows.Count > 0)
            {
                tex = dt.Rows[0]["employee_id"].ToString();
                DB_HIS(con, tex);

            }
            else
            {
                tex = "0";
            }
            return tex;
        }
        public static void DB_HIS(SqlConnection con, string id)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"INSERT INTO [Login_History](employ_ID) VALUES(N'{id}')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
        public static string DB_INI_ROULE(SqlConnection con, string id)// возвращает роль сотрудника
        {
            // Убираем апострофы вокруг {id}, так как employee_id — числовой тип
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT roule FROM employ WHERE [employee_id] = {id}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string rou_f = "0";

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["roule"].ToString() == "менеджер")
                {
                    rou_f = "1";
                }
                else if (dt.Rows[0]["roule"].ToString() == "администратор")
                {
                    rou_f = "2";
                }
                else if (dt.Rows[0]["roule"].ToString() == "мойщик") 
                {
                    rou_f = "3";
                }
            }
            else
            {
                rou_f = "0"; // Роль не найдена
            }
            return rou_f;
        }
        public static string DB_CHECK_ST(SqlConnection con_p, string id)// доработанный
        {
            string query = @"SELECT s.title, s.access FROM employ e INNER JOIN [State] s ON e.state = s.state_id WHERE e.employee_id = @id";

            SqlDataAdapter sda = new SqlDataAdapter(query, con_p);
            sda.SelectCommand.Parameters.AddWithValue("@id", id); 

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string stat = dt.Rows[0]["title"].ToString();
                string acs = dt.Rows[0]["access"].ToString();
                MessageBox.Show(stat, "Статус");
                return acs;
            }
            else
            {
                MessageBox.Show("Данные не найдены", "Ошибка");
                return null;
            }
        }

        public static string DB_NAME_EMP(SqlConnection con, string id)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT full_name FROM employ WHERE employee_id = {id}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string tex;
            tex = dt.Rows[0]["full_name"].ToString();
            return tex;
        }
        public static DataTable DB_LODTAB(SqlConnection con, string tb)
        {
            SqlDataAdapter sda = null;

            if (tb == "client")
            {
                sda = new SqlDataAdapter("SELECT * FROM Clients", con);
            }
            else if(tb == "auto")
            {
                sda = new SqlDataAdapter("SELECT * FROM Auto", con);
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static void DB_ADD_CLIENT(SqlConnection con,string fio, string phone)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"INSERT INTO Clients(client_full_name, phone_number) VALUES(N'{fio}', N'{phone}')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
        public static string DB_ID_CLIENT(SqlConnection con, DataGridViewSelectedCellCollection ro)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT client_id FROM Clients WHERE client_id = {ro[0].Value.ToString()}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string fio;
            fio = dt.Rows[0]["client_id"].ToString();
            return fio;
        }
        public static string DB_NAME_CLIENT(SqlConnection con, DataGridViewSelectedCellCollection ro)//доработана
        {
            try
            {
                // Проверяем, что коллекция ячеек не пустая и что первая ячейка существует
                if (ro == null || ro.Count == 0 || ro[0].Value == null)
                {
                    return "Не выбрана запись"; // Можно вернуть сообщение об ошибке или другое значение по умолчанию
                }

                // Получаем значение из выбранной ячейки
                string clientId = ro[0].Value.ToString();

                // Создаем адаптер и заполняем DataTable
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT client_full_name FROM Clients WHERE client_id = {clientId}", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Проверяем, что в таблице есть хотя бы одна строка
                if (dt.Rows.Count == 0)
                {
                    return "Запись не найдена"; // Можно вернуть сообщение об ошибке или другое значение по умолчанию
                }

                // Получаем значение из первой строки
                string fio = dt.Rows[0]["client_full_name"].ToString();

                return fio;
            }
            catch (Exception ex)
            {
                // Логируем ошибку или возвращаем сообщение об ошибке
                return $"Произошла ошибка: {ex.Message}";
            }
        }
        public static DataTable DB_CH_CARS(SqlConnection con, string id)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM Cars WHERE client_id = {id} ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        //public static string GetClientIdByCarId(SqlConnection con, int carId)// мб снести
        //{
        //    using (SqlCommand cmd = new SqlCommand("SELECT client_id FROM Cars WHERE car_id = @CarId", con))
        //    {
        //        cmd.Parameters.AddWithValue("@CarId", carId);
        //        object result = cmd.ExecuteScalar();
        //        return result?.ToString() ?? "";
        //    }
        //}
        public static void DB_ADDCAR(SqlConnection con,string mark, string model, string bod, string c_id)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"INSERT INTO Cars(brand, model, body_type, client_id) VALUES(N'{mark}', N'{model}', N'{bod}', '{c_id}')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
        public static string DB_COMB_SERV(SqlConnection con,int id)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT Descript FROM Servic WHERE ID = {id}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string des;
            des = dt.Rows[0]["Descript"].ToString();
            return des;
        }
        public static string DB_COMB_SERV_prise(SqlConnection con, int id)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT Cost FROM Servic WHERE ID = {id}", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string des;
            des = dt.Rows[0]["Cost"].ToString();
            return des;
        }
        public static void DB_ORDER_add(SqlConnection con, string car_id, int servic_id, string client_id)// нужно переработать, но вообще работает
        {
            SqlDataAdapter sda = new SqlDataAdapter($"INSERT INTO [Order](car_id, servic_id, client_id, Status) " +
                $"VALUES(N'{car_id}', N'{servic_id}', N'{client_id}', N'Готов к выполнению')", con);
            DataTable dt = new DataTable();
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Ошибка, выберите существующую запись");
            }
            else if(dt.Rows.Count <= 0)
            {
                sda.Fill(dt);
                MessageBox.Show("Создан заказ", "Запрос");
            }
;
        }
        // !!!
        internal static void DeleteRecord(SqlConnection con_p, string tableName, int id)// Вот эта срашная говнина вторая часть в DB_ADM
        {
            if (con_p.State != ConnectionState.Open) con_p.Open();

            using (SqlTransaction transaction = con_p.BeginTransaction())
            {
                try
                {
                    // Проверка наличия зависимых записей в Order
                    if (tableName == "Cars")
                    {
                        // Проверяем, есть ли заказы с этим car_id
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM [Order] WHERE car_id = @Id", con_p, transaction);
                        checkCmd.Parameters.AddWithValue("@Id", id);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            DialogResult result = MessageBox.Show(
                                "У этого автомобиля есть активные заказы. Удалить все связанные заказы?",
                                "Подтверждение",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                            if (result != DialogResult.Yes)
                            {
                                transaction.Rollback();
                                return;
                            }

                            // Удаляем связанные заказы
                            SqlCommand deleteOrdersCmd = new SqlCommand("DELETE FROM [Order] WHERE car_id = @Id", con_p, transaction);
                            deleteOrdersCmd.Parameters.AddWithValue("@Id", id);
                            deleteOrdersCmd.ExecuteNonQuery();
                        }
                    }

                    // Удаляем основную запись
                    SqlCommand deleteCmd = new SqlCommand($"DELETE FROM {tableName} WHERE car_id = @Id", con_p, transaction);
                    deleteCmd.Parameters.AddWithValue("@Id", id);
                    deleteCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
                finally
                {
                    if (con_p.State == ConnectionState.Open) con_p.Close();
                }
            }
        }
    }
}

