using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarW.Data
{
    //Данный класс создан исключительно для администатора
    public class DB_ADM
    {
        public static DataTable SELECT_TABLE(SqlConnection con, string sel)
        {
            SqlDataAdapter sda = null;
            sda = new SqlDataAdapter($"SELECT * FROM [{sel}]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static void DELETE(SqlConnection con, DataGridViewSelectedCellCollection ro,string db, string id)
        {
            //заготовка для других таблиц
        }
        public static void UPDATE(SqlConnection con, DataGridViewSelectedCellCollection ro, string one, string two,string three,string four, string five, string vib)
        {
            SqlDataAdapter sda = null;
            if ( vib == "0")
            {
                sda = new SqlDataAdapter($"UPDATE Cars SET brand = N'{one}', model = '{two}', body_type = '{three}' WHERE car_id = {ro[0].Value.ToString()}", con);
            }
            else if ( vib == "1")
            {
                sda = new SqlDataAdapter($"UPDATE Clients SET client_full_name = N'{one}', phone_number = N'{two}' WHERE client_id = {ro[0].Value.ToString()}", con);
            }
            else if (vib == "2")
            {
                sda = new SqlDataAdapter($"UPDATE employ SET logen = N'{one}', passw = '{two}', full_name = N'{three}', roule = N'{four}', salary = N'{five}'" +
                    $"WHERE employee_id = {ro[0].Value.ToString()}", con);
            }
            else if (vib == "3")
            {
                MessageBox.Show("Изменения невозможны");
            }
            else if (vib == "4")
            {
                sda = new SqlDataAdapter($"UPDATE [Order] SET Status = N'{one}' WHERE order_id = {ro[0].Value.ToString()}", con);
            }
            else if (vib == "5")
            {
                decimal tw_i = Convert.ToInt32(two);
                sda = new SqlDataAdapter($@"UPDATE Servic SET ServiceName = N'{one}', Cost = {tw_i}, [Descript] = N'{three}' WHERE supli_id = {ro[0].Value.ToString()}", con);
            }
            else if (vib == "6")
            {
                sda = new SqlDataAdapter($@"UPDATE Supplies SET Status = N'{one}' WHERE supli_id = {ro[0].Value.ToString()}", con);
            }
            if (sda == null)
            {
                MessageBox.Show("Изменения не выполнены","Ошибка");
            }
            else
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
        }
        public static void INSERT_DATA(SqlConnection con, string one, string two, string three, string four, string five, string vib)
        {
            SqlDataAdapter sda = null;
            if ( vib == "2")
            {
                sda = new SqlDataAdapter($"INSERT INTO employ(logen, passw, full_name, roule, salary) VALUES(N'{one}', '{two}',N'{three}',N'{four}',N'{five}')", con);
            }
            else if( vib == "5")
            {
                sda = new SqlDataAdapter($"INSERT INTO Servic(ServiceName, Cost, Descript) VALUES(N'{one}', N'{two}',N'{three}')", con);
            }
            if (sda == null)
            {
                MessageBox.Show("Изменения не выполнены, проверьте корректность вводимых данных", "Ошибка");
            }
            else
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
        }
        // !!!
        public static void DeleteRecord(SqlConnection con, string tableName, int id)// Вторая часть удаления машины из таблицы. Смысл под сомнением. Но вообще работает
        {
            if (con.State != ConnectionState.Open) con.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;

                // Используем корректное имя столбца для таблицы Cars
                if (tableName == "Cars")
                {
                    cmd.CommandText = $"DELETE FROM {tableName} WHERE car_id = @Id";
                }
                else
                {
                    cmd.CommandText = $"DELETE FROM {tableName} WHERE id = @Id";
                }

                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
                finally
                {
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
        }

    }
}
