using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface ITechTagEndpoints
{
    [Post($"/{TechTagModelEndpoints.Post}")]
    Task<TechTagModelResponse> CreateTechTagModel(CreateTechTagModelRequest request);

    [Get($"/{TechTagModelEndpoints.GetById}")]
    Task<TechTagModelResponse> GetTechTagModelByIDAsync(int id);

    [Get($"/{TechTagModelEndpoints.GetAll}")]
    Task<TechTagModelsResponse> GetAllTechTagModels(GetAllTechTagModelsRequest request);

    [Put($"/{TechTagModelEndpoints.Put}")]
    Task<TechTagModelResponse> UpdateTechTagModel(UpdateTechTagModelRequest request);

    [Delete($"/{TechTagModelEndpoints.Delete}")]
    Task<TechTagModelResponse> DeleteTechTagModel(int id);
}
