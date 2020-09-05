using System;

namespace DBConnectionModel
{
   

   public abstract class DBConnection
    {
        private string connectionString { get; }
        private TimeSpan timeOut { get; }

        protected DBConnection(string connectionString)
        {
            if(String.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Invalid Connection String");
            }
            this.connectionString = connectionString;

        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnection:DBConnection
    {
        public SqlConnection(string ConnectionString) : base(ConnectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Sql Connection Established");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection Closed");
        }
    }

    public class OracleConnection:DBConnection
    {
        public OracleConnection(string connectionString):base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection Established");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed");
        }

    }

    public class DBConnectionDemo
    {
        public static void Main(string[] args)
        {
            SqlConnection DB1 = new SqlConnection("sdsdfdfdds");
            OracleConnection DB2 = new OracleConnection("dfdjfrjgfgf");
            DB1.OpenConnection();
            DB1.CloseConnection();
            DB2.OpenConnection();
            DB2.CloseConnection();
        }
i    }
}
