namespace PassHub_API.Models
{
	public class Login
	{
		public int LoginID { get; set; }
		public string Website { get; set; }
		public string UserName { get; set; }
		public string EncryptedPassword { get; set; }
	}
}
