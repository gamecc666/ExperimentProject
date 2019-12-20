using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace SpecialTestProject.Controllers
{
    public class CommonTestController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("----输出两个数的和为："+CallFun(20,50,CalledFun));
            return View();
        }


        #region 非Active函数
        //测试lambda表达式与Func<>委托的结合
        public IActionResult GetBackData()
        {
            //StringBuilder _str = new StringBuilder("hello ");
            //string _str1 = "gamecc666";
            //_str.Append(_str1);
            //return Json(_str.ToString());
            //上面已经走通现在开始使用lambda与Func<>结合，原型Func<T,TResult>
            Func<int, int> GetSum = num1 => num1 + 20;

            int _sum = GetSum(80);
            return Json(_sum);
        }
        //测试C#中的回调函数的使用
        public delegate int CalculateSum(int num1, int num2);
        public int CallFun(int num1,int num2, CalculateSum calledfun)
        {
            int sum = calledfun(num1, num2);
            return sum;
        }
        public int CalledFun(int num1,int num2)
        {
            return num1 + num2;
        }
        #endregion
    }
}