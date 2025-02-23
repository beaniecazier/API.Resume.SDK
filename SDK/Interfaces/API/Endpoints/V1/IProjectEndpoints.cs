using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IProjectEndpoints
{
    [Post($"/{ProjectModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateProjectModel(CreateProjectModelRequest request);

    [Get($"/{ProjectModelEndpoints.GetById}")]
    Task<ProjectModelResponse> GetProjectModelByIDAsync(string id);

    [Get($"/{ProjectModelEndpoints.GetAll}")]
    Task<ProjectModelsResponse> GetAllProjectModels(GetAllProjectModelsRequest request);

    [Put($"/{ProjectModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateProjectModel(string id, UpdateProjectModelRequest request);

    [Delete($"/{ProjectModelEndpoints.Delete}")]
    Task<ProjectModelResponse> DeleteProjectModel(string id);
}
