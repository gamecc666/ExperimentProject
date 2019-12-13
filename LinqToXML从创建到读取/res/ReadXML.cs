using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

/*
 * XElment.Elements()=>只能获得它的子一级，孙子不行
 */

namespace LinqToXML从创建到读取.res
{
    public static class ReadXML
    {
        public static string ReadXMLFile(string filepath)
        {
            bool statusCode = true;
            string errorMsg = null;
            try {
                XElement treeRoot = XElement.Load(filepath);
                Console.WriteLine("输出读取的信息：\n"+treeRoot);
                //开始筛选数据并进行操作
                IEnumerable<XElement> childNodes = 
                                                   //from node in treeRoot.Elements()  筛选根节点的孩子一级节点集合不包含孙子节点
                                                   //from node in treeRoot.Descendants("年龄") 筛选节点名字为“年龄”的节点集合
                                                   //from node in treeRoot.Element("Info").Elements() 筛选  筛选info下的所有子节点和信息值         
                                                   from node in treeRoot.DescendantsAndSelf()                                                            
                                                   select node;
                foreach(XElement node in childNodes)
                {
                    //Console.WriteLine($"节点名称:{node.Name} || value:{node.Value}");
                    //Console.WriteLine($"标签：{node.Name} || 对应的值：{node.Value}");
                    if(node.Attribute("作者")!=null)
                    {
                        Console.WriteLine($"带有属性作者的节点，标签：{node.Attribute("作者").Name}");
                    }                   
                }
            } 
            catch (Exception errorinfo) {
                statusCode = false;
                errorMsg = errorinfo.ToString();
            }
            return statusCode ? "读取成功！" : ($"读取失败，失败信息：{errorMsg}");
        }
    }
}
