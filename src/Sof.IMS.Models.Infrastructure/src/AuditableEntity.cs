using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sof.IMS.Models.Infrastructure
{
	/// <summary>
	/// Auditable Entities
	/// </summary>
	/// <typeparam name="I">[in] ID Type</typeparam>
	[JsonObject (MemberSerialization.OptOut)]
	public class AuditableEntity<I> : Entity<I>, IAuditableEntity
	{
		[JsonIgnore]
		public string		CreatedBy		{ get; set; }

		[JsonIgnore]
		public string		UpdatedBy		{ get; set; }

		[JsonIgnore]
		public DateTime		CreatedDate		{ get; set; }

		[JsonIgnore]
		public DateTime		UpdatedDate		{ get; set; }
	}
}
