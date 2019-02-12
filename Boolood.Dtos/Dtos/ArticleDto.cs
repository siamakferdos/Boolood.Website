using System;
using Boolood.Dtos;

namespace Boolood.Model.Dtos
{
    public class ArticleDto: DtoBase
    {
        public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public Guid LanguageId { get; set; }
        public int AuthorId { get; set; }
        public bool IsAccepted { get; set; }

    }
}
