using Domain.Interfaces;
using Domain.Interfaces.Adapters;
using Domain.Interfaces.Queries;
using Domain.Model;

namespace Domain.Queries
{
    public class CyrilQueries: ICyrilQueries
    {
        private readonly ICyrilService _cyrilService;

        public CyrilQueries(ICyrilService cyrilService)
        {
            _cyrilService = cyrilService;
        }

        public Cyril GetCyril(int id)
        {
            return _cyrilService.FindCyril(id);
        }
    }
}