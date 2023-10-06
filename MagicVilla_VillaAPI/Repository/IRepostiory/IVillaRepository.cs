using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Repository.IRepostiory
{
    public interface IVillaRepository : IRepository<Villa>
    {
      
        Task<Villa> UpdateAsync(Villa entity);
  
    }
}
