using Gay.TCazier.Resume.Contracts.Endpoints.V1;
using Gay.TCazier.Resume.Contracts.Requests.V1.Create;
using Gay.TCazier.Resume.Contracts.Requests.V1.GetAll;
using Gay.TCazier.Resume.Contracts.Requests.V1.Update;
using Gay.TCazier.Resume.Contracts.Responses.V1;
using Refit;

namespace Gay.TCazier.Resume.SDK.Interfaces.API.Endpoints.V1;

public interface ICertificateEndpoints
{
    [Post($"/{CertificateModelEndpoints.Post}")]
    Task<HttpResponseMessage?> CreateCertificateModel(CreateCertificateModelRequest request);

    [Get($"/{CertificateModelEndpoints.GetById}")]
    Task<CertificateModelResponse> GetCertificateModelByIDAsync(string id);

    [Get($"/{CertificateModelEndpoints.GetAll}")]
    Task<CertificateModelsResponse> GetAllCertificateModels(GetAllCertificateModelsRequest request);

    [Put($"/{CertificateModelEndpoints.Put}")]
    Task<HttpResponseMessage?> UpdateCertificateModel(string id, UpdateCertificateModelRequest request);

    [Delete($"/{CertificateModelEndpoints.Delete}")]
    Task<CertificateModelResponse> DeleteCertificateModel(string id);
}
