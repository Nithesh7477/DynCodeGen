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

        public string ApiExceptionClass, APIResponseClass, APIResponseBaseClass, APIValidationErrorResponseClass, BadRequestExceptionClass, AddApplicationProject, AddApplicationReferringDomain, AddAspNetCoreHostingPackage, AddConfigPackage, AddDesignPackage, AddDomainProject, AdddotnetefPackage, AddSeriLogPackage, AddSeriLogConfigurationPackage, AddSeriLogConsolePackage, AddSeriLogSinksPackage, AddSwashbucklePackage, AddExtensionsHostingPackage, AddInfrastructureProject, AddInfrastructureReferringApplication, AddInfrastructureReferringDomain, AddOptionsPackage, AddSqlClientPackage, AddSqlServerPackage, AddToolsPackage, AddWebAPIProject, AddWebAPIReferringApplication, AddWebAPIReferringInfrastructure, BaseRepository, ContollerAdd, ContollerClass, ContollerClassEnd, ContollerDelete, ContollerGet, ContollerGetAll, ContollerHeader, ContollerNamespace, ContollerNamespaceEnd, CheckUserDotNETVersion, ContollerSPClass, ContollerUpdate, ControllerGetMethod, ControllerMethodComments, ControllerPostMethod, ControllerPostMethodAdo, ControllerSPMethodComments, CreateApplication, CreateDomain, CreateInfrastructure, CreateSolution, CreateWebAPI, DBcontextClass, DBcontextNamespace, DBcontextUsing, DBContextWithModels, DotNETVersion, IRepositoryAdd, IRepositoryDelete, IRepositoryGet, IRepositoryGetAll, IRepositoryGetMethod, IRepositoryInterface, IRepositoryInterfaceEnd, IRepositoryMethodComments, IRepositoryNamespace, IRepositoryNamespaceEnd, IRepositoryPostMethod, IRepositoryPostMethodAdo, IRepositorySPInterface, IRepositorySPMethodComments, IRepositoryUpdate, IServiceAdd, IServiceClassEnd, IServiceDelete, IServiceGet, IServiceGetAll, IServiceGetMethod, IServiceInterface, IServiceMethodComments, IServiceNamespace, IServiceNamespaceEnd, IServicePostMethod, IServicePostMethodAdo, IServiceSPInterface, IServiceSPMethodComments, IServiceUpdate, ModelAnnotation, ModelClassEnd, ModelClassProperty, ModelClassStringProperty, ModelClassStart, ModelClassStartKey, ModelClassStartKeyProperty, ModelOnetomany, ModelClassNameSpace, ADOServiceUsing, ADOControllerHeader, CommonUsingHeaderforModel, ModelUsing, ProgramClassEnd, ProgramClassStart, ProgramCreateHostBuilderMethod, ProgramMainMethod, ProgramNamespace, ProgramNamespaceEnd, ExceptionMiddlewareClass, ProgramUsing, RepositoryAdd, RepositoryClassEnd, RepositoryClassStart, RepositoryClassStartAdo, RepositoryConstructor, RepositoryConstructorAdo, RepositoryDelete, RepositoryGetAll, RepositoryGetById, RepositoryGetMethod, RepositoryGetMethodEndAdo, RepositoryGetMethodMiddleAdo, RepositoryGetMethodStartAdo, RepositoryMethodComments, RepositoryNamespace, RepositoryNamespaceEnd, RepositoryPostMethod, RepositoryPostMethodAdo, RepositoryPostMethodEndAdo, RepositoryPostMethodMiddleAdo, RepositoryPostMethodStartAdo, RepositorySPClassStart, RepositorySPConstructor, RepositorySPMethodComments, RepositoryUpdate, RepositoryUsing, RepositoryUsingAdo, ServiceAdd, ServiceClassEnd, ServiceClassStart, ServiceConstructor, ServiceDelete, ServiceGetAll, ServiceGetById, ServiceGetMethod, ServiceGetMethodAdo, ServiceMethodComments, ServiceNamespace, ServiceNamespaceEnd, ServicePostMethod, ServicePostMethodAdo, ServiceSPClassStart, ServiceSPConstructor, ServiceSPMethodComments, ServiceUpdate, ServiceUsing, SpDBContext, SPInput, SPStartupForRepositoriesAndServices, SqlHelperClassEnd, SqlHelperClassStart, SqlHelperConvertDataTableToList, SqlHelperExecuteNonQuery, SqlHelperExecuteSelect, SqlHelperExecutionType, SqlHelperGetItem, SqlHelperNamespace, SqlHelperSetConnectionString, SqlHelperUsings, StartupAddCorsMethod, StartupClassStart, StartupConfigureHealthCheckMethod, StartupConfigureMethod, StartupConfigureServicesMethod, StartupConfigureServicesMethodAdo, StartupConfigureSwaggerMethod, StartupConstructor, StartupForRepositoriesAndServices, StartupNamespaceEnd, StartupNamespaceStart, StartupRegisterDependenciesMethod, StartupUsing, StartupUsingAdo, AddJwtBearer, AddIdentityWeb;
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
