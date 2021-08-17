using System.Threading.Tasks;

namespace CalculaJurosAPI.Infra
{
    public interface IJurosAPI
    {
        Task<decimal> GetJuros();
    }
}