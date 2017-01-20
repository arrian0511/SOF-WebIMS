using System.Collections.Generic;
using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// DailyTask Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class DailyTask : Entity
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DailyTask ()
		{
			/// Initialize Member Variables <BR>
			this.Project = new Project ();
			this.Process = new Process ();
		}

		public int?			PlanMH		{ get; set; }
		public int?			ActualMH	{ get; set; }
		public string		Remarks		{ get; set; }

		public Project		Project		{ get; set; }
		public Process		Process		{ get; set; }
		public WorkStatus	Status		{ get; set; }
	}
}
