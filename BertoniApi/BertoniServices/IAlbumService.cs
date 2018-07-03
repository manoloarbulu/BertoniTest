using System.ServiceModel;
using System.ServiceModel.Web;
using BertoniApi;

namespace BertoniServices
{
    [ServiceContract]
    public interface IAlbumService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/user/{userId}")]
        AlbumCollection GetAlbums(string userId);
    }
}
