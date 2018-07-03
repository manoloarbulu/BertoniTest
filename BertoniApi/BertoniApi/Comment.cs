using System;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [DataContract(Name = "comment")]
    public class Comment
    {
        [DataMember(Name = "postId", EmitDefaultValue = false, IsRequired = true)]
        protected internal int PostId { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = true)]
        public string EMail { get; set; }

        [DataMember(Name = "body", EmitDefaultValue = false, IsRequired = true)]
        public string Body { get; set; }
    }
}
