using System.Threading.Tasks;

namespace CalculaJurosAPI.Infra
{
    public interface IJurosApi
    {
        Task<decimal> GetJuros();
    }
}