using Sof.IMS.Dal.Context;
using Sof.IMS.Models;

namespace Sof.IMS.Dal.Services
{
	/// <summary>
	/// WorkStatus Services Class
	/// </summary>
	public class WorkStatusService : BaseService<WorkStatus>, IWorkStatusService
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="iContext">[in] Context</param>
		public WorkStatusService (IMSContext iContext)
			: base (iContext)
		{
			/// Initialize Member Variables <BR>
		}
	}
}
