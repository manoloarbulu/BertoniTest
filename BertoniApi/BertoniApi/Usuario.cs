using System;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [DataContract(Name = "user")]
    public class Usuario
    {
        [DataMember(Name = "userId", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        //TODO: Invoke Service to getting user Albums
        [DataMember(Name = "album", EmitDefaultValue = false, IsRequired = false)]
        public AlbumCollection Albumes { get; set; }
    }
}
