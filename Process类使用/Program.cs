using System;
using System.Collections;
using System.Diagnostics;

namespace Process类使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************开始调用*******************");
            string resstr= RunPy();
            Console.WriteLine($"输出执行结果：{resstr}");
            Console.WriteLine("******************调用结束*******************");
            Console.Read();
        }

        public static string RunPy()
        {              
            //实例一个Process类，启动一个独立进程
            Process p = new Process();

            //参数处理
            string path = @"G:\test\demo.py";
            string sArguments = path;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            foreach (var param in arrayList)
            {
                sArguments += " " + param;
            }


            p.StartInfo.FileName = @"E:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe"; //设置要启动的应用程序名/文件类型的文档，该文件类型与应用程序关联并且拥有可用的默认打开方式，默认为空
            p.StartInfo.Arguments = @"G:\test\demo.py";//设置程序执行参数
            p.StartInfo.UseShellExecute = false;       //关闭Shell的使用
            p.StartInfo.RedirectStandardInput = true;  //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向输出
            p.StartInfo.RedirectStandardError = true;  //重定向错误输出
            p.StartInfo.CreateNoWindow = true;         //设置不显示窗口

            p.Start();                                 //启动进程
            return p.StandardOutput.ReadToEnd();       //返回输出
        }
    }
}