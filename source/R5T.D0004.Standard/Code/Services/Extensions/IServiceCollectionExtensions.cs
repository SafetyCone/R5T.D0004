using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0004.Default;


namespace R5T.D0004.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IGuidProvider"/> service.
        /// </summary>
        public static IServiceCollection AddGuidProvider(this IServiceCollection services)
        {
            services.AddDefaultGuidProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IGuidProvider"/> service.
        /// </summary>
        public static ServiceAction<IGuidProvider> AddGuidProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IGuidProvider>.New(() => services.AddGuidProvider());
            return serviceAction;
        }
    }
}
