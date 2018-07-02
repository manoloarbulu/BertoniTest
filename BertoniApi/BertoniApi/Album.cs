using System;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [DataContract(Name = "album")]
    public class Album
    {
        [DataMember(Name = "userId", IsRequired = true)]
        protected internal int UserId { get; set; }

        [DataMember(Name = "id", IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = true)]
        public string Title { get; set; }
    }
}