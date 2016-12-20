﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sof.IMS.Models.Infrastructure
{
	/// <summary>
	/// Auditable Entity
	/// </summary>
	/// <typeparam name="I">[in] ID Type</typeparam>
	public interface IAuditableEntity
	{
		string		CreatedBy		{ get; set; }
		string		UpdatedBy		{ get; set; }
		DateTime	CreatedDate		{ get; set; }
		DateTime	UpdatedDate		{ get; set; }
	}
}
