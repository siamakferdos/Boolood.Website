using Boolood.Framework.Core.Repository;
using Boolood.Model.DbModels;
using Microsoft.EntityFrameworkCore.Internal;

namespace Boolood.Services.Initial
{
    public class InitializerService
    {
        //private readonly IIdentityRepository _identityRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly ILanguageRepository _languageRepository;

        public InitializerService(
            //IIdentityRepository identityRepository, 
            IArticleRepository articleRepository,
            ILanguageRepository languageRepository)
        {
            //_identityRepository = identityRepository;
            _articleRepository = articleRepository;
            _languageRepository = languageRepository;
        }

        public void Initialize()
        {
            if (!_articleRepository.GetAllCategories().Any())
            {
                AddCategories();
                AddLanguages();
            }
        }

        private void AddCategories()
        {
            var itCategory = new Category { Name = "IT" };
            var healthCategory = new Category { Name = "Health" };
            var entertainementCategory = new Category { Name = "Entertainement" };
            var lifestyleCategory = new Category { Name = "Life Style" };
            _articleRepository.AddCategory(itCategory);
            _articleRepository.AddCategory(healthCategory);
            _articleRepository.AddCategory(entertainementCategory);
            _articleRepository.AddCategory(lifestyleCategory);
            _articleRepository.SaveChanges();

            AddItCatalogs(itCategory);
            AddHealthCategory(healthCategory);
            AddEntertainementCategory(entertainementCategory);
            AddLifestyleCategory(lifestyleCategory);
            _articleRepository.SaveChanges();
        }

        private void AddLifestyleCategory(Category lifestyleCategory)
        {
            var decorationCategory = new Category { Name = "Decoration", ParentId = lifestyleCategory.Id };
            var handMakingCategory = new Category { Name = "Handmaking", ParentId = lifestyleCategory.Id };
            var creativityCategory = new Category { Name = "Creativity", ParentId = lifestyleCategory.Id };
            var homeStyleCategory = new Category { Name = "HomeStyle", ParentId = lifestyleCategory.Id };
            var beautyCategory = new Category { Name = "Beauty", ParentId = lifestyleCategory.Id };
            _articleRepository.AddCategory(decorationCategory);
            _articleRepository.AddCategory(handMakingCategory);
            _articleRepository.AddCategory(creativityCategory);
            _articleRepository.AddCategory(homeStyleCategory);
            _articleRepository.AddCategory(beautyCategory);
        }

        private void AddEntertainementCategory(Category entertainementCategory)
        {
            var comedyCategory = new Category { Name = "Comedy", ParentId = entertainementCategory.Id };
            var bookIntroductionCategory = new Category { Name = "Book Introduction Category", ParentId = entertainementCategory.Id };
            var storyCategory = new Category { Name = "Story", ParentId = entertainementCategory.Id };
            var generalknowledgeCategory = new Category { Name = "General knowledge", ParentId = entertainementCategory.Id };
            var tourismCategory = new Category { Name = "Tourism", ParentId = entertainementCategory.Id };
            _articleRepository.AddCategory(comedyCategory);
            _articleRepository.AddCategory(bookIntroductionCategory);
            _articleRepository.AddCategory(storyCategory);
            _articleRepository.AddCategory(generalknowledgeCategory);
            _articleRepository.AddCategory(tourismCategory);
        }

        private void AddHealthCategory(Category healthCategory)
        {
            var foodCategory = new Category { Name = "Food", ParentId = healthCategory.Id };
            var sportCategory = new Category { Name = "Sport", ParentId = healthCategory.Id };
            var psychologyCategory = new Category { Name = "Psychology", ParentId = healthCategory.Id };
            var childrenCategory = new Category { Name = "Children", ParentId = healthCategory.Id };
            var ladiesCategory = new Category { Name = "Ladies", ParentId = healthCategory.Id };
            var marriageCategory = new Category { Name = "Marriage", ParentId = healthCategory.Id };
            var testsCategory = new Category { Name = "Tests", ParentId = healthCategory.Id };

            _articleRepository.AddCategory(foodCategory);
            _articleRepository.AddCategory(sportCategory);
            _articleRepository.AddCategory(psychologyCategory);
            _articleRepository.AddCategory(childrenCategory);
            _articleRepository.AddCategory(ladiesCategory);
            _articleRepository.AddCategory(marriageCategory);
            _articleRepository.AddCategory(testsCategory);
        }

        private void AddItCatalogs(Category itCategory)
        {
            var developingCategory = new Category { Name = "Developing", ParentId = itCategory.Id };
            var networkCategory = new Category { Name = "Network", ParentId = itCategory.Id };
            var itNewsCategory = new Category { Name = "IT News", ParentId = itCategory.Id };
            var generalItCategory = new Category { Name = "GeneralIT", ParentId = itCategory.Id };
            _articleRepository.AddCategory(developingCategory);
            _articleRepository.AddCategory(networkCategory);
            _articleRepository.AddCategory(itNewsCategory);
            _articleRepository.AddCategory(generalItCategory);
        }

        private void AddLanguages()
        {
            var englishLang = new Language { Name = "English", Code = "en-US" };
            var persianLang = new Language { Name = "Persian", Code = "fa-IR" };
            _languageRepository.AddLanguage(englishLang);
            _languageRepository.AddLanguage(persianLang);
            _articleRepository.SaveChanges();
        }

        //private void CreateAdminUserRole()
        //{
        //    //_identityRepository.AddRole(InitializationConstants.AdminRoleId);
        //    //_identityRepository.AddRole(InitializationConstants.AdminAuthorRoleId);

        //    //var adminUser = new ApplicationUser
        //    //{
        //    //    Email = "siamak.ferdos@gmail.com",
        //    //    FirstName = "Siamak",
        //    //    LastName = "B.Ferdos",
        //    //    EmailConfirmed = true,
        //    //    CreationDate = DateTimeOffset.Now,
        //    //    AccessFailedCount = 5,
        //    //    PasswordHash = "Kd2HuilFuiowe76F8tfyuioefguew",
        //    //    PhoneNumber = "00989143058600",
        //    //    PhoneNumberConfirmed = true,
        //    //    TwoFactorEnabled = true,
        //    //    UserName = InitializationConstants.AdminUserId
        //    //};

        //    //_identityRepository.AddUser();
        //}
    }
}
