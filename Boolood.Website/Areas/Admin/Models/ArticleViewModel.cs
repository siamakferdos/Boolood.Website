using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boolood.Model.Dtos;

namespace Boolood.Website.Areas.Admin.Models
{
    public class ArticleViewModel
    {
        public List<CategoryDto> Categories { get; set; }
        public List<LanguageDto> Languages { get; set; }
        public ArticleDto Article { get; set; }
        public List<string> Errors { get; set; }
    }
}
