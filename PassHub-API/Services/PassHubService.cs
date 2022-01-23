using PassHub_API.DataAccess;
using PassHub_API.Models;
using System.Collections.Generic;

namespace PassHub_API.Services
{
	public class PassHubService : IPassHubService
	{
		public List<Login> GetAllPasswords(string userID)
		{
			return new List<Login>();
		}
	}
}
