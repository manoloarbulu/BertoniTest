using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BertoniApi;
using BertoniServices;
using System.Runtime.Serialization;

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
    }
}
