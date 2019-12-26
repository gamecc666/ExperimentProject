using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleProject.interfacelib
{
    /*
     * string path="C:\gamecc.txt";
     * Path.GetFullPaht(path)=>C:\1.txt
     * Path.GetDirectoryName(path)=>C:
     * Path.GetFileName(path)=>C:
     * Path.GetDirectoryName(path)=>1.txt
     * Path.GetFileNameWithoutExtension(path)=>1
     * Path.GetExtension(path)=>.txt
     * Path.GetPathRoot(path)=>C:\
     */
    public static class GetFileNames
    {
        public static void GetFilesName(string path)
        {
            Console.WriteLine("come in GetFilesName() func");
            if(Directory.Exists(path))
            {
                var filenames = Directory.GetFiles(path, "*.xml");
                foreach(var item in filenames)
                {
                    Console.WriteLine("输出文件名不包含路径："+Path.GetFileName(item));
                    Console.WriteLine("只输出文件的名字不包含后缀名：" + Path.GetFileNameWithoutExtension(item));
                    Console.WriteLine("输出文件名带路径："+item);
                }
            }
            else
            {
                Console.WriteLine("Sorry!!!!!文件夹路径不存在");
            }
        }
    }
}
