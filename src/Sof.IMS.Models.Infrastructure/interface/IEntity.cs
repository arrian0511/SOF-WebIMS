using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sof.IMS.Models.Infrastructure
{
	/// <summary>
	/// Entity Interface
	/// </summary>
	/// <typeparam name="I">[in] ID Type</typeparam>
	public interface IEntity<I>
	{
		I Id { get; set; }
	}
}
