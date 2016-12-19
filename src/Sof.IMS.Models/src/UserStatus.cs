using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// WorkStatus Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class UserStatus : Entity<int>
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public UserStatus ()
		{
			/// Initialize Member Variables <BR>
		}

		public string Value		{ get; set; }
		public string Remarks	{ get; set; }
	}
}
