using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Models
{
	/// <summary>
	/// Project Model
	/// </summary>
	[JsonObject(MemberSerialization.OptOut)]
	public class Project : AuditableEntity
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Project ()
		{
			/// Initialize Member Variables <BR>
			this.Users		= new List<User> ();
			this.Phases		= new List<Phase> ();
		}

		public	string					Code		{ get; set; }
		public	string					Title		{ get; set; }
		public	string					Remarks		{ get; set; }
		public	int?					DisplayFlag { get; set; }
		public	int?					EstMH		{ get; set; }
		public	int?					ActMH		{ get; set; }

		public	DateTime?				StartDate	{ get; set; }
		public	DateTime?				EndDate		{ get; set; }
		public	ProjectType				Type		{ get; set; }
		public	ICollection<Phase>		Phases		{ get; set; }
		public	ICollection<User>		Users		{ get; set; }
	}
}
