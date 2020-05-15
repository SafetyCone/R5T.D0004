using System;
using System.Threading.Tasks;


namespace R5T.D0004.Default
{
    public class GuidProvider : IGuidProvider
    {
        public Task<Guid> GetGuidAsync()
        {
            var guid = Guid.NewGuid();

            return Task.FromResult(guid);
        }
    }
}
