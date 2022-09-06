using System.Data.SqlClient;

const string connection = "server=localhost,1433;database=Northwind;uid=sa;pwd=Pro247!!;";
SqlConnection con = new SqlConnection(connection);
//con.ConnectionString = connection;


SqlCommand cmd = new SqlCommand("select ProductName, ProductId from Products", con);
if (con.State == System.Data.ConnectionState.Closed)
    con.Open();

SqlDataReader dr = cmd.ExecuteReader();
while (dr.Read())
{
    Console.WriteLine($"{dr["ProductId"]} -> {dr["ProductName"]}");
}

dr.Close();
con.Close();


