using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boolood.Model.DbModels
{
    public class Category: EntityBase
    {
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        
        public List<Article> Articles { get; set; }
        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
        public virtual IList<Category> SubCategories { get; set; }
    }
}
