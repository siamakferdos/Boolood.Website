using System;

namespace Boolood.Model.Dtos
{
    public class DtoBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }

        protected DtoBase()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }
    }
}
