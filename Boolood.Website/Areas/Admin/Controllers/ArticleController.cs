using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boolood.Framework.Core.Query;
using Boolood.Framework.Core.Repository;
using Boolood.Model.Dtos;
using Boolood.Website.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Boolood.Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleQuery _articleQuery;
        private readonly ILanguageQuery _languageQuery;

        public ArticleController(
            IArticleRepository articleRepository, 
            IArticleQuery articleQuery, ILanguageQuery languageQuery)
        {
            _articleRepository = articleRepository;
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
        public IActionResult AddArticle(ArticleViewModel article)
        {
            return View();
        }
    }
}