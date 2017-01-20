using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Sof.IMS.Web
{
	public class Startup
	{
		/// <summary>
		/// Service Configuration
		/// </summary>
		/// <param name="services">[in] Services</param>
		public void ConfigureServices (IServiceCollection services)
		{
			/// Register Services <BR>
			

			/// Add MVC Core <BR>
			services.AddMvcCore (_setup =>
			{
				_setup.CacheProfiles.Add ("PrivateCache", new CacheProfile () {
																				Duration = 0,
																				Location = ResponseCacheLocation.None,
																				NoStore = true
																				});
			});
		}

		/// <summary>
		/// Configure Settings
		/// </summary>
		/// <param name="app">[in] Application</param>
		/// <param name="env">[in] Environment</param>
		/// <param name="loggerFactory">[in] Logger Factory Settings</param>
		public void Configure (IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if(env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			app.UseDefaultFiles();
			app.UseStaticFiles();

			app.Use (async (context, next) =>
			{
				await next ();

				// Set Angular Root Page in case of error
				if (context.Response.StatusCode == 404 && 
					!Path.HasExtension(context.Request.Path.Value)) {
					context.Request.Path = "/index.html";
					await next ();
				}
			});

			app.UseMvc ();
		}
	}
}
