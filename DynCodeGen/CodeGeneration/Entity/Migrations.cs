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
        public string RunMigrationsAndUpdates(string apiProjectPath, string infrastructureProjectPath, string migrationName, string dbContextName)
        {

            StringBuilder execmdStingBuilder = new StringBuilder();
            ExecuteCliCommand execmd = new ExecuteCliCommand();
            // Add a new migration
            execmdStingBuilder.AppendLine(execmd.ExecuteCommand($"ef migrations add {migrationName} --context {dbContextName} --startup-project {apiProjectPath} --project {infrastructureProjectPath}", apiProjectPath.ToString()));

            // Update the database with the new migration
            execmdStingBuilder.AppendLine(execmd.ExecuteCommand($"ef database update --context {dbContextName} --startup-project {apiProjectPath} --project {infrastructureProjectPath}", apiProjectPath));
            return execmdStingBuilder.ToString();

        }
    }
}
