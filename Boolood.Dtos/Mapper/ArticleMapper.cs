using Boolood.Model.DbModels;
using Boolood.Model.Dtos;

namespace Boolood.Model.Mapper
{
    public static class ArticleMapper
    {
        public static Article MapToDbModel(this ArticleDto articleDto, Article article)
        {
            MapDtoToDbModel(articleDto, article);
            return article;
        }
        public static Article MapToDbModel(this ArticleDto articleDto)
        {
            var article = new Article();
            MapDtoToDbModel(articleDto, article);
            return article;
        }

        private static void MapDtoToDbModel(ArticleDto dto, Article dbModel)
        {
            dbModel.CategoryId = dto.CategoryId;
            dbModel.Title = dto.Title;
            dbModel.Body = dto.Body;
            dbModel.Summary = dto.Summary;
            dbModel.Tags = dto.Tags;
            dbModel.AuthorId = dto.AuthorId;
            dbModel.IsAccepted = dto.IsAccepted;
            dbModel.LanguageId = dto.LanguageId;
            dbModel.CreationDate = dto.CreationDate;
        }

        //public static ArticleDto GetArticleDto(this Article article)
        //{
        //    return new ArticleDto
        //    {
        //        Id = article.Id,
        //        CategoryId = article.CategoryId,
        //        Title = article.Title,
        //        Body = article.Body,
        //        Summary = article.Summary,
        //        Tags = article.Tags,
        //        AuthorId = article.AuthorId,
        //        IsAccepted = article.IsAccepted,
        //        LanguageId = article.LanguageId,
        //        CreationDate = article.CreationDate
        //    };
        //}
    }
}
