using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BertoniApi;
using BertoniServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace BertoniAppTests
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new UserService();
            var usuarios = service.GetUsuarios();

            var serializer = new DataContractSerializer(typeof(UsuarioCollection));

            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, usuarios);
                ms.Seek(0, SeekOrigin.Begin);
                using (var reader = new StreamReader(ms))
                {
                    var result = reader.ReadToEnd();
                    Assert.IsNotNull(result);
                }
            }
        }

        [TestMethod]
        public void DeserializePhotos()
        {
            const string json = "[{\"albumId\": 1,\"id\": 1,\"title\": \"accusamus beatae ad facilis cum similique qui sunt\",\"url\": \"http://placehold.it/600/92c952\",\"thumbnailUrl\": \"http://placehold.it/150/92c952\"}, {\"albumId\": 1,\"id\": 2,\"title\": \"reprehenderit est deserunt velit ipsam\", \"url\": \"http://placehold.it/600/771796\", \"thumbnailUrl\": \"http://placehold.it/150/771796\" }]";
            var serializer = new DataContractJsonSerializer(typeof(PhotoCollection));

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var photos = (PhotoCollection)serializer.ReadObject(ms);
                Assert.IsNotNull(photos);
            }
        }

        [TestMethod]
        public void DeserializePhoto()
        {
            const string json = "{\"albumId\": 1,\"id\": 1,\"title\": \"accusamus beatae ad facilis cum similique qui sunt\",\"url\": \"http://placehold.it/600/92c952\",\"thumbnailUrl\": \"http://placehold.it/150/92c952\"}]";
            var serializer = new DataContractJsonSerializer(typeof(Photo));

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var photo = (Photo)serializer.ReadObject(ms);
                Assert.IsNotNull(photo);
            }
        }
    }
}
