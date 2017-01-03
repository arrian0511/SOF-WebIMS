using System.Collections.Generic;
using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// Album Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class Album : Entity
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Album ()
		{
			/// Initialize Member Variables <BR>
			this.Images = new List<Image> ();
		}

		public string				Title		{ get; set; }
		public string				Description	{ get; set; }
		public ICollection<Image>	Images		{ get; set; }
	}
}
