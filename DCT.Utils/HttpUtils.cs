using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.Utils
{
    public static class HttpUtils
    {
        public static string CombineUrl(params string[] urlPart)
        {
            const char SEPARATOR = '/';

            StringBuilder url = new StringBuilder().Append(urlPart[0]);

            for(int i = 1; i < urlPart.Length; ++i)
            {
                url.Append(SEPARATOR + urlPart[i]);
            }

            return url.ToString();
        }
    }
}
