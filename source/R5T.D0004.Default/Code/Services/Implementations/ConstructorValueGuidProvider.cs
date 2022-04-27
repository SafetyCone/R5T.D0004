using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0004.Default
{
    [ServiceImplementationMarker]
    public class ConstructorValueGuidProvider : IGuidProvider, IServiceImplementation
    {
        private Guid Guid { get; }


        public ConstructorValueGuidProvider(
            [NotServiceComponent] Guid guid)
        {
            this.Guid = guid;
        }

        public Task<Guid> GetGuidAsync()
        {
            return Task.FromResult(this.Guid);
        }
    }
}
