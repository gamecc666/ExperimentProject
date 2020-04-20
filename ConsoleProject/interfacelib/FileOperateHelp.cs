using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/*
 * 实现文件的生成到保存
 *  第一步：生成txt文件
 *  第二步：往txt文件里面追加内容
 */
namespace ConsoleProject.interfacelib
{    
    public static class FileOperateHelp
    {
        public static void OutputPathInfo()
        {
            Console.WriteLine($"项目当前路径：{Directory.GetCurrentDirectory()}");
            string paths = "../../../savefilepath/";
            Console.WriteLine($"{paths}");
        }
        public static void CreateFile(string filename)
        {
            string path = "../../../savefilepath/" + filename;
            if (File.Exists(path))
            {
                Console.WriteLine($"文件已存在，请检查path值=>{path}");
                return;
            }
            using(FileStream fs=new FileStream(path, FileMode.CreateNew))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("this is 测试！");
                }
            }
        }

        public static void AppendToFile(string filename)
        {         
            string path = "../../../savefilepath/" + filename;
            Console.WriteLine("---------开始附加文件信息----------");
            if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("append to txt file!");
                }
            }
            else
            {
                Console.WriteLine($"文件不存在，请检查path值=>{path}");
                return;
            }            
        }
    }
}
