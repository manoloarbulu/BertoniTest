using System.ServiceModel;
using BertoniApi;

namespace BertoniServices
{
    public class UserService : IUserService
    {
        #region Implementation of IUserService
        public UsuarioCollection GetUsuarios()
        {
            return Helper.Helper.Usuarios;
        }
        #endregion
    }
}
