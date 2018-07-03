using System.IO;
using System.Runtime.Serialization;
using BertoniApi;
using BertoniServices.Properties;

namespace BertoniServices.Helper
{
    internal static class Helper
    {
        public static UsuarioCollection Usuarios { get; } = LoadUsers();
        public static AlbumCollection Albumes { get; } = LoadAlbumes();
        public static PhotoCollection Photos { get; } = LoadPhotos();
        public static CommentCollection Comments { get; } = LoadComments();

        private static UsuarioCollection LoadUsers()
        {
            var stream = new MemoryStream(Resources.Users);
            var serializer = new DataContractSerializer(typeof(UsuarioCollection));
            var usuarios = (UsuarioCollection) serializer.ReadObject(stream);
            stream.Close();
            return usuarios;
        }

        private static AlbumCollection LoadAlbumes()
        {
            var stream = new MemoryStream(Resources.Albums);
            var serializer = new DataContractSerializer(typeof(AlbumCollection));
            var albumes = (AlbumCollection)serializer.ReadObject(stream);
            stream.Close();
            return albumes;
        }

        private static PhotoCollection LoadPhotos()
        {
            var stream = new MemoryStream(Resources.Photos);
            var serializer = new DataContractSerializer(typeof(AlbumCollection));
            var photos = (PhotoCollection)serializer.ReadObject(stream);
            stream.Close();
            return photos;
        }

        private static CommentCollection LoadComments()
        {
            var stream = new MemoryStream(Resources.Comments);
            var serializer = new DataContractSerializer(typeof(AlbumCollection));
            var comments = (CommentCollection)serializer.ReadObject(stream);
            stream.Close();
            return comments;
        }
    }
}