using Boolood.Model.DbModels;
using Boolood.Model.Dtos;

namespace Boolood.Model.Mapper
{
    public static class ArticleMapper
    {
        public static Article MapToDbModel(this ArticleDto articleDto)
        {
            return new Article
            {
                Id = articleDto.Id,
                CategoryId = articleDto.CategoryId,
                Title = articleDto.Title,
                Body = articleDto.Body,
                Summary = articleDto.Summary,
                Tags = articleDto.Tags,
                AuthorId = articleDto.AuthorId,
                IsAccepted = articleDto.IsAccepted,
                LanguageId = articleDto.LanguageId,
                CreationDate = articleDto.CreationDate

            };
        }

        public static ArticleDto GetArticleDto(this Article article)
        {
            return new ArticleDto
            {
                Id = article.Id,
                CategoryId = article.CategoryId,
                Title = article.Title,
                Body = article.Body,
                Summary = article.Summary,
                Tags = article.Tags,
                AuthorId = article.AuthorId,
                IsAccepted = article.IsAccepted,
                LanguageId = article.LanguageId,
                CreationDate = article.CreationDate
            };
        }
    }
}
