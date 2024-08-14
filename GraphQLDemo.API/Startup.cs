using System;
using GraphQLDemo.API.Schema;

namespace GraphQLDemo.API
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddGraphQLServer().AddQueryType<Query>();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if(env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGraphQL();
			});
		}
	}
}

