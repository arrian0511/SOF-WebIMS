using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Sof.IMS.Utility;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Dal.Repository
{
	/// <summary>
	/// Entity Service Interface
	/// </summary>
	/// <typeparam name="T">[in] Entity Type</typeparam>
	public interface IEntityRepository<T>
		where T: Entity, new ()
	{
		Task<EDataAccessStatus>	SaveAsync ();
		Task<T>					GetByIdAsync (int id);
		Task<IEnumerable<T>>	GetAllRecAsync ();

		Task<EDataAccessStatus>	CreateAsync (T entity);
		Task<EDataAccessStatus>	DeleteAsync (T entity);
		Task<EDataAccessStatus>	DeleteWhereAsync (Expression<Func<T, bool>> predicate);
		Task<EDataAccessStatus>	UpdateAsync (T entity);
	}
}
