using System.Threading.Tasks;
using ProEventosNew.Domain;

namespace ProEventosNew.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        Task<Palestrante[]> GetAllPalestranteByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante> GetAllPalestrantesByIdAsync(int palestranteId, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
    }
}