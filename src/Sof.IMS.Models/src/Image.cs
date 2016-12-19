using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// Image Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class Image
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Image ()
		{
			/// Initialize Member Variables <BR>
		}

		public string		Title		{ get; set; }
		public string		Description	{ get; set; }
		public string		ImageUrl	{ get; set; }
	}
}
