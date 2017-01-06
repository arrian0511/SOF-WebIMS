using System.Collections.Generic;
using System.Threading.Tasks;
using Sof.IMS.Models.Infrastructure;
using Sof.IMS.Utility;

namespace Sof.IMS.Dal.Services
{
	/// <summary>
	/// Base Service Interface
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IBaseService<T>
		where T: Entity, new ()
	{
		/// <summary>
		/// Get All Record Asynchronous
		/// </summary>
		/// <returns>Structure Value (JSON Object)</returns>
		Task<SImsDataInfo<IEnumerable<T>>>	GetAllAsync ();

		/// <summary>
		/// Create Record Asynchronous
		/// </summary>
		/// <param name="entity">[in] Entity Record</param>
		/// <returns>Structure Value (JSON Object)</returns>
		Task<SImsDataInfo<T>>				CreateAsync (T entity);

		/// <summary>
		/// Update Record Asynchronous
		/// </summary>
		/// <param name="entity">[in] Entity Record</param>
		/// <returns>Structure Value (JSON Object)</returns>
		Task<SImsDataInfo<T>>				UpdateAsync (T entity);

		/// <summary>
		/// Delete Record Asynchronous
		/// </summary>
		/// <param name="entity">[in] Entity Record</param>
		/// <returns>Structure Value (JSON Object)</returns>
		Task<SImsDataInfo<T>>				DeleteAsync (T entity);

		/// <summary>
		/// Save Asynchronous
		/// </summary>
		/// <returns>Save Status</returns>
		Task<EDataAccessStatus>				SaveAsync ();
	}
}
