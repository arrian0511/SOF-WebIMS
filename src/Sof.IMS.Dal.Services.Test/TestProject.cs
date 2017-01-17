using Sof.IMS.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Sof.IMS.Dal.Services.Test
{
	/// <summary>
	/// Test Project Table
	/// </summary>
	public class TestProject : IDisposable
	{
		/// <summary>
		/// Constructor (TestInitialize/SetUp)
		/// </summary>
		public TestProject ()
		{
			//
			// TODO: Set DB Configuration Here
			//
		}

		/// <summary>
		/// Destructor (TearDown/TestCleanup)
		/// </summary>
		public void Dispose ()
		{
			/// Release Member Variables <BR>
		}

		/// <summary>
		/// Test Record Creation
		/// </summary>
		[Fact]
		public void TestCreate ()
		{
			IProjectService		_service = new ProjectService (TestContextInstance.GetInstance ().IMSContext);
			//_service.CreateAsync (new Models.Project () { Code = "LO15-00047" });
			var _data =  Task.Run(() => {
				return _service.GetAllAsync ();
			});
			_data.Wait();

			Assert.Equal (0, _data.Result.ObjValue.Count());
		}

		/// <summary>
		/// Test Record Update
		/// </summary>
		[Fact]
		public void TestUpdate ()
		{

		}

		/// <summary>
		/// Test Record Delete
		/// </summary>
		[Fact]
		public void TestDelete ()
		{

		}

		/// <summary>
		/// Test Record Get All
		/// </summary>
		[Fact]
		public void TestGetAll ()
		{

		}
	}
}
