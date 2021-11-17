using System;
using MySqlConnector;

namespace cs_aspnet_dapper
{
  public class Db : IDisposable
  {
    public readonly MySqlConnection Connection;

    public Db(string connectionString)
    {
      Connection = new MySqlConnection(connectionString);
    }

    public void Dispose() => Connection.Dispose();
  }
}