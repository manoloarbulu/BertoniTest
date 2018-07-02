using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BertoniApi;

namespace BertoniServices
{
    public class UserService : IUserService
    {
        #region Implementation of IUserService
        public UsuarioCollection GetUsuarios()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
