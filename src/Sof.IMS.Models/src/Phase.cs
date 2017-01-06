using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;
using System.Collections.Generic;

namespace Sof.IMS.Models
{
	/// <summary>
	/// Phase Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class Phase : Entity
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Phase ()
		{
			/// Initialize Member Variables <BR>
			this.Process	= new List<Process> ();
		}

		public string				Value		{ get; set; }
		public string				Remarks		{ get; set; }
		public ICollection<Process>	Process		{ get; set; }
	}
}
