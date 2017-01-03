using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sof.IMS.Models.Infrastructure
{
	/// <summary>
	/// Entity Class
	/// </summary>
	public class Entity : IEntity
	{
		public virtual int Id { get; set; }
	}
}
