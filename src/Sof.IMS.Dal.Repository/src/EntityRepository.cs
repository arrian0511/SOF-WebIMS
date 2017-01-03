using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Sof.IMS.Utility;
using Sof.IMS.Models.Infrastructure;
using System.Linq.Expressions;

namespace Sof.IMS.Dal.Repository
{
	/// <summary>
	/// Entity Service Class
	/// </summary>
	/// <typeparam name="T">[in] Entity Type</typeparam>
	public class EntityRepository<T> : IEntityRepository<T>
		where T : Entity, new()
	{
		private		DbContext	_context;		// Context
		private		DbSet<T>	_table;			// Table

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="iContext">[in] Database Context</param>
		public EntityRepository (DbContext iContext)
		{
			/// Initialize Member Variables
			this._context	= iContext;
			this._table		= iContext.Set<T> ();
		}

		public async Task<IEnumerable<T>> GetAllRecAsync ()
		{
			/// Get All Record from Database <BR>
			var		_value = await _table.ToListAsync ();
			return	_value;
		}

		public async Task<T> GetByIdAsync (int id)
		{
			/// Get Record By ID <BR>
			T	_find = await _table.FirstOrDefaultAsync (x => int.Equals (x.Id, id));
			return _find;
		}

		public async Task<EDataAccessStatus> CreateAsync (T entity)
		{
			EDataAccessStatus		_retvalue = EDataAccessStatus.SUCCESS; // Return Status

			/// Add Record to Database <BR>
			this._context.Entry<T>(entity).State = EntityState.Added;
			_retvalue = await this.SaveAsync();

			/// Return Value <BR>
			return _retvalue;
		}

		public async Task<EDataAccessStatus> UpdateAsync (T entity)
		{
			EDataAccessStatus		_retvalue = EDataAccessStatus.SUCCESS; // Return Status

			/// Add Record to Database <BR>
			this._context.Entry<T>(entity).State = EntityState.Modified;
			_retvalue = await this.SaveAsync();

			/// Return Value <BR>
			return _retvalue;
		}

		public async Task<EDataAccessStatus> DeleteAsync (T entity)
		{
			EDataAccessStatus		_retvalue = EDataAccessStatus.SUCCESS; // Return Status

			/// Add Record to Database <BR>
			this._context.Entry<T>(entity).State = EntityState.Deleted;
			_retvalue = await this.SaveAsync();

			/// Return Value <BR>
			return _retvalue;
		}

		public async Task<EDataAccessStatus> DeleteWhereAsync (Expression<Func<T, bool>> predicate)
		{
			EDataAccessStatus		_retvalue = EDataAccessStatus.SUCCESS; // Return Status

			/// Get All Records <BR>
			var _allRecord = await GetAllRecAsync ();

			/// Delete the corresponding record based on predicate <BR>
			foreach (var entity in _allRecord) {
				if(predicate.Compile () (entity)) {
					_retvalue = await this.DeleteAsync (entity);
					break;
				}
			}

			/// Return Value <BR>
			return _retvalue;
		}

		public async Task<EDataAccessStatus> SaveAsync ()
		{
			EDataAccessStatus		_retvalue = EDataAccessStatus.SUCCESS; // Return Status

			try {
				/// Save Changes
				await _context.SaveChangesAsync ();
			}
			catch {

				/// Rollback transaction in case of error <BR>
				_context.Database.RollbackTransaction ();
				_retvalue = EDataAccessStatus.ERROR;
			}

			/// Return Value <BR>
			return _retvalue;
		}

		public void Dispose ()
		{
			_context.Dispose ();
		}
	}
}
