using System.Threading.Tasks;
using CalculaJurosAPI.Infra;

namespace CalculaJurosAPITest.FakeUnits
{
    public class FakeJurosAPi : IJurosApi
    {
        public  Task<decimal> GetJuros()
        {
            return Task.FromResult((decimal) 0.01);
        }
    }
}