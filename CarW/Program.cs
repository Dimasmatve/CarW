using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CarW
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void AttachDatabase()
        {
            string mdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DP.mdf");
            string ldfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DP_log.ldf");

            using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\\MSSQLLocalDB;Integrated Security=True"))// подключение к бд
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($@"
                CREATE DATABASE [DP]
                ON (FILENAME = '{mdfPath}'),
                   (FILENAME = '{ldfPath}')
                FOR ATTACH;
            ", conn);
                    cmd.ExecuteNonQuery();
                }
                catch { }
            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AttachDatabase();

            Application.Run(new Avt());
        }
    }
}
