using CalculaJurosAPI.Constants;

namespace CalculaJurosAPI.Domain
{
    public class ShowMeTheCode
    {
        private readonly string _urlGitHub = CalculaJurosCons.GITHUB_URL;

        public string GetUrlGitHub()
        {
            return _urlGitHub;
        }
    }
}