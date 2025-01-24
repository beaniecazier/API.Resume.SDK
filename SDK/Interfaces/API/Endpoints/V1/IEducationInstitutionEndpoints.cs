using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface IEducationInstitutionEndpoints
{
    [Post($"/{EducationInstitutionModelEndpoints.Post}")]
    Task<EducationInstitutionModelResponse> CreateEducationInstitutionModel(CreateEducationInstitutionModelRequest request);

    [Get($"/{EducationInstitutionModelEndpoints.GetById}")]
    Task<EducationInstitutionModelResponse> GetEducationInstitutionModelByIDAsync(int id);

    [Get($"/{EducationInstitutionModelEndpoints.GetAll}")]
    Task<EducationInstitutionModelsResponse> GetAllEducationInstitutionModels(GetAllEducationInstitutionModelsRequest request);

    [Put($"/{EducationInstitutionModelEndpoints.Put}")]
    Task<EducationInstitutionModelResponse> UpdateEducationInstitutionModel(UpdateEducationInstitutionModelRequest request);

    [Delete($"/{EducationInstitutionModelEndpoints.Delete}")]
    Task<EducationInstitutionModelResponse> DeleteEducationInstitutionModel(int id);
}
