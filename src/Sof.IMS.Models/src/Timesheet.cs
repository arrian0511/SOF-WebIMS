using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// Timesheet Model
	/// </summary>
	[JsonObject (MemberSerialization.OptOut)]
	public class Timesheet : Entity
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Timesheet ()
		{
			/// Initialize Member Variables <BR>
			this.DailyTasks = new List<DailyTask> ();
			this.Shift		= new Shift ();
			this.Status		= new TimesheetStatus ();
		}

		public int?						Break		{ get; set; }
		public int?						TotalMH		{ get; set; }
		public int?						OvertimeMH	{ get; set; }
		public bool						HasValue	{ get; set; }

		public DateTime?				Date		{ get; set; }
		public TimeSpan?				TimeIn		{ get; set; }
		public TimeSpan?				TimeOut		{ get; set; }
		public Shift					Shift		{ get; set; }
		public TimesheetStatus			Status		{ get; set; }
		public ICollection<DailyTask>	DailyTasks	{ get; set; }
	}
}
