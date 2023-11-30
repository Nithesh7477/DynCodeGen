namespace DynCodeGen.CodeGeneration.Controller
{
    using System.Text;
    public class ControllerGenerator
    {
        public static void GenerateController(string apiName, string apiPath, string className, string IdName)
        {
            StringBuilder controllerContent = new StringBuilder();
            controllerContent.AppendLine("using Microsoft.AspNetCore.Mvc;");
            controllerContent.AppendLine($"using {apiName}.Application.IService;");
            controllerContent.AppendLine("using System.Collections.Generic;"); // For IEnumerable
            controllerContent.AppendLine();
            controllerContent.AppendLine($"namespace {apiName}.Api.Controllers");
            controllerContent.AppendLine("{");
            controllerContent.AppendLine("    [ApiController]");
            controllerContent.AppendLine("    [Route(\"api/[controller]\")]");
            controllerContent.AppendLine($"    public class {className}Controller : ControllerBase");
            controllerContent.AppendLine("    {");
            controllerContent.AppendLine($"        private readonly I{className}Service _service;");
            controllerContent.AppendLine();
            controllerContent.AppendLine($"        public {className}Controller(I{className}Service service)");
            controllerContent.AppendLine("        {");
            controllerContent.AppendLine("            _service = service;");
            controllerContent.AppendLine("        }");
            controllerContent.AppendLine();

            // GetAll action method
            controllerContent.AppendLine("        [HttpGet(\"GetAll\")]");
            controllerContent.AppendLine($"        public ActionResult<IEnumerable<{className}>> GetAll()");
            controllerContent.AppendLine("        {");
            controllerContent.AppendLine("            return Ok(_service.GetAll());");
            controllerContent.AppendLine("        }");
            controllerContent.AppendLine();

            // GetById action method
            controllerContent.AppendLine($"        [HttpGet(\"GetById/{{{IdName}}}\")]");
            controllerContent.AppendLine($"        public ActionResult<{className}> GetById(int {IdName})");
            controllerContent.AppendLine("        {");
            controllerContent.AppendLine($"            var item = _service.GetById({IdName});");
            controllerContent.AppendLine("            if (item == null)");
            controllerContent.AppendLine("            {");
            controllerContent.AppendLine("                return NotFound();");
            controllerContent.AppendLine("            }");
            controllerContent.AppendLine("            return Ok(item);");
            controllerContent.AppendLine("        }");
            controllerContent.AppendLine();

            // Add action method
            controllerContent.AppendLine("        [HttpPost(\"Add\")]");
            controllerContent.AppendLine($"        public IActionResult Add([FromBody] {className} entity)");
            controllerContent.AppendLine("        {");
            controllerContent.AppendLine("            _service.Add(entity);");
            controllerContent.AppendLine($"            return CreatedAtAction(nameof(GetById), new {{ {IdName} = entity.{IdName} }}, entity);");
            controllerContent.AppendLine("        }");
            controllerContent.AppendLine();

            // Update action method
            controllerContent.AppendLine($"        [HttpPut(\"Update/{{{IdName}}}\")]");
            controllerContent.AppendLine($"        public IActionResult Update(int {IdName}, [FromBody] {className} entity)");
            controllerContent.AppendLine("        {");
            controllerContent.AppendLine($"            if ({IdName} != entity.{IdName})");
            controllerContent.AppendLine("            {");
            controllerContent.AppendLine("                return BadRequest();");
            controllerContent.AppendLine("            }");
            controllerContent.AppendLine("            _service.Update(entity);");
            controllerContent.AppendLine("            return NoContent();");
            controllerContent.AppendLine("        }");
            controllerContent.AppendLine();

            // Delete action method
            controllerContent.AppendLine($"        [HttpDelete(\"Delete/{{{IdName}}}\")]");
            controllerContent.AppendLine($"        public IActionResult Delete(int {IdName})");
            controllerContent.AppendLine("        {");
            controllerContent.AppendLine($"            var existingItem = _service.GetById({IdName});");
            controllerContent.AppendLine("            if (existingItem == null)");
            controllerContent.AppendLine("            {");
            controllerContent.AppendLine("                return NotFound();");
            controllerContent.AppendLine("            }");
            controllerContent.AppendLine($"            _service.Delete({IdName});");
            controllerContent.AppendLine("            return NoContent();");
            controllerContent.AppendLine("        }");

            controllerContent.AppendLine("    }");
            controllerContent.AppendLine("}");

            string controllerDirectory = Path.Combine(apiPath, $"{apiName}.WebAPI", "Controllers");
            Directory.CreateDirectory(controllerDirectory);
            string controllerPath = Path.Combine(controllerDirectory, $"{className}Controller.cs");
            File.WriteAllText(controllerPath, controllerContent.ToString());
        }
    }
}
