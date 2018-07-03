using System.ServiceModel;
using System.ServiceModel.Web;
using BertoniApi;

namespace BertoniServices
{
    [ServiceContract]
    public interface ICommentsService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/photo/{photoId}")]
        CommentCollection PhotoComments(string photoId);
    }
}
