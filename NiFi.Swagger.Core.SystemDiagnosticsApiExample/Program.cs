using System;

namespace NiFi.Swagger.Core.SystemDiagnosticsApiExample
{
    using NiFi.Swagger.Core.Api;
    using NiFi.Swagger.Core.Client;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var config = new Configuration
                                 {
                                     BasePath = "http://localhost:8080/nifi-api"
                                 };

                var systemApi = new SystemDiagnosticsApi(config);

                var localDiagnostics = systemApi.GetSystemDiagnostics();
                Console.WriteLine(localDiagnostics.ToJson());

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
