using MySql.Data.MySqlClient;
using System.Data;

public class DBHelper
{
    private string connStr = "server=localhost;user id=root;password=123;database=projectadb26;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connStr);
    }

    public void ExecuteQuery(string query)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }

    public DataTable GetData(string query)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}