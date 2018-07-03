using System.IO;
using System.Runtime.Serialization;
using BertoniApi;

namespace BertoniServices.Helper
{
    internal static class Helper
    {
        private static string Folder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.FullName;

        public static UsuarioCollection Usuarios { get; } = LoadUsers();
        public static AlbumCollection Albumes { get; } = LoadAlbumes();
        public static PhotoCollection Photos { get; } = LoadPhotos();
        public static CommentCollection Comments { get; } = LoadComments();

        private static UsuarioCollection LoadUsers()
        {
            var file = new FileStream(Folder + @"\Files\users.json", FileMode.Open);
            var serializer = new DataContractSerializer(typeof(UsuarioCollection));
            var usuarios = (UsuarioCollection) serializer.ReadObject(file);
            file.Close();
            return usuarios;
        }

        private static AlbumCollection LoadAlbumes()
        {
            var file = new FileStream(Folder + @"\Files\albums.json", FileMode.Open);
            var serializer = new DataContractSerializer(typeof(AlbumCollection));
            var albumes = (AlbumCollection)serializer.ReadObject(file);
            file.Close();
            return albumes;
        }

        private static PhotoCollection LoadPhotos()
        {
            var file = new FileStream(Folder + @"\Files\photos.json", FileMode.Open);
            var serializer = new DataContractSerializer(typeof(AlbumCollection));
            var photos = (PhotoCollection)serializer.ReadObject(file);
            file.Close();
            return photos;
        }

        private static CommentCollection LoadComments()
        {
            var file = new FileStream(Folder + @"\Files\comments.json", FileMode.Open);
            var serializer = new DataContractSerializer(typeof(AlbumCollection));
            var comments = (CommentCollection)serializer.ReadObject(file);
            file.Close();
            return comments;
        }
    }
}