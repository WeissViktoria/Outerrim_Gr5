using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class AircraftRepository: ARepositoryAsync<Aircraft>
{
    public AircraftRepository(OuterrimDbContext context) : base(context)
    {
    }
}