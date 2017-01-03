using Sof.IMS.Dal.Context;
using Sof.IMS.Models;

namespace Sof.IMS.Dal.Services
{
	/// <summary>
	/// User Services Class
	/// </summary>
	public class UserService : BaseService<User>, IUserService
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="iContext">[in] Context</param>
		public UserService (IMSContext iContext)
			: base (iContext)
		{
			/// Initialize Member Variables <BR>
		}
	}
}
