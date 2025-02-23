using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IWorkExperienceEndpoints
{
    [Post($"/{WorkExperienceModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateWorkExperienceModel(CreateWorkExperienceModelRequest request);

    [Get($"/{WorkExperienceModelEndpoints.GetById}")]
    Task<WorkExperienceModelResponse> GetWorkExperienceModelByIDAsync(string id);

    [Get($"/{WorkExperienceModelEndpoints.GetAll}")]
    Task<WorkExperienceModelsResponse> GetAllWorkExperienceModels(GetAllWorkExperienceModelsRequest request);

    [Put($"/{WorkExperienceModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateWorkExperienceModel(string id, UpdateWorkExperienceModelRequest request);

    [Delete($"/{WorkExperienceModelEndpoints.Delete}")]
    Task<WorkExperienceModelResponse> DeleteWorkExperienceModel(string id);
}
