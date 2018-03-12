namespace AerolineasDATOS
{
    /// <summary>
    /// this class makes the connection to the database in general
    /// </summary>
    public class ConnectionStringProvider
    {
        public string GetConnectionString()
        {
            const string servidor = "localhost";
            const int puerto = 5432;
            const string usuario = "postgres";
            const string clave = "1234";
            const string baseDatos = "aerolinea";

            var connectionString = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" +
                                   "Password=" + clave + ";" + "Database=" + baseDatos;

            return connectionString;
        }
    }
}