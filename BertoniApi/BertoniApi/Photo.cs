using System;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [DataContract(Name = "photo")]
    public class Photo
    {
        [DataMember(Name = "albumId", EmitDefaultValue = false, IsRequired = true)]
        protected internal int AlbumId { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = true)]
        public string Title { get; set; }

        [DataMember(Name = "url", EmitDefaultValue = false, IsRequired = true)]
        protected internal string BaseUrl
        {
            get => Url.AbsolutePath;
            set => Url = new Uri(value);
        }

        [IgnoreDataMember]
        public Uri Url { get; set; }

        [DataMember(Name = "thumbnailUrl", EmitDefaultValue = false, IsRequired = true)]
        protected internal string BaseThumbnailUrl
        {
            get => ThumbnailUrl.AbsolutePath;
            set => ThumbnailUrl = new Uri(value);
        }

        [IgnoreDataMember]
        public Uri ThumbnailUrl { get; set; }
    }
}
