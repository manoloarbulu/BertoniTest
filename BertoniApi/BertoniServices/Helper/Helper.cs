using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
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
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Resources.Users));
            var serializer = new DataContractJsonSerializer(typeof(UsuarioCollection));
            stream.Position = 0;
            var usuarios = (UsuarioCollection) serializer.ReadObject(stream);
            stream.Close();
            return usuarios;
        }

        private static AlbumCollection LoadAlbumes()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Resources.Albums));
            var serializer = new DataContractJsonSerializer(typeof(AlbumCollection));
            stream.Position = 0;
            var albumes = (AlbumCollection)serializer.ReadObject(stream);
            stream.Close();
            return albumes;
        }

        private static PhotoCollection LoadPhotos()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Resources.Photos));
            var serializer = new DataContractJsonSerializer(typeof(PhotoCollection));
            stream.Position = 0;
            var photos = (PhotoCollection)serializer.ReadObject(stream);
            stream.Close();
            return photos;
        }

        private static CommentCollection LoadComments()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Resources.Comments));
            var serializer = new DataContractJsonSerializer(typeof(CommentCollection));
            stream.Position = 0;
            var comments = (CommentCollection)serializer.ReadObject(stream);
            stream.Close();
            return comments;
        }
    }
}