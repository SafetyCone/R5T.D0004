using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0004
{
    [ServiceDefinitionMarker]
    public interface IGuidProvider : IServiceDefinition
    {
        Task<Guid> GetGuidAsync();
    }
}
