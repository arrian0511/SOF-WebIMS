using System.Collections.Generic;
using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// User Model
	/// </summary>
	[JsonObject(MemberSerialization.OptOut)]
	public class User : AuditableEntity<int>
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public User ()
		{
			/// Initialize Member Variables <BR>
			this.Status			= new UserStatus ();
			this.Projects		= new List<Project> ();
			this.Timesheets		= new List<Timesheet> ();
		}

		public string					Code			{ get; set; }
		public string					FirstName		{ get; set; }
		public string					LastName		{ get; set; }
		public string					MiddleName		{ get; set; }
		public string					ImageUrl		{ get; set; }
		public string					Position		{ get; set; }

		public UserStatus				Status			{ get; set; }
		public ICollection<Project>		Projects		{ get; set; }
		public ICollection<Timesheet>	Timesheets		{ get; set; }
	}
}
