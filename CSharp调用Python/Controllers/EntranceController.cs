using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.IO;

namespace 调用Python代码.Controllers
{
    public class EntranceController : Controller
    {
        private static int lineCount = 0;
        private static System.Text.StringBuilder output = new System.Text.StringBuilder();
        public IActionResult Index()
        {
            RunPyScript();
            return View();
        }
        public void RunPyScript()
        {
            Console.WriteLine("*************进入函数中******************");            

            string pythonScriptPath = @"G:\test";//python脚本所在的目录
            Process process = new Process();
            //ProcessStartInfo start = new ProcessStartInfo();
            ProcessStartInfo start = process.StartInfo;
            start.FileName = @"E:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe"; //执行python.exe
            
            start.Arguments = pythonScriptPath + @"\demo.py ";                                                //执行python脚本的命令
           
            start.WorkingDirectory = pythonScriptPath;                                                         //设置运行python脚本的初始目录 这里注意：如果你的python脚本有文件操作，必须设置初始目录
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;

            //process.Exited += new EventHandler(ProcessExited);       //为外部进程添加一个事件监听；当退出后获取通知，该方法不会阻塞当前进程

            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    //output.Append("\n[" + lineCount + "]: " + e.Data);
                    output.Append(e.Data);                    
                }
            });

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();       //这种方法会阻塞当前进程，直到运行的外部程序退出

            Console.WriteLine(output);
            //Console.WriteLine("gamecc666：：："+output);
            //string str = "" + output;
            //string[] words = str.Split(' ');

            //foreach (var word in words)
            //{
            //    Console.WriteLine($"返回的结果值分别是：{word}");
            //}

            process.WaitForExit();
            process.Close();

        }
        void ProcessExited(object sender,EventArgs e)
        {
            Console.WriteLine("-----------Python程序运行结束---------");
        }
    }
}