using BlogProject.Data.UnitOfWorks;
using BlogProject.Entity.Entities;
using BlogProject.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
