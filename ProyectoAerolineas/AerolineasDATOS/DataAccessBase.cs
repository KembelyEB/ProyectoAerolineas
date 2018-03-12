using Npgsql;

namespace AerolineasDATOS
{
    /// <summary>
    /// this class obtains the method that executes queries to the database
    /// </summary>
    public class DataAccessBase
    {
        public void ExecuteNonQuery(string sql)
        {
            var connectioStringProvider = new ConnectionStringProvider();
            var connection = new NpgsqlConnection(connectioStringProvider.GetConnectionString());

            connection.Open();
            var command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}