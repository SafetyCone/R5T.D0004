using System;
using System.Threading.Tasks;


namespace R5T.D0004.Default
{
    public class StaticValueGuidProvider : IGuidProvider
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
