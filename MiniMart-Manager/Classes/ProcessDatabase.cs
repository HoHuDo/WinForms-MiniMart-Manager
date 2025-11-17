using Microsoft.Data.SqlClient;
using System.Data;
namespace MiniMart_Manager.Classes
{
    internal class ProcessDatabase
    {
        //B1: Khai báo chuỗi kết nối
        string strConnect = "Data source=LAPTOP-HOAKR68B\\SQLEXPRESS; DataBase=MarketManager;User Id=sa;Password=123;TrustServerCertificate=True;";
        SqlConnection sqlCnn = null;
        //Create a Method to Connect to a DataBase
        void OpenConnect()
        {
            sqlCnn = new SqlConnection(strConnect);
            if (sqlCnn.State != ConnectionState.Open)
            {
                sqlCnn.Open();
            }
        }
        //Create a method to disConnect to DataBase
        void CloseConnect()
        {
            if (sqlCnn != null && sqlCnn.State != ConnectionState.Closed)
            {
                sqlCnn.Close();
                sqlCnn.Dispose();
            }
        }
        //Creare a method to excute a Select command and return a DataTable
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            //B1,2: Khai báo chuỗi kết nối và mở Kết nối
            OpenConnect();
            //B3: Tạo lệnh SQL --> Tham số hàm
            //B4: Thực thi lệnh
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, sqlCnn);
            adapter.Fill(dt);
            //B5: Đóng kết nối
            CloseConnect();
            adapter.Dispose();
            return dt;
        }

        //Create a method to excute command: insert, update and selete
        public void UpdateData(string sql)
        {
            //B1,2: Khai báo chuỗi kết nối và mở Kết nối
            OpenConnect();
            //B3: Tạo lệnh SQL --> Tham số hàm
            //B4: Thực thi lệnh
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = sqlCnn;
            cmd.ExecuteNonQuery();
            //B5: Đóng kết nối
            CloseConnect();
            cmd.Dispose();
        }

    }
}
