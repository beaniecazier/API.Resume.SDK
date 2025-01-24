using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IAddressEndpoints
{
    [Post($"/{AddressModelEndpoints.Post}")]
    Task CreateAddressModel(CreateAddressModelRequest request);

    [Get($"/{AddressModelEndpoints.GetById}")]
    Task<AddressModelResponse> GetAddressModelByIDAsync(string id);

    [Get($"/{AddressModelEndpoints.GetAll}")]
    Task<AddressModelsResponse> GetAllAddressModels(GetAllAddressModelsRequest request);

    [Put($"/{AddressModelEndpoints.Put}")]
    Task<AddressModelResponse> UpdateAddressModel(string id, UpdateAddressModelRequest request);

    [Delete($"/{AddressModelEndpoints.Delete}")]
    Task<AddressModelResponse> DeleteAddressModel(string id);
}
