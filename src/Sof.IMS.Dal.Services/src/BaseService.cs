using System.Collections.Generic;
using System.Threading.Tasks;
using Sof.IMS.Dal.Context;
using Sof.IMS.Dal.Repository;
using Sof.IMS.Models.Infrastructure;
using Sof.IMS.Utility;

namespace Sof.IMS.Dal.Services
{
	/// <summary>
	/// Base Service Class
	/// </summary>
	/// <typeparam name="T">Entity Type</typeparam>
	public abstract class BaseService<T> : IBaseService <T>
		where T: Entity, new ()
	{
		protected IMSContext			_Context		{ get; }		///< Context
		protected IEntityRepository<T>	_Repository		{ get; }		///< Entity Repository

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="iContext">[in] Context</param>
		protected BaseService(IMSContext iContext)
		{
			/// Intialize Member Variables <BR>
			this._Context		= iContext;
			this._Repository	= new EntityRepository<T> (this._Context);
		}

		/// <summary>
		/// Get All Record Asynchronous
		/// </summary>
		/// <returns>Structure Value (JSON Object)</returns>
		public async Task<SImsDataInfo<IEnumerable<T>>> GetAllAsync ()
		{
			EDataAccessStatus		_retStat = EDataAccessStatus.SUCCESS;	// Return Status

			/// Get All Records <BR>
			var _allrecord = await this._Repository.GetAllRecAsync ();
			return new SImsDataInfo<IEnumerable<T>> (_allrecord, _retStat);
		}

		/// <summary>
		/// Create Record Asynchronous
		/// </summary>
		/// <param name="entity">[in] Entity Record</param>
		/// <returns>Structure Value (JSON Object)</returns>
		public async Task<SImsDataInfo<T>> CreateAsync (T entity)
		{
			EDataAccessStatus	_retStat	= EDataAccessStatus.SUCCESS;	// Return Status

			/// Create Record <BR>
			_retStat = await this._Repository.CreateAsync (entity);
			return new SImsDataInfo<T> (entity, _retStat);
		}

		/// <summary>
		/// Update Record Asynchronous
		/// </summary>
		/// <param name="entity">[in] Entity Record</param>
		/// <returns>Structure Value (JSON Object)</returns>
		public async Task<SImsDataInfo<T>> UpdateAsync (T entity)
		{
			EDataAccessStatus	_retStat	= EDataAccessStatus.SUCCESS;	// Return Status

			/// Update Record <BR>
			_retStat = await this._Repository.UpdateAsync (entity);
			return new SImsDataInfo<T> (entity, _retStat);
		}

		/// <summary>
		/// Delete Record Asynchronous
		/// </summary>
		/// <param name="entity">[in] Entity Record</param>
		/// <returns>Structure Value (JSON Object)</returns>
		public async Task<SImsDataInfo<T>> DeleteAsync (T entity)
		{
			EDataAccessStatus	_retStat	= EDataAccessStatus.SUCCESS;	// Return Status

			/// Delete Record <BR>
			_retStat = await this._Repository.DeleteAsync (entity);
			return new SImsDataInfo<T> (entity, _retStat);
		}

		/// <summary>
		/// Save Asynchronous
		/// </summary>
		/// <returns>Save Status</returns>
		public async Task<EDataAccessStatus> SaveAsync ()
		{
			EDataAccessStatus	_retStat	= EDataAccessStatus.SUCCESS;	// Return Status

			/// Delete Record <BR>
			_retStat = await this._Repository.SaveAsync ();
			return _retStat;
		}
	}
}
