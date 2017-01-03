using Sof.IMS.Dal.Context;
using Sof.IMS.Models;

namespace Sof.IMS.Dal.Services
{
	/// <summary>
	/// DailyTask Services Class
	/// </summary>
	public class DailyTaskService : BaseService<DailyTask>, IDailyTaskService
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="iContext">[in] Context</param>
		public DailyTaskService (IMSContext iContext)
			: base (iContext)
		{
			/// Initialize Member Variables <BR>
		}
	}
}
