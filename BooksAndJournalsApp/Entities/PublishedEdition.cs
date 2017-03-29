using System;

namespace Entities
{
    [Serializable]
    public abstract class PublishedEdition
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
