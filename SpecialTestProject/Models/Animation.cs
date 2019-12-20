using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpecialTestProject.Models
{
    //测试表单参数的提交，如果数据不对应时候怎么传
    public class Animation
    {
        public Animation()
        {
        }

        public string A_Name { get; set; }
        public string A_Sex { get; set; }
        //属性可空可不空
        public int? A_Age { get; set; }
        public string A_Eat { get; set; }
    }
}
