using Domain.Model;

namespace Domain.Interfaces.Queries
{
    public interface ICyrilQueries
    {
        Cyril GetCyril(int id);
    }
}