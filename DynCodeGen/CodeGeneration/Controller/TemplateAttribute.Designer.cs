﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynCodeGen.CodeGeneration.Controller {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class TemplateAttribute {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TemplateAttribute() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DynCodeGen.CodeGeneration.Controller.TemplateAttribute", typeof(TemplateAttribute).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\t\r\n\r\n\t\t[HttpPost(\&quot;Add\&quot;)]\r\n\t\tpublic IActionResult Add([FromBody] {className} entity)\r\n\t\t{\r\n\t\t\t_service.Add(entity);\r\n\t\t\treturn CreatedAtAction(nameof(GetById), new { {IdName} = entity.{IdName}}, entity);\r\n\t\t}.
        /// </summary>
        public static string ContollerAdd {
            get {
                return ResourceManager.GetString("ContollerAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\t[ApiController]\r\n\t[Route(\&quot;api/[controller]\&quot;)]\r\n\tpublic class {className}Controller : ControllerBase\r\n\t{\r\n\t\tprivate readonly I{className}Service _service;\r\n\r\n\t\tpublic {className}Controller(I{className}Service service)\r\n\t\t{\r\n\t\t_service = service;\r\n\t\t}.
        /// </summary>
        public static string ContollerClass {
            get {
                return ResourceManager.GetString("ContollerClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\t}.
        /// </summary>
        public static string ContollerClassEnd {
            get {
                return ResourceManager.GetString("ContollerClassEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\t\r\n\r\n\t\t[HttpDelete(\&quot;Delete/{{IdName}}\&quot;)]\r\n\t\tpublic IActionResult Delete(int {IdName})\r\n\t\t{\r\n\t\t\tvar existingItem = _service.GetById({IdName});\r\n\t\t\tif (existingItem == null)\r\n\t\t\t{\r\n\t\t\t\treturn NotFound();\r\n\t\t\t}\r\n\t\t\t_service.Delete({IdName});\r\n\t\t\treturn NoContent();\r\n\t\t}.
        /// </summary>
        public static string ContollerDelete {
            get {
                return ResourceManager.GetString("ContollerDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\t\r\n\r\n\t\t[HttpGet(\&quot;GetById/{{IdName}}\&quot;)]\r\n\t\tpublic ActionResult&lt;{className}&gt; GetById(int {IdName})\r\n\t\t{\r\n\t\t\tvar item = _service.GetById({IdName});\r\n\t\t\tif (item == null)\r\n\t\t\t{\r\n\t\t\t\treturn NotFound();\r\n\t\t\t}\r\n\t\t\treturn Ok(item);\r\n\t\t}.
        /// </summary>
        public static string ContollerGet {
            get {
                return ResourceManager.GetString("ContollerGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\t\r\n\r\n\t\t[HttpGet(\&quot;GetAll\&quot;)]\r\n\t\tpublic ActionResult&lt;IEnumerable&lt;{className}&gt;&gt; GetAll()\r\n\t\t{\r\n\t\t\treturn Ok(_service.GetAll());\r\n\t\t}.
        /// </summary>
        public static string ContollerGetAll {
            get {
                return ResourceManager.GetString("ContollerGetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Microsoft.AspNetCore.Mvc;\r\nusing {apiName}.Application.IService;\r\nusing System.Collections.Generic;\r\n.
        /// </summary>
        public static string ContollerHeader {
            get {
                return ResourceManager.GetString("ContollerHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {apiName}.Api.Controllers\r\n{.
        /// </summary>
        public static string ContollerNamespace {
            get {
                return ResourceManager.GetString("ContollerNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n}.
        /// </summary>
        public static string ContollerNamespaceEnd {
            get {
                return ResourceManager.GetString("ContollerNamespaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\r\n\t\t[HttpPut(\&quot;Update/{{IdName}}\&quot;)]\r\n\t\tpublic IActionResult Update(int {IdName}, [FromBody] {className} entity)\r\n\t\t{\r\n\t\t\tif ({IdName} != entity.{IdName})\r\n\t\t\t{\r\n\t\t\t\treturn BadRequest();\r\n\t\t\t}\r\n\t\t\t_service.Update(entity);\r\n\t\t\treturn NoContent();\r\n\t\t}.
        /// </summary>
        public static string ContollerUpdate {
            get {
                return ResourceManager.GetString("ContollerUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic class ApplicationDbContext : DbContext\r\n\t{\r\n\t\tpublic ApplicationDbContext(DbContextOptions&lt;ApplicationDbContext&gt; options) : base(options)\r\n\t\t{\r\n}\r\n//DBSets go here\r\n\t}\r\n}.
        /// </summary>
        public static string DBcontextClass {
            get {
                return ResourceManager.GetString("DBcontextClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {namespaceName}.Data\r\n{\r\n.
        /// </summary>
        public static string DBcontextNamespace {
            get {
                return ResourceManager.GetString("DBcontextNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Microsoft.EntityFrameworkCore;\r\n.
        /// </summary>
        public static string DBcontextUsing {
            get {
                return ResourceManager.GetString("DBcontextUsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic DbSet&lt;{className}&gt; {className}Set { get; set; }\r\n.
        /// </summary>
        public static string DBContextWithModels {
            get {
                return ResourceManager.GetString("DBContextWithModels", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tvoid Add({className} entity);\r\n.
        /// </summary>
        public static string IRepositoryAdd {
            get {
                return ResourceManager.GetString("IRepositoryAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tvoid Delete(int {IdName});\r\n.
        /// </summary>
        public static string IRepositoryDelete {
            get {
                return ResourceManager.GetString("IRepositoryDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\t{className} GetById(int {IdName});\r\n.
        /// </summary>
        public static string IRepositoryGet {
            get {
                return ResourceManager.GetString("IRepositoryGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\t\tIEnumerable&lt;{className}&gt; GetAll();\r\n.
        /// </summary>
        public static string IRepositoryGetAll {
            get {
                return ResourceManager.GetString("IRepositoryGetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic interface I{className}Repository\r\n\t{.
        /// </summary>
        public static string IRepositoryInterface {
            get {
                return ResourceManager.GetString("IRepositoryInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\t}.
        /// </summary>
        public static string IRepositoryInterfaceEnd {
            get {
                return ResourceManager.GetString("IRepositoryInterfaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {apiName}.Application.IRepository\r\n{.
        /// </summary>
        public static string IRepositoryNamespace {
            get {
                return ResourceManager.GetString("IRepositoryNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n}.
        /// </summary>
        public static string IRepositoryNamespaceEnd {
            get {
                return ResourceManager.GetString("IRepositoryNamespaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tvoid Update({className} entity);\r\n.
        /// </summary>
        public static string IRepositoryUpdate {
            get {
                return ResourceManager.GetString("IRepositoryUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tvoid Add({className} entity);\r\n.
        /// </summary>
        public static string IServiceAdd {
            get {
                return ResourceManager.GetString("IServiceAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\t}.
        /// </summary>
        public static string IServiceClassEnd {
            get {
                return ResourceManager.GetString("IServiceClassEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tvoid Update({className} entity);\r\n.
        /// </summary>
        public static string IServiceDelete {
            get {
                return ResourceManager.GetString("IServiceDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\t{className} GetById(int {IdName});\r\n.
        /// </summary>
        public static string IServiceGet {
            get {
                return ResourceManager.GetString("IServiceGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tIEnumerable&lt;{className}&gt; GetAll();\r\n.
        /// </summary>
        public static string IServiceGetAll {
            get {
                return ResourceManager.GetString("IServiceGetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic interface I{className}Service\r\n\t{\r\n.
        /// </summary>
        public static string IServiceInterface {
            get {
                return ResourceManager.GetString("IServiceInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {apiName}.Application.IService\r\n{.
        /// </summary>
        public static string IServiceNamespace {
            get {
                return ResourceManager.GetString("IServiceNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n}.
        /// </summary>
        public static string IServiceNamespaceEnd {
            get {
                return ResourceManager.GetString("IServiceNamespaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tvoid Delete(int {IdName});\r\n.
        /// </summary>
        public static string IServiceUpdate {
            get {
                return ResourceManager.GetString("IServiceUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t[{annotation}].
        /// </summary>
        public static string ModelAnnotation {
            get {
                return ResourceManager.GetString("ModelAnnotation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic {propertyType} {propertyName} { get; set;}\r\n.
        /// </summary>
        public static string ModelClassProperty {
            get {
                return ResourceManager.GetString("ModelClassProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public class {className} \r\n{\r\n.
        /// </summary>
        public static string ModelClassStart {
            get {
                return ResourceManager.GetString("ModelClassStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tvirtual ICollection&lt;{propertyType}&gt;.
        /// </summary>
        public static string ModelOnetomany {
            get {
                return ResourceManager.GetString("ModelOnetomany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.ComponentModel.DataAnnotations;\r\nusing System.ComponentModel.DataAnnotations.Schema;\r\n.
        /// </summary>
        public static string ModelUsing {
            get {
                return ResourceManager.GetString("ModelUsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t}\r\n.
        /// </summary>
        public static string ProgramClassEnd {
            get {
                return ResourceManager.GetString("ProgramClassEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic class Program\r\n\t{\r\n.
        /// </summary>
        public static string ProgramClassStart {
            get {
                return ResourceManager.GetString("ProgramClassStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic static IHostBuilder CreateHostBuilder(string[] args) =&gt;\r\n\t\t\tHost.CreateDefaultBuilder(args)\r\n\t\t\t\t.ConfigureWebHostDefaults(webBuilder =&gt;\r\n\t\t\t\t{\r\n\t\t\t\t\twebBuilder.UseStartup&lt;Startup&gt;();\r\n\t\t\t\t});\r\n.
        /// </summary>
        public static string ProgramCreateHostBuilderMethod {
            get {
                return ResourceManager.GetString("ProgramCreateHostBuilderMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic static void Main(string[] args)\r\n\t\t{\r\n\t\t\tCreateHostBuilder(args).Build().Run();\r\n\t\t}\r\n.
        /// </summary>
        public static string ProgramMainMethod {
            get {
                return ResourceManager.GetString("ProgramMainMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {apiName}.WebAPI\r\n{.
        /// </summary>
        public static string ProgramNamespace {
            get {
                return ResourceManager.GetString("ProgramNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to }\r\n.
        /// </summary>
        public static string ProgramNamespaceEnd {
            get {
                return ResourceManager.GetString("ProgramNamespaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using Microsoft.AspNetCore.Hosting;\r\nusing Microsoft.Extensions.Hosting;.
        /// </summary>
        public static string ProgramUsing {
            get {
                return ResourceManager.GetString("ProgramUsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void Add({className} entity)\r\n\t\t{\r\n\t\t\t_context.{className}Set.Add(entity);\r\n\t\t\t_context.SaveChanges();\r\n\t\t}\r\n.
        /// </summary>
        public static string RepositoryAdd {
            get {
                return ResourceManager.GetString("RepositoryAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t}\r\n.
        /// </summary>
        public static string RepositoryClassEnd {
            get {
                return ResourceManager.GetString("RepositoryClassEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic class {className}Repository : I{className}Repository\r\n\t{\r\n.
        /// </summary>
        public static string RepositoryClassStart {
            get {
                return ResourceManager.GetString("RepositoryClassStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\t\tprivate readonly ApplicationDbContext _context;\r\n\r\n\t\tpublic {className}Repository(ApplicationDbContext context)\r\n\t\t{\r\n\t\t\t_context = context;\r\n\t\t}\r\n.
        /// </summary>
        public static string RepositoryConstructor {
            get {
                return ResourceManager.GetString("RepositoryConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void Delete(int {className}Id)\r\n\t\t{\r\n\t\t\tvar entityToDelete = _context.{className}Set.FirstOrDefault(e =&gt; e.{IdName} == {IdName});\r\n\t\t\tif (entityToDelete != null)\r\n\t\t\t{\r\n\t\t\t\t_context.{className}Set.Remove(entityToDelete);\r\n\t\t\t\t_context.SaveChanges();\r\n\t\t\t}\r\n\t\t}\r\n.
        /// </summary>
        public static string RepositoryDelete {
            get {
                return ResourceManager.GetString("RepositoryDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic IEnumerable&lt;{className}&gt; GetAll()\r\n\t\t{\r\n\t\t\treturn _context.{className}Set.ToList();\r\n\t\t}\r\n.
        /// </summary>
        public static string RepositoryGetAll {
            get {
                return ResourceManager.GetString("RepositoryGetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic {className} GetById(int {IdName})\r\n\t\t{\r\n\t\t\treturn _context.{className}Set.FirstOrDefault(e =&gt; e.{IdName} == {IdName});\r\n\t\t}\r\n.
        /// </summary>
        public static string RepositoryGetById {
            get {
                return ResourceManager.GetString("RepositoryGetById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {apiName}.Infrastructure.Repository\r\n{.
        /// </summary>
        public static string RepositoryNamespace {
            get {
                return ResourceManager.GetString("RepositoryNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to }\r\n.
        /// </summary>
        public static string RepositoryNamespaceEnd {
            get {
                return ResourceManager.GetString("RepositoryNamespaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void Update({className} entity)\r\n\t\t{\r\n\t\t\t_context.{className}Set.Update(entity);\r\n\t\t\t_context.SaveChanges();\r\n\t\t}\r\n.
        /// </summary>
        public static string RepositoryUpdate {
            get {
                return ResourceManager.GetString("RepositoryUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using {apiName}.Infrastructure.Data;\r\nusing {apiName}.Application.IRepository;\r\n.
        /// </summary>
        public static string RepositoryUsing {
            get {
                return ResourceManager.GetString("RepositoryUsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void Add({className} entity)\r\n\t\t{\r\n\t\t\t_repository.Add(entity);\r\n\t\t}\r\n.
        /// </summary>
        public static string ServiceAdd {
            get {
                return ResourceManager.GetString("ServiceAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t}\r\n.
        /// </summary>
        public static string ServiceClassEnd {
            get {
                return ResourceManager.GetString("ServiceClassEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic class {className}Service : I{className}Service\r\n\t{\r\n.
        /// </summary>
        public static string ServiceClassStart {
            get {
                return ResourceManager.GetString("ServiceClassStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \r\n\tprivate readonly I{className}Repository _repository;\r\n\r\n\t\tpublic {className}Service(I{className}Repository repository)\r\n\t\t{\r\n\t\t\t_repository = repository;\r\n\t\t}\r\n.
        /// </summary>
        public static string ServiceConstructor {
            get {
                return ResourceManager.GetString("ServiceConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void Delete(int {IdName})\r\n\t\t{\r\n\t\t\t_repository.Delete({IdName});\r\n\t\t}\r\n.
        /// </summary>
        public static string ServiceDelete {
            get {
                return ResourceManager.GetString("ServiceDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic IEnumerable&lt;{className}&gt; GetAll()\r\n\t\t{\r\n\t\t\treturn _repository.GetAll();\r\n\t\t}\r\n.
        /// </summary>
        public static string ServiceGetAll {
            get {
                return ResourceManager.GetString("ServiceGetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic {className} GetById(int {IdName})\r\n\t\t{\r\n\t\t\treturn _repository.GetById({IdName});\r\n\t\t}\r\n.
        /// </summary>
        public static string ServiceGetById {
            get {
                return ResourceManager.GetString("ServiceGetById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {apiName}.Infrastructure.Service\r\n{.
        /// </summary>
        public static string ServiceNamespace {
            get {
                return ResourceManager.GetString("ServiceNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to }\r\n.
        /// </summary>
        public static string ServiceNamespaceEnd {
            get {
                return ResourceManager.GetString("ServiceNamespaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void Update({className} entity)\r\n\t\t{\r\n\t\t\t_repository.Update(entity);\r\n\t\t}\r\n.
        /// </summary>
        public static string ServiceUpdate {
            get {
                return ResourceManager.GetString("ServiceUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using {apiName}.Application.IRepository;\r\nusing {apiName}.Application.IService;\r\n.
        /// </summary>
        public static string ServiceUsing {
            get {
                return ResourceManager.GetString("ServiceUsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tprivate void AddCors(IServiceCollection services)\r\n\t\t{\r\n\t\t\tservices.AddCors(options =&gt;\r\n\t\t\t{\r\r\t\t\t\toptions.AddPolicy(name: \&quot;AllowAll\&quot;, builder =&gt; builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());\r\n\t\t\t});\r\n\t\t}\r\n.
        /// </summary>
        public static string StartupAddCorsMethod {
            get {
                return ResourceManager.GetString("StartupAddCorsMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \tpublic class Startup\r\n\t{\r\n.
        /// </summary>
        public static string StartupClassStart {
            get {
                return ResourceManager.GetString("StartupClassStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tprivate void ConfigureHealthCheck(IApplicationBuilder app)\r\n\t\t{\r\n\t\t\t// Add health check configurations here.\r\n\t\t}\r\n.
        /// </summary>
        public static string StartupConfigureHealthCheckMethod {
            get {
                return ResourceManager.GetString("StartupConfigureHealthCheckMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void Configure(IApplicationBuilder app, IWebHostEnvironment env)\r\n\t\t{\r\n\t\t\tapp.UseSwagger();\r\n\t\t\tapp.UseSwaggerUI(c =&gt; c.SwaggerEndpoint(\&quot;/swagger/v1/swagger.json\&quot;, $\&quot;{apiName} v1\&quot;));\r\n\t\t\tapp.UseHttpsRedirection().UseRouting().UseCors(\&quot;AllowAll\&quot;).UseAuthorization().UseEndpoints(endpoints =&gt; endpoints.MapControllers());\r\n\t\t\tConfigureHealthCheck(app);\r\n\t\t}\r\n.
        /// </summary>
        public static string StartupConfigureMethod {
            get {
                return ResourceManager.GetString("StartupConfigureMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic void ConfigureServices(IServiceCollection services)\r\n\t\t{\r\n\t\t\tservices.AddDbContext&lt;ApplicationDbContext&gt;(options =&gt;\r\n\t\t\toptions.UseSqlServer(Configuration.GetConnectionString(\&quot;DefaultConnection\&quot;)));\r\n\t\t\tRegisterDependencies(services);\r\n\t\t\tservices.AddControllers();\r\n\t\t\tservices.AddSwaggerGen(c =&gt; c.SwaggerDoc(\&quot;v1\&quot;, new OpenApiInfo { Title = $\&quot;{apiName}\&quot;, Version = \&quot;v1\&quot; }));\r\n\t\t\tAddCors(services);\r\n\t\t}\r\n.
        /// </summary>
        public static string StartupConfigureServicesMethod {
            get {
                return ResourceManager.GetString("StartupConfigureServicesMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tprivate void ConfigureSwagger(IApplicationBuilder app)\r\n\t\t{\r\n\t\t\tapp.UseSwagger();\r\n\t\t\tapp.UseSwaggerUI(c =&gt; \r\n\t\t\t{\r\n\t\t\t\tc.SwaggerEndpoint(\&quot;/swagger/v1/swagger.json\&quot;, $\&quot;{apiName} v1\&quot;);\r\n\t\t\t});\r\n\t\t}\r\n.
        /// </summary>
        public static string StartupConfigureSwaggerMethod {
            get {
                return ResourceManager.GetString("StartupConfigureSwaggerMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tpublic Startup(IConfiguration configuration) =&gt; Configuration = configuration;\r\n\t\tpublic IConfiguration Configuration { get; }\r\n.
        /// </summary>
        public static string StartupConstructor {
            get {
                return ResourceManager.GetString("StartupConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\t\tservices.AddScoped&lt;I{className}Repository, {className}Repository&gt;();\r\n\t\t\tservices.AddScoped&lt;I{className}Service, {className}Service &gt;();.
        /// </summary>
        public static string StartupForRepositoriesAndServices {
            get {
                return ResourceManager.GetString("StartupForRepositoriesAndServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t}\r\n}\r\n.
        /// </summary>
        public static string StartupNamespaceEnd {
            get {
                return ResourceManager.GetString("StartupNamespaceEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace {apiName}.WebAPI\r\n{\r\n.
        /// </summary>
        public static string StartupNamespaceStart {
            get {
                return ResourceManager.GetString("StartupNamespaceStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \t\tprivate void RegisterDependencies(IServiceCollection services)\r\n\t\t{\r\n// Add dependency injection registrations here.\r\n\t\t}\r\n.
        /// </summary>
        public static string StartupRegisterDependenciesMethod {
            get {
                return ResourceManager.GetString("StartupRegisterDependenciesMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using {apiName}.Application.IRepository;\r\nusing {apiName}.Application.IService;\r\nusing {apiName}.Infrastructure.Data;\r\nusing {apiName}.Infrastructure.Repository;\r\nusing {apiName}.Infrastructure.Service;\r\nusing Microsoft.AspNetCore.Builder;\r\nusing Microsoft.AspNetCore.Hosting;\r\nusing Microsoft.EntityFrameworkCore;\r\nusing Microsoft.Extensions.Configuration;\r\nusing Microsoft.Extensions.DependencyInjection;\r\nusing Microsoft.OpenApi.Models;\r\n.
        /// </summary>
        public static string StartupUsing {
            get {
                return ResourceManager.GetString("StartupUsing", resourceCulture);
            }
        }
    }
}