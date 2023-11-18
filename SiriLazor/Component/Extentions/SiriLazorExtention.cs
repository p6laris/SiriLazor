using Microsoft.Extensions.DependencyInjection;

namespace SiriLazor.Component.Extentions
{
    public static class SiriLazorExtention
    {
            public static IServiceCollection AddSiriLazor(this IServiceCollection services) =>
                services.AddScoped<ISiriLazor, SiriLazor>();
    }
}
