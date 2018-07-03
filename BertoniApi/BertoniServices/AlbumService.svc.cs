using System;
using BertoniApi;

namespace BertoniServices
{
    public class AlbumService : IAlbumService
    {
        #region Implementation of IAlbumService

        public AlbumCollection GetAlbums(string userId)
        {
            return Helper.Helper.Albumes.UserAlbumes(Convert.ToInt32(userId));
        }

        #endregion
    }
}
