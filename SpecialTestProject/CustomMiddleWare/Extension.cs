using Microsoft.AspNetCore.Builder;

namespace SpecialTestProject.CustomMiddleWare
{
    public static class Extension
    {
        //扩展方法=》对IApplicationBuilder进行扩展（也就是对IApplicationBuilder类添加了一个UseTestMiddleWare方法）
        public static IApplicationBuilder UseTestMiddleWare(this IApplicationBuilder app ,string str)
        {
            return app.UseMiddleware<TestMiddleware>(str);
        }
    }
}
