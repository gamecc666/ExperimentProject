using ConsoleProject.interfacelib;
using System;
using System.Collections.Generic;

namespace ConsoleProject
{
    //重写SortedList的ICompare()
    public class Persion : IComparer<Persion>
    {
        public int age=0;         //如果是private的话通过key是访问不到的
        public string name = "";  

        public Persion()
        {
        }

        public Persion(int ag,string nam)
        {
            this.age = ag;
            this.name = nam;
        }
        //小于零--此实例小于 value        从大到小排
        //零------此实例等于 value
        //大于零--此实例大于 value        从小到大排
        //-value 为空引用
        public int Compare(Persion x, Persion y)
        {
            Console.WriteLine($"比较信息：{x.age}  {y.age}  {(x.age).CompareTo(y.age)}");
            return (y.age).CompareTo(x.age);
        }       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************开始测试**********************************************");

            //C#7.0元组，返回多个值
            //BackValueTuple.GetPerInfo();
            //格式化数据、包含保留小数
            //DataFormat.FormatInfo();
            //测试循环索引
            //Recyle.TestCycle();
            //测试父字符串包含子字符串
            //StringContains.IsStringHasSubstring();
            //string path = @"D:\ZYAPPXmlData\BackData";
            //GetFileNames.GetFilesName(path);                        

            //string[] atr = new string[] { "1"};
            //atr = null;
            //Console.WriteLine(atr);
            //SortList的使用 两种方案实现简单地排序；至于其他方法就不一一展示了，详细请参考网址：https://www.runoob.com/csharp/csharp-sortedlist.html
            //TestSortList();   使用默认的排序方法
            //TestCustomSL();     //使用自定义的排序方法
			
			using System;
			using System.Text;
			 
			public class Test
			{
				
				public static void fun(StringBuilder cs){
					cs.Append("this is test StringBuilder");
				}
				public static void Main()
				{
					//StringBuilder是引用类型
					StringBuilder str=new StringBuilder(1024);
					fun(str);
					Console.WriteLine(str.ToString());
				}
			}

            //测试可空值的使用
            //NullOrNot.NullableUse();            

            //string filepath = DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
            //FileOperateHelp.CreateFile(filepath);
            FileOperateHelp.AppendToFile("20200420044149.txt");

            Console.WriteLine("*****************************************测试结束**********************************************");
            Console.ReadKey();
        }
          
        //通过自定义的方案进行排序
        private static void TestCustomSL()
        {
            SortedList<Persion, int> mySLd = new SortedList<Persion, int>(new Persion());
            Persion obj1 = new Persion(5, "hello");
            Persion obj2 = new Persion(2, "meng");
            Persion obj3 = new Persion(19, "lin");
            Persion obj4 = new Persion(1, "zhang");
            mySLd.Add(obj1, 12);
            mySLd.Add(obj2, 11);
            mySLd.Add(obj3, 14);
            mySLd.Add(obj4, 90);
            foreach (KeyValuePair<Persion, int> v in mySLd)  
            {
                Console.WriteLine($"键：{v.Key}  值：{v.Value}");
            }
        }
        //如果想要按照值来进行排序那么就将值存到键的位置
        private static void TestSortList()
        {
            SortedList<string, string> mySL = new SortedList<string, string>();
            mySL.Add("z", "hello");
            mySL.Add("A", " gamecc");
            mySL.Add("B", " meng");
            mySL.Add("Y", " ling");
            //Console.WriteLine("通过使用Linq实现反向排序");
            ///foreach (KeyValuePair<string, string> v in Enumerable.Reverse(mySL))  //不通过Linq实现反向排序
            ///foreach (KeyValuePair<string, string> v in mySL.Reverse())  //通过Linq实现反向排序
            foreach (KeyValuePair<string, string> v in mySL)  //通过Linq实现反向排序
            {
                Console.WriteLine($"键：{v.Key}  值：{v.Value}");
            }            
        }
    }
}
