using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;

        public OwnerRepository(DataContext context)
        {
            _context = context;
        }


        public IEnumerable<Owner> GetOwners()
        {
            return _context.Owners.OrderBy(o => o.FirstName);
        }


        public Owner GetOwner(int id)
        {
            return _context.Owners.Find(id);
        }
     

        public void AddOwner(Owner owner)
        {
            _context.Owners.Add(owner);
        }


        public void UpdateOwner(Owner owner)
        {
            _context.Owners.Update(owner);
        }


        public void RemoveOwner(Owner owner)
        {
            _context.Owners.Remove(owner);
        }


        public bool OwnerExists(int id)
        {
            return _context.Owners.Any(o => o.Id == id);
        }


        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
