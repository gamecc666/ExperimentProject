using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.interfacelib
{
    //具体详细可参考：cnblogs.com/polk6/p/5465088.html
    public static class DataFormat
    {
        public static void FormatInfo()
        {
            string timestr = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            DateTime da = Convert.ToDateTime("2012-05-15");
            string str = da.ToString("yyyy-MM");
            Console.WriteLine("输出格式化后的信息：" + timestr + "||" + str);
            double a = 5.35;
            double b = 6.354;
            var res = a / b;
            Console.WriteLine($"输出运算结果：{res.ToString("#0.0000")}");
        }
    };    
}
