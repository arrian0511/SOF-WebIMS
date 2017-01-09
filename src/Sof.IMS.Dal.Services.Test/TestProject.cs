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
			_service.CreateAsync (new Models.Project () { Code = "LO15-00047" });
			//Assert.Equal ("LO15-00047", _service.
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
