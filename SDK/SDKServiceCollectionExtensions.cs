using Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Serilog;

namespace Gay.TCazier.Resume.SDK;

public static class SDKServiceCollectionExtensions
{
    public static IServiceCollection RegisterResumeSDK(this IServiceCollection services, string baseURL)
    {
        Log.Information("Now adding http client for SDK calls using base address {baseURL}", baseURL);
        services.AddHttpClient();

        //.AddSingleton<AuthTokenProvider>()
        //.AddRefitClient<IAddressEndpoints>(s => new RefitSettings
        //{
        //    AuthorizationHeaderValueGetter = async () => await s.GetRequiredService<AuthTokenProvider>()
        //                                                          .GetTokenAsync()
        //})

        services.AddRefitClient<IAddressEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Address Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<ICountryCodeEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Country Code Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IContactEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Contact Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IOrganizationEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Organization Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IPersonEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Person Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IPhoneNumberEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Phone Number Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        
        services.AddRefitClient<ICertificateEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Certificate Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IEducationDegreeEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Degree Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IProjectEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Project Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IResumeEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Resume Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<ITechTagEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Tech Tag Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        services.AddRefitClient<IWorkExperienceEndpoints>()
            .ConfigureHttpClient(
            x => {
                Log.Debug("Now assigning {baseURL} as the host url for Work Experience Model calls using the SDK", baseURL);
                x.BaseAddress = new Uri(baseURL);
            });
        return services;
    }
}