using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IContactEndpoints
{
    [Post($"/{ContactModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateContactModel(CreateContactModelRequest request);

    [Get($"/{ContactModelEndpoints.GetById}")]
    Task<ContactModelResponse> GetContactModelByIDAsync(string id);

    [Get($"/{ContactModelEndpoints.GetAll}")]
    Task<ContactModelsResponse> GetAllContactModels(GetAllContactModelsRequest request);

    [Put($"/{ContactModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateContactModel(string id, UpdateContactModelRequest request);

    [Delete($"/{ContactModelEndpoints.Delete}")]
    Task<ContactModelResponse> DeleteContactModel(string id);
}
