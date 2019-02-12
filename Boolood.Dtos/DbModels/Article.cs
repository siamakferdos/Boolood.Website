using System;

namespace Boolood.Model.DbModels
{
    public class Article: EntityBase
    {
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Tags { get; set; }
        public Guid LanguageId { get; set; }
        public Language Language { get; set; }
        public int AuthorId { get; set; }
        public bool IsAccepted { get; set; }
    }
}
