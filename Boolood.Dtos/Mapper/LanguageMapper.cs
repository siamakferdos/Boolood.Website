using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.DbModels;
using Boolood.Model.Dtos;

namespace Boolood.Model.Mapper
{
    public static class LanguageMapper
    {
        public static Language MapToDbModel(this LanguageDto languageDto)
        {
            return new Language
            {
                Id = languageDto.Id,
                Name = languageDto.Name,
                Code = languageDto.Code
            };
        }

        public static LanguageDto MapToDtoModel(this Language language)
        {
            return new LanguageDto
            {
                Id = language.Id,
                Name = language.Name,
                Code = language.Code
            };
        }
    }
}
