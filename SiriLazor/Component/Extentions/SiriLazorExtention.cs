using Microsoft.Extensions.DependencyInjection;

namespace SiriLazor.Component.Extentions
{
    /// <summary>
    /// Provides extension methods for configuring SiriLazor services in the dependency injection container.
    /// </summary>
    public static class SiriLazorExtention
    {
        /// <summary>
        /// Adds SiriLazor services to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <returns>The modified <see cref="IServiceCollection"/> with SiriLazor services added.</returns>
        public static IServiceCollection AddSiriLazor(this IServiceCollection services) =>
            services.AddScoped<ISiriLazor, SiriLazor>();
    }
}
