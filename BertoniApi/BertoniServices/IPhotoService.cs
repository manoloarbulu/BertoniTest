using System.ServiceModel;
using System.ServiceModel.Web;
using BertoniApi;

namespace BertoniServices
{
    [ServiceContract]
    public interface IPhotoService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/album/{albumId}")]
        PhotoCollection AlbumPhotos(string albumId);
    }
}
