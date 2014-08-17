using Domain.Model;

namespace Domain.Interfaces.Adapters
{
    public interface ICyrilService
    {
        Cyril FindCyril(int id);
    }
}