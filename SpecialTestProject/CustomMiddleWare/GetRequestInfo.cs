using Microsoft.AspNetCore.Http;
using System.Text;

namespace SpecialTestProject.CustomMiddleWare
{
    public class GetRequestInfo
    {
        public static string GetRequestInfomation(HttpRequest request)
        {
            StringBuilder info = new StringBuilder("Request 信息包含（Scheme,Host,Path,QueryString,Method,Protocol）||");
            info.Append(request.Scheme.ToString() + " || ");
            info.Append(request.Host.ToString() + " || ");
            info.Append(request.Path.ToString() + " || ");
            info.Append(request.QueryString.ToString() + " || ");
            info.Append(request.Method.ToString() + " || ");
            info.Append(request.Protocol.ToString() + " || ");
            return info.ToString();
        }
    }
}
