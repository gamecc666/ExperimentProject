using System;
using System.IO;
using LinqToXML从创建到读取.res;

namespace LinqToXML从创建到读取
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  创建XML文件
                var msg= BuildXML.BuilderXMLFile();
                Console.WriteLine($"信息： {msg}");
            */
            string path = "../../../TestXml/gameccinfo.xml";
            var msg= ReadXML.ReadXMLFile(path);
            Console.WriteLine($"信息：{msg}");
        }
    }
}
