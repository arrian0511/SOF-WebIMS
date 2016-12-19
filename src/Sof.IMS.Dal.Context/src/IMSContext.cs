using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sof.IMS.Dal.Context
{
	/// <summary>
	/// Information Management System Context
	/// </summary>
	public class IMSContext : DbContext
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public IMSContext (DbContextOptions<IMSContext> options)
			 : base(options)
		{
		}

		/// <summary>
		/// On Model Creation
		/// </summary>
		/// <param name="modelBuilder">[in] Model Builder</param>
		protected override void OnModelCreating (ModelBuilder modelBuilder)
		{
			//// Set Fluent to Employee
			//modelBuilder.Entity<Employee> ().Property(e => e.UserID).IsRequired ();
			//modelBuilder.Entity<Employee> ().HasMany<Project> (e => e.Projects);

			//// Set Fluent to Project
			//modelBuilder.Entity<Project> ().Property(p => p.Code).IsRequired ();
		}
	}
}
