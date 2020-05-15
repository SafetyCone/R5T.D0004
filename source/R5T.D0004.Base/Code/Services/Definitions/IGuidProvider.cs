using System;
using System.Threading.Tasks;


namespace R5T.D0004
{
    public interface IGuidProvider
    {
        Task<Guid> GetGuidAsync();
    }
}
