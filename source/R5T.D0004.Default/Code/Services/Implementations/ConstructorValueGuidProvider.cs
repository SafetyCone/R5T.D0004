using System;
using System.Threading.Tasks;


namespace R5T.D0004.Default
{
    public class ConstructorValueGuidProvider : IGuidProvider
    {
        private Guid Guid { get; }


        public ConstructorValueGuidProvider(Guid guid)
        {
            this.Guid = guid;
        }

        public Task<Guid> GetGuidAsync()
        {
            return Task.FromResult(this.Guid);
        }
    }
}
