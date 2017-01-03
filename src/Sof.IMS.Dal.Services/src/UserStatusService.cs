using Sof.IMS.Dal.Context;
using Sof.IMS.Models;

namespace Sof.IMS.Dal.Services
{
	/// <summary>
	/// UserStatus Services Class
	/// </summary>
	public class UserStatusService : BaseService<UserStatus>, IUserStatusService
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="iContext">[in] Context</param>
		public UserStatusService (IMSContext iContext)
			: base (iContext)
		{
			/// Initialize Member Variables <BR>
		}
	}
}
