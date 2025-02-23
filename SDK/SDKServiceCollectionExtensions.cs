using Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Gay.TCazier.Resume.SDK;

public static class SDKServiceCollectionExtensions
{
    public static IServiceCollection RegisterResumeSDK(this IServiceCollection services, string baseURL)
    {
        services.AddHttpClient();

        //.AddSingleton<AuthTokenProvider>()
        //.AddRefitClient<IAddressEndpoints>(s => new RefitSettings
        //{
        //    AuthorizationHeaderValueGetter = async () => await s.GetRequiredService<AuthTokenProvider>().GetTokenAsync()
        //})
        services.AddRefitClient<IAddressEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<ICountryCodeEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IContactEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IOrganizationEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IPersonEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IPhoneNumberEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        
        services.AddRefitClient<ICertificateEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IEducationDegreeEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IProjectEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IResumeEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<ITechTagEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        services.AddRefitClient<IWorkExperienceEndpoints>()
            .ConfigureHttpClient(x => x.BaseAddress = new Uri(baseURL));
        return services;
    }
}