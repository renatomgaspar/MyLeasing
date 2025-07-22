using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Owners.Any())
            {
                AddOwner("1234567", "Ruben", "Almeida", "244567897", "916546345", "Rua de Cima Lote 6");
                AddOwner("8884321", "Sofia", "Ferreira", "212345678", "934567891", "Avenida das Flores 27");
                AddOwner("2345678", "Tiago", "Silva", "213456789", "912345678", "Rua do Sol nº 15");
                AddOwner("9876543", "Mariana", "Costa", "217654321", "938765432", "Praceta das Palmeiras, Bloco B");
                AddOwner("7654321", "André", "Pereira", "219876543", "927654321", "Estrada Nacional 109 km 43");
                AddOwner("1122334", "Joana", "Martins", "212345987", "935678123", "Rua da Liberdade nº 88");
                AddOwner("5566778", "Miguel", "Rodrigues", "214567890", "939123456", "Travessa da Serra nº 9");
                AddOwner("4433221", "Inês", "Carvalho", "216789012", "918654321", "Urbanização Vilar Alto, Lote 3");
                AddOwner("6677889", "Diogo", "Sousa", "218765432", "915432987", "Rua dos Pinheiros nº 77");
                AddOwner("3214567", "Ana", "Neves", "215432198", "932198654", "Passeio do Rio nº 12");

                await _context.SaveChangesAsync();
            }
        }

        private void AddOwner(string document, string firstName, string lastName, string fixedPhone, string cellPhone, string address)
        {
            _context.Owners.Add(new Owner
            {
                Document = document,
                FirstName = firstName,
                LastName = lastName,
                FixedPhone = fixedPhone,
                CellPhone = cellPhone,
                Address = address
            });
        }
    }
}
