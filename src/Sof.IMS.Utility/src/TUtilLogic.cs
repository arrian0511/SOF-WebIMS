using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sof.IMS.Utility
{
	public class TUtilLogic
	{
		public static JsonSerializerSettings DefaultJsonFormat
		{
			get
			{
				if (DefaultJsonFormat == null) {
					return new JsonSerializerSettings
					{
						Formatting = Formatting.Indented,
						DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
					};
				}
				else {
					return DefaultJsonFormat;
				}
			}
		}
	}
}
