using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Sof.IMS.Dal.Context
{
	public class ConfigureFactory : IDbContextFactory<IMSContext>
	{
		public IMSContext Create (DbContextFactoryOptions options)
		{
			var connection = @"Server=(localdb)\mssqllocaldb;Database=SOF-IMSDB;Trusted_Connection=True;";
			DbContextOptionsBuilder<IMSContext> _opt = new DbContextOptionsBuilder<IMSContext> ();
			_opt.UseSqlServer (connection, act => act.MigrationsAssembly ("Sof.IMS.Dal.Context"));
			return new Context.IMSContext (_opt.Options);
		}
	}
}
