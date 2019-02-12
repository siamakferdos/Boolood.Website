using System.Collections.Generic;

namespace Boolood.Model.DbModels
{
    public class Language: EntityBase
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Article> Articles { get; set; }

    }
}