using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IPersonEndpoints
{
    [Post($"/{PersonModelEndpoints.Post}")]
    Task<PersonModelResponse> CreatePersonModel(CreatePersonModelRequest request);

    [Get($"/{PersonModelEndpoints.GetById}")]
    Task<PersonModelResponse> GetPersonModelByIDAsync(int id);

    [Get($"/{PersonModelEndpoints.GetAll}")]
    Task<PersonModelsResponse> GetAllPersonModels(GetAllPersonModelsRequest request);

    [Put($"/{PersonModelEndpoints.Put}")]
    Task<PersonModelResponse> UpdatePersonModel(UpdatePersonModelRequest request);

    [Delete($"/{PersonModelEndpoints.Delete}")]
    Task<PersonModelResponse> DeletePersonModel(int id);
}
