using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpecialTestProject.PublicClass
{
    /// <summary>
    /// 日志记录类；
    /// 严重级别从小到大：Trace,Debug,Info,Warn,Error,Fatal；
    /// 如果想简单封装的话可以在这个类里面进行，也可以做一个全局日志的开关在开发环境中（Development）打开日志记录按钮，Staging(模拟环境也就是测试环境)/Production(默认)不打开
    /// </summary>
    public class LogHelper
    {
        public static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
