using BeaniesUtilities.Models.Enum;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Gay.TCazier.Resume.SDK;
using Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;


var services = new ServiceCollection();

services
    .AddHttpClient()
    //.AddSingleton<AuthTokenProvider>()
    .AddRefitClient<IPhoneNumberEndpoints>(s => new RefitSettings
    {
        //AuthorizationHeaderValueGetter = async () => await s.GetRequiredService<AuthTokenProvider>().GetTokenAsync()
    })
    .ConfigureHttpClient(x =>
        x.BaseAddress = new Uri("https://localhost:7005"));

var provider = services.BuildServiceProvider();

// var addressApi = provider.GetRequiredService<IAddressEndpoints>();
//
// var responses = await addressApi.GetAllAddressModels(new GetAllAddressModelsRequest()
// {
//     NameSearchTerm = string.Empty,
//     NotesSearchTerm = string.Empty,
//     AllowHidden = false,
//     AllowDeleted = false,
//     AfterDate = null,
//     BeforeDate = null,
//     GreaterThanOrEqualToID = null,
//     LessThanOrEqualToID = null,
//     SpecificIds = new int[] {0},
//     PageIndex = 0,
//     PageSize = int.MaxValue,
//     SortBy = "+CommonIdentity"
// });

var PhoneNumberApi = provider.GetRequiredService<IPhoneNumberEndpoints>();
var newPhoneNumberRequest = new CreatePhoneNumberModelRequest()
{
    AreaCode = "503",
    CountryCode = 230,
    LineNumber = "0608",
    TelephonePrefix = "896",
    Name = "Beanies Cell 1",
    Notes = "SDK Consumer POST Test",
    PhoneType = ePhoneType.Mobile
};
var phonePostResponse = await PhoneNumberApi.CreatePhoneNumberModel(newPhoneNumberRequest);

Console.WriteLine("Hello World");