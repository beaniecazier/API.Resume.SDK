using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IOrganizationEndpoints
{
    [Post($"/{OrganizationModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateOrganizationModel(CreateOrganizationModelRequest request);

    [Get($"/{OrganizationModelEndpoints.GetById}")]
    Task<OrganizationModelResponse> GetOrganizationModelByIDAsync(string id);

    [Get($"/{OrganizationModelEndpoints.GetAll}")]
    Task<OrganizationModelsResponse> GetAllOrganizationModels(GetAllOrganizationModelsRequest request);

    [Put($"/{OrganizationModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateOrganizationModel(string id, UpdateOrganizationModelRequest request);

    [Delete($"/{OrganizationModelEndpoints.Delete}")]
    Task<OrganizationModelResponse> DeleteOrganizationModel(string id);
}
