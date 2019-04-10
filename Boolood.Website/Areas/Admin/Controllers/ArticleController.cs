using System;
using System.Collections.Generic;
using Boolood.Framework.Core.Query;
using Boolood.Framework.Core.Services;
using Boolood.Model.Dtos;
using Boolood.Website.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc; 

namespace Boolood.Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IArticleQuery _articleQuery;
        private readonly ILanguageQuery _languageQuery;

        public ArticleController(
            IArticleService articleService, 
            IArticleQuery articleQuery, ILanguageQuery languageQuery)
        {
            _articleService = articleService;
            _articleQuery = articleQuery;
            _languageQuery = languageQuery;
        }

        [HttpGet]
        public IActionResult AddArticle()
        {
            var categories = _articleQuery.GetCategories();
            var languages = _languageQuery.GetLanguages();
            var article = new ArticleDto();
            return View(new ArticleViewModel
            {
                Article = article,
                Languages = languages,
                Categories = categories
            });
        }

        [HttpPost]
        public IActionResult AddArticle(ArticleDto article)
        {
            try
            {
                _articleService.AddArticle(article);
                ModelState.Clear();
                return Ok();
            }
            catch (Exception e)
            {
                return Ok();
            }
        }

        private ArticleViewModel InitialArticleViewModel()
        {
            var categories = _articleQuery.GetCategories();
            var languages = _languageQuery.GetLanguages();
            return new ArticleViewModel
            {
                Article = new ArticleDto(),
                Languages = languages,
                Categories = categories,
                Errors = new List<string>()
            };
        }
    }
}