using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IEducationDegreeEndpoints
{
    [Post($"/{EducationDegreeModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateEducationDegreeModel(CreateEducationDegreeModelRequest request);

    [Get($"/{EducationDegreeModelEndpoints.GetById}")]
    Task<EducationDegreeModelResponse> GetEducationDegreeModelByIDAsync(string id);

    [Get($"/{EducationDegreeModelEndpoints.GetAll}")]
    Task<EducationDegreeModelsResponse> GetAllEducationDegreeModels(GetAllEducationDegreeModelsRequest request);

    [Put($"/{EducationDegreeModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateEducationDegreeModel(string id, UpdateEducationDegreeModelRequest request);

    [Delete($"/{EducationDegreeModelEndpoints.Delete}")]
    Task<EducationDegreeModelResponse> DeleteEducationDegreeModel(string id);
}
