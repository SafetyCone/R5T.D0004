using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0004.Default
{[ServiceImplementationMarker]
    public class GuidProvider : IGuidProvider,IServiceImplementation
    {
        public Task<Guid> GetGuidAsync()
        {
            var guid = Guid.NewGuid();

            return Task.FromResult(guid);
        }
    }
}
