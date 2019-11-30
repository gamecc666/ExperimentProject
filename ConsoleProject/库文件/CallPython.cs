using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.库文件
{
    public static class CallPython
    {
        public static void GetDataFromPython()
        {
            /*直接加载py文件 =>很大局限性各种方式不能加载第三方模块       
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
            */
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            scope.SetVariable("my_object_model", new CSharpClass());
            string pythonscript =
                "import sys\n"+
                "def fun(arg1):\n" +
                "   result = arg1+1\n" +
                "   return result\n" +
                "adder = fun(5) + my_object_model.Foo(2)\n";
            engine.CreateScriptSourceFromString(pythonscript).Execute(scope);
            Console.WriteLine(scope.GetVariable("adder"));
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
