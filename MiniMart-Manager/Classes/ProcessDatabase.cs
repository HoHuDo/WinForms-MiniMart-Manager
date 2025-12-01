using Microsoft.Data.SqlClient;
using System.Data;

namespace MiniMart_Manager.Classes
{
    internal class ProcessDatabase
    {
        string strConnect = "Data source=LAPTOP-HOAKR68B\\SQLEXPRESS; DataBase=MarketManager;User Id=sa;Password=123;TrustServerCertificate=True;";
        SqlConnection sqlCnn = null;

        void OpenConnect()
        {
            sqlCnn = new SqlConnection(strConnect);
            if (sqlCnn.State != ConnectionState.Open)
            {
                sqlCnn.Open();
            }
        }

        void CloseConnect()
        {
            if (sqlCnn != null && sqlCnn.State != ConnectionState.Closed)
            {
                sqlCnn.Close();
                sqlCnn.Dispose();
            }
        }

        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, sqlCnn);
            adapter.Fill(dt);
            CloseConnect();
            adapter.Dispose();
            return dt;
        }

        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = sqlCnn;
            cmd.ExecuteNonQuery();
            CloseConnect();
            cmd.Dispose();
        }

        public int CountRecordsWithFilter(string tenKhach, string sdt)
        {
            string countQuery = "SELECT COUNT(*) FROM KhachHang WHERE TenKhachHang LIKE @TenKhach AND SoDienThoai LIKE @SDT";
            int totalRecords = 0;

            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(countQuery, sqlCnn);

                cmd.Parameters.AddWithValue("@TenKhach", $"%{tenKhach}%");
                cmd.Parameters.AddWithValue("@SDT", $"%{sdt}%");

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalRecords = Convert.ToInt32(result);
                }
            }
            finally
            {
                CloseConnect();
            }
            return totalRecords;
        }

        public DataTable ReadPagedDataWithFilter(int offset, int pageSize, string tenKhach, string sdt)
        {
            DataTable dt = new DataTable();

            string dataQuery = $@"
                SELECT * FROM KhachHang 
                WHERE TenKhachHang LIKE @TenKhach AND SoDienThoai LIKE @SDT
                ORDER BY MaKhachHang
                OFFSET @Offset ROWS 
                FETCH NEXT @PageSize ROWS ONLY";

            try
            {
                OpenConnect();
                SqlDataAdapter adapter = new SqlDataAdapter(dataQuery, sqlCnn);

                adapter.SelectCommand.Parameters.AddWithValue("@Offset", offset);
                adapter.SelectCommand.Parameters.AddWithValue("@PageSize", pageSize);
                adapter.SelectCommand.Parameters.AddWithValue("@TenKhach", $"%{tenKhach}%");
                adapter.SelectCommand.Parameters.AddWithValue("@SDT", $"%{sdt}%");

                adapter.Fill(dt);
                adapter.Dispose();
            }
            finally
            {
                CloseConnect();
            }
            return dt;
        }
        public int CountNhanVien(string tenNV)
        {
            string countQuery = "SELECT COUNT(*) FROM NhanVien WHERE TenNhanVien LIKE @TenNV";
            int totalRecords = 0;

            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(countQuery, sqlCnn);
                cmd.Parameters.AddWithValue("@TenNV", $"%{tenNV}%");

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalRecords = Convert.ToInt32(result);
                }
            }
            finally
            {
                CloseConnect();
            }
            return totalRecords;
        }

        public DataTable ReadPagedNhanVien(int offset, int pageSize, string tenNV)
        {
            DataTable dt = new DataTable();
            string dataQuery = $@"
                        SELECT * FROM NhanVien 
                        WHERE TenNhanVien LIKE @TenNV
                        ORDER BY MaNhanVien
                        OFFSET @Offset ROWS 
                        FETCH NEXT @PageSize ROWS ONLY";

            try
            {
                OpenConnect();
                SqlDataAdapter adapter = new SqlDataAdapter(dataQuery, sqlCnn);

                adapter.SelectCommand.Parameters.AddWithValue("@Offset", offset);
                adapter.SelectCommand.Parameters.AddWithValue("@PageSize", pageSize);
                adapter.SelectCommand.Parameters.AddWithValue("@TenNV", $"%{tenNV}%");

                adapter.Fill(dt);
                adapter.Dispose();
            }
            finally
            {
                CloseConnect();
            }
            return dt;
        }
        public int CountSanPham(string tenSP, string maLoai)
        {
            string countQuery = "SELECT COUNT(*) FROM SanPham WHERE TenSanPham LIKE @Ten";

            if (!string.IsNullOrEmpty(maLoai) && maLoai != "0")
            {
                countQuery += " AND MaLoaiHang = @MaLoai";
            }

            int totalRecords = 0;
            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(countQuery, sqlCnn);
                cmd.Parameters.AddWithValue("@Ten", $"%{tenSP}%");

                if (!string.IsNullOrEmpty(maLoai) && maLoai != "0")
                {
                    cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                }

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalRecords = Convert.ToInt32(result);
                }
            }
            finally
            {
                CloseConnect();
            }
            return totalRecords;
        }
        public DataTable ReadPagedSanPham(int offset, int pageSize, string tenSP, string maLoai)
        {
            DataTable dt = new DataTable();
            string dataQuery = "SELECT * FROM SanPham WHERE TenSanPham LIKE @Ten";

            if (!string.IsNullOrEmpty(maLoai) && maLoai != "0")
            {
                dataQuery += " AND MaLoaiHang = @MaLoai";
            }

            dataQuery += " ORDER BY MaSanPham OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

            try
            {
                OpenConnect();
                SqlDataAdapter adapter = new SqlDataAdapter(dataQuery, sqlCnn);
                adapter.SelectCommand.Parameters.AddWithValue("@Ten", $"%{tenSP}%");

                if (!string.IsNullOrEmpty(maLoai) && maLoai != "0")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@MaLoai", maLoai);
                }

                adapter.SelectCommand.Parameters.AddWithValue("@Offset", offset);
                adapter.SelectCommand.Parameters.AddWithValue("@PageSize", pageSize);

                adapter.Fill(dt);
                adapter.Dispose();
            }
            finally
            {
                CloseConnect();
            }
            return dt;
        }
        public int CountNhaCungCap(string tenNCC)
        {
            string countQuery = "SELECT COUNT(*) FROM NhaCungCap WHERE TenNhaCungCap LIKE @Ten";
            int totalRecords = 0;
            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(countQuery, sqlCnn);
                cmd.Parameters.AddWithValue("@Ten", $"%{tenNCC}%");
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalRecords = Convert.ToInt32(result);
                }
            }
            finally
            {
                CloseConnect();
            }
            return totalRecords;
        }

        public DataTable ReadPagedNhaCungCap(int offset, int pageSize, string tenNCC)
        {
            DataTable dt = new DataTable();
            string dataQuery = @"
        SELECT * FROM NhaCungCap 
        WHERE TenNhaCungCap LIKE @Ten
        ORDER BY MaNhaCungCap
        OFFSET @Offset ROWS 
        FETCH NEXT @PageSize ROWS ONLY";

            try
            {
                OpenConnect();
                SqlDataAdapter adapter = new SqlDataAdapter(dataQuery, sqlCnn);
                adapter.SelectCommand.Parameters.AddWithValue("@Offset", offset);
                adapter.SelectCommand.Parameters.AddWithValue("@PageSize", pageSize);
                adapter.SelectCommand.Parameters.AddWithValue("@Ten", $"%{tenNCC}%");
                adapter.Fill(dt);
                adapter.Dispose();
            }
            finally
            {
                CloseConnect();
            }
            return dt;
        }
    }
}