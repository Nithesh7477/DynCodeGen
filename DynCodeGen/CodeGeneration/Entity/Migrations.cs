using DynCodeGen.CodeGeneration.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Entity
{
    public class Migrations
    {
        public static void RunMigrationsAndUpdates(string apiProjectPath, string infrastructureProjectPath, string migrationName, string dbContextName)
        {

            // Add a new migration
            ExecuteCliCommand.ExecuteCommand($"ef migrations add {migrationName} --context {dbContextName} --startup-project {apiProjectPath} --project {infrastructureProjectPath}", apiProjectPath);

            // Update the database with the new migration
            ExecuteCliCommand.ExecuteCommand($"ef database update --context {dbContextName} --startup-project {apiProjectPath} --project {infrastructureProjectPath}", apiProjectPath);
        }
    }
}
