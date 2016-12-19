﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sof.IMS.Models.Infrastructure
{
	/// <summary>
	/// Entity Class
	/// </summary>
	/// <typeparam name="I">[in] ID Type</typeparam>
	public class Entity<I> : IEntity<I>
	{
		public virtual I Id { get; set; }
	}
}
