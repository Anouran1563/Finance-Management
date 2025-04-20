using Microsoft.Data.SqlClient;

namespace Finance_Management
{
    class catData
    {
        string stringConnection = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Dokumente\Expense.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID       { set; get; }
        public string Name     { set; get; } // 1
        public string Type     { set; get; } // 2
        public string Status   { set; get; } // 3
        public string DoC      { set; get; }

        public List<catData> CatListData
        {
            get
            {
            
                List<catData> listData = new List<catData>();

                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();
                    string selectData = "SELECT * FROM CATEGORY";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            catData cData = new catData();
                            cData.ID = (int)reader["id"];
                            cData.Name = reader["category"].ToString();
                            cData.Type = reader["type"].ToString();
                            cData.Status = reader["status"].ToString();
                            cData.DoC = reader["DoC"].ToString();

                            listData.Add(cData);
                        }

                    }
                }
                return listData;
            }
        }
    }
}
