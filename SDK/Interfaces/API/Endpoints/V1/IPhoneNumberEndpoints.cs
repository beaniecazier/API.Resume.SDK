using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IPhoneNumberEndpoints
{
    [Post($"/{PhoneNumberModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreatePhoneNumberModel(CreatePhoneNumberModelRequest request);

    [Get($"/{PhoneNumberModelEndpoints.GetById}")]
    Task<PhoneNumberModelResponse> GetPhoneNumberModelByIDAsync(int id);

    [Get($"/{PhoneNumberModelEndpoints.GetAll}")]
    Task<PhoneNumberModelsResponse> GetAllPhoneNumberModels(GetAllPhoneNumberModelsRequest request);

    [Put($"/{PhoneNumberModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdatePhoneNumberModel(string id, UpdatePhoneNumberModelRequest request);

    [Delete($"/{PhoneNumberModelEndpoints.Delete}")]
    Task<PhoneNumberModelResponse> DeletePhoneNumberModel(int id);
}
