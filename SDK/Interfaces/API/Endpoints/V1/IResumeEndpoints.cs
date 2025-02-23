using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IResumeEndpoints
{
    [Post($"/{ResumeModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateResumeModel(CreateResumeModelRequest request);

    [Get($"/{ResumeModelEndpoints.GetById}")]
    Task<ResumeModelResponse> GetResumeModelByIDAsync(int id);

    [Get($"/{ResumeModelEndpoints.GetAll}")]
    Task<ResumeModelsResponse> GetAllResumeModels(GetAllResumeModelsRequest request);

    [Put($"/{ResumeModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateResumeModel(string id, UpdateResumeModelRequest request);

    [Delete($"/{ResumeModelEndpoints.Delete}")]
    Task<ResumeModelResponse> DeleteResumeModel(int id);
}
