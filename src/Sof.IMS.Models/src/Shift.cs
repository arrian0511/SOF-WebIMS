using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// WorkStatus Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class Shift : Entity<int>
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Shift ()
		{
			/// Initialize Member Variables <BR>
		}

		public string Value		{ get; set; }
		public string Remarks	{ get; set; }
	}
}
