using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetOwners();


        Owner GetOwner(int id);


        void AddOwner(Owner owner);


        void UpdateOwner(Owner owner);


        void RemoveOwner(Owner owner);


        bool OwnerExists(int id);


        Task<bool> SaveAllAsync();
    }
}
