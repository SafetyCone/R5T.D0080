using System;
using System.Threading.Tasks;


namespace R5T.D0080
{
    public interface IOutputTextFilePathProvider
    {
        Task<string> GetOutputTextFilePath();
    }
}
