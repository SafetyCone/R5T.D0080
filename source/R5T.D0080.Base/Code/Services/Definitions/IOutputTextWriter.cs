using System;

using R5T.T0064;


namespace R5T.D0080
{
    [ServiceDefinitionMarker]
    public interface IOutputTextWriter : IServiceDefinition
    {
        void Write(string text);
    }
}
