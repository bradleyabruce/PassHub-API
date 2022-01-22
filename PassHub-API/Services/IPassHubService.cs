using PassHub_API.Models;
using System.Collections.Generic;

namespace PassHub_API.Services
{
	public interface IPassHubService
	{
		List<Login> GetAllPasswords(string userID);
	}
}
