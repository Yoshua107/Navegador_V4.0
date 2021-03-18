using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Navegador_V4._0
{
    class NormalizarURL
    {
        public static string NormalizeUrl(string url)
        {
            url.Trim();
            Regex completeUrl = new Regex("^(https)?(http)?://w{3}?\\.?\\w+\\.?\\w{3}.*$");

            if (!completeUrl.IsMatch(url))
            {
                return $"https://{url}";
            }

            return url;
        }
    }
}
