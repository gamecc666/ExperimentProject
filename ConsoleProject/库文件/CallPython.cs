using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.库文件
{
    class CallPython
    {
        public string GetDataFromPython()
        {
            string result = null;
            var pythonEngine = Python.CreateEngine();
            var script = pythonEngine.CreateScriptSourceFromFile(System.IO.Directory.GetCurrentDirectory() + "/PythonScript/PyLib.py");
            var code = script.Compile(); //编译
            var scope = pythonEngine.CreateScope();
            code.Execute(scope);
            //调用py方法,带参数
            var _func = scope.GetVariable("GetSum");
            var CustomerData = _func(555, 445);            

            return result;
        }
    }
}
