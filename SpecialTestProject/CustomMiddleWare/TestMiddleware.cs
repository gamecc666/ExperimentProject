using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SpecialTestProject.CustomMiddleWare
{
    public class TestMiddleware
    {
        protected RequestDelegate Next;

        public TestMiddleware(RequestDelegate next, string s)
        {
            Next = next;
            Str = s;
        }

        public string Str { get; set; }
        
        public virtual async Task InvokeAsync(HttpContext context)
        {
            //按照第一种，会直接返回一句话并停止
            //context.Response.WriteAsync("this is gamecc666's test MiddleWare!");
            //return Next(context);   
            //按照第二种需改为异步函数，将会继续下面中间件的执行
            await Next(context);
        }
    }
}
