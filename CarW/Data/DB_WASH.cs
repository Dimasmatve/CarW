using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Threading;

namespace CarW.Data
{
    public class DB_WASH
    {
        public static DataTable SELECT_TABLE(SqlConnection con, string sel)
        {
            SqlDataAdapter sda = null;
            if(sel == "Order")
            {
                sda = new SqlDataAdapter(@"SELECT   
                Cars.brand,    
                Cars.model,    
                Cars.body_type,   
                [Order].DateAdded,    
                [Order].[Status], [Order].[order_id]FROM   
                Cars INNER JOIN     
                [Order] ON Cars.car_id = [Order].car_id WHERE  
                [Order].[Status] = N'Готов к выполнению';", con);
            }
            else if(sel == "Supplies")
            {
                sda = new SqlDataAdapter("SELECT * FROM Supplies", con);
            }
            if ( sda == null ) 
            {
                MessageBox.Show("Таблица не найдена", "Ошибка");
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static void ADD_SUPLI(SqlConnection con, string pn, string desc, string qua)
        {
            if (qua == "0") qua = "1";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter($"INSERT INTO Supplies([Product_Name],Descript,Quantity,Status) VALUES(N'{pn}', N'{desc}','{qua}',N'Требует заказа')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Запрос добавлен", "Заявка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Добавление не выполнено");
            }
            
        }
        public static void CLOSE_ORD(SqlConnection con, DataGridViewSelectedCellCollection ro)
        {
            try
            {
                SqlDataAdapter sda = null;
                sda = new SqlDataAdapter($"UPDATE [Order] SET Status = N'Завершен' WHERE order_id = {ro[5].Value.ToString()}", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка");
            }          
        }
    }

}
