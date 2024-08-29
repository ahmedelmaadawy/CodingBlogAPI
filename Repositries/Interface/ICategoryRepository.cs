using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositries.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
