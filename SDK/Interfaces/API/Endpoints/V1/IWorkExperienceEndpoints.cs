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
    Task<WorkExperienceModelResponse> CreateWorkExperienceModel(CreateWorkExperienceModelRequest request);

    [Get($"/{WorkExperienceModelEndpoints.GetById}")]
    Task<WorkExperienceModelResponse> GetWorkExperienceModelByIDAsync(int id);

    [Get($"/{WorkExperienceModelEndpoints.GetAll}")]
    Task<WorkExperienceModelsResponse> GetAllWorkExperienceModels(GetAllWorkExperienceModelsRequest request);

    [Put($"/{WorkExperienceModelEndpoints.Put}")]
    Task<WorkExperienceModelResponse> UpdateWorkExperienceModel(UpdateWorkExperienceModelRequest request);

    [Delete($"/{WorkExperienceModelEndpoints.Delete}")]
    Task<WorkExperienceModelResponse> DeleteWorkExperienceModel(int id);
}
