using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0004.Default
{[ServiceImplementationMarker]
    public class StaticValueGuidProvider : IGuidProvider,IServiceImplementation
    {
        /// <summary>
        /// Note: not thread-safe.
        /// </summary>
        public static Guid Guid { get; }


        public Task<Guid> GetGuidAsync()
        {
            return Task.FromResult(StaticValueGuidProvider.Guid);
        }
    }
}
