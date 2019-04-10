using System;
using System.Collections.Generic;
using Boolood.Dtos;
using Microsoft.AspNetCore.Http;

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
        public string Tags { get; set; }
        public IFormFile MainImage { get; set; }
        public IFormFile SummaryImage { get; set; }
        public IFormFile ThumbnailImage { get; set; }

    }
}
