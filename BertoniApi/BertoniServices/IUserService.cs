using System.ServiceModel;
using System.ServiceModel.Web;
using BertoniApi;

namespace BertoniServices
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract(Name = "users")]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UsuarioCollection GetUsuarios();
    }
}
