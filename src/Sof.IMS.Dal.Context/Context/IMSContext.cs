using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sof.IMS.Models;
using Sof.IMS.Models.Infrastructure;

namespace Sof.IMS.Dal.Context
{
	/// <summary>
	/// Information Management System Context
	/// </summary>
	public class IMSContext : DbContext
	{
		public DbSet<Album>				Album				{ get; set; }
		public DbSet<DailyTask>			DailyTask			{ get; set; }
		public DbSet<Image>				Image				{ get; set; }
		public DbSet<Phase>				Phase				{ get; set; }
		public DbSet<Process>			Process				{ get; set; }
		public DbSet<Project>			Project				{ get; set; }
		public DbSet<ProjectType>		ProjectType			{ get; set; }
		public DbSet<Shift>				Shift				{ get; set; }
		public DbSet<Timesheet>			Timesheet			{ get; set; }
		public DbSet<TimesheetStatus>	TimesheetStatus		{ get; set; }
		public DbSet<User>				User				{ get; set; }
		public DbSet<UserStatus>		UserStatus			{ get; set; }
		public DbSet<WorkStatus>		WorkStatus			{ get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public IMSContext (DbContextOptions<IMSContext> options)
			 : base (options)
		{
		}

		/// <summary>
		/// On Model Creation
		/// </summary>
		/// <param name="modelBuilder">[in] Model Builder</param>
		protected override void OnModelCreating (ModelBuilder modelBuilder)
		{
			// Set Fluent to User
			modelBuilder.Entity<User> ().Property(e => e.Id).IsRequired ();
			modelBuilder.Entity<User> ().HasMany<Project> (e => e.Projects);

			// Set Fluent to Project
			modelBuilder.Entity<Project> ().Property(e => e.Id).IsRequired ();
			modelBuilder.Entity<Project> ().HasMany<User> (e => e.Users);
		}

		public override Task<int> SaveChangesAsync (bool acceptAllChangesOnSuccess,
													CancellationToken cancellationToken = default (CancellationToken))
		{
			var entity = ChangeTracker.Entries ().Where (e => e.Entity is IAuditableEntity &&
															  e.State == EntityState.Added ||
															  e.State == EntityState.Modified);

			if (entity != null) {

				foreach (var _item in entity) {

					IAuditableEntity _audit = _item.Entity as IAuditableEntity;
					string			 _name = "Name of Updater";

					if (_item.State == EntityState.Added) {
						_audit.CreatedDate = DateTime.Now;
						_audit.CreatedBy = _name;
					}
					else if (_item.State == EntityState.Modified) {
						_audit.UpdatedDate = DateTime.Now;
						_audit.UpdatedBy = _name;
					}
				}
			}

			return base.SaveChangesAsync (acceptAllChangesOnSuccess, cancellationToken);
		}
	}
}
