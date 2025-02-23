using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface ICountryCodeEndpoints
{
    [Post($"/{CountryCodeModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateCountryCodeModel(CreateCountryCodeModelRequest request);

    [Get($"/{CountryCodeModelEndpoints.GetById}")]
    Task<CountryCodeModelResponse> GetCountryCodeModelByIDAsync(string id);

    [Get($"/{CountryCodeModelEndpoints.GetAll}")]
    Task<CountryCodeModelsResponse> GetAllCountryCodeModels(GetAllCountryCodeModelsRequest request);

    [Put($"/{CountryCodeModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateCountryCodeModel(string id, UpdateCountryCodeModelRequest request);

    [Delete($"/{CountryCodeModelEndpoints.Delete}")]
    Task<CountryCodeModelResponse> DeleteCountryCodeModel(string id);
}
