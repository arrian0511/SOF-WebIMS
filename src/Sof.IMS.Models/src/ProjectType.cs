using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// WorkStatus Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class ProjecType : Entity<int>
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ProjecType ()
		{
			/// Initialize Member Variables <BR>
		}

		public string Value		{ get; set; }
		public string Remarks	{ get; set; }
	}
}
