using Sof.IMS.Dal.Context;
using Sof.IMS.Models;

namespace Sof.IMS.Dal.Services
{
	/// <summary>
	/// Image Services Class
	/// </summary>
	public class ImageService : BaseService<Image>, IImageService
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="iContext">[in] Context</param>
		public ImageService (IMSContext iContext)
			: base (iContext)
		{
			/// Initialize Member Variables <BR>
		}
	}
}
