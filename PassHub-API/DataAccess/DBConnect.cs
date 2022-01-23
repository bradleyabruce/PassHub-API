using MySql.Data.MySqlClient;
using PassHub_API.Helpers.Constants;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PassHub_API.Helpers.Constants.Enums;

namespace PassHub_API.DataAccess
{
	public class DBConnect
	{
		private MySqlConnection connection;

		public DBConnect()
		{
			Initialize();
		}

		private void Initialize()
		{
			var connString = string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3}", DBConstants.Server, DBConstants.Database, DBConstants.UserID, DBConstants.Password);
			connection = new MySqlConnection(connString);
		}

		private bool OpenConnection()
		{
			try
			{
				connection.Open();
				return true;
			}
			catch
			{
				return false;
			}
		}

		private bool CloseConnection()
		{
			try
			{
				connection.Close();
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void CreateQuery(QueryType queryType, string query, Dictionary<string, string> parameters)
		{
			var command = new MySqlCommand(query, connection);
			foreach(var key in parameters.Keys)
			{
				command.Parameters.AddWithValue(key, parameters[key]);
			}

			switch(queryType)
			{
				case QueryType.Select:
					break;
				case QueryType.Insert:
					break;
				case QueryType.Update:
					break;
				case QueryType.Delete:
					break;
			}
		}

		private void Insert(string query, Dictionary<string, string> parameters)
		{
			
		}
	}
}
