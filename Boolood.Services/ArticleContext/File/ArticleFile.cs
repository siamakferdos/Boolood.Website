using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Framework.Website;
using Boolood.Model.Dtos;
using Boolood.Utility;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext.File
{
    public class ArticleFile
    {
        public static void SaveArticleImages(ArticleDto article)
        {
            if(!FileUtility.IsDirectoryExist(GetArticleMainImagePath(article)))
                FileUtility.CreateDirectory(GetArticleCategoryImageDirectory(article));
            DeleteCategoryImages(article);
            SaveArticleMainImage(article);
            SaveArticleSummaryImage(article);
            SaveArticleThumbImage(article);
        }

        public static void DeleteCategoryImages(ArticleDto article)
        {
            FileUtility.DeleteFile(GetArticleMainImagePath(article));
            FileUtility.DeleteFile(GetArticlrSummaryImagePath(article));
            FileUtility.DeleteFile(GetArticlrThumbImagePath(article));
        }

        private static void SaveArticleMainImage(ArticleDto articleDto)
        {
            FileUtility.SaveFileForm(articleDto.MainImage, 
                GetArticleMainImagePath(articleDto));

        }

        public static bool AreArticleAllImagesExist(ArticleDto article)
        {
            return
                FileUtility.IsFileExist(GetArticleMainImagePath(article))
                && FileUtility.IsFileExist(GetArticlrSummaryImagePath(article))
                && FileUtility.IsFileExist(GetArticlrThumbImagePath(article));
        }

        private static void SaveArticleSummaryImage(ArticleDto articleDto)
        {
            FileUtility.SaveFileForm(articleDto.SummaryImage,
                GetArticlrSummaryImagePath(articleDto));

        }
        private static void SaveArticleThumbImage(ArticleDto articleDto)
        {
            FileUtility.SaveFileForm(articleDto.ThumbnailImage,
                GetArticlrThumbImagePath(articleDto));

        }
        public static string GetArticleMainImagePath(ArticleDto dto)
        {
            return
                $"{GetArticleCategoryImageDirectory(dto)}" +
                $"/{dto.Id}_main{ImageUtility.GetExtention(dto.MainImage)}";
        }
        public static string GetArticlrSummaryImagePath(ArticleDto dto)
        {
            return
                $"{GetArticleCategoryImageDirectory(dto)}" +
                $"/{dto.Id}_summary{ImageUtility.GetExtention(dto.SummaryImage)}";
        }
        public static string GetArticlrThumbImagePath(ArticleDto dto)
        {
            return
                $"{GetArticleCategoryImageDirectory(dto)}" +
                $"/{dto.Id}_thumb{ImageUtility.GetExtention(dto.ThumbnailImage)}";
        }

        public static string GetArticleCategoryImageDirectory(ArticleDto article)
        {
            return $"{WebsiteInfo.WwwrootPath}/articleImg/{article.CategoryId}";
        }

    }
}
