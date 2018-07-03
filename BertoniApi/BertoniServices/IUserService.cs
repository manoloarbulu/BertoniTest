using System.ServiceModel;
using System.ServiceModel.Web;
using BertoniApi;

namespace BertoniServices
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract(Name = "Usuarios")]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UsuarioCollection GetUsuarios();
    }
}
