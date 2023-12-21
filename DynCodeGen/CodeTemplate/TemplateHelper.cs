using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCodeGen.CodeGeneration.CodeTemplate
{
    public sealed class TemplateHelper
    {
        private TemplateHelper()
        {
            PopoluteResourceValues();
        }
        private static readonly Lazy<TemplateHelper> lazy = new Lazy<TemplateHelper>(() => new TemplateHelper());
        public static TemplateHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        
        public string AddApplicationProject, AddApplicationReferringDomain, AddAspNetCoreHostingPackage, AddDesignPackage, AddDomainProject, AdddotnetefPackage, AddExtensionsHostingPackage, AddInfrastructureProject, AddInfrastructureReferringApplication, AddInfrastructureReferringDomain, AddSqlServerPackage, AddToolsPackage, AddWebAPIProject, AddWebAPIReferringApplication, AddWebAPIReferringInfrastructure, ContollerAdd, ContollerClass, ContollerClassEnd, ContollerDelete, ContollerGet, ContollerGetAll, ContollerHeader, ContollerNamespace, ContollerNamespaceEnd, ContollerSPClass, ContollerUpdate, ControllerGetMethod, ControllerMethodComments, ControllerPostMethod, ControllerSPMethodComments, CreateApplication, CreateDomain, CreateInfrastructure, CreateSolution, CreateWebAPI, DBcontextClass, DBcontextNamespace, DBcontextUsing, DBContextWithModels, IRepositoryAdd, IRepositoryDelete, IRepositoryGet, IRepositoryGetAll, IRepositoryGetMethod, IRepositoryInterface, IRepositoryInterfaceEnd, IRepositoryMethodComments, IRepositoryNamespace, IRepositoryNamespaceEnd, IRepositoryPostMethod, IRepositorySPInterface, IRepositorySPMethodComments, IRepositoryUpdate, IServiceAdd, IServiceClassEnd, IServiceDelete, IServiceGet, IServiceGetAll, IServiceGetMethod, IServiceInterface, IServiceMethodComments, IServiceNamespace, IServiceNamespaceEnd, IServicePostMethod, IServiceSPInterface, IServiceSPMethodComments, IServiceUpdate, ModelAnnotation, ModelClassEnd, ModelClassProperty, ModelClassStart, ModelClassStartKeyProperty, ModelClassStartKey, ModelOnetomany, ModelUsing, ProgramClassEnd, ProgramClassStart, ProgramCreateHostBuilderMethod, ProgramMainMethod, ProgramNamespace, ProgramNamespaceEnd, ProgramUsing, RepositoryAdd, RepositoryClassEnd, RepositoryClassStart, RepositoryConstructor, RepositoryDelete, RepositoryGetAll, RepositoryGetById, RepositoryGetMethod, RepositoryMethodComments, RepositoryNamespace, RepositoryNamespaceEnd, RepositoryPostMethod, RepositorySPClassStart, RepositorySPConstructor, RepositorySPMethodComments, RepositoryUpdate, RepositoryUsing, ServiceAdd, ServiceClassEnd, ServiceClassStart, ServiceConstructor, ServiceDelete, ServiceGetAll, ServiceGetById, ServiceGetMethod, ServiceMethodComments, ServiceNamespace, ServiceNamespaceEnd, ServicePostMethod, ServiceSPClassStart, ServiceSPConstructor, ServiceSPMethodComments, ServiceUpdate, ServiceUsing, SpDBContext, SPInput, SPStartupForRepositoriesAndServices, StartupAddCorsMethod, StartupClassStart, StartupConfigureHealthCheckMethod, StartupConfigureMethod, StartupConfigureServicesMethod, StartupConfigureSwaggerMethod, StartupConstructor, StartupForRepositoriesAndServices, StartupNamespaceEnd, StartupNamespaceStart, StartupRegisterDependenciesMethod, StartupUsing= string.Empty;
        public void PopoluteResourceValues()
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("DynCodeGen.CodeGeneration.Controller.TemplateAttribute", this.GetType().Assembly);
            var entry = rm.GetResourceSet(System.Threading.Thread.CurrentThread.CurrentCulture, true, true)
                .OfType<DictionaryEntry>();

            var properties = typeof(TemplateHelper).GetFields();
            properties.ToList().ForEach(prop =>
            {
                prop.SetValue(this, entry.Where(y => y.Key.ToString() == prop.Name).Select(x => x.Value).First());
            });
        }
        public static void InsertCodeBeforeComments(StringBuilder codeBuilder, string codeToInsert, string methodName)
        {
            string[] lines = codeBuilder.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                int commentIndex = lines[i].IndexOf($"{methodName}");

                if (commentIndex != -1 && lines[i].Trim().Equals($"{methodName}"))
                {
                    lines[i] = lines[i].Insert(commentIndex + $"{methodName}".Length, Environment.NewLine + codeToInsert);
                }
                //if (lines[i].Trim().Equals($"// {methodName}"))
                //{
                //    lines[i] = codeToInsert + Environment.NewLine + lines[i];
                //}
            }
            codeBuilder.Clear();
            codeBuilder.AppendLine(string.Join(Environment.NewLine, lines));
        }
    }
}
