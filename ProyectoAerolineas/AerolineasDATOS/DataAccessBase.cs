using Npgsql;

namespace AerolineasDATOS
{
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