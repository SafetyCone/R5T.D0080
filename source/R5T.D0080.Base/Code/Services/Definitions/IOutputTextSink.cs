using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0080
{
    /// <summary>
    /// Service is synchronous as interior to it's implementation will be the synchronicity test.
    /// (Borderline case of whether this service should even independently exist, or whether it should be folded into the console- and file-specific implementations.)
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IOutputTextSink : IServiceDefinition
    {
        void Write(string text, Func<string, Task> writingAction);
    }
}
