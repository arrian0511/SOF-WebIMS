using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sof.IMS.Dal.Repository;
using Sof.IMS.Models;

namespace Sof.IMS.Dal.Services
{
	public interface IProjectService : IEntityRepository<int, Project>
	{

	}
}
