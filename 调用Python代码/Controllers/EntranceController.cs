using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Scripting.Hosting;

namespace 调用Python代码.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            var str= GetDataFromPython();
            Console.WriteLine("-----------:"+str);
            return View();
        }
        public static string GetDataFromPython()
        {
            /*直接加载py文件 =>很大局限性各种方式不能加载第三方模块 
             * 方法一：
            var result=0;
            var pythonEngine = Python.CreateEngine();
            var script = pythonEngine.CreateScriptSourceFromFile(System.IO.Directory.GetCurrentDirectory() + "/PythonScript/demo.py");
            var code = script.Compile(); //编译
            var scope = pythonEngine.CreateScope();
            code.Execute(scope);
            //调用py方法,带参数
            var _func = scope.GetVariable("call");
            result = _func(5);            

            return result;
            *方法二：
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            scope.SetVariable("my_object_model", new CSharpClass());
            string pythonscript =
                "import sys\n"+:“File 'PyLib.py' not found in language's search path: .”

                "def fun(arg1):\n" +
                "   result = arg1+1\n" +
                "   return result\n" +
                "adder = fun(5) + my_object_model.Foo(2)\n";
            engine.CreateScriptSourceFromString(pythonscript).Execute(scope);
            Console.WriteLine(scope.GetVariable("adder"));
            */
            /*方法三使用ScriptRuntime*/
            ScriptRuntime runtime = Python.CreateRuntime();
            ScriptEngine engine = runtime.GetEngine("Python");
            var path = engine.GetSearchPaths();            
            engine.SetSearchPaths(path);
            dynamic py = runtime.UseFile(@"PythonScript\demo.py");                      

            var res = py.call(40);
            
            Console.WriteLine("调用python输出的结果：" + res);
            string str= res.ToString();
            return str;
        }
    }
    public class CSharpClass
    {
        public int Foo(int arg)
        {
            return arg + 1;
        }
    }
}