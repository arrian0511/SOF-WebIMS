using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sof.IMS.Utility
{
	public class SImsDataInfo<T>
	{
		public T					ObjValue	{ get; set; }
		public JsonResult			JsonValue	{ get; set; }
		public EDataAccessStatus	Return		{ get; set; }

		public SImsDataInfo ()
		{
			this.ObjValue	= default(T);
			this.JsonValue	= new JsonResult (this.ObjValue);
			this.Return		= EDataAccessStatus.SUCCESS;
		}

		public SImsDataInfo (T iObjValue, EDataAccessStatus iReturn)
		{
			this.Return		= iReturn;
			this.ObjValue	= iObjValue;
			this.JsonValue	= new JsonResult (this.ObjValue, TUtilLogic.DefaultJsonFormat);
		}
	}
}
