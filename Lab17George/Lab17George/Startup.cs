using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Lab17George.Models;

namespace Lab17George
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<Lab17GeorgeContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Lab17GeorgeContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
/* Recreate your Travel Packer site from day one. You do not need to include the repository that we worked on in class 16.
 * Design a database schema for your Travel Packer website. 
 *      Dont focus so much on tables that hold "types", only focus on the tables that are most important (i.e. Destination, Supplies).
 * Every Supply item should have a link to the destination table.
 *      We won't worry to much about duplicates across the supplies right now, the rows in the table will still be 'unique' because the DestinationID will be different for         each item.
 * You should have at least 2 tables (Destination & Supplies).
 * Draw out the different tables and identify the foreign keys, primary keys, and associations between each (1 - *, * - *, etc...)
 * Include the Navigation Properties within your diagram
 * use This as a reference when creating your data model diagram.
 * Make these tables you created be represented as Models in your website.
 * Be sure that all the tables you created are represented in both the database and in your model folder */
