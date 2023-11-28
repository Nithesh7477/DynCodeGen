using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Project
{
    public class UpdateProgramFile
    {
        public static void CreateOrUpdateProgramFile(string apiName, string apiPath)
        {
            string programFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Program.cs");

            string programFileContent = @"
            using Microsoft.AspNetCore.Hosting;
            using Microsoft.Extensions.Hosting;

            namespace " + apiName + @".WebAPI
            {
                public class Program
                {
                    public static void Main(string[] args)
                    {
                        CreateHostBuilder(args).Build().Run();
                    }

                    public static IHostBuilder CreateHostBuilder(string[] args) =>
                        Host.CreateDefaultBuilder(args)
                            .ConfigureWebHostDefaults(webBuilder =>
                            {
                                webBuilder.UseStartup<Startup>();
                            });
                }
            }";

            File.WriteAllText(programFilePath, programFileContent);
        }
    }
}
