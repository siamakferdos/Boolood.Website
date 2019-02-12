using Boolood.Model.DbModels;
using Boolood.Model.Dtos;

namespace Boolood.Dtos.Mapper
{
    public static class CategoryMapper
    {
        public static Category MapToDbModel(this CategoryDto categoryDto)
        {
            return new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                ParentId = categoryDto.ParentId
            };
        }

        public static CategoryDto MapToDtoModel(this Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId
            };
        }
    }
}
