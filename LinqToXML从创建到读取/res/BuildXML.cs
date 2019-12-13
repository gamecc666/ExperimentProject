using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace LinqToXML从创建到读取.res
{
    public static class BuildXML
    {
        public static string BuilderXMLFile()
        {
            bool statusCode = true;
            string errorMsg = null;
            try { 
                //开始创建xml文件
                XElement treeRoot = new XElement("Root",new XAttribute("作者","gamecc666"));
                XElement xNode1 = new XElement("Info");

                List<XElement> xnodelist = new List<XElement>();
            
                XElement xNode1_1 = new XElement("年龄", 26);
                XElement xNode1_2 = new XElement("性别", "男");
                XElement xNode1_3 = new XElement("婚姻", "未婚");
                xnodelist.Add(xNode1_1);
                xnodelist.Add(xNode1_2);
                xnodelist.Add(xNode1_3);

                xNode1.Add(xnodelist);
                treeRoot.Add(xNode1);          

                Console.WriteLine(treeRoot);
                //保存文件
                Console.WriteLine("当前目录的完全限定路径：" + Environment.CurrentDirectory);
                Console.WriteLine("当前应用程序的工作目录：" + Directory.GetCurrentDirectory());
                string path = "../../../TestXml/";
                if(!Directory.Exists(path))
                {
                    Console.WriteLine("---文件夹不存在，开始创建..........");
                    Directory.CreateDirectory(path);
                    Console.WriteLine("---文件夹创建成功！");
                }
                string xmlFilePath = path + "gameccinfo.xml";
                treeRoot.Save(xmlFilePath);
            }
            catch (Exception errinfo)
            {
                statusCode = false;
                errorMsg = errinfo.ToString();
            }

            return statusCode ? "XML文档创建成功!" : ("文档创建失败，失败信息："+errorMsg);
        }
    }
}
