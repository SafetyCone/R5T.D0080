using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0080
{
    [ServiceDefinitionMarker]
    public interface IOutputTextFilePathProvider : IServiceDefinition
    {
        Task<string> GetOutputTextFilePath();
    }
}
