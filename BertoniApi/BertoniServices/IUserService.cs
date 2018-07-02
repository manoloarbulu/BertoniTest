using System.ServiceModel;
using BertoniApi;

namespace BertoniServices
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract(Name = "Usuarios")]
        UsuarioCollection GetUsuarios();
    }
}
