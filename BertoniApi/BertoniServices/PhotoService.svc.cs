using System;
using BertoniApi;

namespace BertoniServices
{
    public class PhotoService : IPhotoService
    {
        #region Implementation of IPhotoService

        public PhotoCollection AlbumPhotos(string albumId)
        {
            return Helper.Helper.Photos.AlbumPhotos(Convert.ToInt32(albumId));
        }

        #endregion
    }
}
