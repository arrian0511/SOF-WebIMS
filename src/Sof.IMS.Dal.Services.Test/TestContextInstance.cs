using Microsoft.EntityFrameworkCore;
using Sof.IMS.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sof.IMS.Dal.Services.Test
{
	public class TestContextInstance
	{
		public IMSContext IMSContext { get; set; }
		private static TestContextInstance mContextInstance  = null;		// Test Context Instance

		/// <summary>
		/// Constructor
		/// </summary>
		private TestContextInstance ()
		{
			/// Initialize Member Variables <BR>
			this.OnInitConfig ();
		}

		/// <summary>
		/// Get Instance
		/// </summary>
		/// <returns>Class Instance</returns>
		public static TestContextInstance GetInstance ()
		{
			/// Return Instance <BR>
			if (mContextInstance != null) {
				return mContextInstance;
			}
			else {
				mContextInstance = new TestContextInstance ();
				return mContextInstance;
			}
		}

		/// <summary>
		/// Initialize Configuration
		/// </summary>
		private void OnInitConfig ()
		{
			var connection = @"Server=(localdb)\mssqllocaldb;Database=SOF-IMSDB;Trusted_Connection=True;";
			DbContextOptionsBuilder<IMSContext> _opt = new DbContextOptionsBuilder<IMSContext> ();
			_opt.UseSqlServer (connection, act => act.MigrationsAssembly ("Sof.IMS.Dal.Context"));
			this.IMSContext = new IMSContext (_opt.Options);
		}
	}
}
