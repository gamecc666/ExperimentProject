using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog.Web;
using SpecialTestProject.CustomMiddleWare;
using System;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Web;

/*
 * KeyNote:
 *       1:在configure方法中添加中间件组件的顺序定义了对请求调用中间件组件的顺序以及响应的相反顺序，顺序至关重要；见下
 *          a:异常/错误处理
 *              aa:开发环境=>异常界面中间件：UseDeveloperExceptionPage ||数据库错误页面中间件：UseDatabaseErrorPage
 *              ab:生产环境=>异常处理中间件：UseExceptionHandler ||Http严格传输安全协议中间件：UseHsts(Strict-Transport-Security)
 *          b:https重定向：UseHttpsRedirection=>将http重定向到https（前提请求的网站已有安全证书）
 *          c:静态文件：UseStaticFiles=>返回静态文件
 *          d:cookie政策：UseCookiePolicy=>使用符合欧盟一般数据保护条例规定
 *          e:身份验证：UseAuthentication=>对用户进行身份验证，然后才允许用户访问安全资源
 *          f:会话：UseSession=>建立和维护会话状态（如果应用使用会话状态，必须在UseCookiePolicy之后和UseMvc之前使用会话中间件）
 *          g:mvc：UseMvc=>将Mvc添加到请求管道
 */

namespace SpecialTestProject
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration,IHostingEnvironment env)
        {            
            Configuration = configuration;
            env.ConfigureNLog("NLog.config");            
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }


        //Map单独业务处理函数
        private static void HandleMapTest(IApplicationBuilder app)
        {
            Console.WriteLine("--------进入HandleMapTest函数--------");            
            app.Run(async context =>
            {
                await context.Response.WriteAsync("amp 1 handle");
            });
        }
        //中间件得到请求的信息
        private static void HandleMapReqinfo(IApplicationBuilder app)
        {
            Console.WriteLine("--------进入HandleMapTest函数--------");
            app.Run(async context =>
            {
                //解决中文显示编码问题
                context.Response.ContentType = "text/plain; charset=utf-8";
                await context.Response.WriteAsync(GetRequestInfo.GetRequestInfomation(context.Request));                
            });
            //await context.Response.WriteAsync(HtmlEncoder.Create(UnicodeRanges.All).Encode(GetRequestInfo.GetRequestInfomation(context.Request)));
          
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }           

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            //扩展方式添加(见TestMiddleware可中断可传到下一级)
            app.UseTestMiddleWare("111");
            //使用Map进行业务的单独处理
            app.Map("/maptest", HandleMapTest);
            app.Map("/reqinfo", HandleMapReqinfo);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller= FrontAndBackDataInteract}/{action=Index}/{id?}");
            });
            //app.Run(async (context) =>
            //{
            //    var msg = Configuration["message"];
            //    context.Response.ContentType = "text/plain; charset=utf-8";
            //    await context.Response.WriteAsync(msg);
            //});
        }

       
    }
}
