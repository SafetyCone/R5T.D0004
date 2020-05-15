using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0004.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GuidProvider"/> implementation of <see cref="IGuidProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultGuidProvider(this IServiceCollection services)
        {
            services.AddSingleton<IGuidProvider, GuidProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GuidProvider"/> implementation of <see cref="IGuidProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IGuidProvider> AddDefaultGuidProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IGuidProvider>.New(() => services.AddDefaultGuidProvider());
            return serviceAction;
        }
    }
}
