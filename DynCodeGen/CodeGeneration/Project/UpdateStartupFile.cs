using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Project
{
    public class UpdateStartupFile
    {
        public static void CreateStartupFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Startup.cs");

            string startupFileContent = @"
            using " + apiName + @".Application.IRepository;
            using " + apiName + @".Application.IService;
            using " + apiName + @".Infrastructure.Data;
            using " + apiName + @".Infrastructure.Repository;
            using " + apiName + @".Infrastructure.Service;
            using Microsoft.AspNetCore.Builder;
            using Microsoft.AspNetCore.Hosting;
            using Microsoft.EntityFrameworkCore;
            using Microsoft.Extensions.Configuration;
            using Microsoft.Extensions.DependencyInjection;
            using Microsoft.OpenApi.Models;

            namespace " + apiName + @".WebAPI
            {
                public class Startup
                {
                    public Startup(IConfiguration configuration)
                    {
                        Configuration = configuration;
                    }

                    public IConfiguration Configuration { get; }

                    public void ConfigureServices(IServiceCollection services)
                    {
                        services.AddDbContext<ApplicationDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString(""DefaultConnection"")));

                        RegisterDependencies(services);
                        services.AddControllers();
                        services.AddSwaggerGen(c =>
                        {
                            c.SwaggerDoc(""v1"", new OpenApiInfo { Title = """ + apiName + @""", Version = ""v1"" });
                        });

                        AddCors(services);
                    }

                    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
                    {
                        app.UseSwagger();
                        app.UseSwaggerUI(c => c.SwaggerEndpoint(""/swagger/v1/swagger.json"", """ + apiName + @" v1""));

                        app.UseHttpsRedirection();
                        app.UseRouting();
                        app.UseCors(""AllowAll"");
                        app.UseAuthorization();
                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                        });

                        ConfigureHealthCheck(app);
                    }

                    private void RegisterDependencies(IServiceCollection services)
                    {
                        // Add dependency injection registrations here.
                    }

                    private void AddCors(IServiceCollection services)
                    {
                        services.AddCors(options =>
                        {
                            options.AddPolicy(name: ""AllowAll"",
                                              builder =>
                                              {
                                                  builder.AllowAnyOrigin()
                                                         .AllowAnyMethod()
                                                         .AllowAnyHeader();
                                              });
                        });
                    }

                    private void ConfigureHealthCheck(IApplicationBuilder app)
                    {
                        // Add health check configurations here.
                    }

                    private void ConfigureSwagger(IApplicationBuilder app)
                    {
                        app.UseSwagger();
                        app.UseSwaggerUI(c => 
                        {
                            c.SwaggerEndpoint(""/swagger/v1/swagger.json"", """ + apiName + @" v1"");
                        });
                    }
                }
            }";

            File.WriteAllText(startupFilePath, startupFileContent);
        }

        public static void UpdateStartupForRepositoriesAndServices(string apiName, string apiPath, Dictionary<string, List<Tuple<string, string, string, string>>> sheetsData)
        {
            string startupPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Startup.cs");
            StringBuilder sb = new StringBuilder();

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                sb.AppendLine($"services.AddScoped<I{className}Repository, {className}Repository>();");
                sb.AppendLine($"services.AddScoped<I{className}Service, {className}Service>();");
            }

            // Read existing Startup.cs content and find a place to insert the new lines
            string existingContent = File.ReadAllText(startupPath);
            int insertionIndex = existingContent.IndexOf("// Add dependency injection registrations here.");

            if (insertionIndex > -1)
            {
                existingContent = existingContent.Insert(insertionIndex, sb.ToString());
                File.WriteAllText(startupPath, existingContent);
            }
        }
    }
}
