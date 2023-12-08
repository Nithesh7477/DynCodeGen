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
        
        public string ContollerAdd, ContollerClass, ContollerClassEnd, ContollerDelete, ContollerGet, ContollerGetAll, ContollerHeader, ContollerNamespace, ContollerNamespaceEnd, ContollerUpdate, IRepositoryAdd, IRepositoryDelete, IRepositoryGet, IRepositoryGetAll, IRepositoryInterface, IRepositoryInterfaceEnd, IRepositoryNamespace, IRepositoryNamespaceEnd, IRepositoryUpdate, IServiceAdd, IServiceClassEnd, IServiceDelete, IServiceGet, IServiceGetAll, IServiceInterface, IServiceNamespace, IServiceNamespaceEnd, IServiceUpdate, ProgramClassEnd, ProgramClassStart, ProgramCreateHostBuilderMethod, ProgramMainMethod, ProgramNamespace, ProgramNamespaceEnd, ProgramUsing, RepositoryAdd, RepositoryClassEnd, RepositoryClassStart, RepositoryConstructor, RepositoryDelete, RepositoryGetAll, RepositoryGetById, RepositoryNamespace, RepositoryNamespaceEnd, RepositoryUpdate, RepositoryUsing, ServiceAdd, ServiceClassEnd, ServiceClassStart, ServiceConstructor, ServiceDelete, ServiceGetAll, ServiceGetById, ServiceNamespace, ServiceNamespaceEnd, ServiceUpdate, ServiceUsing, StartupAddCorsMethod, StartupClassStart, StartupForRepositoriesAndServices, StartupConfigureHealthCheckMethod, StartupConfigureMethod, StartupConfigureServicesMethod, StartupConfigureSwaggerMethod, StartupConstructor, StartupNamespaceEnd, StartupNamespaceStart, StartupRegisterDependenciesMethod, StartupUsing, DBcontextUsing, DBcontextNamespace, DBcontextClass,DBContextWithModels, ModelUsing, ModelClassStart, ModelOnetomany, ModelAnnotation,ModelClassProperty, CreateWebAPI, CreateSolution, CreateApplication, CreateDomain, CreateInfrastructure, AddWebAPIProject, AddApplicationProject, AddDomainProject, AddInfrastructureProject, AddWebAPIReferringApplication, AddWebAPIReferringInfrastructure, AddApplicationReferringDomain, AddInfrastructureReferringDomain, AddInfrastructureReferringApplication, AddSqlServerPackage, AddDesignPackage, AddToolsPackage, AddAspNetCoreHostingPackage, AddExtensionsHostingPackage, AdddotnetefPackage = string.Empty;
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
    }
}
