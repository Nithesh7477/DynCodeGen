using DynCodeGen.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.Project
{
    public class ExecuteCliCommand
    {
            public string  ExecuteCommand(string command,string? workingDirectory = null)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDirectory != null ? workingDirectory : Directory.GetCurrentDirectory() // use the provided directory or the current one
                }
            };

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd(); // Capture error output

            process.WaitForExit();

            if (!string.IsNullOrWhiteSpace(error))
            {
                Debug.WriteLine("Error: " + error);
            }
            Debug.WriteLine(output);
            return output;
        }
    }
}
