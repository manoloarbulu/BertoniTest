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
    }
}
